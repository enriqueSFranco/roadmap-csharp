//namespace RoadmapCsharp.Basics.OOP // La declaración namespace permite organizar el código de forma lógica.

/*
'this' solo es necesario cuando una variable o un parámetro local tiene el mismo nombre que el campo o la propiedad
*/
namespace RoadmapCsharp.Basics.OOP.Models
{
  public class BankAccount
  {
    // . Campo privado estático
    //   s_ → indica que es static.
    // camelCase o PascalCase según la convención interna del equipo o herramienta (en este caso, camelCase con prefijo s_).
    private static int s_accountNumberSeed = 1234567890;
    private readonly decimal _minimumBalance;
    // Propiedades públicas
    //   ➡️ Se escriben en PascalCase porque son miembros públicos que exponen datos de forma controlada.
    // 🔹 Convención: PascalCase para propiedades y métodos públicos.
    public string Number { get; }
    public string Owner { get; }
    public decimal Balance
    {
      get
      {
        decimal balance = 0;
        foreach (var item in _allTransitions)
        {
          balance += item.Amount;
        }
        return balance
      }
    }

    //   🔹 Convención común (Microsoft):
    // Campos privados normales: _nombre
    private List<Transaction> _allTransactions = new List<Transaction>();
    // Campos estáticos privados: s_nombre

    // constructor
    public BankAccount(string, name, decimal initialBalance) : this(name, initialBalance, 0)
    {
      Owner = name;
      MakeDeposit(initialBalance, DateTime.Now, "Initial balance.")
      s_accountNumberSpeed++;
    }

    public BankAccount(string, name, decimal initialBalance, decimal minimumBalance)
    {
      Numbre = s_accountNumberSeed.ToString();
      s_accountNumberSeed++;

      Owner = name;
      _minimumBalance = minimumBalance;
      if (initialBalance > 0)
      {
        MakeDeposit(initialBalance, DateTime.Now, "Initial balance")
      }
    }

    // métodos
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
      if (amount <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
      }
      var deposit = new Transaction(amount, date, note);
      _allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
      if (amount <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
      }
      Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance)
      Transaction? withdrawal = new(-amount, date, note);
      // if (Balance - amount < _minimumBalance) {
      //   throw new InvalidOperationException("Not sufficient funds for this withdrawal");
      // }
      // var withdrawal = new Transaction(-amount, date, note);
      _allTransactions.Add(withdrawal);
      if (overdraftTransaction != null)
      {
        _allTransactions.Add(overdraftTransaction);
      }
    }

    public string GetAccountHistory()
    {
      var report = new System.Text.StringBuilder();
      decimal balance = 0;
      report.AppendLine("Date\t\tAmount\tBalance\tNote");
      foreach (var item in _allTransactions)
      {
        balance += item.Amount;
        report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Note}");
      }
      return balance;
    }

    // creando un método virtual
    // Los métodos virtuales en C# son métodos que puedes sobrescribir (override) en una clase derivada (hija),
    // lo que permite modificar su comportamiento sin cambiar el de la clase base (padre).
    public virtual void PerformMonthEndTransactions() { }

    protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
    {
      if (isOverdrawn)
      {
        throw new InvalidOperationException("Not sufficient funds for this withdrawal");
      }
      else
      {
        return default;
      }
    }
  }
}
