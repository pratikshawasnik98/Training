using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exxit_to_enter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press a enter key to exit ");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("  Press enter key");
            }
            Console.ReadKey();

        }
    }
}
