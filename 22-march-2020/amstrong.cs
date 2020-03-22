using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amstrong
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int d,rev=0;
            while(num>0)
            {
                d = num % 10;
                num = num / 10;
                rev = rev * 10 + d;
            }
            Program p = new Program();
            int result=p.ams(rev);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public int ams(int r)
        {
            int rev;
            rev = r;
            return rev;
        }
    }
}
