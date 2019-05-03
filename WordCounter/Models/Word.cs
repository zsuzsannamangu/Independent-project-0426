using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Models
{
  public class Machine
  {
    private string _word;
    private string _sentence;

    public Machine (string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public string GetWord()
    {
      return _word;
    }

    public string GetSentence()
    {
      return _sentence;
    }

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
