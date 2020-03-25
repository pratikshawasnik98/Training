using System;

namespace accpet_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number till it non zero");
            int positive = 0,min=0,max=0,avg=0;
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            while (num>0)
            {
                if (num > 0)
                {
                    positive++;
                }
                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());
                if(num<positive)
                {
                    min= num;
                }
                if (num > positive)
                {
                    max = num;
                }
                avg = (num+=num)/positive;
            }
            Console.WriteLine("Total Positive Number is : "+positive);
            Console.WriteLine("Total Minimun Number is : " + min);
            Console.WriteLine("Total Maximun Number is : " + max);
            Console.WriteLine("Total avg Number is : " + avg);
            Console.ReadKey();
        }
    }
}
