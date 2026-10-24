using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class BankAccount
    {
        public BankAccount(string accNumber , decimal balance)
        {
            AccountNumber = accNumber;
            Balance = balance;
        }

        public string AccountNumber {  get; set; }
        public decimal Balance { get; set; }
        public bool IsLocked { get; set; }

        public void Withdraw(decimal amount)
        {
            if (IsLocked == true)
            {
                throw new AccountLockedException("Account locked");
            }
            else if (amount <= 0)
            {
                throw new InvalidAmountException("Zero or negative amount");
            }
            else if (amount > Balance)
            {
                var ex = new InsufficientFundsException("Not enough money on the account.");
                ex.CurrentBalance = Balance;
                ex.RequestedAmount = amount;
                throw new InsufficientExecutionStackException("No enough money");
            }
            Balance = Balance-amount;
        }

        public void Deposit(decimal amount)
        {
            if (IsLocked == true)
            {
                throw new AccountLockedException("Account locked");
            }
            else if (amount <= 0)
            {
                throw new InvalidAmountException("Zero or negative amount");
            }
            
            Balance = Balance + amount;
        }

    }
}
