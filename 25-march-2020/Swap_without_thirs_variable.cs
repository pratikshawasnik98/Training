using System;

namespace Swap_without_thirs_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number 1 :");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number 2 :");
            int num2 = int.Parse(Console.ReadLine());

            int res = 0;
            res = num1;
            num1 = num2;
            num2 = res;

            Console.WriteLine("Enter a number 1 :" + num1);
            Console.WriteLine("Enter a number 2 :" + num2);

            Console.ReadKey();
        }
    }
}
