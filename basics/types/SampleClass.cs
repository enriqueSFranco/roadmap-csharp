// Un tipo que se define como una class, es un tipo de referencia.
// Al declarar una variable de un tipo de referencia en tiempo de ejecución,
// esta contendrá el valor null hasta que se cree expresamente una instancia de la clase mediante el operador new o que se le asigne un objeto creado en otro lugar

namespace SampleClass
{
  public class Container(int capacity) // constructor principal, los parametros estan disponibles en el cuerpo de la clase
  {
    private int _capacity = capacity;
  }

  public class Person
  {
    public required string FirstName {get;}
    public required string Surname {get;}
  }

  // Herencia
  public class Employee {}
  public class Manager: Employee {}
}

/*
NOTE: Para instanciar un objeto de tipo Person se deben establecer las propiedades marcadas como requeridas
como una parte de la expresión.

var p1 = new Person() // ❌ Error! Required properties not set
var p2 = new Person() {FirstName = "kazuto", Surname = "kirigaya" };
*/
