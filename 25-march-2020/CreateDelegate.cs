using System;

namespace CreateDelegate
{
    class Account
    {
        public int balance = 1000;
        public int intrest = 500;
        public string depoist(int amt)
        {
            balance = balance + amt;
            return "Amount deposite ,balance :" + balance;
        }
        
        public string withdrwal(int amt)
        {
            balance = balance - amt;
            return "Amount withdrwal,Balance " + balance;
        }

        public int  Loan(int amt)
        {
            balance =balance-amt;
            Console.WriteLine("Loan Method");
            return balance;
        }
        public void interst()
        {
            
            balance = balance + intrest;
            Console.WriteLine("Intrest method " + balance);
            //return balance;
        }
    }
    class Program
    {
        //declaring  a delegate
        public delegate string accountdelegate(int amt);
        public delegate int  accountdelegate1(int amt);
        public delegate void accountdelegate2();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter as amount");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a deposite and withdrwal ,loan ,intrest");
            string t = Console.ReadLine();

            Account act = new Account();
            accountdelegate ad = null;
            accountdelegate1 ad1 =null;
            accountdelegate2 ad2 = null;

            switch (t)
            {
                case "deposite":
                    ad = new accountdelegate(act.depoist);
                    break;

                case "withdrawl":
                    ad = new accountdelegate(act.withdrwal);
                    break;

                case "loan":
                    ad1 = new accountdelegate1(act.Loan);
                    break;

                case "intrest":
                    ad2 = new accountdelegate2(act.interst);
                    ad2();
                    break;
             
                default:
                    Console.WriteLine("Invlid ");
                    //ad1 = new accountdelegate1();
                    break;
                    
            }
            //calling delegate
            if (ad != null)
            {
                string result = ad(amount);
                Console.WriteLine(result);

            }
            else if(ad1!=null)
            {
                //ad1 = new accountdelegate1(act.Loan);
                int res = ad1(amount);
                Console.WriteLine(res);
            }
           /* else if(ad2!=null)
            {
                //ad2 = new accountdelegate2(act.interst);
                ad2();

            }/*
            ad2 = new accountdelegate2(act.interst);
            ad2 = act.interst();
            ad1 = act.Loan(200);*/
            Console.ReadKey();
        }
    }
}
