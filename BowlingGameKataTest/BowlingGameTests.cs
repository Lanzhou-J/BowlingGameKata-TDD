using System;
using BowlingGameKata;
using Xunit;

namespace BowlingGameKataTest
{
    public class BowlingGameTests
    {

        private Game g;
        public BowlingGameTests()
        {
            g = new Game();
        }

        [Fact]
        public void TestGutterGame()
        {
            int n = 20;
            int pins = 0;
            RollMany(n, pins);
            Assert.Equal(0, g.Score());
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < 20; i++)
            {
                g.Roll(pins);
            }
        }

        [Fact]
        public void TestAllOnes()
        {
            for (int i = 0; i < 20; i++)
            {
                g.Roll(1);
            }
            Assert.Equal(20, g.Score());
        }
    }
}