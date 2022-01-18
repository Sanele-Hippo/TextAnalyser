using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyser.Operators
{
  public class VowelCountOperator : VowelBase, IOperator
  {
    public string ExecuteOperation(string input)
    {
      var vowelCount = base.GetVowelCount(input);
      return vowelCount == 0 ? "No vowels were found" : $"The number of vowels is {vowelCount}";
    }
  }
}
