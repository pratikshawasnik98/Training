using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_3_val_make_a_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three side values of  a triangle ");
            float s1 = float.Parse(Console.ReadLine());
            float s2 = float.Parse(Console.ReadLine());
            float s3 = float.Parse(Console.ReadLine());

            if(s1<(s1+s2) && s2<(s1+s3) && s3<(s1+s2))
            {
                float res = s1 + s2 + s3;
                Console.WriteLine("Result :" + res);
                Console.WriteLine("with the help of these three point we can make a triangle ");
            }
            else
            {
                Console.WriteLine("with the help of these three point we can not make a triangle ");
            }
            Console.ReadKey();
        }
    }
}
