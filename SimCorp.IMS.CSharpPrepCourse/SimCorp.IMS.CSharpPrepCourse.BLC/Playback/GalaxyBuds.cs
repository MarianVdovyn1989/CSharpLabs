using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Playback
{
    class GalaxyBuds : PlaybackBase, IPlayback
    {
        public GalaxyBuds(int volume) : base(volume)
        {

        }
        public override void Play(object data)
        {
            Console.WriteLine($"Do you hear this {nameof(GalaxyBuds)} sound? Me too");
            Console.WriteLine("");
        }
        public override string ToString()
        {
            return nameof(GalaxyBuds);
        }

    }
}
