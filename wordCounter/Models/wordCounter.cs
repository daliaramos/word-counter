using System;
using System.Collections.Generic;

namespace wordCounter.Models
{
  public class wordCounter
  {
    private string _words;
    private string _sentence;
    private int _count = 0;

    public wordCounter(string words, string sentence, int count)
    {
      _words = words;
      _sentence = sentence;
      _count = count;
    }

    public string GetWords()
    {
      return _words;
    }

    public void SetWords(string words)
    {
      _words = words;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public void SetSentence(string sentence)
    {
      _sentence = sentence;
    }

    public void SetCount(int count)
    {
      _count = count;
    }

    public int GetCount()
    {
      return _count;
    }

   public int addWords(string word, string sentence)
     {
       int count = 0;

       sentence = sentence.ToLower();
       word = word.ToLower();

       if(sentence == word)
         return 1;

       string[] wordArray = sentence.Split(' ');

       for(int i = 0; i < wordArray.Length; i++)
       {
         if(wordArray[i] == word)
           count++;
       }

       return count;
     }
   }
}
