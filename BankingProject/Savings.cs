using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Savings : Account, IPrintable, IAccount  //using inheritance to call accounts 
    {
        public override string Print()
        {
            return base.Print() + $" IntRate={IntRate}";
        }
        private decimal IntRate { get; set; } = .01M;

        public decimal GetIntRate()
        {
            return IntRate;
        }
        public void SetIntRate(decimal NewIntRate)
        {
            IntRate = NewIntRate;
        }
        
        public void PayInterest()
        {
            var IntToBePaid = GetBalance() * GetIntRate();
            Deposit(IntToBePaid);
        }

        public Savings(string NewDescription) : base(NewDescription)
        {
            SetIntRate(.01M);
        }
        public Savings() : this(null)
        {

        }
    }



}
