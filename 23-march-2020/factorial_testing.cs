using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_testing//.exe program namespane_name
{
    //with argument and with return type
    public class multiply
    {
        public int multi(int n)
        {
            //int num=n;
            int  fact;
            fact = n * n;
            Console.WriteLine("Result :" + fact);
            return fact;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            multiply obj = new multiply();
            obj.multi(4);
            Console.ReadKey();
        }
    }
}
