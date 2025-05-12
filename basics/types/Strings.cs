class Strings
{
  static void main(string[] args)
  {
    string firstFriend = "Maria";
    string secondFriend = "Sage";
    Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

    // longitud de un string
    Cosole.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
    Cosole.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

    // borrar espacios principales o finales
    string greeting = "      Hello World!       ";
    Console.WriteLine($"[{greeting}]");

    string trimmedGreeting = greeting.TrimStart();
    Console.WriteLine($"[{trimmedGreeting}]");

    trimmedGreeting = greeting.TrimEnd();
    Console.WriteLine($"[{trimmedGreeting}]");

    string trimmedGreeting = greeting.Trim();
    Console.WriteLine($"[{trimmedGreeting}]");

    // reemplazar una string por otro
    string sayHello = "Hello, World";
    Console.WriteLine($"{sayHello}");

    sayHello = sayHello.Replace("Hello", "Greetings");
    Console.WriteLine(sayHello);

    // lowercase y uppercase
    Console.WriteLine(sayHello.ToUpper());
    Console.WriteLine(sayHello.ToLower());

    // buscar si una cadena contiene una subcadena
    string songLyrics = "You say goodbye, and I say hello";
    Console.WriteLine(songLyrics.Contains("goodbye")); // true
    Console.WriteLine(songLyrics.Contains("greetings")); // false

    // 🧪 6. Comparación
    string nick1 = "Kirito";
    string nick2 = "kirito";
    Console.WriteLine($"nick1 == nick2: {nick1 == nick2}");
    Console.WriteLine($"Equals con ignore case: {nick1.Equals(nick2, StringComparison.OrdinalIgnoreCase)}");

    // 🔄 7. Split y Join
    string csv = "manzana,banana,pera";
    string[] frutas = csv.Split(',');
    Console.WriteLine("Frutas separadas:");
    foreach (string fruta in frutas)
    {
      Console.WriteLine($" - {fruta}");
    }

    string reunidas = string.Join(" + ", frutas);
    Console.WriteLine($"Frutas reunidas: {reunidas}");

    // 📐 10. Verificación de cadena vacía o nula
    string vacia = "";
    string? nula = null;
    Console.WriteLine($"String vacía: {string.IsNullOrEmpty(vacia)}");
    Console.WriteLine($"String nula: {string.IsNullOrEmpty(nula)}");
    Console.WriteLine($"¿Nula o solo espacios?: {string.IsNullOrWhiteSpace("   ")}");

    Console.ReadKey();
  }
}
