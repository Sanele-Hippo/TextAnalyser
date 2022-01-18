using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyser;

namespace TextAnalyserTest
{
  public class VowelCountOperatorTest
  {
    private readonly int _countOperatorId = 2;

    [SetUp]
    public void SetUp() { }

    [TearDown]
    public void TearDown() { }

    [TestCase("I like eating apples", "The number of vowels is 3")]
    [TestCase("I'm", "The number of vowels is 1")]
    [TestCase("Hmm", "No vowels were found")]
    [TestCase("", "No vowels were found")]
    public void Test_CountOperator_Should_Return_Success(string input, string result)
    {
      //Arrange
      var op = OperatorFactory.Create(_countOperatorId);

      //Act
      var response = op.ExecuteOperation(input);

      //Assert
      Assert.AreEqual(response, result);
    }
  }
}
