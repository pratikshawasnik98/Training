using System;

namespace Event_with_delegate
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
        public int Loan(int amt)
        {
            balance = balance - amt;
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
        public delegate string accountdelegate(int amt);
        public delegate int accountdelegate1(int amt);
        public delegate void accountdelegate2();

        private event accountdelegate accountdelegateEvent;
        private event accountdelegate1 accountdelegate1Event;
        private event accountdelegate2 accountdelegate2Event;
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter as amount");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a deposite and withdrwal ,loan ,intrest");
            string t = Console.ReadLine();

            Account act = new Account();
           
            switch (t)
            {
                case "deposite":
                    p.accountdelegateEvent = new accountdelegate(act.depoist);
                    break;

                case "withdrwal":
                    p.accountdelegateEvent = new accountdelegate(act.withdrwal);
                    break;

                case "loan":
                    p.accountdelegate1Event = new accountdelegate1(act.Loan);
                    break;

                case "intrest":
                    p.accountdelegate2Event = new accountdelegate2(act.interst);
                    
                    break;

                default:
                    Console.WriteLine("Invlid ");
                    //ad1 = new accountdelegate1();
                    break;

            }
            //calling delegate
            if (p.accountdelegateEvent != null)
            {
                string result = p.accountdelegateEvent(amount);
                Console.WriteLine(result);

            }
            else if (p.accountdelegate1Event != null)
            {
                int res = p.accountdelegate1Event(amount);
                Console.WriteLine(res);
            }
            else if (p.accountdelegate2Event != null)
            {               
                p.accountdelegate2Event();
            }
            Console.ReadKey();
        }
    }
}
