using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyser
{
  public interface IOperator
  {
    string ExecuteOperation(string input);
  }
}
