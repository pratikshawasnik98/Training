using System;

namespace abstract_Hierachy
{
    interface IAccount
    {
        string Depoiste(int amt);
    }
    abstract class Account
    {
        public abstract void hello();
        public  string ShowBalance()
        {
            return "Hello from account Balance";
        }
    }
    class Saving:Account,IAccount
    {
        public int Balance = 1000;

        public override void hello()
        {
            Console.WriteLine("Hello from abstract method");
        }
        public string Depoiste(int amt)
        {
            Balance = Balance + amt;
            return "Amount Deposite Balance is : " + Balance;
        }
    }
        

    class Program
    {
        static void Main(string[] args)
        {
            Saving saving = new Saving();
            string str = saving.Depoiste(200);
            Console.WriteLine(str);
            Console.WriteLine(saving.ShowBalance());
            saving.hello();
            Console.ReadKey();
        }
    }
}
