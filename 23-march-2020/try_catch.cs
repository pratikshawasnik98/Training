using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a number");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 + num2;
                Console.WriteLine("Result = " + result);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("End of code");
            Console.ReadKey();
        }
    }
}
