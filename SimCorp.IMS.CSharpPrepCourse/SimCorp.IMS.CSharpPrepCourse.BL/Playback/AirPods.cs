using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Playback
{
    public class AirPods : PlaybackBase
    {
        IOutput Output;
        public AirPods(int volume, IOutput output) : base(volume)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(AirPods)} to Mobile Phone");
        }
        public override void Play()
        {
            Output.WriteLine($"Do you hear this {nameof(AirPods)} sound? Me too\n");
        }
        public override string ToString()
        {
            return nameof(AirPods);
        }
    }
}
