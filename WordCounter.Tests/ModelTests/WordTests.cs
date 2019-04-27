using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCount.Models;

namespace WordCount.Tests
{
  [TestClass]
  public class WordCountTest
  {

    // [TestMethod]
    // public void DoTheWordsMatch_WordsThatMatch_True()
    // {
    //   //Arrange
    //   Word newWord = new Word("test", "test");
    //
    //   //Act
    //   bool result = newWord.DoTheWordsMatch("you", "you");
    //
    //   //Assert
    //   Assert.AreEqual(true, result);
    // }

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
    public void SplitSentenceToWords_ListsMatch_True()
    {
      //Arrange
      Machine machine = new Machine();
      List<string> check = new List<string> {"hello", "there"};


      // Act
      List<string> words = machine.SplitSentenceToWords("hello there");

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


      //Assert
      CollectionAssert.AreEqual(words, check);
    }
  }
}
