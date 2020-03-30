using System;

namespace acceptSevenDigitNunberAndSeparateIt
{
    class separate
    {
        public int digit;
        public void separateNumber(int num)
        {
            for(int i=0;num!=0;i++)
            {
                digit = num % 10;
                num = num / 10;
                Console.Write(digit+ "  ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter seven digit number");
            int number = int.Parse(Console.ReadLine());

            separate sep = new separate();
            sep.separateNumber(number);

            Console.ReadKey();
        }
    }
}
