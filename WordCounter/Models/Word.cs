using System;
using System.Collections.Generic;

namespace WordCount.Models
{
  public class Machine
  {
    // private string _word;
    // private string _sentence;
    // private string _words;
    // private static List<Word> _instances = new List<Word> {};

    // public Machine ()
    // {
    //   // _word = word;
    //   // _sentence = sentence;
    //   // _words = words;
    //   // _instances.Add(this);
    // }

    // public string GetWord()
    // {
    //   return _word;
    // }
    //
    // public string GetSentence()
    // {
    //   return _sentence;
    // }
    // public string GetWords()
    // {
    //   return _words;
    // }

    // public static List<Word> GetAll()
    // {
    //   return _instances;
    // }
    //
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
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
      // int total = 0;

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
