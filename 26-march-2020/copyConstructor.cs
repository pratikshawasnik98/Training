using System;

namespace copyConstructor
{
     class company
    { 
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
          Console.WriteLine("Instance Constructor");
          Console.WriteLine("\nName : " + emp_name + "\nEmployee Id : " + emp_no + "\nEmployee Salary :" + emp_salary);
      }
      public void copy_show_detail()
      {
          Console.WriteLine("Copy Constructor");
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
                c1.copy_show_detail();

                Console.ReadKey();

            }
        }
}
