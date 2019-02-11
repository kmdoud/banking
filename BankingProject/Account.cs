using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Account : IComparable<Account>, IPrintable, IAccount // account class is now comparable by description by the "IComparable<Account>"
    {
        public int CompareTo(Account acct) // combined with this method containing this template as well
        {
            if(this.Description.Equals(acct.Description))
            {
                return 0;
            }
            if (this.Description.CompareTo (acct.Description) >0 )
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public void TransferTo(decimal Amount, Account acct)
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
        private decimal Balance { get; set; }
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
        public decimal GetBalance()
        {
            return Balance;
        }
        public void Deposit(decimal Amount)
        {
            if (Amount <= 0)
            {
                throw new DepositWithdrawTransferException();
            }
            else
            {
                Balance += Amount;
            }
        }
        public void Withdraw(decimal Amount)
        {
            if (Amount <= 0)
            {
                throw new DepositWithdrawTransferException();
                //Console.WriteLine("Cannot withdraw a negative number!");
                //return;
            }
            if (Amount > Balance)
            {
                throw new InsufficientFundsException();

                //Console.WriteLine("Insuffiecient Funds!");
                //return;
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
