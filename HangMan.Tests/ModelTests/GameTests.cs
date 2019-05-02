using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HangMan.Models;

namespace HangMan.Tests
{
  [TestClass]
  public class GameTest : IDisposable
  {

    public void Dispose()
    {
        Item.ClearAll();
    }


  }
}
