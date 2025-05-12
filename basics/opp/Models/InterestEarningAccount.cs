namespace RoadmapCsharp.Basics.OOP.Models
{
  public class InterestEarningAccoung : BankAccount
  {
    public InterestEarningAccoung(string name, decimal initialBalanace) : base(name, initialBalance)
    {

    }
    public override void PerformMonthEndTransactions()
    {
      if (Balance > 500m)
      {
        decimal interest = Balance * 0.02m;
        MakeDeposit(interest, DateTime.Now, "apply monthly interest")
      }
    }
  }
}
