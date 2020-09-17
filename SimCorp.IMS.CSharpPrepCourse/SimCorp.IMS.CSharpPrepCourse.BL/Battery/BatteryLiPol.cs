using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Battery
{
    public class BatteryLiPol : BatteryBase
    {
        public BatteryLiPol(int? capacity, string manufacturer) : base(capacity, manufacturer)
        {

        }

        public override string ToString()
        {
            return nameof(BatteryLiPol).ToString();
        }
    }
}
