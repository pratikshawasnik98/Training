using System;

namespace print_value_of_s_with_fractional_number
{
    class Program
    {
        static void Main(string[] args)
        {
            float i = 1,s=0;
            
            for(i=1;i<=50;i++)
            {
                s =s+1 / i;
                Console.WriteLine("Sum of s :{0} \ni : {1}  ", s, i);
            }
            
            Console.ReadKey();
        }
    }
}
