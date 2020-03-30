using System;

namespace calculateCubeAndSquare0To20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int square, cube;
            Console.WriteLine("Square and Cube of 0 To 20 Numbers");

            Console.WriteLine("Number    Square    Cube    ");
            while (i<=20)
            {
                square = i * i;
                cube = i * i * i;
                Console.WriteLine(i+"          "+square + "          " + cube+"        " );
                i++;
            }
            Console.ReadKey();
        }
    }
}
