using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psw_crt_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            start:

            Console.WriteLine("Enter a Password");
            int psw = int.Parse(Console.ReadLine());

            if(psw==1234)
            {
                Console.WriteLine("Enter a Password is correct");
                goto end;
            }
            else
            {
                Console.WriteLine("Enter a Password is wrong");
                goto start;

            }
            end:
            Console.ReadKey();
        }
    }
}
