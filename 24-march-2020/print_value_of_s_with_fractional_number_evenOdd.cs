using System;

namespace print_value_of_s_with_fractional_number_evenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
                float i = 3, s = 0,j=2;
            s = s + 1;
            while (i<=8)
                {
                    s = s +( i / j);
                    Console.WriteLine("\ni : {0}  \nj: {1} \nSum of s : {2}",i, j,s);
                    i = i + 2;
                    j = j * 2;
                
                 }            
            Console.WriteLine("Sum of s : "+s);
            Console.ReadKey();
        }
    }
}
