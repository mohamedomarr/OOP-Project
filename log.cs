class login
{
    public static void log(Account CAccount)
    {
        Console.WriteLine("What's your next move");
        Console.WriteLine("1- Deposit");
        Console.WriteLine("2- Withdraw");
        Console.WriteLine("3- Check balance");
        Console.WriteLine("4- Exit");
        Console.Write("Enter your intended operation number: ");


        int opr = Convert.ToInt32(Console.ReadLine());
        if (opr == 1)
        {
            Console.Write("Enter your deposit amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            CAccount.Deposit(amount);
            CAccount.PrintBalance();
            log(CAccount);
        }
        else if (opr == 2)
        {
            Console.Write("Enter your withdrow amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            CAccount.Withdraw(amount);
            CAccount.PrintBalance();
            log(CAccount);
        }
        else if (opr == 3)
        {
            CAccount.PrintBalance();
            log(CAccount);

        }
        else if (opr == 4)
        {
            Console.WriteLine("bye");
        }
        else
        {
            Console.WriteLine("try again");
        }
    }
}