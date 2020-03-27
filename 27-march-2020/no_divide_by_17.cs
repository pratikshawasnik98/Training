using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no_divide_by_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number range from");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2sd number range to");
            float num2= float.Parse(Console.ReadLine());

            float sum = 0;
            while(num1<=num2)
            {
                if(num1%17!=0)
                    {
                        sum = sum + num1;
                    }
                num1++;
            }
            Console.WriteLine("Addition of number is : " + sum);
            Console.ReadKey();
        }
    }
}
