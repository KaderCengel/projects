

namespace _2.odev3;

class CheckingAccount:BankAccount
{
    public CheckingAccount(double balance) : base(balance) { }
    public override void CalculateInterest()
    {
        Console.WriteLine("Checking account interest: Checking accounts do not earn interest.");
    }
}
