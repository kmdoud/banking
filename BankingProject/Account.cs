using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Account
    {
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
            Balance += Amount; 

        }
        public void Withdraw(double Amount)
        {
            Balance -= Amount;
        }
        public void Print()
        {
            Console.WriteLine($"Id ={Id}, Description = {Description}, and Balance = {Balance}");
        }
        public Account(string NewDescription)
        {
            Id = -1;
            Description = NewDescription;
            Balance = 0;
        }
        public Account()
        {
            Id = -1;
            Description = "$New Account";
            Balance = 0;

        }

    }
}
