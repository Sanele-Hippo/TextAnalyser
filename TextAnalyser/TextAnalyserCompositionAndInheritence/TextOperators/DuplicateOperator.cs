using System.Linq;
using TextAnalyserCompositionAndInheritance.Extensions;
using TextAnalyserCompositionAndInheritance.TextOperators.Inheritance;

namespace TextAnalyserCompositionAndInheritance.TextOperators
{

  /// <summary>
  /// duplicate operator - relationship inheritance (is a baseOperator) its closed for modification
  /// duplicate operator - does not have vowel
  /// </summary>
  public class DuplicateOperator : BaseOperator
  {
    public override string ExecuteOperation(string input)
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
