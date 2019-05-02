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

    public char[] GameWord{ get => _gameWord; set => _gameWord = value; }
    public char[] WordsBlank{ get => _wordBlank; set => _wordBlank = value; }
    public List<char> LettersGuessed{ get; set; }
    publi int NumberOfGuesses{ get; set; }

    public Game()
    {
      this.MakeCharArray();
      this.BuildWordBlanks();
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
  }
}
