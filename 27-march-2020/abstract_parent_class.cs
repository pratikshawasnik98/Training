using System;

namespace abstract_parent_class
{
    abstract class parent
    {
        public void message()
        {
            Console.WriteLine("Calling abstrct class");
        }
    }
    class first:parent
    {
        public void message()
        {
            Console.WriteLine("Calling first class");
        }
    }
    class second:parent
    {
        public void message()
        {
            Console.WriteLine("Calling secound class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            second sec = new second();
            sec.message();
          

            first fir = new first();
            fir.message();
          
            parent p = new first();
            p.message();
            Console.ReadKey();
        }
    }
}
