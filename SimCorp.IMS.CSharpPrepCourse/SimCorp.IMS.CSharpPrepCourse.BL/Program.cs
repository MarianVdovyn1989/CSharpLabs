using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone simCorpMobile = SimCorpMobile.Instance;
            //Console.WriteLine(simCorpMobile.GetMobileComponentsDescription());

            //simCorpMobile.ScreenTouchComp.Touch(simCorpMobile.ScreenTouchComp);
            //simCorpMobile.Play(simCorpMobile.PlaybackComp);
            //simCorpMobile.Charge(simCorpMobile.BatteryChargerComp);

            Console.ReadLine();
        }
    }
}
