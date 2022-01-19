using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyser.Helpers;

namespace TextAnalyser.Operators
{
  public class CountOperator : IOperator
  {
    public string ExecuteOperation(string input)
    {
      var vowelCount = VowelsHelper.GetVowelsCount(input);
      return vowelCount == 0 ? "No vowels were found" : $"The number of vowels is {vowelCount}";
    }
  }
}
