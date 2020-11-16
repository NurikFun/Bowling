using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling_Game;

namespace GameTests
{
    [TestClass]
    public class UnitTest1
    {
        /*
        private BowlingGame game; // для того, чтобы в каждом методе не создавать заново экземпляры класса

        [TestInitialize]
        public void Initialize() // мы создаем экземпляр здесь и все, поэтому он будет виден для всех тестов
        {
            game = new BowlingGame();
        }

        [TestMethod]
        public void CanRollGutterGame()
        {
            RollMany(0, 20);
            Assert.AreEqual(0, game.Score);
        }

        [TestMethod]
        public void CanRollAllOnes()
        {
            RollMany(1, 20);
            Assert.AreEqual(20, game.Score);
        }

        [TestMethod]
        public void CanRollSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(0, 17);
            Assert.AreEqual(16, game.Score);
        }

        [TestMethod]
        public void CanRollStrike()
        {
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollMany(0, 16);
            Assert.AreEqual(24, game.Score);
        }

        [TestMethod]
        public void CanRollPerfectGame()
        {
            RollMany(10, 12);
            Assert.AreEqual(300, game.Score);
        }


        private void RollMany(int pins, int rolls)
        {
            for (var i = 0; i < rolls; i++)
                game.Roll(pins);
        }
        */


        private BowlingGameTest test;

        [TestInitialize]
        public void InitializeTest()
        {
            test = new BowlingGameTest();
        }

        private void RollManyTest(int pins, int rolls)
        {
            for (var i = 0; i < rolls; i++)
                test.Roll(pins);
        }

        [TestMethod]
        public void BadGame()
        {
            RollManyTest(0, 20);
            Assert.AreEqual(0, test.Scores);
            
        }

        

        [TestMethod]
        public void PerfectGame()
        {
            RollManyTest(10, 12);
            Assert.AreEqual(300, test.Scores);
        }

        
        [TestMethod]
        public void SpareGame()
        {
            
            test.Roll(5);
            test.Roll(5);
            test.Roll(3);

            RollManyTest(0, 17);
            Assert.AreEqual(16, test.Scores);

        }
        

        [TestMethod]
        public void StrikeTest()
        {
            test.Roll(10);
            test.Roll(4);
            test.Roll(3);
            RollManyTest(0, 17);
            Assert.AreEqual(24, test.Scores);
        }

        
        [TestMethod]
        public void SpareTest2()
        {
            test.Roll(5);
            test.Roll(5);
            test.Roll(5);
            test.Roll(5);
            test.Roll(4);
            RollManyTest(0, 15);
            Assert.AreEqual(33, test.Scores);
        }

        
        [TestMethod]
        public void SpareTest3()
        {
            test.Roll(5);
            test.Roll(5);
            test.Roll(4);
            test.Roll(6);
            test.Roll(9);
            RollManyTest(0, 15);
            Assert.AreEqual(42, test.Scores);
        }


        
    }
}
