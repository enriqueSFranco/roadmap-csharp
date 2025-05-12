namespace Basics.OOP
{
  public class GiftCardAccount
  {
    private readonly decimal _monthlyDeposit = 0m;
    public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialDecimal)
      => _monthlyDeposit = monthlyDeposit;

    public override void PerformMonthEndTransactions()
    {
      if (Balance != 0)
      {
        MakeDeposit(initialBalance, DateTime.Now, "Add monthly deposit");
      }
    }
  }
}
