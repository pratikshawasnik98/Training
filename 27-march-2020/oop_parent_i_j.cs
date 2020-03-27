using System;

namespace oop_parent_i_j
{
    class parent
    {
        public int i { get; set; }
        public void printNum(int I)
        {
            i = I;
            Console.WriteLine("I: " + i);
        }
    }
    class subClass:parent
    {
        public int j { get; set; }
        public void printNum(int J)
        {
            j = J;
            Console.WriteLine("J: " + j);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            subClass sc = new subClass();
            sc.printNum(10);
            sc.printNum(20);
            Console.ReadKey();
        }
    }
}
