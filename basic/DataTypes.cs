class DataTypes {
  int age = 21;
  string name = "kazuto";
  bool isActive = false;

  // 🧠 2. Palabras clave para declarar variables
  // var ->	Inferencia de tipo	| let/const con inferencia (TS)	| Uso: Cuando el tipo es obvio
  // dynamic ->	Tipo flexible en tiempo de ejecución	| any (TS) |	Para interoperabilidad o datos inciertos
  var surname = "kirigaya";

  // 🔒 3. Constantes en C#
  //   🔹 const
  // Valor constante en tiempo de compilación
  // No puede cambiar nunca
  // Debe ser inicializado en la declaración
  const dobule PI = 3.1416;

  // 🧊 4. Readonly: para valores constantes en tiempo de ejecución
  //   🔹 readonly
  // Valor establecido en el constructor o al declarar
  // Es constante después de la inicialización, pero puede depender de cálculos o parámetros
  public readonly Radio;
}
