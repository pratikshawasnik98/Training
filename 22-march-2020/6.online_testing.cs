using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.online_testing
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Program p = new Program();
            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;

            int a = p.first(num1);
            int b = p.second(num2);

            Console.WriteLine("Two numbers are : " + a + " " + b);
            Console.ReadKey();

        }
        public int first(int n2)
        {
            return n2;
        }
        public int second(int n1)
        {
            return n1;
        }
    }
    }

