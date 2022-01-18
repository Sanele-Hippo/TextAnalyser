using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyser.Extensions;

namespace TextAnalyser.Operators
{
  public class DuplicateOperator : IOperator
  {
    public string ExecuteOperation(string input)
    {
      var duplicates = GetDuplicates(input.Clean());
      return string.IsNullOrWhiteSpace(duplicates) ? "No duplicate values were found" : $"Found the following duplicates: {duplicates}";
    }

    private static string GetDuplicates(string input)
    {
      return string.Join("", input.GroupBy(s => s).Where(c => c.Count() > 1).Select(g => g.Key));
    }
  }
}
