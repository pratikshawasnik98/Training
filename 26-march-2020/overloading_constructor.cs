using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading_constructor
{
    public class employee
    {
        public  int salary;
        public employee(int annualSalary)
        {
            salary = annualSalary;
        }
        public employee(int weeklySalary,int numberofWeek)
        {
            salary = weeklySalary * numberofWeek;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee(500000);
            Console.WriteLine("Annual Salary : " + e.salary);

            employee e1 = new employee(7000,4);
            Console.WriteLine("Annual Salary : " + e1.salary);
            
            
            Console.ReadKey();
        }
    }
}
