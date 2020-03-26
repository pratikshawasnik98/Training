using System;

namespace normalConstructor
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
    public void show_detail()
    {
        Console.WriteLine("Name : " + emp_name + "\nEmployee Id : " + emp_no + "\nEmployee Salary :" + emp_salary);
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

            company c = new company(id,name,salary);
            c.show_detail();
            //c.employee_detail();
            Console.ReadKey();
            
        }
    }
}
