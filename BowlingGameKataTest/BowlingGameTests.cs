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
            g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.Roll(0);
            }
            Assert.Equal(0, g.Score());
        }
        
        [Fact]
        public void TestAllOnes()
        {
            g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.Roll(1);
            }
            Assert.Equal(20, g.Score());
        }
    }
}