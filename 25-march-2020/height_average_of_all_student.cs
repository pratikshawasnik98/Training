using System;

namespace height_average_of_all_student
{
    class Student
    {
        public int numberstudent;
        public float averageHeight;
        public float height1;

        public void showDetail()
        {
            Console.WriteLine(numberstudent + "       " + averageHeight + "       ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float averageHeight=0;
            int[] count = new int[3];
            Student[] student = new Student[3];
            for (int i = 0; i < 3; i++)
            {
                student[i] = new Student();
                Console.WriteLine("Enter a roll number: ");
                student[i].numberstudent = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a Height of student: ");
                student[i].height1 = int.Parse(Console.ReadLine());

                averageHeight = (count[i]+student[i].height1) / 3;
            }
            Console.WriteLine(averageHeight +"        ");
            Console.ReadKey();
        }
    }
}
