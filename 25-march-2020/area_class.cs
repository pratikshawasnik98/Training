using System;

namespace area_class
{
    class Area
    {
        public float Length { get; set; }
        public float Breadth { get; set; }
        public float areaRectangle { get; set; }
        public void SetDim(float lenght,float breadth)
        {
            Length = lenght;
            Breadth = breadth;
            //areaRectangle = lenght * breath;
        }
        public float getArea()
        {
            
            areaRectangle = Length * Breadth;
            return areaRectangle;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Length :");
            float len = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Breadth :");
            float bre = float.Parse(Console.ReadLine());

            Area area = new Area();
            area.SetDim(len, bre);
            Console.WriteLine(area.getArea());

            Console.WriteLine();
        }
    }
}
