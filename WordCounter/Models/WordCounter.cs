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
  
  // public class RepeatCounter
  // {
    public int GetScore()
    {
      string[] splitString = UserSentence.Split();
      int wordScore = 0;
      for(int i = 0; i < splitString.Length; i++)
      {
        foreach(string userWord in splitString)
        {
          if (UserWord.Contains(splitString[i]))
          {
            wordScore += 1;
          }
        }
      }
      return wordScore;
    }
  }
}