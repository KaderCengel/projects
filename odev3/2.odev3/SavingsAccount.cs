

namespace _2.odev3;

class SavingsAccount:BankAccount
{
    public SavingsAccount(double balance) : base(balance) { }
    public override void CalculateInterest()
    {
         Console.WriteLine("Saving account interest: "+(Balance * 5) / 100);
    }
}
