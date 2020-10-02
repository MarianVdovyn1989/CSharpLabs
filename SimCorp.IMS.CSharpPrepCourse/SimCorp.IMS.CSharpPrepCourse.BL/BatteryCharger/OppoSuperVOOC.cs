using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.BatteryCharger
{
    public class OppoSuperVOOC : BatteryChargerBase
    {
        IOutput Output;
        public OppoSuperVOOC(bool inductiveCharge, _ChargingTechnology chargingTechnology, IOutput output) : base(inductiveCharge, chargingTechnology)
        {
            Output = output ;
            Output.WriteLine($"Setting {nameof(OppoSuperVOOC)} to Mobile Phone");
        }
        public override void Charge()
        {
            Output.WriteLine($"Battery now is charging using {nameof(OppoSuperVOOC)}");
            Output.WriteLine("Wow, this charging speed must be illegal, right?\n");
        }
        public override string ToString()
        {
            return nameof(OppoSuperVOOC);
        }
    }
}
