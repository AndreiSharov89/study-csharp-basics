
using System;

class CreateAccount
{
    // Test Harness
    static void Main() 
    {
        BankAccount acc1, acc2, acc3, acc4;
        acc1 = new BankAccount();
        acc2 = new BankAccount(AccountType.Deposit);
        acc3 = new BankAccount(100);
        acc4 = new BankAccount(AccountType.Deposit, 150);
        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);

        acc1.Deposit(10);
        acc2.Deposit(10);
        acc3.Deposit(10);
        acc4.Deposit(10);

        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);

        acc2.Withdraw(5);
        acc3.Withdraw(50);
        acc4.Deposit(5);
        acc1.Withdraw(5);

        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);



        Console.ReadKey();

        acc2.Withdraw(5);
        acc3.Withdraw(50);
        acc4.Deposit(5);
        acc1.Withdraw(5);
        acc2.Withdraw(5);
        acc3.Withdraw(50);
        acc4.Deposit(5);
        acc1.Withdraw(5);

        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);


        Console.ReadKey();

    }

    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}", acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
        Console.WriteLine("Transactions:");
        foreach (BankTransaction tran in acc.Transactions())
        {
            Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
        }
        Console.WriteLine();
    }
}
