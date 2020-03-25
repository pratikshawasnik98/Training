using System;

namespace sum_of_digit_till_500
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int rem =0,sum = 0,num1,num2,num3;
          if(num<=500)
            {
                num1 = num % 10;
                num = num / 10;

                num2 = num % 10;
                num = num / 10;

                num3 = num % 10;
                num = num / 10;

                sum = num1 + num2 + num3;
            }
            
            Console.WriteLine("Sum of Digit is : " + sum);
            Console.ReadKey();
        }
    }
}
