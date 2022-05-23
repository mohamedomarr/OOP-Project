class CheckingAccount : Account
{

    public CheckingAccount(double balance)
        : base(balance) { }


    public override bool Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            return true;
        }
        return false;
    }


    public override bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }


    public override void PrintBalance()
    {

        Console.WriteLine("The checking account balance is: " + base.Balance);
    }

}