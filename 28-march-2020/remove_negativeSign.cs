using System;

namespace remove_negativeSign
{
    class removeNegative
    {
        public void remove(float number)
        {
            if(number<0)
            {
                number = number * (-1);
            }
            Console.WriteLine("Posistive Value is : " + number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a negative Number");
            float negativeNumber = float.Parse(Console.ReadLine());

            removeNegative removenegative = new removeNegative();
            removenegative.remove(negativeNumber);

            Console.ReadKey();

        }
    }
}
