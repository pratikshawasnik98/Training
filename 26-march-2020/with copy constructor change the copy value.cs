using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comapny_details_with_copy_constructor
{
    class company
    {
        //with copy constructor change the copy value
        
        public int emp_no;
        public string emp_name;
        public float emp_salary;

        public company(int eno, string n, float sal)
        {
            emp_no = eno;
            emp_name = n;
            emp_salary = sal;
        }
        public company(company com)
        {
            emp_no = com.emp_no;
            emp_name = com.emp_name;
            emp_salary = com.emp_salary;
        }
        public void instance_show_detail()
        {
            Console.WriteLine("\nInstance Constructor");
            Console.WriteLine("\nName : " + emp_name + "\nEmployee Id : " + emp_no + "\nEmployee Salary :" + emp_salary);
        }
        public void copy_show_detail()
        {
            Console.WriteLine("\nCopy Constructor");
            Console.WriteLine("\nName : " + emp_name + "\nEmployee Id : " + emp_no + "\nEmployee Salary :" + emp_salary);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Employee ID :");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a Employee Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a Employee Salary :");
            float salary = int.Parse(Console.ReadLine());

            company c = new company(id, name, salary);
            c.instance_show_detail();

            company c1 = new company(c);
            Console.WriteLine("\nYou want to change the copy variable value then  enter a 'yes' for yes and 'no' for no:");
            string ch = Console.ReadLine();
            if (ch == "yes")
            {
                
                Console.WriteLine("Enter a Employee ID :");
                c1.emp_no = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a Employee Name :");
                c1.emp_name = Console.ReadLine();

                Console.WriteLine("Enter a Employee Salary :");
                c1.emp_salary = int.Parse(Console.ReadLine());

                Console.WriteLine("Values after a upadating");
                c1.copy_show_detail();
            }
            else
            {
                c1.copy_show_detail();
            }

            Console.ReadKey();
        }
    }
}
