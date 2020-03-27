using System;

namespace Complex_number
{
    class Complex
    {
        //public float first,secound;
        public float real,imaginary;

        public void calculate(float first1,float first2,float secound1,float secound2)
        {
            Console.WriteLine("First Complex Number : {0} + {1}i ", first1, first2);
            Console.WriteLine("Secound Complex Number : {0} + {1}i ", secound1,secound2);
            real = first1 + first2;
            imaginary = secound1 + secound2;
        }
        public void display()
        {          
            Console.WriteLine("Calculation of Complex Number : {0} + {1}i ", real, imaginary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex();
            Console.WriteLine("Enter a 1st complex number");
            float userfirst1 = float.Parse(Console.ReadLine());
            float usersecound1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a 2sd complex number");
            float userfirst2 = float.Parse(Console.ReadLine());
            float usersecound2 = float.Parse(Console.ReadLine());
            complex.calculate(userfirst1, userfirst2, usersecound1, usersecound2);
            complex.display();
            Console.ReadKey();
        }
    }
}
