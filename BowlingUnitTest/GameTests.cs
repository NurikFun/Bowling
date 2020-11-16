using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling_Game;

namespace BowlingGamesTests
{
    [TestClass]
    public class GameTests
    {


        [TestMethod]
        public void CanCreateGame()
        {
            var game = BowlingGame();

        }
    }
}
