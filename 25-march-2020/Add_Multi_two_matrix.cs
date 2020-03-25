using System;

namespace Add_Multi_two_matrix
{
    class Matrix
    {
        public static int matrixRows { get; set; }
        public static int matrixColoumn { get; set; }
        public static int i, j;
        public static int[,] a = new int[100,100];
        public static int[,] b = new int[100, 100];
        public static int[,] c = new int[100, 100];

        public void getRows()
        {
            Console.WriteLine("Enter a number of rows");
            matrixRows = int.Parse(Console.ReadLine());
        }
        public void getColoumns()
        {
            Console.WriteLine("Enter a number of coloums");
            matrixColoumn = int.Parse(Console.ReadLine());
        }
        
        public void Matrix1Position()
        {
            Console.WriteLine("Enter a matrix Element");

            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColoumn; j++)
                {
                    a[i,j] =int.Parse(Console.ReadLine());
                }
            }
            
        }
        public void Matrix2Position()
        {
            Console.WriteLine("Enter Secound matrix Element");
            Console.WriteLine("Enter a matrix Element");

            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColoumn; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
        }
        public void showMatrixs()
        {
            Console.WriteLine("Show a 1st matrix Element");
            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColoumn; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Show a 2sd matrix Element");
            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColoumn; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void addMatrix()
        {

            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColoumn; j++)
                {
                    c[i,j]= a[i,j] + b[i,j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Show a matrix Element after addition ");
            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColoumn; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        public void multiMatrix()
        {
            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColoumn; j++)
                {
                    c[i, j] = a[i, j] * b[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Show a matrix Element after Multiplication ");
            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColoumn; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            Matrix matrix1 = new Matrix();
            matrix.getRows();
            matrix.getColoumns();
            matrix.Matrix1Position();
            matrix.Matrix2Position();
            matrix.showMatrixs();
            Console.WriteLine("Enter your choice 1 Add 2 Multiplication :");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    matrix.addMatrix();
                    break;

                case 2:
                    matrix.multiMatrix();
                    break;
            }
            Console.ReadKey();
        }
    }
}
