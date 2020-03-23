using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_by_refenrence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            float result;
            result=add(num1,num2);
            result = add(num1, num2,num3);
            Console.Write("Result = " + result);
            Console.ReadKey();

        }
        static int add(int a , int b)
        {
            return a + b;
        }
        static float add(int a, float b)
        {
            return a + b;
        }
        static float add(int a, float b,int c)
        {
            return a + b;
        }
    }
}
