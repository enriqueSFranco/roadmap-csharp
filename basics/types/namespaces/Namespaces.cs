using Postres; // Instancio el namespace de Postres

namespace RoadmapCSharp.Basics.Types
{
  class Program
  {
    static void Main(string[] args)
    {
      MisPostres mp = new MisPostres();
      mp.Test();
    }
  }
}
