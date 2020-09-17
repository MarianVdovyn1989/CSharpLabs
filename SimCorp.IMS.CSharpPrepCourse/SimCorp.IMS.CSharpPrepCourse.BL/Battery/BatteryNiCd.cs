using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Battery
{
    public class BatteryNiCd : BatteryBase
    {
        public BatteryNiCd(int? capacity, string manufacturer) : base(capacity, manufacturer)
        {

        }

        public override string ToString()
        {
            return nameof(BatteryNiCd).ToString();
        }
    }
}
