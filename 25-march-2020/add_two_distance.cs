using System;

namespace add_two_distance
{
    class AddDistance
    {
        public float sumInch =0;
        public float sumFeet = 0;
        public void inchFeet(float feet1 , float inch1, float feet2 , float inch2)
        {
            sumInch = inch1 + inch2 ;
            sumFeet = feet1 + feet2;

            if(sumInch > 12)
            {
                sumInch = sumInch - 12;
                sumFeet = sumFeet + 1;
                
            }
            Console.WriteLine("Sum of Distance = " + sumFeet + " Feet " + sumInch + "  Inch");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AddDistance ad = new AddDistance();
            float f1, f2, i1, i2;
            Console.WriteLine("Enter a 1st  inch and feet:");
            Console.WriteLine("Enter a  feet :");
            f1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a  inch :");
            i1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter a 2sd  inch and feet:");
            Console.WriteLine("Enter a  feet :");
            f2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a  inch :");
            i2 = float.Parse(Console.ReadLine());

            ad.inchFeet(f1, i1, f2, i2);
            Console.ReadKey();
        }
    }
}
