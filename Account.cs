class Account
{

    private double _balance;

    protected double Balance
    {
        get { return this._balance; }
        set
        {
            if (value >= 0)
                this._balance = value;
        }
    }

    // Constructor
    public Account(double balance)
    {
        this.Balance = balance;
    }

    //Virtual Methods
    public virtual bool Deposit(double amount)
    {

        return false;
    }

    public virtual bool Withdraw(double amount)
    {

        return false;
    }

    public virtual void PrintBalance()
    {
        Console.WriteLine("The balance is: " + Balance);
    }


}