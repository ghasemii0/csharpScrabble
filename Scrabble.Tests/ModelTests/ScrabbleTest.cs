using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System.Collections.Generic;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void ScrabbleConstructor_CreatesInstanceOfScrabble_True()
    {
      Words newScrabble = new Words();
      Assert.AreEqual(3, newScrabble.GetPoints('C'));
    }

    [TestMethod]
    public void CheckCharInWord_ShowCorrectCharacter_True()
    {
      Words newScrabble = new Words();
      char[] testArray = {'f','a','c','e'};
      char[] result = newScrabble.CharOfWord("face");
      CollectionAssert.AreEqual(testArray, result);
    }

    [TestMethod]
    public void SumTheWord_AddAllChars_Int()
    {
      Words newScrabble = new Words();
      // char[] string = "face";
      int result = newScrabble.SumTheWord("face");
      Assert.AreEqual(9, result);
    }

  }
}
