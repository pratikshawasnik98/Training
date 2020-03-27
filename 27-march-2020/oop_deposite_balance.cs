using System;

namespace oop_deposite_balance
{
    class Bank
    {
        public int getBalance()
        {
            return 0;
        }
    }
    class BankA:Bank
    {
        public int getBalance(int a)
        {
            return a;
        }
    }
    class BankB : Bank
    {
        public int getBalance(int b)
        {
            return b;
        }
    }
    class BankC : Bank
    {
        public int getBalance(int c)
        {
            return c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            int parent=bank.getBalance();
            Console.WriteLine("Bank Parent Class:" + parent);

            BankA A = new BankA();
            int a=A.getBalance(1000);
            Console.WriteLine("Bank A:" + a);

            BankB B = new BankB();
            int b=B.getBalance(1500);
            Console.WriteLine("Bank B:" + b);

            BankC C = new BankC();
            int c=C.getBalance(2000);
            Console.WriteLine("Bank C:" + c);

            Console.ReadKey();


        }
    }
}
