using System;

namespace method_Overriding
{
    class Figure
    {
        public void Draw()
        {
            Console.WriteLine("Base Class");
        }
    }
    class Rectangle : Figure
    {
        public new void Draw()
        {
            Console.WriteLine("Child Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            //this is create a child class object through we can call a child class method
            //Rectangle r = new Rectangle();
            //r.Draw();
            

            //this is create a child class object with base class name through we can call a base class method
            Figure r = new Rectangle();
            r.Draw();

            Console.ReadKey();
        }
    }
}
