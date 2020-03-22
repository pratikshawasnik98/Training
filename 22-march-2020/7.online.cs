using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.online
{
     public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a exponent");
            int exp = int.Parse(Console.ReadLine());

            Program obj = new Program();
            int result=obj.power(num, exp);
            Console.WriteLine("So, the number " + num + "(To the power)" + exp + " =" + result);
            Console.ReadKey();
        }

        public int power(int a,int b)
        { 
            int res=1;
            for(int i=b;i>0;i--)
            {
                res = a * res;
            }            
            
            return res;
        }
    }
}
