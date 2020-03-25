using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_keyword
{
    class keyword
    {
        string name;
        public void SetName(string name)
        {
            this.name = name;
        }
        public void show()
        {
            Console.WriteLine("Name :" + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            keyword obj = new keyword();
            obj.SetName("Abc");
            obj.show();
            Console.ReadKey();
        }
    }
}
