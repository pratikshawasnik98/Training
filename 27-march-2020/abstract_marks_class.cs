using System;

namespace abstract_marks_class
{
   
     abstract class Marks
    {
        public float fourPercentage { get; set; }
        public float threePercentage { get; set; }
        public float threeTotal;
        public float fourTotal;
        public abstract float getPercentage();
        


    }
    class A : Marks
    {
       public A(float s1, float s2, float s3)
        {
             threeTotal = s1 + s2 + s3;
            //Console.WriteLine(percen);
        }
        public override float getPercentage()
        {
            threePercentage = threeTotal / 300 * 100;
            Console.WriteLine("Percentage of a Student :" + threePercentage);
            return threePercentage;
        }
    }
    class B : Marks
    {
        public B(float s1,float s2,float s3,float s4)
        {
            fourTotal = s1 + s2 + s3 + s4;
        }
        public override float getPercentage()
        {
            fourPercentage = fourTotal/ 400 * 100;
            Console.WriteLine("Percentage of a Student :" + fourPercentage);
            return fourPercentage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float threeP;
            Console.WriteLine("\n Enter  a 1st student marks ");
            Console.WriteLine("Enter  a 1st subject mark :");
            float subject1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter  a 2sd subject mark :");
            float subject2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter  a 3rd subject mark :");
            float subject3 = float.Parse(Console.ReadLine());

            Marks a = new A(subject1, subject2, subject3);
            threeP = a.getPercentage();
            Console.WriteLine("Three Subject Marks Percentage :" + threeP);
            

            Console.WriteLine("\n Enter  a 2sd student marks ");
            Console.WriteLine("Enter  a 1st subject mark :");
            float sub1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter  a 2sd subject mark :");
            float sub2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter  a 3rd subject mark :");
            float sub3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter  a 4th subject mark :");
            float sub4 = float.Parse(Console.ReadLine());
            Marks b = new B(sub1, sub2, sub3, sub4);
            float fourP = b.getPercentage();
            Console.WriteLine("Four Subject Marks Percentage :" + fourP);


            Console.ReadKey();
        }
    }

}
