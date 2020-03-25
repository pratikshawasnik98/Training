using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace default_constructor
{
   
    class Program
    {
        static void Main(string[] args)
        {
            constant c = new constant();
            Console.WriteLine("Account :"+c.actno);
            Console.ReadKey();
        }
    }
    class constant
    {
        public int actno;
        public constant()
        {
            actno = 22;
        }
    }
}

