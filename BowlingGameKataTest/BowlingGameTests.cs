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
          
            RollMany(20, 0);
            Assert.Equal(0, g.Score());
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.Roll(pins);
            
        }

        [Fact]
        public void TestAllOnes()
        {
            RollMany(20,1);
            Assert.Equal(20, g.Score());
        }
        
        [Fact]
        public void TestOneSpare()
        {
            g.Roll(5);
            g.Roll(5);
            g.Roll(3);
            RollMany(17, 0);
            Assert.Equal(16, g.Score());
        }
    }
}