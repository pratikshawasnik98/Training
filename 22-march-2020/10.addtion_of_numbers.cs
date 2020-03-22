using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.addtion_of_numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int res = int.Parse(Console.ReadLine());
            Program obj = new Program();
            int sum = obj.separate(res);
            Console.WriteLine("The sum of the digits of the number " + res + " is :" + sum);
            Console.ReadKey();
        }
        public int separate(int r)
        { 
            int total = 0;
            int d=0;
            while(r>0)
            {
                d = r % 10;
                r = r / 10;
                total = total + d;
            }
            return total;
        }
    }
}
