using System;
using BowlingGameKata;
using Xunit;

namespace BowlingGameKataTest
{
    public class BowlingGameTests
    {
        [Fact]
        public void TestGutterGame()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.roll(0);
            }
            Assert.Equal(0, g.score());
        }
        
        [Fact]
        public void TestAllOnes()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.roll(1);
            }
            Assert.Equal(20, g.score());
        }
    }
}