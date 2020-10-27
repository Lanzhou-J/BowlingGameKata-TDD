using System.Collections.Generic;

namespace BowlingGameKata
{
    public class Game
    {
        private int _score = 0;
        private readonly int[] _rolls = new int[21];
        private int _currentRoll = 0;
        public void Roll(int pins)
        {
            _score += pins;
            _rolls[_currentRoll++] = pins;
        }
        public int Score()
        {
             int score = 0;
             for (int i = 0; i < _rolls.Length; i++)
                 score += _rolls[i];
             return score;
        }
    }
}