using System;

namespace roll_avg_marks_of_8_stud
{
    class Student
    {
        public int rollNo;
        public float averageMarks;

        public void showDetail()
        {
            Console.WriteLine(rollNo + "       " + averageMarks + "       " );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float subject1, subject2, subject3;
            Student[] student = new Student[3];
            for (int i = 0; i < 3; i++)
            {
                student[i] = new Student();
                Console.WriteLine("Enter a roll number: ");
                student[i].rollNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a 1st subject mark: ");
                subject1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a 2sd subject mark: ");
                subject2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a 3rd subject mark: ");
                subject3 = int.Parse(Console.ReadLine());

                student[i].averageMarks = (subject1 + subject2 + subject3) / 300 ;
            }
            Console.WriteLine("Roll Number           Average Marks        ");
            for (int i = 0; i < 3; i++)
            {
                student[i].showDetail();
            }

            Console.ReadKey();
        }
    }
}
