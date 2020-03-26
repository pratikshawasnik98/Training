using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_even_1_to_50
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=50)
            {
                if(i%2==0)
                {
                    Console.WriteLine("Number :"+i);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
