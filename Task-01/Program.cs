using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("ACC12345", 1000);

            Console.WriteLine("Account Number: " + acc.AccountNumber);
            Console.WriteLine("Opening Balance: " + acc.Balance);

            acc.Deposit(500);
            acc.Withdraw(300);

            Console.WriteLine("Remaining Balance: " + acc.Balance);
        }
    }
}
