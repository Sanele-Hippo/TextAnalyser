using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyser.Extensions
{
  public static class StringExtension
  {
    public static string Clean(this string input)
    {
      return input.ToLower().Replace(" ", "");
    }
  }
}
