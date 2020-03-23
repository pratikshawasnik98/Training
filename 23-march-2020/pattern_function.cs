using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_function
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Enter a row number");
            int r = int.Parse(Console.ReadLine());
            int i, j;
            for (i = r; i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    if (j == 2 || j == 4 || j == 6 || j==8 || i == 2 || i == 4 || i == 6 || i == 8)
                    {
                        continue;
                    }
                        Console.Write(" " + j);              
                }
                Console.Write("\n");
            }
            Console.ReadKey();*/

            //Console.WriteLine("Enter a row number");
            //int r = int.Parse(Console.ReadLine());
            /*int i, j;
            for (i = 1; i <= 9; i++)
            {
                for (int sp = 8; sp >= i; sp--)
                {
                         Console.Write("  ");
                }
                for (j = 1; j <= i; j++)
                {
                        Console.Write("*   " );
                }
                
                Console.Write("\n");
             }
        int i, j;
            for (i = 1; i <= 9; i++)
            {
                for (int sp = 8; sp >= i; sp--)
                {
                         Console.Write("  ");
                }
                for (j = 1; j <= i; j++)
                {
                     if (i == 2 || i == 4 || i == 6 || i == 8)
                        {
                            continue;
                        }
                        Console.Write("*   " );
                }
                
                Console.Write("\n");
             }*/
                int i, j;
            for (i = 1; i <= 9; i++)
            {
                for (int sp = 8; sp >= i; sp--)
                {
                    Console.Write("  ");
                }
                for (j = 1; j <= i; j++)
                {
                    
                    Console.Write("*   ");
                }

                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
