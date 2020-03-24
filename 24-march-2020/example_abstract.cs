using System;

namespace example_abstract
{
    abstract class Account
    {
        public abstract void Deposite();
        public void ShowBalance()
        {
            Console.WriteLine("Balanace");
        }
    }
    class Saving : Account
    {
        public override void Deposite()
        {
            Console.WriteLine("Deposite");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Saving();
            account.ShowBalance();
            account.Deposite();
            Console.ReadKey();
        }
    }
}
