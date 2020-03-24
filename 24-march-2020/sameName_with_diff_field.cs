using System;

namespace sameName_with_diff_field
{
    class Student
    {
        public int RollNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public void GetStudentDetail(int rollNumber,string name,string phoneNumber,string address)
        {
            RollNumber = rollNumber;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public void DisplayResult()
        {
            Console.WriteLine("\nStudent Details are: ");
            Console.WriteLine("Student Roll number  : " + RollNumber);
            //Console.WriteLine("Student Name  : " + Name);
            Console.WriteLine("Student Phone number  : " + PhoneNumber);
            Console.WriteLine("Student Address  : " + Address);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            
                Console.WriteLine("\nEnter a student Roll Number :");
                int rollnumber1 = int.Parse(Console.ReadLine());

                //Console.WriteLine("Enter a student Name:");
                //string name = Console.ReadLine();

                Console.WriteLine("Enter a student phone Number :");
                string phonenumber1 = Console.ReadLine();

                Console.WriteLine("Enter a student Address :");
                string add1 = Console.ReadLine();

                student1.GetStudentDetail(rollnumber1, "John", phonenumber1, add1);
                student1.DisplayResult();


            Student student2 = new Student();

            Console.WriteLine("\nEnter a student Roll Number :");
            int rollnumber2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a student Name:");
            //string name = Console.ReadLine();

            Console.WriteLine("Enter a student phone Number :");
            string phonenumber2 = Console.ReadLine();

            Console.WriteLine("Enter a student Address :");
            string add2 = Console.ReadLine();

            student2.GetStudentDetail(rollnumber1, "Sam", phonenumber2, add2);
            student2.DisplayResult();

            Console.ReadKey();
        }
    }
}
