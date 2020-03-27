using System;

namespace oops_primeNumber_class
{
    class primeNumber
    {
        public void print(int number1)
        {
            Console.WriteLine("Print method with integer parameter :" + number1);
        }
        public void print(float number2)
        {
            Console.WriteLine("Print method with float parameter :" + number2);
        }
        public void print(double number3)
        {
            Console.WriteLine("Print method with double parameter :" + number3);
        }
        public void print(string name)
        {
            Console.WriteLine("Print method with string parameter :" + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            primeNumber primenumber = new primeNumber();
            primenumber.print(5);
            primenumber.print(5.6);
            primenumber.print(54.90);
            primenumber.print("Hello");
            Console.ReadKey();
        }
    }
}
