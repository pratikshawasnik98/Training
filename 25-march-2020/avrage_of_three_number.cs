using System;

namespace avrage_of_three_number
{
    class Average
    {
        public int Avge=0;
        public void PrintAverage(int number1,int number2,int number3)
        {
            Avge = (number1 + number2 + number3) / 3;
            Console.WriteLine("Average : " + Avge);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 1st number ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a 2sd number ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a 3rd number ");
            int num3 = int.Parse(Console.ReadLine());

            Average average = new Average();
            average.PrintAverage(num1, num2, num3);

            Console.ReadKey();
        }
    }
}
