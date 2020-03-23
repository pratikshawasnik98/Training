using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_greater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1>num2 && num1>num3)
            {
                Console.WriteLine("greater number = " + num1);
            }
            else if(num2>num3)
            {
                Console.WriteLine("greater number = " + num2);
            }
            else
            {
                Console.WriteLine("greater number = " + num3);
            }
            Console.ReadKey();
        }
    }
}
