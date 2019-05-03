using System;
using System.Collections.Generic;

namespace WordCount.Models
{
  public class Machine
  {
    private string _word;
    private string _sentence;
    // private string _matchWord;

    public Machine (string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
      // _matchWord = matchWord;
    }

    public string GetWord()
    {
      return _word;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    // public string GetMatchWord()
    // {
    //   return _matchWord;
    // }

    // public string Word {get => _word; set => _word = value;}
    // public string Sentence {get => _sentence; set => _sentence = value;}

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

    public bool IsThereAMatch(string matchWord, List<string> wordList)
    {

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
