using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter_constructor
{
    class person
    {
        private string last;
        private string first;

        public person(string firstName, string lastName)
        {
            last = lastName;
            first = firstName;
        }
        public void show()
        {
            Console.WriteLine("First :" + first);
            Console.WriteLine("Last :" + last);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a First Name :" );
            string f = Console.ReadLine();

            Console.WriteLine("Enter a Last Name :");
            string l = Console.ReadLine();

            person p = new person(f,l);
            p.show();
            Console.ReadKey();
        }
    }
}
