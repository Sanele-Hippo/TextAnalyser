using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyserCompositionAndInheritance.Extensions;

namespace TextAnalyserCompositionAndInheritance.TextOperators.Composition
{
  public class Vowel : IVowel
  {
    private static readonly List<char> _vowelChars = new() { 'a', 'e', 'i', 'o', 'u' };
    public int GetVowelsCount(string input)
    {
      int count = 0;
      foreach (var c in input.Clean().Distinct())
      {
        if (_vowelChars.Contains(c))
          count++;
      }
      return count;
    }
  }
}
