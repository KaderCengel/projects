

namespace _2.odev3;

class BankAccount
{
    public BankAccount(double balance)
    {
        Balance = balance;
    }
    public string AccountHolder;
    public double Balance;
    public virtual  void CalculateInterest() { }
}
