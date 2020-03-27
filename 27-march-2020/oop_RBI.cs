using System;

namespace oop_RBI
{
   class RBI
    {
        public void welcome()
        {
            Console.WriteLine("Welcome To Internet Banking");
        }
    }
    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Enter your Full Name:");
            Console.ReadLine();
        }
    }
    class Account
    {

        public string AccountType()
        {
            Console.WriteLine("Enter Your Bank Name (i.e sbi, icici, pnb)");
            string bankname=Console.ReadLine();
            return bankname;
        }
    }
    class SBI : RBI 
    {
        double Balance=1000, intrestCalulate, principle = 100, rate = 0.04, year = 1;
        public void intrest()
        {
            intrestCalulate = principle * rate * year;
        }
        public void deposit(double amountRecevied)
        {
            Balance = Balance +intrestCalulate + amountRecevied;
            Console.WriteLine("Your Account Balance Is : " + Balance);
            Console.WriteLine("Thank Tou for Using Banking service");
        }
        public void withdrwal(double amountRecevied)
        {
            if (amountRecevied < 20000)
            {
                Balance = Balance - amountRecevied;
                if (Balance < 1000)
                {
                    Console.WriteLine("Your Bank Account balance Minimum Required 1000");
                }
                else
                {

                    Console.WriteLine("Your Account Balance Is : " + Balance);
                    Console.WriteLine("Thank Tou for Using Banking service");
                }
            }
            else
            {
                Console.WriteLine("You can only withdrwal less than 20000");
            }
        }
        public void checkedBalance()
        {
            //Balance = Balance + amountRecevied;
            Console.WriteLine("Your Account Balance Is : " + Balance);
            Console.WriteLine("Thank Tou for Using Banking service");
        }
    }
    class ICICI : RBI
    {
        double Balance=1000,intrestCalulate,principle=100,rate=0.04,year=1;
        public void intrest()
        {
            intrestCalulate = principle * rate * year;
        }
        public void deposit(double amountRecevied)
        {
            Balance = Balance + intrestCalulate + amountRecevied;
            Console.WriteLine("Your Account Balance Is : " + Balance);
            Console.WriteLine("Thank Tou for Using Banking service");
        }
        public void withdrwal(double amountRecevied)
        {
            if (amountRecevied < 20000)
            {
                Balance = Balance - amountRecevied;
                if (Balance < 1000)
                {
                    Console.WriteLine("Your Bank Account balance Minimum Required 1000");
                }
                else
                {

                    Console.WriteLine("Your Account Balance Is : " + Balance);
                    Console.WriteLine("Thank Tou for Using Banking service");
                }

            }
            else
            {
                Console.WriteLine("You can only withdrwal less than 20000");
            }
        }
        public void checkedBalance()
        {
            //Balance = Balance + amountRecevied;
            Console.WriteLine("Your Account Balance Is : " + Balance);
            Console.WriteLine("Thank Tou for Using Banking service");
        }
    }
    class PNB : RBI
    {
        double Balance=1000, intrestCalulate, principle = 100, rate = 0.04, year = 1;
        public void intrest()
        {
            intrestCalulate = principle * rate * year;
        }
        public void deposit(double amountRecevied)
        {
            Balance = Balance +intrestCalulate+ amountRecevied;
            Console.WriteLine("Your Account Balance Is : " + Balance);
            Console.WriteLine("Thank Tou for Using Banking service");
        }
        public void withdrwal(double amountRecevied)
        {
            if (amountRecevied < 20000)
            {
                Balance = Balance - amountRecevied;
                if (Balance < 1000)
                {
                    Console.WriteLine("Your Bank Account balance Minimum Required 1000");
                }
                else
                {
                   
                    Console.WriteLine("Your Account Balance Is : " + Balance);
                    Console.WriteLine("Thank Tou for Using Banking service");
                }

            }
            else
            {
                Console.WriteLine("You can only withdrwal less than 20000");
            }
        }
        public void checkedBalance()
        {
            //Balance = Balance + amountRecevied;
            Console.WriteLine("Your Account Balance Is : " + Balance);
            Console.WriteLine("Thank Tou for Using Banking service");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String Name,accountType, depoWith;
            double amount;
            //Classe Objects
            SBI sbiBank = new SBI();
            ICICI iciciBank = new ICICI();
            PNB pnbBank = new PNB();

            RBI rbi = new RBI();
            rbi.welcome();
            Customer customer = new Customer();
            Account account = new Account();

        start:
            String bankName = account.AccountType();
            switch(bankName)
            {
                
                //FOr SBI Bank
                case "sbi":
                    Console.WriteLine("Enter your account type (i.e saving or current)");
                    accountType = Console.ReadLine();
                    switch(accountType)
                    {
                        case "saving":
                            Console.WriteLine("You want to deposit or withdrwal ammount And you can Chacked your account balance");
                            depoWith = Console.ReadLine();
                            switch (depoWith)
                            {
                                case "deposit":
                                    Console.WriteLine("Enter a ammount that you want to deposit");
                                    amount = double.Parse(Console.ReadLine());
                                    sbiBank.deposit(amount);
                                    break;

                                case "withdrwal":
                                    Console.WriteLine("Enter a ammount that you want to Withdrwal");
                                    amount = double.Parse(Console.ReadLine());
                                    sbiBank.withdrwal(amount);
                                    break;

                                case "balance":
                                    Console.WriteLine("Cheacked your balance");
                                    sbiBank.checkedBalance();
                                    break;
                            }
                            break;
                        case "current":
                            Console.WriteLine("You want to deposit or withdrwal ammount And you can Chacked your account balance");
                            depoWith = Console.ReadLine();
                            switch (depoWith)
                            {
                                case "deposit":
                                    Console.WriteLine("Enter a ammount that you want to deposit");
                                    amount = double.Parse(Console.ReadLine());
                                    sbiBank.deposit(amount);
                                    break;

                                case "withdrwal":
                                    Console.WriteLine("Enter a ammount that you want to Withdrwal");
                                    amount = double.Parse(Console.ReadLine());
                                    sbiBank.withdrwal(amount);
                                    break;

                                case "balance":
                                    Console.WriteLine("Cheacked your balance");
                                    sbiBank.checkedBalance();
                                    break;
                            }
                            break;
                    }
                    break;

                //for ICICI Bank 
                case "icici":
                    Console.WriteLine("Enter your account type (i.e saving or current)");
                    accountType = Console.ReadLine();
                    switch (accountType)
                    {
                        case "saving":
                            Console.WriteLine("You want to deposit or withdrwal ammount And you can Chacked your account balance");
                            depoWith = Console.ReadLine();
                            switch (depoWith)
                            {
                                case "deposit":
                                    Console.WriteLine("Enter a ammount that you want to deposit");
                                    amount = double.Parse(Console.ReadLine());
                                    iciciBank.deposit(amount);
                                    break;

                                case "withdrwal":
                                    Console.WriteLine("Enter a ammount that you want to Withdrwal");
                                    amount = double.Parse(Console.ReadLine());
                                    iciciBank.withdrwal(amount);
                                    break;

                                case "balance":
                                    Console.WriteLine("Cheacked your balance");
                                    iciciBank.checkedBalance();
                                    break;
                            }
                            break;
                        case "current":
                            Console.WriteLine("You want to deposit or withdrwal ammount And you can Chacked your account balance");
                            depoWith = Console.ReadLine();
                            switch (depoWith)
                            {
                                case "deposit":
                                    Console.WriteLine("Enter a ammount that you want to deposit");
                                    amount = double.Parse(Console.ReadLine());
                                    iciciBank.deposit(amount);
                                    break;

                                case "withdrwal":
                                    Console.WriteLine("Enter a ammount that you want to Withdrwal");
                                    amount = double.Parse(Console.ReadLine());
                                    iciciBank.withdrwal(amount);
                                    break;

                                case "balance":
                                    Console.WriteLine("Cheacked your balance");
                                    iciciBank.checkedBalance();
                                    break;
                            }
                            break;

                    }
                    break;

                //For PNB Bank
                case "pnb":
                    Console.WriteLine("Enter your account type (i.e saving or current)");
                    accountType = Console.ReadLine();
                    switch (accountType)
                    {
                        case "saving":
                            Console.WriteLine("You want to deposit or withdrwal ammount And you can Chacked your account balance");
                            depoWith = Console.ReadLine();
                            switch (depoWith)
                            {
                                case "deposit":
                                    Console.WriteLine("Enter a ammount that you want to deposit");
                                    amount = double.Parse(Console.ReadLine());
                                    pnbBank.deposit(amount);
                                    break;

                                case "withdrwal":
                                    Console.WriteLine("Enter a ammount that you want to Withdrwal");
                                    amount = double.Parse(Console.ReadLine());
                                    pnbBank.withdrwal(amount);
                                    break;

                                case "balance":
                                    Console.WriteLine("Cheacked your balance");
                                    pnbBank.checkedBalance();
                                    break;
                            }
                            break;
                        case "current":
                            Console.WriteLine("You want to deposit or withdrwal ammount And you can Chacked your account balance");
                            depoWith = Console.ReadLine();
                            switch (depoWith)
                            {
                                case "deposit":
                                    Console.WriteLine("Enter a ammount that you want to deposit");
                                    amount = double.Parse(Console.ReadLine());
                                    pnbBank.deposit(amount);
                                    break;

                                case "withdrwal":
                                    Console.WriteLine("Enter a ammount that you want to Withdrwal");
                                    amount = double.Parse(Console.ReadLine());
                                    pnbBank.withdrwal(amount);
                                    break;

                                case "balance":
                                    Console.WriteLine("Cheacked your balance");
                                    pnbBank.checkedBalance();
                                    break;
                            }
                            break;
                    }
                    break;
            }//main Switch case Close
            Console.WriteLine("You Want to do Another Task(yes/no): ");
            string taskType = Console.ReadLine();
            if(taskType=="yes")
            {
                goto start;
            }
            else
            {
                goto end;
            }
        end:
            Console.ReadKey();
        }
    }
}
