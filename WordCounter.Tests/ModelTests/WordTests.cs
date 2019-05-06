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
    public void IsValidChar_a_True_space_True()
    {
      //Arrange
      Machine machine = new Machine("a","a");

      //Assert
      Assert.AreEqual(true, machine.IsValidChar('a'));
      Assert.AreEqual(true, machine.IsValidChar('1'));
      Assert.AreEqual(true, machine.IsValidChar('A'));
      Assert.AreEqual(false, machine.IsValidChar(';'));
    }

    [TestMethod]
    public void DoTheWordsMatch_WordsThatMatch_True()
    {
      //Arrange
      Machine machine = new Machine("a","a");

      //Act
      bool result = machine.DoTheWordsMatch("hello", "hello");

      //Assert
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void SplitSentenceToWords_ListsMatch_Equal()
    {
      //Arrange
      Machine machine = new Machine("a","a");
      List<string> check = new List<string> {"hello", "there"};


      // Act
      List<string> words = machine.SplitSentenceToWords("hello there");

      //Assert
      CollectionAssert.AreEqual(words, check);

    }
    [TestMethod]
    public void StripPunct_WordsMatch_Equal()
    {
      //Arrange
      Machine machine = new Machine("a","a");

      //Assert
      Assert.AreEqual("hello", machine.StripPunct("hello."));

    }
    [TestMethod]
    public void IsThereAMatch_DoTheWordsMatch_True()
    {
      //Arrange
      Machine machine = new Machine("a","a");

      // Act
      bool answer = machine.IsThereAMatch("there", machine.SplitSentenceToWords("hello there"));

      //Assert
      Assert.AreEqual(true, answer);
    }

    [TestMethod]
    public void WordCount_HowManyMatchingWordsAreThere_2()
    {
      //Arrange
      Machine machine = new Machine("a","a");

      // Act
      int answer = machine.WordCount("there", "therer there? hello there.");

      //Assert
      Assert.AreEqual(2, answer);
    }
  }
}
