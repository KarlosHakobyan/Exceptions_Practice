using System;

namespace Exceptions
{
    internal class BankService
    {
        public static void Transfer(BankAccount fromAccount, BankAccount toAccount, decimal amount)
        {
            Console.WriteLine($"[START] Sender Balance: {fromAccount.Balance}, Receiver Balance: {toAccount.Balance}, Transfer Amount: {amount}");

            try
            {
                fromAccount.Withdraw(amount);
                toAccount.Deposit(amount);
                Console.WriteLine("Transfer completed successfully!");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Transfer failed: {ex.Message}. Current Balance: {ex.CurrentBalance}, Requested: {ex.RequestedAmount}");
            }
            catch (AccountLockedException ex)
            {
                Console.WriteLine($"Transfer failed: {ex.Message}");
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine($"Transfer failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"[END] Sender Balance: {fromAccount.Balance}, Receiver Balance: {toAccount.Balance}");
                Console.WriteLine("Transfer operation finished.\n");
            }
        }
    }
}