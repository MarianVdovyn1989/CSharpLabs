using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Playback
{
    public class PhoneSpeaker :PlaybackBase, IPlayback
    {
        public PhoneSpeaker(int volume) : base(volume)
        {

        }

        public override void Play(object data)
        {
            Console.WriteLine($"Do you hear this {nameof(PhoneSpeaker)} sound? Me too");
            Console.WriteLine("");
        }
        public override string ToString()
        {
            return nameof(PhoneSpeaker);
        }
    }
}
