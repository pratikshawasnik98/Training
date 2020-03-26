using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_no_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter three number");
            int num3 = int.Parse(Console.ReadLine());

            if(num1>num2 && num1>num3)
            {
                Console.WriteLine(num1 + " Is greater");
            }
            else if (num2 > num1 && num2 > num3)
            { 
                Console.WriteLine(num2 + " Is greater");
            }
            else
            { 
                Console.WriteLine(num3 + " Is greater");
            }
            Console.ReadKey();
        }
    }
}
