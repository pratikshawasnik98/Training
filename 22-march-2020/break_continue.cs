using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while(true)
            {
                Console.WriteLine(i);
                i++;

                if (i < num)
                    continue;
                else
                    break;
            }
            Console.ReadKey();
        }
    }
}
