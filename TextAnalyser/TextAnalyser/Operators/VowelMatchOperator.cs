using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyser.Extensions;

namespace TextAnalyser.Operators
{
  public class VowelMatchOperator : VowelBase, IOperator
  {
    public string ExecuteOperation(string input)
    {
      var vowelCount = base.GetVowelCount(input);
      var nonVowels = input.Clean().Length - vowelCount;

      if (vowelCount == nonVowels)
        return "The text has an equal amount of vowels and non vowels";

      return nonVowels > vowelCount ? "The text has more non vowels than vowels" : "The text has more vowels than non vowels";
    }
   }
}
