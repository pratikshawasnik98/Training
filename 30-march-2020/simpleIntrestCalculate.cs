using System;

namespace simpleIntrestCalculate
{
    class simpleIntrest
    {
        public float finalAmount;
        public void simple(float p,float r,float t)
        {
            finalAmount = p * (1 + r * t);
            Console.WriteLine("Final Simple Intrest Amount : " + finalAmount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Principle Balance");
            float principle = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Anunal Intrest Rate");
            float rate = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Time(In years)");
            float time = float.Parse(Console.ReadLine());

            simpleIntrest si = new simpleIntrest();
            si.simple(principle, rate, time);

            Console.ReadKey();

        }
    }
}
