using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyser;
using TextAnalyserCompositionAndInheritance.TextOperators.Composition;

namespace TextAnalyserTest
{
  public class DuplicateOperatorTest
  {
    private readonly int _duplicateOperatorId = 1;  

    [SetUp]
    public void SetUp() { }

    [TearDown]
    public void TearDown() { }

    [TestCase("I like eating apples", "Found the following duplicates: ileap")]
    [TestCase("ApPles", "Found the following duplicates: p")]
    [TestCase("abcd4", "No duplicate values were found")]
    [TestCase("", "No duplicate values were found")]
    public void Test_TextAnalyser_DuplicateOperator_Should_Return_Success(string input, string result)
    {
      //Arrange
      var op = OperatorFactory.Create(_duplicateOperatorId);

      //Act
      var response = op.ExecuteOperation(input);

      //Assert
      Assert.AreEqual(response, result);
    }

    [TestCase("I like eating apples", "Found the following duplicates: ileap")]
    [TestCase("ApPles", "Found the following duplicates: p")]
    [TestCase("abcd4", "No duplicate values were found")]
    [TestCase("", "No duplicate values were found")]
    public void Test_TextAnalyserCompositionAndInheritance_DuplicateOperator_Should_Return_Success(string input, string result)
    {
      //Arrange
      var _operatorFactory = new TextAnalyserCompositionAndInheritance.OperatorFactory(new Vowel());
      var op = _operatorFactory.Create(_duplicateOperatorId); 

      //Act
      var response = op.ExecuteOperation(input);

      //Assert
      Assert.AreEqual(response, result);
    }
  }
}
