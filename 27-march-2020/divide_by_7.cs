using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide_by_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number range from");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2sd number range to");
            float num2 = float.Parse(Console.ReadLine());

            
            while (num1 <= num2)
            {
                if (num1 % 7 == 2 )
                {
                    Console.WriteLine("number is divide by 7 with reminder 2 : " + num1);
                }
                if (num1 % 7 == 3)
                {
                    Console.WriteLine("number is divide by 7 with reminder 3 : " + num1);
                }
                num1++;
            }
            
            Console.ReadKey();
        }
    }
}
