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
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("test");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void ValueToMatch_WhatIsTheValueOfALetter_Number()
    {
      //Arrange
      Word newWord = new Word("b");

      //Act
      int result = newWord.ValueToMatch("b");

      //Assert
      Assert.AreEqual(2, result);
    }
      [TestMethod]

      public void ValueToMatch_WhatIsTheValueOfALetterS_Number()
      {
        //Arrange
        Word newWord = new Word("apple");

        //Act
        int result = newWord.ValueToMatch("apple");

        //Assert
        Assert.AreEqual(8, result);
    }
  }
}
