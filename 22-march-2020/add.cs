using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,square;
            Console.WriteLine("Enter a two  number");
             num = Convert.ToInt16(Console.ReadLine());

           // num = Console.ReadLine();
            square =  num * num;

            Console.WriteLine("Answer = " +square);

            Console.ReadKey();
        }
    }
}
