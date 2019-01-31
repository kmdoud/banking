using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Account
    {
        public void TransferTo(double Amount, Account acct)
        {
            var BalanceBeforeWithdraw = GetBalance();
            Withdraw(Amount);
            var BalanceAfterWithdraw = GetBalance();
            if (BalanceBeforeWithdraw == BalanceAfterWithdraw)
            {
                Console.WriteLine(" Insufficient Funds");
                return;
            }
            acct.Deposit(Amount);
        }
        private static int nextId = 1;
        private int Id { get; set; }
        private string Description { get; set; }
        private double Balance { get; set; }
        public string GetDescription()
        {
            return Description;
        }
        public int GetId()
        {
            return Id;
        }
        public void SetDescription(string NewDescription)
        {
            Description = NewDescription;
        }
        public double GetBalance()
        {
            return Balance;
        }
        public void Deposit(double Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Must deposit at least .01 !");
            }
            else
            {
                Balance += Amount;
            }
        }
        public void Withdraw(double Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Cannot withdraw a negative number!");
                return;
            }
            if (Amount > Balance)
            {
                Console.WriteLine("Insuffiecient Funds!");
                return;
            }
            else
            {
                Balance -= Amount;
            }
        
        }

        public virtual string Print()
        {
           return $"Id = {Id}, Description = {Description}, and Balance = {Balance}";
        }


       

        public Account(string NewDescription)
        {
            Id = nextId++;
            if (NewDescription == null)
            {
                Description = "*New Account*";
            }
            else
            {
                Description = NewDescription;
            }
            Balance = 0;
        }
        public Account()
            : this(null)
        {


        }
    }
}
