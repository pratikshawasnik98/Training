﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure_constructor
{
    class Program
    {
        struct employee
        {
            public string firstName;
            public int age;

            public void showData(string name,int a)
            {
                firstName = name;
                age = a;
            }
        }
        static void Main(string[] args)
        {
            employee companyEmployee;
            Console.WriteLine("enter a name");
            companyEmployee.firstName = Console.ReadLine();
            Console.WriteLine("enter a age");
            companyEmployee.age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("First Name = " + companyEmployee.firstName + " \n age = " + companyEmployee.age);
            //Console.WriteLine("age = " + companyEmployee.age);

            Console.ReadKey();
        }
    }
}