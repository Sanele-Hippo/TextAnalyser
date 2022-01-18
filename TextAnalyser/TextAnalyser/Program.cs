using System;

namespace TextAnalyser
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter text to be analysed");
      var text = Console.ReadLine();

      Console.WriteLine("Enter which operator to do on the supplied text");
      var operations = Console.ReadLine();

      Console.WriteLine(text + operations);
    }
  }
}
