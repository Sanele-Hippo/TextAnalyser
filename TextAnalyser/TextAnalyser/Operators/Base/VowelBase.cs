using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyser.Operators
{
  public abstract class VowelBase
  {
    private readonly string[] vowelChars = new[] { "a", "e", "i", "o", "u" };

    public virtual int GetVowelCount(string input)
    {
      return 0;
    }
  }
}
