using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class AccountLockedException : Exception
    {
        public AccountLockedException()
        {
            
        }

        public AccountLockedException(string message) : base(message) 
        {
            
        }
    }
}
