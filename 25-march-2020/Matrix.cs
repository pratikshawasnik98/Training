using System;

namespace Matrix
{
    class Matrix
    {
        public int matrixRows { get; set; }
        public int matrixColoumn { get; set; }
        public int i,j;
        

        public Matrix()
        {
            
            Console.WriteLine("Enter a number of rows");
            matrixRows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number of coloums");
            matrixColoumn = int.Parse(Console.ReadLine());

             int[,] a = new int[matrixRows, matrixColoumn];
        
            Console.WriteLine("Enter a matrix Element");

            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColoumn; j++)
                {
                    a[i,j] =int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Show a matrix Element");
            for (i = 0; i < matrixRows; i++)
            {
                for (j = 0; j < matrixColoumn; j++)
                {
                    Console.Write(a[i,j]+" ");
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
            Console.ReadKey();
        }
    }
}
