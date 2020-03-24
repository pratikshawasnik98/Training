using System;

namespace runtime_plymorphism
{
    class Figure
    {
        public virtual void Draw()
        {
            Console.WriteLine("Base Class");
        }
    }
    class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Child Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //this is create a child class object with base class name through we can call a base class method
            Figure r = new Rectangle();
            r.Draw();

            Console.ReadKey();
        }
    }
}

