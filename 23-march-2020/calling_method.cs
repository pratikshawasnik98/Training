using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter a two number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            sum =addition(num1,num2);
            //int sum = num1 + num2;
            Console.WriteLine("Result + " + sum);
            Console.ReadKey();
        }
        public static int addition(int n1,int n2)
        {
            
            return n1 + n2;
        }

    }
}
