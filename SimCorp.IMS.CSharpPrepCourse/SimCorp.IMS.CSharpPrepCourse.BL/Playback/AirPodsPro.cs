using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Playback
{
    public class AirPodsPro : PlaybackBase
    {
        IOutput Output;
        public AirPodsPro(int volume, IOutput output) : base(volume)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(AirPodsPro)} to Mobile Phone");
        }
        public override void Play()
        {
            Output.WriteLine($"Do you hear this {nameof(AirPodsPro)} sound? Me too\n");
        }
        public override string ToString()
        {
            return nameof(AirPodsPro);
        }
    }
}
