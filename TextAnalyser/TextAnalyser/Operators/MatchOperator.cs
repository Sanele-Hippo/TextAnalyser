using TextAnalyser.Extensions;
using TextAnalyser.Helpers;

namespace TextAnalyser.Operators
{
  public class MatchOperator : IOperator
  {
    public string ExecuteOperation(string input)
    {
      var vowelCount = VowelsHelper.GetVowelsCount(input);
      var nonVowels = input.Clean().Length - vowelCount;

      if (vowelCount == nonVowels)
        return "The text has an equal amount of vowels and non vowels";

      return nonVowels > vowelCount ? "The text has more non vowels than vowels" : "The text has more vowels than non vowels";
    }
   }
}
