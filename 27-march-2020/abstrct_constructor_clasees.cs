using System;

namespace abstrct_constructor_clasees
{
    abstract class parentClass
    {
        public parentClass()
        {
            Console.WriteLine("This is Constructor of abstract class");
        }
        abstract public void a_method();
        public void normalMethod()
        {
            Console.WriteLine("This is normal method of abstrct class ");
        }
    }
    class subClass : parentClass
    {
        public override void a_method()
        {
            Console.WriteLine("This is abstract method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            subClass subclass = new subClass();
            subclass.a_method();
            subclass.normalMethod();
            Console.ReadKey();
        }
    }
}
