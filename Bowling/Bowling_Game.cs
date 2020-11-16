using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game
{
    public class BowlingGame
    {
        private int[] rolls = new int[21]; // попытка бросков
        private int currentRoll = 0; // изначальное значение
        public int Score
        {
            get
            {
                var score = 0;
                var rollIndex = 0;
                for (var frame = 0; frame < 10; frame++)
                {
                    if (IsStrike(rollIndex)) // если страйк
                    {
                        score += GetStrikeScore(rollIndex);
                        rollIndex++;
                    }
                    else if (IsSpare(rollIndex)) // если spare
                    {
                        score += GetSpareScore(rollIndex);
                        rollIndex += 2;

                    }
                    else // другие случаи 
                    {
                        score += GetStandartScore(rollIndex);
                        rollIndex += 2;

                    }
                }

                return score;
            }
        }


        public void Roll(int pins) // метод который запоняет массив в юнит тесте
        {
            rolls[currentRoll++] = pins;
        }

        private int GetStrikeScore(int rollIndex) // метод при страйке
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] + rolls[rollIndex + 2];
        }

        private bool IsStrike(int rollIndex) // если страйк
        {
            return rolls[rollIndex] == 10;
        }

        private int GetStandartScore(int rollIndex) // если обычное выбывание 
        {
            return rolls[rollIndex] + rolls[rollIndex + 1];
        }

        private int GetSpareScore(int rollIndex) // при spare
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] + rolls[rollIndex + 2];
        }

        private bool IsSpare(int rollIndex) // проверка является ли spare
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] == 10;
        }

    }
}
