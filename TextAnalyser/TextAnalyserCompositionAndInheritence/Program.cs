using System;
using TextAnalyserCompositionAndInheritance.TextOperators.Composition;

namespace TextAnalyserCompositionAndInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter text to be analysed");
      var text = Console.ReadLine();

      Console.WriteLine("Enter which operator to do on the supplied text");
      var operations = Console.ReadLine();

      var operatorFactory = new OperatorFactory(new Vowel());
      foreach (var operation in operations)
      {
        var op = operatorFactory.Create(Convert.ToInt16(operation.ToString()));
        Console.WriteLine(op.ExecuteOperation(text));
      }

      Console.ReadLine();
    }
  }
}
