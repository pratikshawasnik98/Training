using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bhaskaras_formula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three values :");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float t = (b * b) - 4 * a * c;
            Console.WriteLine("Result :" + t);
            if (t >= 0)
            {
                Double temp = Math.Sqrt(t);
                Console.WriteLine("Result :" + temp);
            }
            else
            {
                Console.WriteLine("It is not possible to find the roots ");
            }
            Console.ReadKey();
        }
    }
}
