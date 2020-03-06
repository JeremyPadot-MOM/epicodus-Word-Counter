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
    // [TestMethod]
    // public void GetWordScore_CalculateWordScore_Int()
    // {
    //   // arrange
    //   string userWord = "cat";
    //   string userSentence = ""
    //   // act

    //   // assert

    // }
  }
}