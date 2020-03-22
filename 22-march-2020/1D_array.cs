using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_array
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int[] marks = new int[5];

            Console.WriteLine("Enter a 5 subject name :");
            for(int i=0;i<5;i++)
            {
                
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                total = total + marks[i];
            }
            Console.WriteLine(total);
            float per = (float)total / 500.0f * 100.0f;
            Console.WriteLine(" "+per+"%");
            //Calculating grades

            string grade;

            if(per>=75)
            {
                Console.WriteLine("1st Class");
            }
            else if(per>65 || per<75)
            {
                Console.WriteLine("2sd Class");
            }
            else if(per<=55)
            {
                Console.WriteLine("3rd Class");
            }*/
            //with user input
            Console.WriteLine("how many subjects you have?");
            int subject = int.Parse(Console.ReadLine());

            int[] marks = new int[subject];

            Console.WriteLine("Enter a "+subject +" subject marks :");
            for (int i = 0; i < subject; i++)
            {

                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int total = 0;
            for (int i = 0; i < subject; i++)
            {
                total = total + marks[i];
            }
            Console.WriteLine("Total : "+total);
            float out_of_subject = subject * 100;
            float per = (float)total /out_of_subject * 100.0f;
            Console.WriteLine("Percentage : "+ per + "%");
            //Calculating grades

            string grade;

            if (per >= 75)
            {
                Console.WriteLine("1st Class Pass");
            }
            else if (per > 65 || per < 75)
            {
                Console.WriteLine("2sd Class Pass");
            }
            else if (per <= 55)
            {
                Console.WriteLine("3rd Class Pass");
            }

            Console.ReadKey();


        }
    }
}
