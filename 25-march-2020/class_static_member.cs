using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_static_member
{
    class BankAccount
    {
        private decimal balance = 1000;
        private string name;
        public void Withdraw(string n,decimal amount)
        {
            name = n;
            balance = balance - amount;
            Console.WriteLine("Amount withdraw {0} Balanace  is  {1} ", name, balance);
        }
        public void Deposit(string n,decimal amount)
        {
            name = n;
            balance = balance+amount;
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

            switch(t)
            {
                case "deposite":
                    ba.Deposit(n, amt);
                    break;

                case "withdraw":
                    ba.Withdraw(n, amt);
                    break;
            }
            Console.ReadKey();
        }
    }
}
