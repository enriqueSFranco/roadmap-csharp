class ArithmeticOperators
{
  static void main(string[] args)
  {
    Console.WriteLine("🧮 Operadores en C#\n");
    Console.WriteLine("🔢 Aritméticos");
    Console.WriteLine($"Suma: {a + b}");
    Console.WriteLine($"Resta: {a - b}");
    Console.WriteLine($"Multiplicación: {a * b}");
    Console.WriteLine($"División: {a / b}");         // División entera
    Console.WriteLine($"Módulo (resto): {a % b}");
    Console.WriteLine($"Incremento (++a): {++a}");
    Console.WriteLine($"Decremento (--b): {--b}\n");


    // 📝 2. Operadores de Asignación
    int x = 5;
    Console.WriteLine("📝 Asignación");
    x += 3;  // x = x + 3
    Console.WriteLine($"x += 3: {x}");
    x -= 2;
    Console.WriteLine($"x -= 2: {x}");
    x *= 4;
    Console.WriteLine($"x *= 4: {x}");
    x /= 3;
    Console.WriteLine($"x /= 3: {x}");
    x %= 5;
    Console.WriteLine($"x %= 5: {x}\n");

    // 🔍 3. Operadores de Comparación (Relacionales)
    int m = 7, n = 9;
    Console.WriteLine("🔍 Comparación");
    Console.WriteLine($"m == n: {m == n}");
    Console.WriteLine($"m != n: {m != n}");
    Console.WriteLine($"m > n: {m > n}");
    Console.WriteLine($"m < n: {m < n}");
    Console.WriteLine($"m >= n: {m >= n}");
    Console.WriteLine($"m <= n: {m <= n}\n");

    // ⚙️ 4. Operadores Lógicos
    bool p = true;
    bool q = false;
    Console.WriteLine("⚙️ Lógicos");
    Console.WriteLine($"p && q (AND): {p && q}");
    Console.WriteLine($"p || q (OR): {p || q}");
    Console.WriteLine($"!p (NOT): {!p}\n");


    // 🧠 5. Operadores Bit a Bit (Bitwise)
    int bit1 = 5;   // 0101
    int bit2 = 3;   // 0011
    Console.WriteLine("🧠 Bitwise");
    Console.WriteLine($"bit1 & bit2: {bit1 & bit2}"); // 0001 = 1
    Console.WriteLine($"bit1 | bit2: {bit1 | bit2}"); // 0111 = 7
    Console.WriteLine($"bit1 ^ bit2: {bit1 ^ bit2}"); // 0110 = 6
    Console.WriteLine($"~bit1: {~bit1}");             // Inverso de bits
    Console.WriteLine($"bit1 << 1: {bit1 << 1}");     // Desplazamiento a la izquierda
    Console.WriteLine($"bit1 >> 1: {bit1 >> 1}\n");   // Desplazamiento a la derecha

    // 🎯 6. Operador Ternario
    int score = 85;
    string result = (score >= 60) ? "Aprobado" : "Reprobado";
    Console.WriteLine("🎯 Ternario");
    Console.WriteLine($"Resultado: {result}\n");

    // 🧩 7. Otros Operadores Útiles
    object obj = "Hola mundo";
    Console.WriteLine("🧩 Otros");
    Console.WriteLine($"obj is string: {obj is string}"); // Verifica tipo
    Console.WriteLine($"typeof(int): {typeof(int)}");     // Muestra tipo
    string? nullableString = null;
    Console.WriteLine($"nullableString ?? 'Vacío': {nullableString ?? "Vacío"}"); // Null-coalescing
    Console.WriteLine($"nullableString?.Length: {nullableString?.Length}\n");     // Null-conditional

    Console.ReadKey();
  }
}
