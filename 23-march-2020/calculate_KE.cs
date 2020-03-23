using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_KE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a mass & velocitnm m y");
            float m = Convert.ToSingle(Console.ReadLine());
            float v = Convert.ToSingle(Console.ReadLine());
            float ke = 0.5f * m * v * v;
            Console.WriteLine("result = " + ke);
            Console.ReadKey();
        }
    }
}
