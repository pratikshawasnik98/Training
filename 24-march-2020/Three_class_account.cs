using System;

namespace Three_class_account
{
    class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public Account()
        {
            Balance = 1000;
        }
        public virtual string Deposite(double amount)
        {
            return "Hello from account class deposite method";
        }
        public string ShowBalance()
        {
            return "Balance amount of account no: " + AccountNumber + " is :" + Balance;
        }
    }
    class Saving : Account
    {
        public double  interest { get; set; }
        public override string Deposite(double amount)
        {
            interest = 500;
            Balance = Balance + amount + interest;
            
            return "Amount Deposited Succesfully with interst and balance is: " +Balance;
        }

    }
    class Current : Account
    {
        public override string Deposite(double amount)
        {
            Balance = Balance + amount;
            return "Amount Depoisted Succesfully and balance is: " + Balance;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string result = null, result1 = null;

            Account account = new Account();

            Console.WriteLine("Enter a account Number");
            int actNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount");
            double amt = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter account type (Saving or Current) ");
            string accountType = Console.ReadLine();

            if(accountType == "saving")
            {
                account=new Saving();
            }
            else if (accountType == "current")
            {
                account=new Current();
            }

            account.AccountNumber = actNo;
            result = account.Deposite(amt);
            result1 = account.ShowBalance();

            Console.WriteLine(result);
            Console.WriteLine(result1);

            Console.ReadKey();
        }
    }
}
