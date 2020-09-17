using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Playback
{
    public class AirPods : PlaybackBase
    {
        public AirPods(int volume):base(volume)
        {

        }
        public override void Play(object data)
        {
            Console.WriteLine($"Do you hear this {nameof(AirPods)} sound? Me too");
            Console.WriteLine("");
        }
        public override string ToString()
        {
            return nameof(AirPods);
        }
    }
}
