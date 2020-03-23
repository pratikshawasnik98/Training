using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace throw_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                float num1 = float.Parse(Console.ReadLine());
                float num2 = float.Parse(Console.ReadLine());
                float result=0;
                result = num1 / num2;
                //Console.WriteLine("Result = " + result);
                //throw wrong = new wrong();
                throw new Exception("result = " + result);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Final output ");
            }        
            Console.ReadKey();
        }
    }
}

