using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_by_value
{
    class Program
    {
        //static int x = 10;

        static void Main(string[] args)
        {/* addition of two number call by value
            Console.WriteLine("Enter a number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            //int x = 40;
            int sum = num1 + num2;
            display(sum);
            //Console.WriteLine("Result =" + x);
            Console.ReadKey();
        }
        static void display(int x)
        {
            //int x = 10;
            Console.WriteLine("Result = " + x);
        }
        */

            int[]  n = new  int[6];
             n[6] = display();
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.ReadKey();
        }
      static int display()
        {
           
                Console.WriteLine("Enter a array element");
                int[] num = new int[6];
                for (int i = 0; i <= 5; i++)
                {
                    num[i] = int.Parse(Console.ReadLine());
                } 
                return num.Length;
           
          }
        }
    }

