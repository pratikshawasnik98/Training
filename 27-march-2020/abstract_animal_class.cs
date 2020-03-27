using System;

namespace abstract_animal_class
{
    abstract class animal
    {
        abstract public void cats();
        abstract public void dogs();
    }
    class Cats : animal
    {
        public override void cats()
        {
            Console.WriteLine("Cats Meow from cats class");
        }
        public override void dogs()
        {
            Console.WriteLine("Dogs Bark from cats class");
        }
    }
    class Dogs : animal
    {
        public override void cats()
        {
            Console.WriteLine("Cats Meow from dogs class");
        }
        public override void dogs()
        {
            Console.WriteLine("Dogs Bark from dogs class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            animal cat = new Cats();
            cat.cats();

           animal dog = new Dogs();
            dog.dogs();

            Console.ReadKey();
        }
    }
}
