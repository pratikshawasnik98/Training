using System;

namespace copyConstructorwithProperty
{
    class person
    {
        public int Age
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int ag
        {
            get;
            set;
        }
        public string na
        {
            get;
            set;
        }
        public person(int a, string n)
        {
            Name = n;
            Age = a;
        }
        public person(person pobj)
        {
            na = pobj.Name;
            ag = pobj.Age;
        }
        public void show1()
        {
            Console.WriteLine("Instance Constructor");
            Console.WriteLine("Name : " + Name + " Age :" + Age);

        }
        public void show2()
        {
            Console.WriteLine("\nCopy Constructor");
            Console.WriteLine("Name : " + na + " Age :" + ag);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person(21, "ABC");
            p1.show1();

            person p2 = new person(p1);
            p2.show2();

            Console.ReadKey();
            
    }
    }
}

