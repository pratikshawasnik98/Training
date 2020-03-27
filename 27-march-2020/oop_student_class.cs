using System;

namespace oop_student_class
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Student()
        {
            Name = "Unknow";
            Age = 0;
            Address = "Not Available";
        }
        public void setInfo(string name,int age)
        {
            Console.WriteLine("Name of Stuedent : " + name + " Age :"+age);
        }
        public void setInfo(string name, int age,string address)
        {
            Console.WriteLine("Name of Stuedent : " + name + " Age :" + age + " Address :" +address);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[10];
            for(int i=0;i<10;i++)
            {
                student[i] = new Student();
                Console.WriteLine("Enter Student Name");
                student[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Student Age");
                student[i].Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student Address");
                student[i].Address = Console.ReadLine();
            }
            for (int i = 0; i < 10; i++)
            {
                student[i].setInfo(student[i].Name, student[i].Age, student[i].Address);
            }
            Console.ReadKey();
        }
    }
}
