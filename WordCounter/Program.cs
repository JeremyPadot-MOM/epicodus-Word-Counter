using System;
using Counter.Models;
using System.Collections.Generic;

namespace Counter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a word, followed by a sentence containing that word and I'll tell you how many times it appears.");
      string response = Console.ReadLine();
      UserInput newResponse = new UserInput(response, response);
// will GetScore actually be my RepeatCounter? Try when using RepeatCounter logic
// GetScore is a placeholder for now?
      int score = newResponse.GetScore();
      Console.WriteLine("your word appeared " + score + " times.");
    }
  }
}