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
      Machine machine = new Machine();

      //Act
      bool result = machine.DoTheWordsMatch("hello", "hello");

      //Assert
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void SplitSentenceToWords_ListsMatch_Equal()
    {
      //Arrange
      Machine machine = new Machine();
      List<string> check = new List<string> {"hello", "there"};


      // Act
      List<string> words = machine.SplitSentenceToWords("hello there");

      //Assert
      CollectionAssert.AreEqual(words, check);

      // Console.WriteLine("SplitSentenceToWords:");
      // foreach (string word in words)
      // {
      //   Console.WriteLine(word);
      // }
      // Console.WriteLine("--------------------");
      //
      // List<string> check = new List<string> {"hello", "there"};
      // Console.WriteLine("{\"hello\", \"there\"}");
      // foreach (string c in check)
      // {
      //   Console.WriteLine(c);
      // }
    }
    [TestMethod]
    public void IsThereAMatch_DoTheWordsMatch_True()
    {
      //Arrange
      Machine machine = new Machine();

      // Act
      bool answer = machine.IsThereAMatch("there", machine.SplitSentenceToWords("hello there"));

      //Assert
      Assert.AreEqual(true, answer);
    }

    [TestMethod]
    public void WordCount_HowManyMatchingWordsAreThere_2()
    {
      //Arrange
      Machine machine = new Machine();

      // Act
      int answer = machine.WordCount("there", "therer there hello there");

      //Assert
      Assert.AreEqual(2, answer);
    }
  }
}
