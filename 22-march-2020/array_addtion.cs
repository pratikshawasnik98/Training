using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_addtion
{
    class Program
    {
        static void Main(string[] args)
        {
                int sum = 0;
                int[] num = new int[4];
                Console.WriteLine("Enter a array element");
                // num[4] = int.Parse(Console.ReadLine());
                for (int i = 0; i <= 3; i++)
                {
                    num[i] = int.Parse(Console.ReadLine());
                    //Console.(num[i]);
                }

                Console.WriteLine("Printed array elemnets are :");

                foreach (int i in num)
                {
                    Console.WriteLine(i);
                }
                for (int i = 0; i <= 3; i++)
                {
                    // num[i] = int.Parse(Console.ReadLine());
                    //Console.(num[i]);
                    sum = sum + num[i];
                }
                Console.WriteLine("sum = " + sum);
            
            Console.ReadKey();
        }

    }
}
