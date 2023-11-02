using Bank;

namespace BankTest;

public class BankAccountTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Adding_Funds_Updates_Balance()
    {
        var account = new BankAccount(1000);
        account.Add(500);
        Assert.That(account.Balance, Is.EqualTo(1500));
    }

    [Test]
    public void Adding_Negative_Funds_Throws()
    {
        var account = new BankAccount(1000);
        Assert.Throws<ArgumentOutOfRangeException>(() => account.Add(-500));
    }

    [Test]
    public void Withdraw_Funds_Updates_Balance()
    {
        var account = new BankAccount(1000);
        account.Withdraw(500);
        Assert.That(account.Balance, Is.EqualTo(500));
    }

    [Test]
    public void Withdrawing_Negative_Funds_Throws()
    {
        var account = new BankAccount(1000);
        Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(-500));
    }

    [Test]
    public void Withdrawing_More_Than_Balance_Throws()
    {
        var account = new BankAccount(1000);
        Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(-2000));
    }

    [Test]
    public void Transfer_Funds_To_Another_Account()
    {
        var account = new BankAccount(1000);
        var otherAccount = new BankAccount(0);


        account.TransferFundsTo(otherAccount, 500);
        Assert.That(account.Balance, Is.EqualTo(500));
        Assert.That(otherAccount.Balance, Is.EqualTo(500));
    }
}
