class Methods {
  static void Main(string[] args) {
    Console.WriteLine("Clase de Métodos");

    Console.WriteLine(Sum(10, 5));
    Console.WriteLine(Sum(10, 5, 20));
    Console.WriteLine(Sum(10, 5)); // llama al metodo Sum(int a, int b) y NO al metodo Sum(int a, double b, double c = 0.5)
  }

  static int Sum(int a, int b) => a + b;

  // sobrecarga de métodos
  static int Sum(int a, int b, int c) => a + b +c;

  // parametros por defecto
  private static double Sum(int a, double b, double c = 0.5) => a + b +c;
}
