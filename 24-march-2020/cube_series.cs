using System;

namespace cube_series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a last range ");
            int range = int.Parse(Console.ReadLine());
            int i;
            for (i = 1; i < range; i++)
            {
                int num = i * i *i;
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
