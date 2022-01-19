using System;
using TextAnalyserCompositionAndInheritance.TextOperators;
using TextAnalyserCompositionAndInheritance.TextOperators.Composition;
using TextAnalyserCompositionAndInheritance.TextOperators.Inheritance;

namespace TextAnalyserCompositionAndInheritance
{
  public class OperatorFactory
  {
    private readonly IVowel _vowel;
    public OperatorFactory(IVowel vowel)
    {
      _vowel = vowel;
    }
    public BaseOperator Create(int operatorId)
    {
      return operatorId switch
      {
        1 => new DuplicateOperator(),
        2 => new CountOperator(_vowel),
        3 => new MatchOperator(_vowel),
        _ => throw new NotImplementedException($"Operator id {operatorId} has not been implimented yet.")
      };
    }
  }
}
