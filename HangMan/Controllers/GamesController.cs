using Microsoft.AspNetCore.Mvc;
using HangMan.Models;
using System.Collections.Generic;
using System;

namespace HangMan.Controllers
{
  public class GamesController : Controller
  {
    [HttpGet("/game")]
    public ActionResult Index()
    {
      Game thisGame = Game.FindGame();
      // Game newGame = new Game();
      return View(thisGame);
    }

    [HttpPost("/game")]
    public ActionResult Update(string userLetter)
    {
      // char converted;
      // bool userChar = Char.TryParse(userLetter, out converted);

      char newChar = userLetter[0];
      Game thisGame = Game.FindGame();
      thisGame.DoesContainChar(newChar);
      return View("Index", thisGame);
    }

  }
}
