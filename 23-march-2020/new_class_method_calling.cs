using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_class_method_calling
{
   class sample
    {
        public static int addition()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            return num1 + num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter a two number");
           
            //sample s = new sample();
            sum=sample.addition();
            //sum =s.addition();
            //int sum = num1 + num2;
            Console.WriteLine("Result + " + sum);
            Console.ReadKey();
        }
        
    }
}

