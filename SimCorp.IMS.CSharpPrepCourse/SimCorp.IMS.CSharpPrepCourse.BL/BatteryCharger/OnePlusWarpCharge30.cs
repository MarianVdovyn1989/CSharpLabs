﻿using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;

namespace SimCorp.IMS.CSharpPrepCourse.BL.BatteryCharger
{
    public class OnePlusWarpCharge30 : BatteryChargerBase
    {
        IOutput Output;
        public OnePlusWarpCharge30(bool inductiveCharge, _ChargingTechnology chargingTechnology, IOutput output) : base(inductiveCharge, chargingTechnology)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(OnePlusWarpCharge30)} to Mobile Phone");
        }
        public override void Charge()
        {
            Output.WriteLine($"Battery now is charging using {nameof(OnePlusWarpCharge30)}");
            Output.WriteLine("Wow, this charging speed must be illegal, right?\n");
        }
        public override string ToString()
        {
            return nameof(OnePlusWarpCharge30);
        }
    }
}
