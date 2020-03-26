using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avrage_weight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Weight 1 and  Weight 2: ");
            float w1 = float.Parse(Console.ReadLine());
            float w2 = float.Parse(Console.ReadLine());

           // Console.WriteLine("Enter Weight 2: ");            

            Console.WriteLine("Enter Item 1 Purchase: ");
            float i1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Item 2 Purchase: ");
            float i2 = float.Parse(Console.ReadLine());

           // float weight_sum = w1 + w2;

            float item_sum = i1 + i2;
            float avg = item_sum / 2;

            Console.WriteLine("Avrage :" + avg);
            Console.ReadKey();
        }

    }
}
