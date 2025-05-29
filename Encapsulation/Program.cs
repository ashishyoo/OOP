public class BankAccount
{
    private double balance;

    // Public method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount");
        }
    }

    // Public method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid or insufficient funds");
        }
    }

    // Public method to check balance
    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        account.Deposit(1000); // Output: Deposited: 1000
        account.Withdraw(200); // Output: Withdrawn: 200
        Console.WriteLine($"Current Balance: {account.GetBalance():f2}"); // Output: Current Balance: 800.00

        // account.balance = 5000; // Not allowed, balance is private
    }
}
