class SavingsAccount : Account
{

    private double _interestRate;

    public SavingsAccount(double balance)
        : base(balance)
    {
        this._interestRate = 0.8;
        Balance += (Balance * this._interestRate);
    }

    public override bool Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount + (amount * this._interestRate);
            return true;
        }
        return false;
    }


    public override bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            // Deducting from balance with interest rate
            Balance -= amount + (amount * this._interestRate);
            return true;
        }
        return false;
    }


    public override void PrintBalance()
    {

        Console.WriteLine("The saving account balance is: " + base.Balance);
    }

}