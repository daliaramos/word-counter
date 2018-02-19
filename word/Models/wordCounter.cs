using System;
using System.Collections.Generic;

namespace word.Models
{
  public class wordCounter
  {
    private string _word;
    private string _sentence;

    public wordCounter(string word, string sentence)
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

    public int addWord()
    {
      int _counter = 0;
      string singleWord = _word.ToLower();
      string sentenceString = _sentence.ToLower();
        string[] Input = sentenceString.Split(' ');
        foreach (string word in Input)
        {
          if(word == singleWord.ToLower())
          {
            _counter++;
          }
        }
      return _counter;
    }
  }
}
