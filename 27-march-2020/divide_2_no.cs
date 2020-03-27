using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide_2_no
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter a 1 st number");
                float num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter a 2 sd number");
                float num2 = float.Parse(Console.ReadLine());

                if(num1%num2==0)
                {
                    Console.WriteLine(num1 + " is Divide by " + num2);
                }
                else
                {
                    Console.WriteLine(num1 +" is Not Divide by "+num2);
                    
                }
            Console.ReadKey();
            
        }
    }
}
