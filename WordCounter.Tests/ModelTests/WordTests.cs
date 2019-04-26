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
    public void DoTheWordsMatch_WordsThatMatch_True()
    {
      //Arrange
      Word newWord = new Word("test", "test");

      //Act
      bool result = newWord.DoTheWordsMatch("you", "you");

      //Assert
      Assert.AreEqual(true, result);
    }

    // [TestMethod]
    // public void SplitsSentenceToWords_WordsThatMatch_True()
    // {
    //   //Arrange
    //   Word newWord = new Word("test", "test");
    //
    //   //Act
    //   bool result = newWord.SplitsSentenceToWords("you", "how are you");
    //
    //   //Assert
    //   Assert.AreEqual(true, result);
    // }

    [TestMethod]
    public void IsThereAMatch_WordsThatMatch_True()
    {
      //Arrange
      Word newWord = new Word("test", "test");

      //Act
      bool result = newWord.IsThereAMatch("you", "how are you");

      //Assert
      Assert.AreEqual(true, result);
    }
  }
}
