namespace Basics.OOP
{
  public class LineOfCreditAccount
  {
    private decimal _creditLimit;

    public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
    {
      _creditLimit = creditLimit;
    }

    public override bool CheckWithdrawalLimit(bool isOverdrawn) =>
      isOverdrawn
      ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
      : default;

    public override void PerformMonthEndTransactions()
    {
      if (Balance < 0)
      {
        decimal interest = -Balance * 0.07m;
        MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest")

        if (Math.Abs(Balance) > _creditLimit)
        {
          MakeWithdrawal(25m, DateTime.Now, "Cargo por exceder el crédito")
        }
      }
    }
  }
}
