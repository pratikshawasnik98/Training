using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_print_array
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int[] num = new int[4];
            Console.WriteLine("Enter a array element");
           // num[4] = int.Parse(Console.ReadLine());
            for(int i=0;i<=3;i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                //Console.(num[i]);
            }
            Console.WriteLine("Printed array elemnets are :");

            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
            */

            Console.WriteLine("Enter a row value");
            int row = int.Parse(Console.ReadLine());
              
            for(int i =0;i< row;i++)
            {
                for(int j=0 ; j <= i;j++)
                {
                    Console.Write( " *  "+i);
                }
                Console.WriteLine("\n");
            }
            /*
            foreach(int j in row)
            {

            }*/
            Console.ReadKey();
        }
    }
}
