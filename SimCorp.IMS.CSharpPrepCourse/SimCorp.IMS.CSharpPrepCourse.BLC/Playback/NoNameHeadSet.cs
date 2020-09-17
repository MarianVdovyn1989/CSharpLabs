using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Playback
{
    class NoNameHeadSet :PlaybackBase, IPlayback
    {
        public NoNameHeadSet(int volume) : base(volume)
        {

        }
        public override void Play(object data)
        {
            Console.WriteLine($"Do you hear this {nameof(NoNameHeadSet)} sound? Me too");
            Console.WriteLine("");
        }
        public override string ToString()
        {
            return nameof(NoNameHeadSet);
        }
    }
}
