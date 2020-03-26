using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_constructor
{
    public class Counter
    {
        
        private Counter()
        {
        }
        public static int currentCount;
        public static int incrementCount()
        {
            return ++currentCount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter.currentCount = 100;
            Counter.incrementCount();
            Console.WriteLine("New count = {0}", Counter.currentCount);

            Console.ReadKey();
        }
    }
}
