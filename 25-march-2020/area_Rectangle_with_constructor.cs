using System;

namespace area_Rectangle_with_constructor
{
    class Area
    {
        public float Length { get; set; }
        public float Breath { get; set; }
        public float areaRectangle { get; set; }
        public Area(float lenght, float breath)
        {
            Length = lenght;
            Breath = breath;
            //areaRectangle = lenght * breath;
        }
        public float returnArea()
        {

            areaRectangle = Length * Breath;
            return areaRectangle;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Length :");
            float len = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Breath :");
            float bre = float.Parse(Console.ReadLine());

            Area area = new Area(len, bre);
            //area.SetDim();
            Console.WriteLine(area.returnArea());

            Console.WriteLine();
        }
    }
}
