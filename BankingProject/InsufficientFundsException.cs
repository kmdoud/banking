using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    public class InsufficientFundsException: Exception
    {
        public InsufficientFundsException() 
            : base() { }

        public InsufficientFundsException(string Message) 
            : base(Message) { }

        public InsufficientFundsException(string Message, Exception innerException)
            :base(Message, innerException) { }


    }
}
