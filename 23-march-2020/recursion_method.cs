using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_method
{
   public class Program
    {
        static void Main(string[] args)
        {
            int num,result;
            Console.WriteLine("enter number: ");
            num = int.Parse(Console.ReadLine());
            Program obj = new Program();
            result = obj.factorial(num);
            Console.WriteLine(result);
            Console.ReadKey();      
        }
        public int factorial(int a)
        {

            int fact = 1;
            //int i = 1;
            while (a > 0)
            {
                fact = fact * a;
                a--;
            }
            return fact;
            
        }

    }
}
