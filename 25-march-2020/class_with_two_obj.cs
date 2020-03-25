using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_with_two_obj
{
    class BankAccount
    {
        public decimal balance = 1000;
        public string name;
        public static decimal interst = 200;
        public void Withdraw(string n, decimal amount)
        {
            name = n;
            balance = balance - amount+interst;
            Console.WriteLine("Amount withdraw ,{0} Balanace  is  {1} ", name, balance);
        }
        public void Deposit(string n, decimal amount)
        {
            name = n;
            balance = balance + amount+interst;
            Console.WriteLine("Deposite amount {0} Balance is {1} ", name, balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();
            Console.WriteLine("enter a name and Amount ");
            string n = Console.ReadLine();
            decimal amt = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Deposite or withdraw");
            string t = Console.ReadLine();
            BankAccount.interst = 500;
            switch (t)
            {
                case "deposite":
                    ba.Deposit(n, amt);
                    break;

                case "withdraw":
                    ba.Withdraw(n, amt);
                    break;
            }
            
            BankAccount ba1 = new BankAccount();
            Console.WriteLine("enter a name and Amount ");
             n = Console.ReadLine();
            amt = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Deposite or withdraw");
            t = Console.ReadLine();

            switch (t)
            {
                case "deposite":
                    ba1.Deposit(n, amt);
                    break;

                case "withdraw":
                    ba1.Withdraw(n, amt);
                    break;
            }
            Console.ReadKey();
        }
    }
}