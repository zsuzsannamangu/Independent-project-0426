using System;
using System.Collections.Generic;

namespace WordCount.Models
{
  public class Word
  {
    private string _word;
    private string _sentence;
    // private static List<Word> _instances = new List<Word> {};

    public Word (string word)
    {
      _word = word;
      _sentence = sentence;
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

    // public static List<Word> GetAll()
    // {
    //   return _instances;
    // }
    //
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

    public string SplitSentenceToWords(string word, string sentence)
    {
      string words = "";
      //split sentence into characters, an array of characters are made
      //sentence is "how are you"
      char[] sentenceArray = sentence.ToCharArray();
      //create an empty array/list for the words to go into
      List<string> wordList = new List<string> {};
      //how, are, you
      //characters of sentence needs to rejoin into words before spaces then go into wordList if they equal to THE WORD
      foreach (char letter in sentenceArray)
        {
          // how, are, you = w
          if (letter != ' ')
          {
            // word = ho + w so that will be word = how
            words += letter;
            // word = String.Join("", letter)
          }
          // now the next letter is space, so the word "how" is going to the list(array) called wordList
          else {
            wordList.Add(words);
            string word = "";
          }
        }
        return wordList;
        //how, are, you
    }

    public bool IsThereAMatch(string word, string sentence)
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
  }
}
