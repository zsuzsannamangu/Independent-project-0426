using System;
using System.Collections.Generic;

namespace WordCount.Models
{
  public class Word
  {
    private string _word;
    public List<string> _sentence = new List<string> {};

    public Word (string word, string sentence)
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
      //split sentence into characters
      char[] sentenceArray = sentence.ToCharArray();
      //create an empty array/list for the words to go into
      List<string> wordList = new List<string> {};
      //characters of sentence needs to rejoin into words before spaces then go into wordList if they equal to THE WORD
      foreach (char letter in sentenceArray)
        {
          // how, are, you = w
          if (letter != ' ')
          {
            // word = ho + w so that will be word = how
            word = word + letter;
            word = String.Join("", letter)
          }
          // now the next letter is space, so the word "how" is going to the list(array) called wordList
          else {
            wordList.Add(word);
            string word = "";
          }
        }
        return wordList;
    }

    // public string IsThereAMatch(string word, string sentence)
    // {
    //   char [] sentenceArray = sentence.ToCharArray();
    //
    //   int total = 0;
    //
    //   foreach (char letter in sentenceArray)
    //   //whatever is at the first place: what are we looking for? what do we want to do something to?
    //   //whatever is at the second place: where is that first thing located at?
    //   {
    //     if (_instances.ContainsKey(Word))
    //     {
    //       total = total + _instances[letter];
    //     }
    //   }
    //   return total;
    // }
  }
}
