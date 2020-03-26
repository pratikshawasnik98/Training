using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_construtor
{
    public class adult
    {
        private static int minimumAge;
        static adult()
        {
            minimumAge = 18;
        }
        public void show()
        {
            Console.WriteLine("Age = " + minimumAge);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            adult a = new adult();
            a.show();
            Console.ReadKey();
        }
    }
}
