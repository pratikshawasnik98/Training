using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Online_testing
{
    /*Write a program in C# Sharp to create a user define function. 
        Expected Output :
        Welcome Friends!
        Have a nice day!
        */

    class Program
    {
        static void Main(string[] args)
        {
            welcome obj = new welcome();
            string s1 = "Welcome Friends !";
            string s = obj.nice(s1);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
    public class welcome
    { 
            public string nice(string name)
        {
            Console.WriteLine(name);
            string str="Have a Nice Day";
            return str;
            }
        }
    }

