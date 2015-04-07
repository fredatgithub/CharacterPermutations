using System;

namespace PermutationCalculator
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Please type in some characters to get all the permutations possible:");
      string inputString = Console.ReadLine();
      PermutationCalculator permutationCalculator = new PermutationCalculator();
      var result = permutationCalculator.Calculate(inputString.ToCharArray());
      Console.WriteLine("Total items:" + result.Count);
      foreach (var item in result)
      {
        Console.WriteLine(item);
      }

      Console.ReadKey();
    }
  }
}