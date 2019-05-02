using System.Collections.Generic;
using System;

namespace HangMan.Models
{
  public class Game
  {
    private List<string> _wordPool = new List<string> {"tamagotchi", "string", "bootygame", "vaporwave", "cheese", "robot", "bobby", "godzilla", "queen", "crispy", "alligator"};
    private char[] _gameWord;
    private char[] _wordBlank;
    private List<char> _lettersGuessed = new List<char> {};
    private int _numberOfGuesses = 0;
    private static List<Game> _instances = new List<Game> {};
    private int _id;

    public char[] GameWord{ get => _gameWord; set => _gameWord = value; }
    public char[] WordBlank{ get => _wordBlank; set => _wordBlank = value; }
    public List<char> LettersGuessed{ get => _lettersGuessed; set =>  _lettersGuessed = value;}
    public int NumberOfGuesses{ get; set; }

    public Game()
    {
      this.MakeCharArray();
      this.BuildWordBlanks();
      _instances.Add(this);
      _id = _instances.Count;

    }

    public string GetGameWord()
    {
      Random rand = new Random();
      // int count = _wordPool.Count;
      // string gameWord = _wordPool[rand.Next(count-1)];
      // return gameWord;
      return _wordPool[rand.Next(_wordPool.Count-1)];
    }

    public void MakeCharArray()
    {
      string gameWordString = this.GetGameWord();
      _gameWord = gameWordString.ToCharArray();
    }

    public char[] BuildWordBlanks()
    {
      _wordBlank = _gameWord;
      for(int i = 0; i < _wordBlank.Length; i++)
      {
        _wordBlank[i] = '_';
      }
      return _wordBlank;
    }

//original method for DoesContainChar returning a bool:
    // public bool DoesContainChar(char userChar)
    // {
    //   for (int i = 0; i < _gameWord.Length; i++)
    //   {
    //     if(_gameWord[i] == userChar)
    //     {
    //       return true;
    //     }
    //   }
    //   return false;
    // }

    public void DoesContainChar(char userChar)
    {
      for (int i = 0; i < _gameWord.Length; i++)
      {
        if(_gameWord[i] == userChar)
        {
          CheckForWin();
          UpdateLettersGuessed(userChar);
          UpdateBlanks(userChar);
        }
        else
        {
          UpdateLettersGuessed(userChar);
          CheckForLose();
          UpdateNumberOfGuesses();
        }
      }
    }

    public char[] UpdateBlanks(char userChar)
    {
      for(int i = 0; i < _gameWord.Length; i++)
      {
        if(_gameWord[i] == userChar)
        {
          _wordBlank[i] = userChar;
        }
      }
      return _wordBlank;
    }

    public List<char> UpdateLettersGuessed(char userChar)
    {
      _lettersGuessed.Add(userChar);
      return _lettersGuessed;
    }

    public int UpdateNumberOfGuesses()
    {
      _numberOfGuesses = this.NumberOfGuesses+=1;
      // return _numberOfGuesses+=1;
      return _numberOfGuesses ;
    }

    public bool CheckForWin()
    {
      bool doesMatch = true;
      for (int i = 0; i < _wordBlank.Length; i++)
      {
        if (_wordBlank[i] != _gameWord[i])
        {
          doesMatch = false;
        }

      }
      return doesMatch;
    }

    public bool CheckForLose()
    {
      if(_numberOfGuesses > 6)
      {
        return true;
      }
      return false;
    }

    public static Game FindGame()
    {
      return _instances[0];
    }

  }
}
