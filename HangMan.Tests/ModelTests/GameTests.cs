using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HangMan.Models;

namespace HangMan.Tests
{
  [TestClass]
  public class GameTest
  {

    // public void Dispose()
    // {
    //     Game.ClearAll();
    // }

    [TestMethod]
    public void GameConstructor_CreateGameInstance_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GetGameWord_SetWordForGame_String()
    {
      Game newGame = new Game();
      string gameWord = newGame.GetGameWord();
      bool doesContain = false;
      List<string> _wordPool = new List<string> {"tamagotchi", "string", "bootygame", "vaporwave", "cheese", "robot", "bobby", "godzilla", "queen", "crispy", "alligator"};

      for(int i = 0; i < _wordPool.Count; i ++)
      {
        if(gameWord == _wordPool[i])
        {
          doesContain = true;
        }
      }
      Console.WriteLine(gameWord);
      Assert.AreEqual(true, doesContain);
    }

    [TestMethod]
    public void BuildWordBlanks_MakeACharArrayOfWordBlanks_CharArray()
    {
      Game newGame = new Game();
      // char[] gameWordArray = newGame.GameWord;
      // char[] testArray = {'h', 'a', 'p', 'p', 'y'};
      char[] blanksArray = newGame.BuildWordBlanks();
      char testChar = '_';
      Assert.AreEqual(testChar, blanksArray[3]);
    }
//Test works with static input
    // [TestMethod]
    // public void UpdateBlanks_CompareUserCharToGameWordAndUpdateBlanks_CharArray()
    // {
    //   Game newGame = new Game();
    //   char userChar = 'a';
    //   char[] testArray = {'h', 'a', 'p', 'p', 'y'};
    //   char[] testBlanks = {'_', 'a', '_', '_', '_'};
    //   char[] result = newGame.UpdateBlanks(userChar, testArray);
    //
    //   Assert.AreEqual(userChar, result[1]);
    // }

    //Test Worked before we switched to random word generation
    // [TestMethod]
    // public void DoesContainChar_CheckGameWordArrayForUserChar_True()
    // {
    //   Game newGame = new Game();
    //   // newGame.GameWord = {'b', 'c', 'a'};
    //   char testChar = 'a';
    //   bool testBool = newGame.DoesContainChar(testChar);
    //
    //   Assert.AreEqual(true, testBool);
    // }


  }
}
