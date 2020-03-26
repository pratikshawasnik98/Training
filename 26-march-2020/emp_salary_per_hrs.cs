using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_salary_per_hrs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a emp ID :");
            int emp_id = int.Parse(Console.ReadLine());
            int hrs = 200;
            int months = 26;
            int total=months * 8;
            int salary = total * hrs;

            Console.WriteLine("Employee ID : " + emp_id + " Salaray :" + salary);
            Console.ReadKey();
        }
    }
}
