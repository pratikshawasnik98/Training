using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierachicalInheritance
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeDesignation { get; set; }
        public double EmployeeSalary { get; set; }

        //method
        public void getEmployeeDetail(int employeenumber, string employeename, string employeeaddress, string employeedesignation, double employeesalary)
        {
            Name = employeename;
            Address = employeeaddress;
            EmployeeNumber = employeenumber;
            EmployeeDesignation = employeedesignation;
            EmployeeSalary = employeesalary;
        }

        public void showEmployeeDetail()
        {
            Console.WriteLine("Employee Details are: ");
            Console.WriteLine("Employee Number: " + EmployeeNumber);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Address: " + Address);
            Console.WriteLine("Employee Designation: " + EmployeeDesignation);
            Console.WriteLine("Employee Salary: " + EmployeeSalary);
        }
    }
    class Student : Person
    {
        public int RollNumber { get; set; }
        public string Subject { get; set; }
        public double Marks { get; set; }
        
        //method
        public void getStudentDetail(int rollNumber, string subject, string employeename, string employeeaddress, double marks)
        {
            RollNumber =rollNumber;
            Name = employeename;
            Address = employeeaddress;
            Marks = marks;
            Subject = subject;           
            
        }

        public void showStudentDetail()
        {
            Console.WriteLine("\n Student Details are: ");
            
            Console.WriteLine("Student Roll Number: " + RollNumber);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student Address: " + Address);
            Console.WriteLine("Student Subject: " + Subject);
            Console.WriteLine("Student Marks: " + Marks);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int employeeNumber;
            string employeeName, employeeAddress, employeeDesignation;
            double employeeSalary;

            Employee obj = new Employee();

            Console.WriteLine("Enter Employee Number: ");
            employeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            employeeName = Console.ReadLine();

            Console.WriteLine("Enter Employee Address: ");
            employeeAddress = Console.ReadLine();

            Console.WriteLine("Enter Employee Designation: ");
            employeeDesignation = Console.ReadLine();

            Console.WriteLine("Enter Employee Salray: ");
            employeeSalary = int.Parse(Console.ReadLine());


            obj.getEmployeeDetail(employeeNumber,employeeName, employeeAddress, employeeDesignation,employeeSalary);
            obj.showEmployeeDetail();
            Student s = new Student();
            s.getStudentDetail(123,"ABc","Futala","Java",100);
            s.showStudentDetail();
            Console.ReadKey();
        }
    }
}
