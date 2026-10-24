using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class InvalidAmountException : Exception
    {
        public InvalidAmountException()
        {
            
        }

        public InvalidAmountException(string message) : base(message) 
        {
            
        }
    }


}
