using System;

namespace tringular_series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a last range ");
            int range = int.Parse(Console.ReadLine());
            int i,sum=0;
            for (i = 1; i < range; i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
    }
}
