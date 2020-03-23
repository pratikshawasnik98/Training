using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_with_property
{
    public class employee
    {
        private int emp_id;
        private string emp_name;

        public int employee_id
        {
            get
            {
                return emp_id;
            }
            set
            {
                emp_id = value;
            }
        }
        public string employee_name
        {
            get
            {
                return emp_name;
            }
            set
            {
                emp_name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            Console.WriteLine("Enter a employee id :");
            emp.employee_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a employee name :");
            emp.employee_name = Console.ReadLine();

            Console.WriteLine("\nEmpolyee id :" + emp.employee_id + "\nEmpolyee Name : " + emp.employee_name);

            Console.ReadKey();
        }
    }
}
