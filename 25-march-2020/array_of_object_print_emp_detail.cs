using System;

namespace array_of_object_print_emp_detail
{
    class ArryOfObject
    {
        public string name, dateOfJoning;
        public double salary;
        public void showDetail()
        {
            
            Console.WriteLine(name +"       " + salary + "       " + dateOfJoning + "       ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArryOfObject[] arrayObject = new ArryOfObject[10];
            for(int i=0;i<10;i++)
            {
                arrayObject[i] = new ArryOfObject();
                Console.WriteLine("Enter your name:");
                arrayObject[i].name = Console.ReadLine();

                Console.WriteLine("Enter your Salary:");
                arrayObject[i].salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your Date of Joning:");
                arrayObject[i].dateOfJoning= Console.ReadLine();

            }
            Console.WriteLine("Name       Salary          Date of Joning        ");
            for (int i = 0; i < 10; i++)
            {
                //arrayObject[i] = new ArryOfObject();
                arrayObject[i].showDetail();
            }

                Console.ReadKey();
        }
    }
}
