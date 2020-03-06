using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Counter.Models;
using System;

namespace Counter.Tests
{
  [TestClass]
  // change class name?
  public class MakeFilesTests
  {
    [TestMethod]
    public void InputConstructor_CreatesInstanceOfUserInput_UserInput()
    {
      // arrange
      string userWord = "cat";
      string userSentence = "Today I need to buy cat food for my cat so my cat can eat something";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      // act
      // assert
      Assert.AreEqual(typeof(UserInput), newUserInput.GetType());
    }
    [TestMethod]
    public void GetScore_CalculateWordScore_Int()
    {
      // arrange
      string userWord = "cat";
      string userSentence = "Today I need to buy cat food for my cat so my cat can eat something";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      // act
      int score = newUserInput.GetScore();
      // assert
      Assert.AreEqual(3, score);
    }
    [TestMethod]
    public void GetScore_ExcludeWordsWithSameCharacters_Int()
    {
      //arrange
      string userWord = "cat";
      string userSentence = "Today I'm taking my cat to the cathedral";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      //act
      int score = newUserInput.GetScore();
      //assert
      Assert.AreEqual(1, score);
    }
    [TestMethod]
    public void GetWordScore_CalculateWordScore_Int()
    {
    //arrange
    string userWord = "dog";
    string userSentence = "I'd like to take my dog to the dogpark to meet other dogs";
    UserInput newUserInput = new UserInput(userWord, userSentence);
    //act
    int score = newUserInput.GetScore();
    //assert
    Assert.AreEqual(1, score);
    }
    [TestMethod]
    public void GetScore_GetErrorMessage_Int()
    {
      //arrange
      string userWord ="";
      string userSentence = "";
      Userinput newUserInput = new UserInput(userWord, userSentence);
      //act
      int score = newUserInput.GetScore();
      //arrange
      Assert.AreEqual();
    }
  }
}