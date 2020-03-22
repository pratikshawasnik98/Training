using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.online_testing
{
   /* Write a program in C# Sharp to create a function for the sum of two numbers. Test Data :
    Enter a number: 15
    Enter another number: 16
    Expected Output :
    The sum of two numbers is : 31
    */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another  number:");
            int num2 = int.Parse(Console.ReadLine());
           // Program obj = new Program();
            int res= Program.sum(num1, num2);
            Console.WriteLine("The two numbers is : " + res);
            Console.ReadKey();
        }
        public static int sum(int a, int b)
        {
            int result;
            result = a + b;
            
            return result;
        }
    }
}
