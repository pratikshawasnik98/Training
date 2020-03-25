using System;

namespace Reverse_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int d, res = 0;
            while(num!=0)
            {
                d = num % 10;
                num = num / 10;
                res = res*10 + d;
                
            }
            Console.WriteLine("Reverse of number : " + res);
            Console.ReadKey();
        }
    }
}
