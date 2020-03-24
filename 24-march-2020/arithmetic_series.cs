using System;

namespace arithmetic_series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a last range ");
            int range = int.Parse(Console.ReadLine());
            int i;
            for(i=1;i<range;i=i+3)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
