using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyserCompositionAndInheritance.TextOperators.Composition;
using TextAnalyserCompositionAndInheritance.TextOperators.Inheritance;

namespace TextAnalyserCompositionAndInheritance.TextOperators
{
  /// <summary>
  /// count operator - relationship inheritance (is a baseOperator) its closed for modification
  /// count operator - relationship composition (has a vowel)
  /// </summary>
  public class CountOperator : BaseOperator
  {
    private readonly IVowel _vowel;
    public CountOperator(IVowel vowel)
    {
      _vowel = vowel;
    }
    public override string ExecuteOperation(string input)
    {
      var vowelCount = _vowel.GetVowelsCount(input);
      return vowelCount == 0 ? "No vowels were found" : $"The number of vowels is {vowelCount}";
    }
  }
}
