using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Playback
{
    class HomePod :PlaybackBase, IPlayback
    {
        public HomePod(int volume) : base(volume)
        {

        }
        public override void Play(object data)
        {
            Console.WriteLine($"Do you hear this {nameof(HomePod)} sound? Me too");
            Console.WriteLine("");
        }
        public override string ToString()
        {
            return nameof(HomePod);
        }
    }
}
