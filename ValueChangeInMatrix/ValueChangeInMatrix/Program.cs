namespace ValueChangeInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5,5];


            MatrixFill(matrix, 8);

            PrintAllMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine();

            RandomChangeFifth(matrix);

            PrintAllMatrix(matrix);



            Console.WriteLine();
            Console.WriteLine();


            

            MatrixFill(matrix, 8);
            PrintAllMatrix(matrix);

            Console.WriteLine();
            SaftyParse("what do we change number to? ", out int numbIntoChange);
            Console.WriteLine();

            RandomChangeA(matrix, numbIntoChange);
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
        static void RandomChangeA(int[,] matrix, int a)
        {
            Random random = new Random();
            matrix[random.Next(0, matrix.GetLength(0)), random.Next(0, matrix.GetLength(1))] = a;
        }

        static void SaftyParse(string s, out int numb)
        {
            bool isSafe = false;

            do
            {
                Console.Write(s);

                isSafe = int.TryParse(Console.ReadLine(), out numb);

            } while (!isSafe);
            
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