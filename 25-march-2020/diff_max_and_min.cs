using System;

namespace diff_max_and_min
{
    class Program
    {
        static void Main(string[] args)
        {
            double max=0, min=0;
            Console.WriteLine("Enter a four number");
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            double num3 = int.Parse(Console.ReadLine());
            double num4 = int.Parse(Console.ReadLine());
            //Maximum
            if(num1>num2 && num1> num3 && num1>num4)
            {
                max = num1;
               Console.WriteLine(num1 + " Greater Number");
            }
            else if (num2>num1 && num2 > num3 && num2 > num4)
            {
                max = num2;
                Console.WriteLine(num2 + " Greater Number");
            }
            else if (num3 > num1 && num3 > num2 && num3 > num4)
            {
                max = num3;
                Console.WriteLine(num3 + " Greater Number");
            }
            else if (num4 > num1 && num4 > num3 && num4 > num2)
            {
                max = num4;
                Console.WriteLine(num4 + " Greater Number");
            }
            //minimum
            if (num1 < num2 && num1 < num3 && num1 < num4)
            {
                min = num1;
                Console.WriteLine(num1 + " Minimum Number");
            }
            else if (num2 < num1 && num2 < num3 && num2 < num4)
            {
                min = num2;
                Console.WriteLine(num2 + " Minimum Number");
            }
            else if (num3 < num1 && num3 < num2 && num3 < num4)
            {
                min = num3;
                Console.WriteLine(num3 + " Minimum Number");
            }
            else if (num4 < num1 && num4 < num3 && num4 < num2)
            {
                min = num4;
                Console.WriteLine(num4 + " Minimum Number");
            }
            double sum = max - min;

            Console.WriteLine("Difference of maximun and minimum number is : " + sum);

            Console.ReadKey();
        }
    }
}
