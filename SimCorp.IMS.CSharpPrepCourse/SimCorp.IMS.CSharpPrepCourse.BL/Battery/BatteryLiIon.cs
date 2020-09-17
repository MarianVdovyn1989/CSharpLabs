using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Battery
{
    public class BatteryLiIon : BatteryBase
    {
        public IOutput Output;
        public BatteryLiIon(int? capacity, string manufacturer, IOutput output) : base(capacity, manufacturer)
        {
            Output = output;
        }


        public override string ToString()
        {
            return nameof(BatteryLiIon).ToString();
        }
    }
}
