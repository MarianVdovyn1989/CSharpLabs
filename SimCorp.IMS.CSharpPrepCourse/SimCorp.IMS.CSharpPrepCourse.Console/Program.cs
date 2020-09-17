using SimCorp.IMS.CSharpPrepCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public class Program
    {
        static void Main(string[] args)
        {
            MobilePhone simCorpMobile = SimCorpMobile.Instance;
            System.Console.WriteLine(simCorpMobile.GetMobileComponentsDescription());

            simCorpMobile.Touch(simCorpMobile.ScreenTouchComp);
            simCorpMobile.Play(simCorpMobile.PlaybackComp);
            simCorpMobile.Charge(simCorpMobile.BatteryChargerComp);

            System.Console.ReadLine();
        }
    }
}
