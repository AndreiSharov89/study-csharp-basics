
using System.Security.Cryptography;

class BankAccount 
{
    //out
    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }
    
    //in(it)
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
    
    //fields
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    
    private static long nextNumber = 123;

    //methods
    private static long NextNumber()
    {
        return nextNumber++;
    }

    public decimal Deposit(decimal amount) 
    {
        accBal += amount;
        return accBal; 
    }

    public bool Withdraw(decimal amount) 
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds) 
        {
            accBal -= amount;
        }
        return sufficientFunds;
    }
}
