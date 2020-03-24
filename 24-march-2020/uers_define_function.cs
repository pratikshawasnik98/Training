using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uers_define_function
{
    class Program
    {
        /* 342.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name : ");
            string str = Console.ReadLine();

            nice(str);
            Console.ReadKey();
        }
        static void nice(string s)
        {
           Console.WriteLine("Welcome Friend !" + s); ;
            Console.WriteLine("Have a Nice Day");
        }
        */
        /*343.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another  number:");
            int num2 = int.Parse(Console.ReadLine());
            sum(num1,num2);
            Console.ReadKey();
        }
        static void sum(int a, int b)
        {
            int result;
            result = a + b;
            Console.WriteLine("The two numbers is : "+result);        
        }*/
        /*
           //344.
           static void Main(string[] args)
           {
               Console.WriteLine("Please input a string : ");
               string str = Console.ReadLine();

               nice(str);
               Console.ReadKey();
           }
           static void nice(string s)
           {
               int Flag = 1;

               for (int i = 0; i < s.Length; i++)
               {
                   if (s[i] == ' ')
                   {
                       Flag++;
                       //Console.WriteLine(s);

                   }
               }            
               Console.WriteLine(s +"\ncontains "+ Flag + " spaces"); 

           }*/
        //345 sum of entered array element
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter a array element");
            int[] array = new int[5];

            for(int i=0;i<5;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                //array[i] = int.Parse(Console.ReadLine());
                total = total + array[i];
            }

            Console.WriteLine("Total : " + total);
            Console.ReadKey();
        }*/

    }
}