using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalizer
{
    class car
    {
        public car()
        {
            Console.WriteLine("Con called");
        }
        ~car()
        {
            Console.WriteLine("DeCon called");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            Console.ReadKey();
        }
    }
}
