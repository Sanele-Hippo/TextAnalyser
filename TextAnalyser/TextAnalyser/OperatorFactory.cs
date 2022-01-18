using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyser.Operators;

namespace TextAnalyser
{
  public class OperatorFactory
  {
     public static IOperator Create(int operatorId)
    {
      return operatorId switch
      {
        1 => new DuplicateOperator(),
        2 => new VowelCountOperator(),
        3 => new VowelMatchOperator(),
        _ => throw new NotImplementedException($"Operator id {operatorId} has not been implimented yet.")
      };
    }
  }
}
