namespace Bank;

public class BankAccount
{
    private double balance = 0;

    public BankAccount(double balance)
    {
        this.balance = balance;
    }

    public double Balance
    {
        get { return balance; }
    }

    public void Add(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount));
        }

        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > balance || amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount));
        }

        balance -= amount;
    }

    public void TransferFundsTo(BankAccount otherAccount, double amount)
    {
        if (otherAccount is null)
        {
            throw new ArgumentException(nameof(otherAccount));
        }

        Withdraw(amount);
        otherAccount.Add(amount);
    }
}
