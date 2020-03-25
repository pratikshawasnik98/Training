using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_class
{

    class BankAccount
    {
        public class Account
        {
            static string name;
            public void SetName(string n)
            {
                name = n;
                Console.WriteLine("Name :" + name);
            }
        }
            public int actno;
            public void SetActno(int a)
            {
                actno = a;
                Console.WriteLine("Account  :" + actno);
            }
     }
    
        class Program
        {
            static void Main(string[] args)
            {
                BankAccount.Account obj = new BankAccount.Account();
                obj.SetName("Abc");

                BankAccount b = new BankAccount();
                b.SetActno(22);
                Console.ReadKey();
            }
        }
}

