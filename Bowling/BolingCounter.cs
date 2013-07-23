using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class BolingCounter
    {
        private readonly List<Frame> _frames = new List<Frame>();

        public void Roll(int i)
        {
            if (!_frames.Any()) _frames.Add(new Frame());

            if (_frames.Count == 10 && (_frames.Last().Rolls.Sum() == 10 | _frames.Last().Rolls.First() == 10))
                _frames.Last().Rolls.Add(i);
            else if (_frames.Last().Rolls.Count == 2 | _frames.Last().Rolls.Sum() == 10)
                _frames.Add(new Frame {Rolls = new List<int> {i}});
            else _frames.Last().Rolls.Add(i);
        }

        public int GetResult()
        {
            var result = 0;
            Frame lastFrame = null;
            foreach (var frame in _frames)
            {
                result += frame.Rolls.Sum();

                //Spare
                if (lastFrame != null && lastFrame.Rolls.Count == 2 && lastFrame.Rolls.Sum() == 10)
                    result += frame.Rolls.First();

                //Strike
                if (lastFrame != null && lastFrame.Rolls.Count == 1 && lastFrame.Rolls.Sum() == 10)
                    result += frame.Rolls.GetRange(0, 2).Sum();

                if (frame.Rolls.Count == 2 | frame.Rolls.First() == 10)
                    lastFrame = frame;
            }
            return result;
        }
    }
}