using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int result;
                result = num1 / num1;
                Console.WriteLine("Result = " + result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("!st exception = " + e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception =  " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finall output ");
            }
            Console.ReadKey();
        }
    }
}
