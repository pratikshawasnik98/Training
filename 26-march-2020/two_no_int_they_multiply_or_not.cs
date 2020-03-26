using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_no_int_they_multiply_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 % num2 == 0)
                {
                    //int result = num1 * num2;
                    Console.WriteLine(num1 + " is multiply by " + num2);
                }
                else
                {
                    Console.WriteLine(num1 + " is not multiply by " + num2);
                }
            }
            else
            {
                int temp = 0;
                temp = num1;
                num1 = num2;
                num2 = temp;

                Console.WriteLine("Number after swapping number 1 : {0} and number 2 : {1}", num1, num2);
                if (num1 % num2 == 0)
                {
                    //int res = num1 * num2;
                    Console.WriteLine(num1 + " is multiply by " + num2);
                }
                else
                {
                    Console.WriteLine(num1 + " is not multiply by " + num2);
                }
            }
            Console.ReadKey();
        }
    }
}
