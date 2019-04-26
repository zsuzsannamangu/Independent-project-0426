using System;
using System.Collections.Generic;

namespace WordCount.Models
{
  public class Word
  {
    private string _word;
    public List<string> _sentence = new List<string> {};

    public Word (string word)
    {
      _word = word;
      _sentence = sentence;
    }

    public string GetWord()
    {
      return _word;
    }

    public string SplitSentenceToWords(string sentence)
    {
      string word = "";
      charList = sentence.
      List<string> charList = new List<string> {};
    }






    public string IsThereAMatch(string word, string sentence)
    {
      char [] sentenceArray = sentence.ToCharArray();

      int total = 0;

      foreach (char letter in sentenceArray)
      //whatever is at the first place: what are we looking for? what do we want to do something to?
      //whatever is at the second place: where is that first thing located at?
      {
        if (_instances.ContainsKey(Word))
        {
          total = total + _instances[letter];
        }
      }
      return total;
    }
  }
}
