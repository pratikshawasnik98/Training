using System;

namespace example_Interface
{
    interface Account
    {
         void Deposite();
    }
    interface Account1 : Account
    {
        void ShowBalanace();
    }
    class Saving : Account1
    {
        public void ShowBalanace()
        {
            Console.WriteLine("Balanace");
        }
        public  void Deposite()
        {
            Console.WriteLine("Deposite");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Saving account = new Saving();
            account.ShowBalanace();
            account.Deposite();
            Console.ReadKey();
        }
    }
}
