using System;
using System.Collections.Generic;

namespace WordCount.Models
{
  public class Word
  {
    private string _word;
    private string _sentence;
    // private string _words;
    // private static List<Word> _instances = new List<Word> {};

    public Word (string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
      // _words = words;
      // _instances.Add(this);
    }

    public string GetWord()
    {
      return _word;
    }

    public string GetSentence()
    {
      return _sentence;
    }
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
    // public bool DoTheWordsMatch(string word, string sentence)
    // {
    //   if (word == sentence)
    //   {
    //     return true;
    //   }
    //   else
    //   {
    //     return false;
    //   }
    // }

    public List<string> SplitSentenceToWords(string word, string sentence)
    {

      string words = "";
      char[] sentenceArray = sentence.ToCharArray();
      List<string> wordList = new List<string> {};

      foreach (char letter in sentenceArray)
      {
        if (letter != ' ')
        {
          // words += letter;
          words = String.Join("", letter);
        }
        else {
          wordList.Add(words);
        }
      }
      return wordList;
    }

    public bool IsThereAMatch(string word, string sentence)
    {
      // int total = 0;

      foreach (string words in wordList)
      {
        if (word == words)
        {
          return true;
          // return total++;
        }
      }
      return false;
      // return total;
    }

    // int total = IsThereAMatch(SplitSentenceToWords(sentence, word));
  }
}
