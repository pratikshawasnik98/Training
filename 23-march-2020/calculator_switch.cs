using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_switch
{
    class Program
    {
       // enum oprator { '+','-','*','/','%'};
        static void Main(string[] args)
        {
            int result=0;
            Console.WriteLine("Calculator");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. subtraction");
            Console.WriteLine("3. multiplication");
            Console.WriteLine("4. division");
            Console.WriteLine("5. remender");
            Console.WriteLine("Enter a choice");
            int op = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a two number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            float div = 0;

            switch (op) 
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                   
                    if (num1 > num2)
                        div = num1 / num2;
                    else
                        div = num2 / num1;
                    Console.WriteLine("Result " + div);
                    break;
                case 5:
                    if (num1 > num2)
                        result = num1 % num2;
                    else
                        result = num2 % num1;
                    break;
                default:
                    Console.WriteLine("Invalid enter");
                    break;
            }
            if(div == result)
                Console.WriteLine("Result = " +result);
            else
                Console.WriteLine("Result = " + result);
            Console.ReadKey();
        }
    }
}
