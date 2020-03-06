using System;
using System.Collections.Generic;

namespace Counter.Models
{
  public class UserInput
  {
    public string UserWord {get; set;}
    public string UserSentence {get; set;}
    
    public UserInput(string userWord, string userSentence)
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