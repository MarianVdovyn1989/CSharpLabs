using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Playback
{
    public abstract class PlaybackBase : IPlayback
    {
        public PlaybackBase(int volume)
        {
            Volume = volume;
        }
        private int _volume;

        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value >= 0 || value <= 100)
                {
                    _volume = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{Volume}", "Value should be from 0 to 100");
                }
            }
        }

        public abstract void Play();

        public override abstract string ToString();
    }
}
