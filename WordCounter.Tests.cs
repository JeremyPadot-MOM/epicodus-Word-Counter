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
      string userSentence = "cat cat cat";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      // List<string> list1 = new List<string> {"I love my cat"};
      // UserInput newUserInput = new UserInput(string1, list1);
      // act
      // assert
      Assert.AreEqual(userWord, userSentence);
    }
  }
}