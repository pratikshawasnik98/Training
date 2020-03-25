using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class Account
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
   public class Saving : Account
    {
        public double interest { get; set; }
        public override string Deposite(double amount)
        {
            interest = 500;
            Balance = Balance + amount + interest;

            return "Amount Deposited Succesfully with interst and balance is: " + Balance;
        }

    }
    public class Current : Account
    {
        public override string Deposite(double amount)
        {
            Balance = Balance + amount;
            return "Amount Depoisted Succesfully and balance is: " + Balance;
        }

    }
}
