using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Checking : IPrintable, IAccount //built using composition from Account
    {
        private Account account { get; set; }

        public int NextCheckNbr { get; set; } = 1;
        public int GetId()
        {
            return account.GetId();

        }
        public decimal GetBalance()
        {
            return account.GetBalance();
        }
        public string GetDescription()
        {
            return account.GetDescription();
        }
        public void SetDescription(string NewDescription)
        {
            account.SetDescription(NewDescription);
        }
        public void Deposit(decimal Amount)
        {
            account.Deposit(Amount);
        }
        public void Withdraw(decimal Amount)
        {
            account.Withdraw(Amount);
        }
        public string Print()
        {
            return account.Print() + $" NextCheckNbr= {NextCheckNbr}";
        }

        public int GetNextCheckNbr()
        {
            return NextCheckNbr;
        }
        public void TransferTo(decimal Amount, Account account)
        {

        }
        
        

        public Checking(string Newdescription) 
        {
            account = new Account(Newdescription);
        }
        public Checking() : this(null) 
        {

        }
    }

}
