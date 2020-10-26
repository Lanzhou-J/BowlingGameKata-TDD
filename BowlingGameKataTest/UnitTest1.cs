using System;
using BowlingGameKata;
using Xunit;

namespace BowlingGameKataTest
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.roll(0);
            }
            Assert.Equal(0, g.score());
        }
    }
}