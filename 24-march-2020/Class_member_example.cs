using System;

namespace Class_member_example
{
    class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }

        public void PrintSalary(string Membername, int Memberage, string Memberphonenumber, string Memberaddress, double Membersalary)
        {
            Console.WriteLine("\n Employee Details: " );
            Console.WriteLine("Name is: " + Membername);
            Console.WriteLine("Age is: " + Memberage);
            Console.WriteLine("Phone Number is: " + Memberphonenumber);
            Console.WriteLine("Address is: " + Memberaddress);
            Console.WriteLine("Salary is: " + Membersalary);
        }
    }
    class Employee : Member
    {
        public string EmployeeSpecialization { get; set; }
        
        public string EmployeeDepartmnet { get; set; }
        public void ESpecialization(string employeespecialization)
        {
            Console.WriteLine("Employee Specialization : " + employeespecialization);
        }
        public void EDepartmnet(string employeeDepartmnet)
        {
            Console.WriteLine("Employee Departmnet : " + employeeDepartmnet);
        }
    }
    class Manager : Member
    {
        public string ManagerSpecialization { get; set; }
        public string ManagerDepartmnet { get; set; }
        public void MSpecialization(string managerspecialization)
        {
            Console.WriteLine("Manager Specialization : " + managerspecialization);
        }
        public void MDepartmnet(string managerDepartmnet)
        {
            Console.WriteLine("Manager Departmnet : " + managerDepartmnet);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();

            Console.WriteLine("Enter Your Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Age :");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Phone Number :");
            string phonenumber = Console.ReadLine();

            Console.WriteLine("Enter Your Address :");
            string address = Console.ReadLine();

            Console.WriteLine("Enter Your Specialization");
            string specialization = Console.ReadLine();

            Console.WriteLine("Enter Your Departmnet");
            string departmnet = Console.ReadLine();

            Console.WriteLine("Enter Your salary :");
            double sal = double.Parse(Console.ReadLine());

            Employee employee = new Employee();
            employee.PrintSalary(name, age, phonenumber, address, sal);
            employee.ESpecialization(specialization);
            employee.EDepartmnet(departmnet);

            Manager manager = new Manager();
            manager.PrintSalary(name, age, phonenumber, address, sal);
            manager.MSpecialization(specialization);
            manager.MDepartmnet(departmnet);

            Console.ReadKey();
        }
    }
}
