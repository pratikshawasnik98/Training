using System;

namespace Employee
{
    class Employee
    {
        public string Name;
        public double YeraOfJoining;
        public double Salary;
        public string Address;

        public void assign(string name, double yeraOfJoining, string address)
        {
            Name = name;
            YeraOfJoining = yeraOfJoining;
            Address = address;
        }
        public string display()
        {
            
            return  Name + "        " + YeraOfJoining + "                 "+ Address;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee[] employee = new Employee[3];

            for (int i = 0; i <3; i++)
            {
                employee[i] =new  Employee();
                Console.WriteLine("Enter a Name :");
                employee[i].Name = Console.ReadLine();

                Console.WriteLine("Enter a Year of Joining  :");
                employee[i].YeraOfJoining = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter a Address:");
                employee[i].Address = Console.ReadLine();
                
            }
            Console.WriteLine("Name     Year of Joining      Address");
            for (int i = 0; i <= 2; i++)
            {
               employee[i].assign(employee[i].Name, employee[i].YeraOfJoining, employee[i].Address);
                string str=employee[i].display();
                Console.WriteLine(str);
            }
            Console.ReadKey();
            
        }
    }
}
