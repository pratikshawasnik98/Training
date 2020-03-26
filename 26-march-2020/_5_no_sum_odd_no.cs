using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_no_sum_odd_no
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a five number : ");
            int[] num = new int[5];

            for(int i=0;i<5;i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int res = 0;
            for (int i = 0; i < 5; i++)
            {
                if(num[i]%2!=0)
                {
                    res = res + num[i];
                }
            }
            Console.WriteLine("Print result :"+res);
            Console.ReadKey();
        }
    }
}
