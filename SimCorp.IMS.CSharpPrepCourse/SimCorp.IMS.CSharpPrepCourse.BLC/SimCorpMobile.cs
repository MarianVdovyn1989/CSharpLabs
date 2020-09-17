using SimCorp.IMS.CSharpPrepCourse.Playback;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    public class SimCorpMobile : MobilePhone
    {
        #region SingletonConstructor
        private SimCorpMobile()
        {
            vAPR = new AcousticPulseRecognition(pixelHeight: 1000, pixelWidth: 1500, diagonalInInches: 3.1, numberOfMultipleTouches: 8);
            vAFC = new AppleFastCharge(BatteryChargerBase._SupportInductiveCharge.yes, BatteryChargerBase._ChargingTechnology.Apple_FastCharge);
            vLiPol = new BatteryLiPol(capacity: 4000, manufacturer: "Toshiba");
            homePod = new HomePod(volume: 75);
        }
        #endregion

        #region SingletonProperties
        private static MobilePhone instance;
        public static MobilePhone Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SimCorpMobile();
                }
                return instance;
            }
        }
        #endregion

        #region Properties
        private readonly AcousticPulseRecognition vAPR;
        public override ScreenTouchBase ScreenTouchComp { get { return vAPR; } }

        private readonly AppleFastCharge vAFC;
        public override BatteryChargerBase BatteryChargerComp { get { return vAFC; } }

        private readonly BatteryBase vLiPol;
        public override BatteryBase BatteryComp { get { return vLiPol; } }

        private readonly PlaybackBase homePod;
        public override PlaybackBase PlaybackComp {get {return homePod;} }

        #endregion





    }
}
