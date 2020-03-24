using System;

namespace StudentClass_to_print_constant_value
{
    class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }

        public void GetStudentDetail(int rollNumber, string name)
        {
            RollNumber = rollNumber;
            Name = name;
        }

        public void DisplayResult()
        {
            Console.WriteLine("Student Roll number  : " + RollNumber);
            Console.WriteLine("Student Name  : " + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetStudentDetail(2, "John");
            student.DisplayResult();
            Console.ReadKey();        }
    }
}
