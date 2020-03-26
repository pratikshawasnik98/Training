using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_negative_positive_no
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 5 numbers:");
            int[] num = new int[5];

            for (int i = 0; i < 5; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int positive = 0;
            int negative = 0;
            for (int i = 0; i < 5; i++)
            {
                if (num[i] > 0)
                {
                    positive++;
                }
                else if(num[i] < 0)
                {
                    negative++;
                }
            }
            Console.WriteLine("Positive Number Result : " + positive);
            Console.WriteLine("Negative Number Result : " + negative);
            Console.ReadKey();
        }
    }
}
