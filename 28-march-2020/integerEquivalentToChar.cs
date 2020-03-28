using System;

namespace integerEquivalentToChar
{
    class Program
    {
        static void Main(string[] args)
        {
   
            string letters = "abcdefghijklmnopqrstuvwxyz ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int n;
            Console.WriteLine("List of integer equivalents of letters (a-z, A-Z).\n");
            for (n = 0; n < 53; n++)
            {
                Console.WriteLine(letters[n]);
                Console.Write("");
                /*if ((n + 1) % 6 == 0)
                {
                    
                }*/
            }
        }
    }
}
