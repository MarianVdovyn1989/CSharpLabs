using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Playback
{
    class GalaxyBudsLive :PlaybackBase, IPlayback
    {
        public GalaxyBudsLive(int volume) : base(volume)
        {

        }
        public override  void Play(object data)
        {
            Console.WriteLine($"Do you hear this {nameof(GalaxyBudsLive)} sound? Me too");
            Console.WriteLine("");
        }
        public override string ToString()
        {
            return nameof(GalaxyBudsLive);
        }
    }
}
