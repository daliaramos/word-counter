using System;
using System.Collections.Generic;

namespace wordCounter.Models
{
  public class wordCounter
  {
    private string _words;
    private int _totalWords = 0;

    public string GetWords()
    {
      return _words;
    }

    public int GetTotalWords()
    {
      return _totalWords;
    }

     public wordCounter(string words)
     {
       _words = words;
     }
 //
 //     public void addWords()
 //     {
 //    // Create a string array and store the contents of the Lines property.
 //    string[] stringArray= GetWord();
 //
 //    // Loop through the array and send the contents of the array to debug window.
 //    for(int i=0; counter < stringArray.Length; i++)
 //    {
 //       System.Diagnostics.Debug.WriteLine(stringArray[i]);
 //    }
 // }

  }
}
