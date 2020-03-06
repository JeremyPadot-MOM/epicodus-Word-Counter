using System;
using System.Collections.Generic;

namespace Counter.Models
{
  public class UserInput
  {
    public string UserWord {get; set;}
    public string UserSentence {get; set;}
    // public List<string> UserSentence = new List<string> {};
    // public void UserInput(string userWord, List<string> userSentence)
    public UserInput(string userWord, string UserSentence)
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