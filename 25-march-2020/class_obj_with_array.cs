using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_obj_with_array
{
    class BankAccount
    {
        public decimal balance = 1000;
        public string name;
        public static decimal interst = 200;
        public void Withdraw(string n, decimal amount)
        {
            name = n;
            balance = balance - amount + interst;
            Console.WriteLine("Amount withdraw ,{0} Balanace  is  {1} ", name, balance);
        }
        public void Deposit(string n, decimal amount)
        {
            name = n;
            balance = balance + amount + interst;
            Console.WriteLine("Deposite amount {0} Balance is {1} ", name, balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] ba = new BankAccount[3];
            for (int i = 0; i < 3; i++)
            {
                ba[i] = new BankAccount();
                Console.WriteLine("enter a name and Amount ");
                ba[i].name = Console.ReadLine();
                decimal amt = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Deposite or withdraw");
                string t = Console.ReadLine();
                BankAccount.interst = 500;
                switch (t)
                {
                    case "deposite":
                        ba[i].Deposit(ba[i].name, amt);
                        break;

                    case "withdraw":
                        ba[i].Withdraw(ba[i].name, amt);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
