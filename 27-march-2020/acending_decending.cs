using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acending_decending
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 1st number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a 2sd number");
            int num2 = int.Parse(Console.ReadLine());

            if(num1<num2)
            {
                Console.WriteLine("Enter numbers are in accending order");
            }
            else if (num1>num2)
            {
                Console.WriteLine("Enter numbers are in decending order");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Enter numbers are equal");
            }
            Console.ReadKey();

        }
    }
}
