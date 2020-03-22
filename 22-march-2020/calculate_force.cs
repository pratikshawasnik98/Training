using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_force
{
    public class force
    {
        public float nikita(float m , float a )
        {
            
            //Console.WriteLine("enter a mass & acclerator");
            //int m = Convert.ToInt32(Console.ReadLine());
            //int a = Convert.ToInt32(Console.ReadLine());
            float f = m * a;
            // Console.WriteLine("result = " + f);
            return f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float a=20, b=10;
            force f = new force();
            float res=f.nikita(a,b);
            Console.ReadKey();
        }
    }
}
