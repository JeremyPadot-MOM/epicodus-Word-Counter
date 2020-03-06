using System;
using System.Collections.Generic;

namespace Counter.Models
{
  public class Word
  {
    public string UserWord {get; set;}
    public List<string> UserSentence = new List<string> {};
    public void UserInput(string userWord, List<string> userSentence)
    {
      UserWord = userWord;
      UserSentence = userSentence;
      
    }
  }
  public class RepeatCounter
  {
    public int GetScore()
    {
      int score = 0;
      return score;
    }
  }
}