using System;

namespace printTheValueFormationOfX
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Enter the value of x");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("X      X+2     X+4     X+6");
            int first = x + 2;
            int secound = x + 4;
            int third = x + 6;
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(x + "     " +first+ "     " +secound+ "     " + third + "    ");
            Console.WriteLine("You want to enter another number (yes/no)");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "yes":
                    goto start;
                    break;

                case "no":
                    Console.ReadKey();
                    break;
            }
        }
    }
}
