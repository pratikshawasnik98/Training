using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] name = new string[5, 2];

            for(int i=0;i<5;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.WriteLine("Enter Name and year");
                    name[i, j] = Console.ReadLine();

                }
            }
            //dispaly
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(name[i,j] + " ");
                    //name[i, j] = Console.ReadLine();
                }
            }
            Console.ReadKey();
        }
    }
}
