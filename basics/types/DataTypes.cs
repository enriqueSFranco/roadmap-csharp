// ✅ Convenciones de nomenclatura en C#

// C# sigue ciertas convenciones para diferenciar roles de los elementos del código:
// Elemento	                          Convención	    Ejemplo
// Clases	                            PascalCase	    Circulo, Persona
// Métodos	                          PascalCase	    CalcularArea()
// Propiedades	                      PascalCase	    Radio, Nombre
// Campos privados	                  camelCase       con guion bajo (_)	_radio, _contador
// Parámetros y variables locales	    camelCase	      radio, area, nombre

using System;

class DataTypes
{
  // Campo de solo lectura (readonly)
  public readonly double EarthRadius = 6371.0;

  static void Main(string[] args)
  {
    Console.WriteLine("📚 Tipos de datos en C#\n");

    // 🌱 Tipos de datos primitivos
    int age = 21;                 // Entero
    string name = "Kazuto";       // Cadena de texto
    bool isActive = false;        // Booleano
    char symbol = '#';            // Carácter
    float temperature = 36.6f;    // Decimal de 32 bits (requiere 'f')
    double pi = 3.1416;           // Decimal de doble precisión
    decimal salary = 12345.67m;   // Decimal de alta precisión (requiere 'm')
    byte level = 255;             // Entero sin signo de 8 bits
    long population = 7800000000; // Entero largo
    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}");

    Console.WriteLine($"Nombre: {name}, Edad: {age}, Activo: {isActive}, Símbolo: {symbol}");

    // 🔍 Tipos inferidos (var)
    var surname = "Kirigaya"; // El compilador infiere que es una cadena
    Console.WriteLine($"Apellido (var): {surname}");

    // 🔐 Constantes (valor fijo en tiempo de compilación)
    const double GOLDEN_RATIO = 1.618;
    Console.WriteLine($"Constante GOLDEN_RATIO: {GOLDEN_RATIO}");

    // 🧊 Readonly (valor fijo en tiempo de ejecución)
    DataTypes instance = new DataTypes();
    Console.WriteLine($"Readonly EarthRadius: {instance.EarthRadius} km");

    // 🔄 Conversión de tipos (Type casting)
    double gravity = 9.8;
    Console.WriteLine($"Tipo original de gravity: {gravity.GetType()}");

    int integerGravity = Convert.ToInt32(gravity);
    Console.WriteLine($"Convertido a entero: {integerGravity}, tipo: {integerGravity.GetType()}");

    string strGravity = Convert.ToString(integerGravity);
    Console.WriteLine($"Convertido a string: \"{strGravity}\", tipo: {strGravity.GetType()}");

    // 🧠 Mostrar tipo de dato con typeof
    Console.WriteLine($"\nTipo de 'pi': {typeof(double)}");
    Console.WriteLine($"Tipo de 'name': {typeof(string)}");

    // Literarles
    double d = 3D;
    d = 4d;
    d = 3.934_001; // separador '_' de dígitos

    float f = 3_000.5F;
    f = 5.4f;

    decimal myMoney = 3_000.5m;
    myMoney = 400.75M;

    // 🧑🏻‍🔬 Notación cientifica
    double d = 0.42e2;
    Console.WriteLine(d);  // output 42

    float f = 134.45E-2f;
    Console.WriteLine(f);  // output: 1.3445

    decimal m = 1.5E6m;
    Console.WriteLine(m);  // output: 1500000

    // Más sobre booleans
    // bool? que acepta valores NULL
    bool check = true;
    Console.WriteLine(check ? "Checked" : "Not checked");  // output: Checked

    Console.WriteLine(false ? "Checked" : "Not checked");  // output: Not checked

    // Constantes
    const dobule PI = 3.1416;

    Console.ReadKey(); // Esperar entrada del usuario
  }
}
