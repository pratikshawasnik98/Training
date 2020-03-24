using System;

namespace Geometric_series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a last range ");
            int range = int.Parse(Console.ReadLine());
            int i;
            for (i = 5; i < range; i = i *2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
