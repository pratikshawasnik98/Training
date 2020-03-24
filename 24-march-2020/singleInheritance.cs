using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleInheritance
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
        public void getEmployeeDetail(int employeenumber,string employeename,string employeeaddress,string employeedesignation,double employeesalary)
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
            employeeDesignation =Console.ReadLine();

            Console.WriteLine("Enter Employee Salray: ");
            employeeSalary = int.Parse(Console.ReadLine());

            obj.getEmployeeDetail(employeeNumber, employeeName, employeeAddress, employeeDesignation, employeeSalary);
            obj.showEmployeeDetail();
            Console.ReadKey();
        }
    }
}
