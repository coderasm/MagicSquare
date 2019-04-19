using System;

namespace MagicSquare
{
  class Program
  {
    static void Main(string[] args)
    {
      MagicSquare.Create(3).print();
      Console.WriteLine();
      MagicSquare.Create(5).print();
      Console.WriteLine();
      MagicSquare.Create(7).print();
      Console.ReadKey();
    }
  }
}
