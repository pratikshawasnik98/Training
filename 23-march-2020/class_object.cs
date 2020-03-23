using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            Console.WriteLine("Enter Employee Number and Name: ");
            obj.EmpNo = Convert.ToInt32(Console.ReadLine());
            obj.EmpName = Console.ReadLine();
            Console.WriteLine("Employee Number = " + obj.EmpNo);
            Console.WriteLine("Employee Name = " + obj.EmpName);
            Console.ReadKey();

        }
    }
    class Employee
    {
       public int EmpNo;
       public string EmpName;

    }
}
