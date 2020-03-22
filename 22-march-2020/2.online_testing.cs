using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.online_testing
{
    /*Write a program in C# Sharp to create a user define function with parameters. Test Data :
    Please input a name : John
    Expected Output :
    Welcome friend John !
    Have a nice day!
    */
   public class Program
    {
        static void Main(string[] args)
     {
            Console.WriteLine("Enter your Name : ");
            string str = Console.ReadLine();
            Program obj = new Program();
            string name=obj.nice(str);
            Console.WriteLine(name);
            Console.ReadKey();
            }
            public string nice(string s)
            {
                Console.WriteLine("Welcome Friend ! " + s);
                string str1="Have a Nice Day";
            return str1;
            }
        }
    }
 
