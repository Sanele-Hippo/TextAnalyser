using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyser.Extensions;

namespace TextAnalyser.Operators
{
  public abstract class VowelBase
  {
    private readonly string[] _vowelChars = new[] { "a", "e", "i", "o", "u" };

    public virtual int GetVowelCount(string input)
    {
      int count = 0;
      foreach(var vowel in _vowelChars)
      {
        if (input.Clean().Contains(vowel))
          count++;
      }
      return count;
    }
  }
}
