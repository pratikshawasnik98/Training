using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_pattern_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a row number");
            int r = int.Parse(Console.ReadLine());
            int i, j;
            for(i=r;i>=0;i--)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write(" * "+j );
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
