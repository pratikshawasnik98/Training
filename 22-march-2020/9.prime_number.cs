using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.prime_number
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int k = 0, i = 1;
            while (i <= num)
            {
                if (num % i == 0)
                {
                    k = k + 1;
                }
                i++;
            }
            Program obj = new Program();
            obj.prime(k);
            Console.ReadKey();
        }

        public int prime(int n)
        { 
            if(n==2)
            {
                Console.WriteLine(" Prime Number");
            }
           else
                Console.WriteLine(" Not Prime Number");
            return 0;
        }
    }
}
