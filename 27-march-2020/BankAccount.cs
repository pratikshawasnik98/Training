using System;

namespace BankAccount
{
    class BankAccount
    {
        public string nameOfDepositor { get; set; }
        public string addressOfDepositor { get; set; }
        public string typeOfAccount { get; set; }
        public double accountBalance = 1000;
        //public int numberOfTransaction { get; set; }
        public string depositeOrWithdrwal { get; set; }
        public double countId = 999;
        public void uniqueId()
        {
            countId = countId + 1;
            Console.WriteLine("Bank Account Id :BA" + countId);
                
            
        }
        public void deposit(double amount)
        {
            accountBalance = accountBalance + amount;
            Console.WriteLine("Account Balance After Deposite Amount " +accountBalance);
        }
        public void withdrwal (double amount)
        {
            accountBalance = accountBalance - amount;
            Console.WriteLine("Account Balance After Withdrwal Amount " +accountBalance);
        }
        public string Balance()
        {
            Console.WriteLine("Account Balance is : " + accountBalance);
            return "v";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            yes:
            BankAccount[] banckAccount = new BankAccount[3];
            for (int i = 1; i < 3; i++)
            {
                banckAccount[i] = new BankAccount();
                Console.WriteLine("Enter a Your Name");
                banckAccount[i].nameOfDepositor = Console.ReadLine();

                Console.WriteLine("Enter a Your Address");
                banckAccount[i].addressOfDepositor = Console.ReadLine();

       
                Console.WriteLine("Enter a Your type of account saving or current");
                banckAccount[i].typeOfAccount = Console.ReadLine();
           
                switch (banckAccount[i].typeOfAccount)
                {
                    case "saving":
                        Console.WriteLine("Enter Choice to deposit or withdrwal amount");
                        banckAccount[i].depositeOrWithdrwal = Console.ReadLine();

                        switch (banckAccount[i].depositeOrWithdrwal)
                        {
                            case "deposit":
                                Console.WriteLine("Enter a amount you want to Deposite");
                                double deposite = double.Parse(Console.ReadLine());
                                banckAccount[i].deposit(deposite);
                                break;
                            case "withdrwal":
                                Console.WriteLine("Enter a amount you want to Withdrwal");
                                double withdrwal = double.Parse(Console.ReadLine());
                                banckAccount[i].withdrwal(withdrwal);
                                break;

                        }
                        break;

                    case "current":
                        Console.WriteLine("Enter Choice to deposit or withdrwal amount");
                        banckAccount[i].depositeOrWithdrwal = Console.ReadLine();

                        switch (banckAccount[i].depositeOrWithdrwal)
                        {
                            case "deposit":
                                Console.WriteLine("Enter a amount you want to Deposite");
                                double deposite = double.Parse(Console.ReadLine());
                                banckAccount[i].deposit(deposite);
                                break;
                            case "withdrwal":
                                Console.WriteLine("Enter a amount you want to Withdrwal");
                                double withdrwal = double.Parse(Console.ReadLine());
                                banckAccount[i].withdrwal(withdrwal);
                                break;
                        }
                        break;
                }
                banckAccount[i].Balance();
                banckAccount[i].uniqueId();
                Console.WriteLine("Number of Transcation are :" +i);
            }
            //Display info
            display:
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("\n Name of Account Holder :" + banckAccount[i].nameOfDepositor);
                Console.WriteLine("Address of Account Holder :" + banckAccount[i].addressOfDepositor);
                Console.WriteLine("Balance of Account Holder :" + banckAccount[i].Balance());
            }
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("You want to deposit another amount in account (yes/no)");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "yes":
                        goto yes;
                        break;

                    case "no":
                        goto no;
                        break;

                }
                Console.WriteLine("You want to change the adress (yes/no)");
                string ch = Console.ReadLine();
                if(ch=="yes")
                {
                    Console.WriteLine("Enter a new Update address");
                    banckAccount[i].addressOfDepositor = Console.ReadLine();
                    goto display;
                }
                else
                {
                    goto no;
                }
            }
        no:
            Console.ReadKey();
        }
    }
}
