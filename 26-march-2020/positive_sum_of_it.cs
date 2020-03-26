using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive_sum_of_it
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 5 numbers:");
            int[] num = new int[5];

            for(int i=0;i<5;i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            int res = 0;
            for (int i = 0; i < 5; i++)
            {
                if(num[i]>0)
                {
                    count++;
                    res = res + num[i];
                }
            }
            Console.WriteLine("Result : " + res);
            //Console.WriteLine(count);
            float avg = res / count;
            Console.WriteLine("Result Avrage : " + avg);
            Console.ReadKey();
        }
    }
}
