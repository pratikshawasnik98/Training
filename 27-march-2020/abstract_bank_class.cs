using System;

namespace abstract_bank_class
{
    abstract class Bank
    {
        public abstract void getBalance();
       /* {
            Console.WriteLine("$100 depoistes in Bank A");
        }*/
    }
    class BankA : Bank
    {
        public override void getBalance()
        {
            Console.WriteLine("$100 depoistes in Bank A");
        }
    }
    class BankB : Bank
    {
        public override void getBalance()
        {
            Console.WriteLine("$150 depoistes in Bank B");
        }
    }
    class BankC : Bank
    {
        public override void getBalance()
        {
            Console.WriteLine("$200 depoistes in Bank C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankA banka = new BankA();
            banka.getBalance();

            BankB bankb = new BankB();
            bankb.getBalance();

            BankC bankc= new BankC();
            bankc.getBalance();

            Console.ReadKey();
        }
    }
}
