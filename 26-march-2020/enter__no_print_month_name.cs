using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enter__no_print_month_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 to 12");
            int num=int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("1.Jan");
                    break;

                case 2:
                    Console.WriteLine("2.Feb");
                    break;

                case 3:
                    Console.WriteLine("3.March");
                    break;

                case 4:
                    Console.WriteLine("4.April");
                    break;

                case 5:
                    Console.WriteLine("5.May");
                    break;

                case 6:
                    Console.WriteLine("6.June");
                    break;

                case 7:
                    Console.WriteLine("7.July");
                    break;

                case 8:
                    Console.WriteLine("8.August");
                    break;

                case 9:
                    Console.WriteLine("9.Sep");
                    break;

                case 10:
                    Console.WriteLine("10.Oct");
                    break;

                case 11:
                    Console.WriteLine("11.Nov");
                    break;

                case 12:
                    Console.WriteLine("12.Dec");
                    break;

                default:
                    Console.WriteLine("Enter a invalid Choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
