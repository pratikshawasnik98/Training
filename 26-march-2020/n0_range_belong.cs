using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n0_range_belong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            if(num>=0 && num<=80)
            {
                if (num>=1 && num<=10)
                {
                    Console.WriteLine(num + " Is belong to 1 to 10 ");
                }
                else if (num >= 11 && num <= 20)
                {
                    Console.WriteLine(num + " Is belong to 11 to 20 ");
                }
                else if (num >= 21 && num <= 30)
                {
                    Console.WriteLine(num + " Is belong to 21 to 30 ");
                }
                else if (num >= 31 && num <= 40)
                {
                    Console.WriteLine(num + " Is belong to 31 to 40 ");
                }
                else if (num >= 41 && num <= 50)
                {
                    Console.WriteLine(num + " Is belong to 41 to 50 ");
                }
                else if (num >= 51 && num <= 60)
                {
                    Console.WriteLine(num + " Is belong to 51 to 60 ");
                }
                else if (num >= 61 && num <= 70)
                {
                    Console.WriteLine(num + " Is belong to 61 to 70 ");
                }
                else if (num >= 71 && num <= 80)
                {
                    Console.WriteLine(num + " Is belong to 71 to 80 ");
                }
            }
            else
            {
                Console.WriteLine("Number is greter");
            }
            Console.ReadKey();
        }
    }
}
