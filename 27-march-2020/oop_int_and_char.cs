using System;

namespace oop_int_and_char
{
    class parentClass
    {
        public void first(int n,string name)
        {
            Console.WriteLine("Integer :" + n + " String :" + name);
        }
        public void secound(string name,int n)
        {
            Console.WriteLine("String :" + name + " Integer :" + n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            parentClass pc = new parentClass();
            pc.first(2, "ABC");
            pc.secound("PQR", 4);
            Console.ReadKey();
        }
    }
}
