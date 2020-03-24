using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_fact
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            while(num>0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("Factorial  = " + fact);

            Console.ReadKey();
        }
    }
}
