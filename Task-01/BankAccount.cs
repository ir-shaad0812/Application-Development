//Task-01:  Enccapsulation 
public class BankAccount
{
    private string accountNumber;
    private double balance;

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
                balance = value;
            else
                throw new Exception("Balance cannot be zero or negative.");
        }
    }

    // Constructor
    public BankAccount(string accNum, double initialBalance)
    {
        accountNumber = accNum;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }
        balance += amount;
        Console.WriteLine($"Deposited: {amount}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be positive.");
            return;
        }
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
            return;
        }
        balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}");
    }
}
