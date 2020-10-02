using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.BatteryCharger
{
    public class HuaweiSuperCharge2_0 : BatteryChargerBase
    {
        IOutput Output;
        public HuaweiSuperCharge2_0(bool inductiveCharge, _ChargingTechnology chargingTechnology, IOutput output) : base(inductiveCharge, chargingTechnology)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(HuaweiSuperCharge2_0)} to Mobile Phone");
        }
        public override void Charge()
        {
            Output.WriteLine($"Battery now is charging using {nameof(HuaweiSuperCharge2_0)}");
            Output.WriteLine("Wow, this charging speed must be illegal, right?\n");
        }
        public override string ToString()
        {
            return nameof(HuaweiSuperCharge2_0);
        }
    }
}
