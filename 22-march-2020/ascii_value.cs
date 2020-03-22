using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascii_value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a  character");
            int ch = Console.Read();
            Console.WriteLine("ascii value = " + ch);
            Console.WriteLine("character " + Convert.ToChar(ch));
            Console.ReadKey();
        }
    }
}
