using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_notes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of money:");
            int mny = int.Parse(Console.ReadLine());

            int rup = mny / 10;
            Console.WriteLine("10 Rupees Note are :" +rup);

            int b = mny / 20;
            Console.WriteLine("20 Rupees Note are :" + b);

            int c = mny / 50;
            Console.WriteLine("50 Rupees Note are :" + c);

            int d = mny / 100;
            Console.WriteLine("100 Rupees Note are :" + d);

            int e = mny / 500;
            Console.WriteLine("500 Rupees Note are :" + e);

            int f = mny / 2000;
            Console.WriteLine("2000 Rupees Note are :" + f);
            Console.ReadKey();
        }
    }
}
