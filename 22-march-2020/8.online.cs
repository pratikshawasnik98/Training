using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.online
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.fibo(num);            
            Console.ReadKey();
        }
        public int fibo(int r)
        {
            int a = 0, b = 1, c = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            while (c<r)
            {
                c = a + b;
                if(c<r)
                {
                    Console.WriteLine(c);
                }
                a = b;
                b = c;
            }
            return 0;
        }
    }
}
