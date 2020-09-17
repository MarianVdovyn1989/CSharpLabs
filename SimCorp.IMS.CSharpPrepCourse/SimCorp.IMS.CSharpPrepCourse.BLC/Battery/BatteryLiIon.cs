using SimCorp.IMS.CSharpPrepCourse.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class BatteryLiIon : BatteryBase
    {
        public IOutput Output;
        public BatteryLiIon(int? capacity, string manufacturer, IOutput output) :base(capacity, manufacturer)
        {
            Output = output;
        }


        public override string ToString()
        {
            return nameof(BatteryLiIon).ToString();
        }
    }
}
