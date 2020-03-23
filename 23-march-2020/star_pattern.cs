using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a row value");
            int row = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                if (i == 1 || i == 3 || i==5 || i==7)
                {
                    continue;
                }
                for(int sp=row-1;sp>=0;sp--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("  *");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
