
using System;
using System.Collections;

class BankAccount 
{
	private long accNo;
    private decimal accBal;
    private AccountType accType;
    private Queue tranQueue = new Queue();
    
    private static long nextNumber = 123;

    //public void Populate(decimal balance)
    //{
    //    accNo = NextNumber();
    //    accBal = balance;
    //    accType = AccountType.Checking;
    //}

    public BankAccount()
    { 
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = 0;
    }

    public BankAccount(AccountType aType)
    { 
        accType = aType;
        accNo = NextNumber();
        accBal = 0;
    }

    public BankAccount(decimal aBal)
    {
        accType = AccountType.Checking;
        accNo = NextNumber();
        accBal = aBal;
    }

    public BankAccount(AccountType aType, decimal aBal)
    {
        accType = aType;
        accNo = NextNumber();
        accBal = aBal;
    }



    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds) {
            accBal -= amount;
            BankTransaction tran = new BankTransaction(amount);
            tranQueue.Enqueue(tran);
        }
        return sufficientFunds;
    }
    
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        BankTransaction tran = new BankTransaction(amount);
        tranQueue.Enqueue(tran);
        return accBal;
    }
    
    public long Number()
    {
        return accNo;
    }
    
    public decimal Balance()
    {
        return accBal;
    }
    
    public string Type()
    {
        return accType.ToString();
    }

    private static long NextNumber()
    {
        return nextNumber++;
    }
    public Queue Transactions()
    {
        return tranQueue;
    }



    //public static string ToString(BankAccount accString)
    //{
    //    string Empty = "";
    //    while (true) 
    //    {
    //        Empty = ($"Acc num {accString.accNo}, acc type {accString.accType}, and balance {accString.accBal}");
    //        return Empty;
    //    }
    //    return Empty;

    //}
}
