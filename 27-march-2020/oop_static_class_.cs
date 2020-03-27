using System;

namespace oop_static_class_
{
    class A
    {
        public static void method()
        {
            Console.WriteLine("Parent");
        }
    }
    class B:A
    {
        public static void method()
        {
            Console.WriteLine("Child");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A.method();

            A b = new B();
            //b.method();

            B obj = new B();
            B.method();

            Console.ReadKey();


        }
    }
}
