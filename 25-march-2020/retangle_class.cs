using System;

namespace retangle_class
{
    class Rectangle
    {
        public float Lenght { get; set; }
        public float Breath { get; set; }
        public float area = 0;
        public Rectangle(float side1,float side2)
        {
             Lenght = side1;
             Breath = side2;
        }
        public string Area()
        {
            area = Lenght * Breath;
            Console.WriteLine( " Lenght :" + Lenght + " Breath :" + Breath +" Area : " + area );
            return " Lenght :" + Lenght + " Breath :" + Breath + " Area : " + area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(4,5);
            rect.Area();

            Rectangle rect1 = new Rectangle(5, 8);
            rect1.Area();

            Console.ReadKey();
        }
    }
}
