using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arthemetic_testing
{
    public class BasicMethod
    {
        public double add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double adivide(double num1, double num2)
        {
            return num1 / num2;
        }
        public double multiply(double num1, double  num2)
        {
            return num1 * num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BasicMethod bm = new BasicMethod();
            Console.WriteLine("Enter a two number");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
