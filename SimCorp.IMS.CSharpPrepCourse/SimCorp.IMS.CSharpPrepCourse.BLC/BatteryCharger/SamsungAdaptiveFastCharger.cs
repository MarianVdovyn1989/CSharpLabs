﻿using SimCorp.IMS.CSharpPrepCourse.BL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BatteryCharger
{
    public class SamsungAdaptiveFastCharger : BatteryChargerBase
    {
        public SamsungAdaptiveFastCharger(_SupportInductiveCharge inductiveCharge, _ChargingTechnology chargingTechnology) : base(inductiveCharge, chargingTechnology)
        {

        }

        public override void ChargeBattery(object batteryCharger)
        {
            Console.WriteLine($"battery now is charging using {nameof(SamsungAdaptiveFastCharger)}");
            Console.WriteLine("Wow,  This charging speed speed must be illegal, right?");
            Console.WriteLine("");
        }

        public override string ToString()
        {
            return nameof(SamsungAdaptiveFastCharger);
        }
    }
}