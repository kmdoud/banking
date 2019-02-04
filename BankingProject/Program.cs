using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{

    class Program
    {
        static void Main(string[] args)
        {
            IPrintable[] accounts =
            {
                new Account("An Account"),
                new Savings("A Savings"),
                new Checking("A Checking")
                
            };
            foreach (var account in accounts)
            {
                IAccount acct = account as IAccount;
               
                Console.WriteLine(account.Print());
            }
            Console.ReadKey();
            //Account acctAbc = new Account("abc");
            //Account acctXyz = new Account("xyz");
            //Account[] accounts = { acctXyz, acctAbc };
            //Array.Sort(accounts);
            //foreach(var account in accounts)
            //{
            //    Console.WriteLine(account.GetDescription());
            //}
            //Console.ReadKey();

            //Checking chk0 = new Checking();
            //Console.WriteLine(chk0.Print());
            //var chk1 = new Checking("My First Checking Acct");
            //var chk2 = new Checking();
            //chk2.Deposit(500);
            //Console.WriteLine(chk2.Print());
            //Console.WriteLine(chk1.Print());


            //var sav1 = new Savings();
            //sav1.Print();
            //sav1.Deposit(1500);
            //sav1.Print();
            //sav1.Withdraw(500);
            //sav1.Print();
            //sav1.PayInterest();
            //Console.WriteLine(sav1.Print());

            //var sav2 = new Savings();
            //sav2.SetDescription("From Savings Account");
            //sav2.Deposit(1000);
            //Console.WriteLine(sav2.Print());

            //var sav3 = new Savings();
            //sav3.SetDescription("To Savings Account");
            //sav3.Deposit(100);
            //Console.WriteLine(sav3.Print());

            //List<Account> accounts = new List<Account>();
            //accounts.Add(chk1);
            //accounts.Add(chk2);
            //accounts.Add(sav1);
            //accounts.Add(sav2);
            //accounts.Add(sav3);

            //foreach (var account in accounts)
            //{
            //    Console.WriteLine(account.Print());

            //}

            //sav2.TransferTo(200, sav3);
            //sav2.Print();
            //sav3.Print();
            //sav3.TransferTo(500, sav2);
            //Console.WriteLine(sav2.Print());
            //Console.WriteLine(sav3.Print());



            //var acct1 = new Account(("Test Checking"));
            //acct1.Print();
            //acct1.Deposit(1000.00);
            //acct1.Print();
            //acct1.Withdraw(60.00);
            //Console.WriteLine(acct1.Print());

            //var acct2 = new Account(("Test Savings"));
            //acct2.Print();
            //acct2.Deposit(1000000.00);
            //acct2.Deposit(100.00);
            //acct2.Print();
            //acct2.Withdraw(100.00);

            //var acct3 = new Account();
            //Console.WriteLine(acct3.Print());

        }
    }
}
