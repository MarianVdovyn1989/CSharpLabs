using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Playback
{
    public class HomePod : PlaybackBase
    {
        IOutput Output;
        public HomePod(int volume, IOutput output) : base(volume)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(HomePod)} to Mobile Phone");
        }
        public override void Play()
        {
            Output.WriteLine($"Do you hear this {nameof(HomePod)} sound? Me too\n");
        }
        public override string ToString()
        {
            return nameof(HomePod);
        }
    }
}
