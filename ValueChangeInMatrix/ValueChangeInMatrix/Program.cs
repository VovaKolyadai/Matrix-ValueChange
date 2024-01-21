namespace ValueChangeInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5,5];

            MatrixFill(matrix, 5);

            PrintAllMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine();

            RandomChangeFifth(matrix);

            PrintAllMatrix(matrix);


        }

        
        static void MatrixFill(int[,] matrix, int numb)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = numb;
                }

            }

        }

        static void RandomChangeFifth(int[,] matrix)
        {
            Random random = new Random();
            matrix[4,random.Next(0, matrix.GetLength(1))] = 1949;
        }

        static void PrintAllMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}