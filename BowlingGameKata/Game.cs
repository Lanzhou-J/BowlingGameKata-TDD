using System.Collections.Generic;

namespace BowlingGameKata
{
    public class Game
    {
        private readonly int[] _rolls = new int[21];
        private int _currentRoll = 0;
        public void Roll(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }
        public int Score()
        {
             int score = 0;
             int i = 0;
             for (int frame = 0; frame < 10; frame++)
             {
                 if (_rolls[i] + _rolls[i+1] == 10)
                 {
                     score += 10 + _rolls[i + 2];
                     i += 2;
                 }
                 else
                 {
                     score += _rolls[i] + _rolls[i+1];
                     i += 2;
                 }
             }
             return score;
        }
    }
}