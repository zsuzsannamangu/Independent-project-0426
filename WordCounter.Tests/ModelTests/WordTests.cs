using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCount.Models;

namespace WordCount.Tests
{
  [TestClass]
  public class WordCountTest
  {

    [TestMethod]
    public void IsThereAMatch_WordsThatMatch_True()
    {
      //Arrange
      Word newWord = new Word("test");

      //Act
      bool result = newWord.IsThereAMatch("you", "you");

      //Assert
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void SplitsSentenceToWords_WordsThatMatch_True()
    {
      //Arrange
      Word newWord = new Word("test");

      //Act
      bool result = newWord.SplitsSentenceToWords("you", "how are you");

      //Assert
      Assert.AreEqual(true, result);
    }
      // [TestMethod]
      //
      // public void ValueToMatch_WhatIsTheValueOfALetterS_Number()
      // {
      //   //Arrange
      //   Word newWord = new Word("apple");
      //
      //   //Act
      //   int result = newWord.ValueToMatch("apple");
      //
      //   //Assert
      //   Assert.AreEqual(8, result);

  }
}
