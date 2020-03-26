using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_line_constructor
{//this single line can not run into vb 2015 because it is a 2019 feature
    class person
    {
        private string last;
       // private string first;

        public person(string name)=>Name=name;
        
        public void show()
        {
            Get => last;
            sett => last=vale;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Enter a Last Name :");
            string l = Console.ReadLine();

            person p = new person( l);
            p.show();
            Console.ReadKey();
        }
    }
}
