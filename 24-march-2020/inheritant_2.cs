using System;

namespace inheritant_2
{
    class BaseClass
    {

        private void Display()
        {
            Console.WriteLine("Parent Class");
        }
    }
    class ChildClass : BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("Child Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseclass = new BaseClass();
            baseclass.Display();//give error becuase its protection level

            ChildClass childclass = new ChildClass();
            childclass.Display1();
            //childclass.Display();


            Console.ReadKey();
        }
    }
}
