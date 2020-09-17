﻿using SimCorp.IMS.CSharpPrepCourse.BL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class USB2_0 : BatteryChargerBase
    {
        public USB2_0(_SupportInductiveCharge inductiveCharge, _ChargingTechnology chargingTechnology) : base(inductiveCharge, chargingTechnology)
        {

        }

        public override void ChargeBattery(object batteryCharger)
        {
            Console.WriteLine($"battery now is charging using {nameof(USB2_0)}");
            Console.WriteLine("Wow,  This charging speed speed must be illegal, right?");
            Console.WriteLine("");
        }

        public override string ToString()
        {
            return nameof(USB2_0);
        }
    }
}