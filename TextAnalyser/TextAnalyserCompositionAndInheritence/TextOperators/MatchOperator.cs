using TextAnalyserCompositionAndInheritance.Extensions;
using TextAnalyserCompositionAndInheritance.TextOperators.Composition;
using TextAnalyserCompositionAndInheritance.TextOperators.Inheritance;

namespace TextAnalyserCompositionAndInheritance.TextOperators
{
  /// <summary>
  /// match operator - relationship inheritance (is a baseOperator) its closed for modification
  /// match operator - relationship composition (has a vowel) 
  /// </summary>
  public class MatchOperator : BaseOperator
  {
    private readonly IVowel _vowel;
    public MatchOperator(IVowel vowel)
    {
      _vowel = vowel;
    }
    public override string ExecuteOperation(string input)
    {
      var vowelCount = _vowel.GetVowelsCount(input);
      var nonVowels = input.Clean().Length - vowelCount;

      if (vowelCount == nonVowels)
        return "The text has an equal amount of vowels and non vowels";

      return nonVowels > vowelCount ? "The text has more non vowels than vowels" : "The text has more vowels than non vowels";
    }
  }
}
