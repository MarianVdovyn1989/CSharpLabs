using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Playback
{
    public class PhoneSpeaker : PlaybackBase
    {
        IOutput Output;
        public PhoneSpeaker(int volume,IOutput output) : base(volume)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(PhoneSpeaker)} to Mobile Phone");
        }

        public override void Play()
        {
            Output.WriteLine($"Do you hear this {nameof(PhoneSpeaker)} sound? Me too\n");
        }
        public override string ToString()
        {
            return nameof(PhoneSpeaker);
        }
    }
}
