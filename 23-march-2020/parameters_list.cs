using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameters_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a array element");
            int[] num = new int[10];
            int[] b = new int[10];

            for (int i=0;i<=5;i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            b=show(num);

            for (int i = 0; i <= 5; i++)
            {
                //b[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Result :" + b[i]);

            }
            Console.ReadKey();
        }
        static int[] show(params int [] a)
        {
            for(int i =a.Length;i>=0;i--)
            {
                Console.WriteLine("Result :" + a[i]);
            }
            return a;

        }
    }
}
