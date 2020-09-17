using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Playback
{
    public abstract class PlaybackBase:IPlayback
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
                if (value>=0 || value<=100)
                {
                    _volume = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{Volume}", "Value should be from 0 to 100");
                }
            }
        }

        public abstract void Play(object data);

        public override abstract string ToString();
    }
}
