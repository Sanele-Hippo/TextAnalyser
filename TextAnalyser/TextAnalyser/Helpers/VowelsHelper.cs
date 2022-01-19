using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyser.Extensions;

namespace TextAnalyser.Helpers
{
  public static class VowelsHelper
  {
    private static readonly List<char> _vowelChars = new() { 'a', 'e', 'i', 'o', 'u' };
    public static int GetVowelsCount(string input)
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
