using System;

namespace areaOf10Element
{
    class Square 
    {
        public float Side { get; set; }
        //public float Side2 { get; set; }

        public Square(float side)
        {
            Side = side;
        }
        public void areaSquare()
        {
            float areasquare = Side * Side;
            Console.WriteLine("\nArea of Square :" + areasquare);
        }
        public void perimeterSquare()
        {
            float perimetersquare = 4 * Side;
            Console.WriteLine("Perimeter of Square :" + perimetersquare);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Square[] square = new Square[10];
            for(int i = 0;i<10;i++)
            {

                Console.WriteLine("Entera side:");
                float s = float.Parse(Console.ReadLine());
                //square[i] = float.Parse(Console.ReadLine());
                square[i] = new Square(s);
                square[i].areaSquare();
            }
            
            //square.perimeterSquare();

            Console.ReadKey();
        }
    }
}
