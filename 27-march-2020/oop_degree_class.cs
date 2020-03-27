using System;

namespace oop_degree_class
{
    class Degree
    {
        public void getDegree()
        {
            Console.WriteLine("I Got a Degree");
        }
    }
    class Undergraduate:Degree
    {
        public void getDegree()
        {
            Console.WriteLine("I am an Undergraduate");
        }
    }
    class Postgraduate : Degree
    {
        public void getDegree()
        {
            Console.WriteLine("I am an Postgraduate");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Degree degree = new Degree();
            degree.getDegree();

            Undergraduate undergraduate = new Undergraduate();
            undergraduate.getDegree();

            Postgraduate postgraduate = new Postgraduate();
            postgraduate.getDegree();

            Console.ReadKey();
        }
    }
}
