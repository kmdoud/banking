using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
   public class DepositWithdrawTransferException : Exception
    {
        public DepositWithdrawTransferException() 
            :base (){ }

        public DepositWithdrawTransferException(string Message) 
            :base (Message){ }

        public DepositWithdrawTransferException(string Message, Exception innerException) 
            :base(Message, innerException) { }
    }
}
