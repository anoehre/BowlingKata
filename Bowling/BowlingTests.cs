#region

using NUnit.Framework;

#endregion

namespace Bowling
{
    public class BowlingTests
    {
        [Test]
        public void RollOne()
        {
            var bowlingCounter = new BolingCounter();
            bowlingCounter.Roll(1);
            Assert.AreEqual(1, bowlingCounter.GetResult());
        }

        [Test]
        public void RollTwo()
        {
            var bowlingCounter = new BolingCounter();
            bowlingCounter.Roll(1);
            bowlingCounter.Roll(5);
            Assert.AreEqual(6, bowlingCounter.GetResult());
        }

        [Test]
        public void RollSpare()
        {
            var bowlingCounter = new BolingCounter();
            bowlingCounter.Roll(5);
            bowlingCounter.Roll(5);
            bowlingCounter.Roll(5);
            Assert.AreEqual(20, bowlingCounter.GetResult());
        }

        [Test]
        public void RollStrike()
        {
            var bowlingCounter = new BolingCounter();
            bowlingCounter.Roll(10);
            bowlingCounter.Roll(1);
            bowlingCounter.Roll(1);
            Assert.AreEqual(14, bowlingCounter.GetResult());
        }

        [Test]
        public void RollGame()
        {
            var bowlingCounter = new BolingCounter();
            bowlingCounter.Roll(1);
            bowlingCounter.Roll(4);
            bowlingCounter.Roll(4);
            bowlingCounter.Roll(5);
            bowlingCounter.Roll(6);
            bowlingCounter.Roll(4);
            bowlingCounter.Roll(5);
            bowlingCounter.Roll(5);
            bowlingCounter.Roll(10);
            bowlingCounter.Roll(0);
            bowlingCounter.Roll(1);
            bowlingCounter.Roll(7);
            bowlingCounter.Roll(3);
            bowlingCounter.Roll(6);
            bowlingCounter.Roll(4);
            bowlingCounter.Roll(10);
            bowlingCounter.Roll(2);
            bowlingCounter.Roll(8);
            bowlingCounter.Roll(6);
            Assert.AreEqual(133, bowlingCounter.GetResult());
        }
    }
}