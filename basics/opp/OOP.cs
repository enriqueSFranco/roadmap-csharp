// En C#, una clase es una plantilla o plano para crear objetos.
// Funciona como un tipo de dato definido por el usuario que agrupa datos (llamados campos o atributos)
// y funciones (llamadas métodos) que operan sobre esos datos.

// ⚙️ Los cuatro principios básicos de la programación orientada a objetos son:
// 1.- Abstracción: modelar los atributos e interacciones pertinentes de las entidades como clases para definir una representación abstracta de un sistema.
// 2.- Encapsulación: ocultar el estado interno y la funcionalidad de un objeto y permitir solo el acceso a través de un conjunto público de funciones.
// 3.- Herencia: capacidad de crear nuevas abstracciones basadas en abstracciones existentes.
// 4.- Polimorfismo: capacidad de implementar propiedades o métodos heredados de maneras diferentes en varias abstracciones.

// Una clase en sí misma no es un objeto, sino el molde a partir del cual se crean los objetos.
// Un objeto es una instancia concreta de una clase.

using System;

namespace Basics.OOP
{
  // 1. Definición de una Clase:
  class OOP
  {
    // Object-oriented programming
    static void Main(string[] args)
    {
      var account = new BankAccount("<name>", 1000); // 2. Objetos (Instancias de una Clase)
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.")
      try
      {
        account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
        Console.WriteLine(account.Balance);
      }
      catch (InvalidOperationException e)
      {
        Console.WriteLine("Exception caught trying to overdraw");
        Console.WriteLine(e.ToString());
      }

      try
      {
        account.MakeWithdrawal(450, DateTime.Now, "Friend paid me back");
        Console.WriteLine(account.Balance);
      }
      catch (InvalidOperationException e)
      {
        Console.WriteLine("Exception caught trying to overdraw");
        Console.WriteLine(e.ToString());
      }
      // Mostramos el historial de las transacciones
      Console.WriteLine(account.GetAccountHistory());

      // haciendo uso del try-catch
      BankAccount invalidAccount;
      try
      {
        invalidAccount = new BankAccount("invalid", -100);

      }
      catch (ArgumentOutOfRangeException e)
      {
        Console.WriteLine("Exception caught creating account with negative balance");
        Console.WriteLine(e.ToString());
        return;
      }
      var giftCard = new GiftCardAccount("gift card", 100, 50);
      giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
      giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");

      giftCard.MakeDeposit(750, DateTime.Now, "add some additional spending money");
      Console.WriteLine(giftCard.GetAccountHistory());

      var savings = new LineOfCreditAccount("line of credit", 0);
      savings.MakeDeposit(750, DateTime.Now, "save some money");
      savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
      savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
      savings.PerformMonthEndTransactions();
      Console.WriteLine(savings.GetAccountHistory());

      var lineOfCredit = new LineOfCreditAccount("line of credit", 0);
      // How much is too much to borrow?
      lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
      lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
      lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
      lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
      lineOfCredit.PerformMonthEndTransactions();
      Console.WriteLine(lineOfCredit.GetAccountHistory());



      var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
      // How much is too much to borrow?
      lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
      lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
      lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
      lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
      lineOfCredit.PerformMonthEndTransactions();
      Console.WriteLine(lineOfCredit.GetAccountHistory());
    }
  }
}
