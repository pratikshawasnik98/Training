using System;

namespace alphabet_set_decimal_and_character
{
    /*class decimalToCharacter
    {
        public void method(int num)
        {
            string Name = num.ToString();
            for (num = 65; num <= 122; Name = Name + 1)
            {
                if (num > 90 && num < 97)
                    continue;
                Console.WriteLine("Character :" + Name);               
            }
            Console.WriteLine();
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            decimalToCharacter obj = new decimalToCharacter();
            obj.method(number);
            */

            char c;
            //int temp = int.Parse(c);
            Console.WriteLine("\n\n");
            for (c = 65 ; c <= 122; c = c + 1)
            {
                if (c > 90 && c < 97)
                    continue;
                Console.WriteLine(" ", c, c);
            }
            Console.WriteLine("|\n");
            Console.ReadKey();
        }
    }
}
