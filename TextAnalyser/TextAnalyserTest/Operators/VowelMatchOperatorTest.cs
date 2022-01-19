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
  public class VowelMatchOperatorTest
  {
    private readonly int _matchOperatorId = 3;

    [SetUp]
    public void SetUp() { }

    [TearDown]
    public void TearDown() { }

    [TestCase("I eat", "The text has more vowels than non vowels")]
    [TestCase("that dog", "The text has more non vowels than vowels")]
    [TestCase("3 a", "The text has an equal amount of vowels and non vowels")]
    [TestCase("", "The text has an equal amount of vowels and non vowels")]
    public void Test_TextAnalyser_VowelMatchOperator_Should_Return_Success(string input, string result)
    {
      //Arrange
      var op = OperatorFactory.Create(_matchOperatorId);

      //Act
      var response = op.ExecuteOperation(input);

      //Assert
      Assert.AreEqual(response, result);
    }

    [TestCase("I eat", "The text has more vowels than non vowels")]
    [TestCase("that dog", "The text has more non vowels than vowels")]
    [TestCase("3 a", "The text has an equal amount of vowels and non vowels")]
    [TestCase("", "The text has an equal amount of vowels and non vowels")]
    public void Test_TextAnalyserCompositionAndInheritance_VowelMatchOperator_Should_Return_Success(string input, string result)
    {
      //Arrange
      var _operatorFactory = new TextAnalyserCompositionAndInheritance.OperatorFactory(new Vowel());
      var op = _operatorFactory.Create(_matchOperatorId);

      //Act
      var response = op.ExecuteOperation(input);

      //Assert
      Assert.AreEqual(response, result);
    }
  }
}
