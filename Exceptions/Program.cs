using Exceptions;

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount("BYN123", 500m);
        BankAccount acc2 = new BankAccount("BYN456", 100m);

     
        Console.WriteLine("--- Тест 1 ---");
        BankService.Transfer(acc1, acc2, 200m);

   
        Console.WriteLine("\n--- Тест 2 ---");
        BankService.Transfer(acc1, acc2, -50m);

       
        Console.WriteLine("\n--- Тест 3 ---");
        BankService.Transfer(acc2, acc1, 1000m);

        
        Console.WriteLine("\n--- Тест 4 ---");
        acc1.IsLocked = true;
        BankService.Transfer(acc1, acc2, 50m);
    }
}