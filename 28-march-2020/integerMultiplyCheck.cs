using System;

namespace integerMultiplyCheck
{
    class multiply
    {
        public void integerMutiply(int num1,int num2)
        {
            if(num1/num2==0)
            {
                Console.WriteLine(num1 + " Is Completly multiply by " + num2);
            }
            else
            {
                Console.WriteLine(num1 + " Is not Completly multiply by " + num2);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first integer");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a secound integer");
            int number2 = int.Parse(Console.ReadLine());

            multiply multi = new multiply();

            multi.integerMutiply(number1, number2);

            Console.ReadKey();
        }
    }
}
