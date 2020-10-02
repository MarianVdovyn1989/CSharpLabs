using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BL.BatteryCharger
{
    public class AppleFastCharge : BatteryChargerBase
    {
        IOutput Output;
        public AppleFastCharge(bool inductiveCharge, _ChargingTechnology chargingTechnology, IOutput output) : base(inductiveCharge, chargingTechnology)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(AppleFastCharge)} to Mobile Phone");
        }

        public override void Charge()
        {
            Output.WriteLine($"Battery now is charging using {nameof(AppleFastCharge)}");
            Output.WriteLine($"Wow, this charging speed must be illegal, right?\n");
        }

        public override string ToString()
        {
            return nameof(AppleFastCharge);
        }
    }
}
