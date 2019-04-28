using System;
using System.Collections.Generic;

namespace WordCount.Models
{
  public class Machine
  {
    public bool DoTheWordsMatch(string word, string sentence)
    {
      if (word == sentence)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public List<string> SplitSentenceToWords(string sentence)
    {

      char[] sentenceArray = sentence.ToCharArray();
      List<string> wordList = new List<string> {};

      string word = "";
      foreach (char letter in sentenceArray)
      {
        if (letter == ' ')
        {
          wordList.Add(word);
          word = "";
        }
        else {
          word += letter;
        }
        // Console.WriteLine(word);
      }
      if (word != "")
      {
        wordList.Add(word);
      }
      return wordList;
    }

    public bool IsThereAMatch(string matchWord, string sentence)
    {

      List<string> wordList = SplitSentenceToWords(sentence);

      foreach (string word in wordList)
      {
        if (word == matchWord)
        {
          return true;
        }
      }
      return false;
    }

    public int WordCount(string matchWord, string sentence)
    {
      int total = 0;

      List<string> wordList = SplitSentenceToWords(sentence);

      foreach (string word in wordList)
      {
        if (word == matchWord)
        {
          total++;
        }
      }
      return total;
    }

  }
}
