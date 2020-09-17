using SimCorp.IMS.CSharpPrepCourse.BL;
using SimCorp.IMS.CSharpPrepCourse.Playback;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse
{
    public abstract class MobilePhone
    {
        #region Properties
        public abstract ScreenTouchBase ScreenTouchComp { get;}
        public abstract BatteryChargerBase BatteryChargerComp { get; }
        public abstract BatteryBase BatteryComp { get; }
        public abstract PlaybackBase PlaybackComp { get; }
        private IPlayback _Playback { get; }
        private IBatteryCharger _BatteryCharger { get; }

        #endregion

        #region Methods
        //wrapper
        public void Touch(IScreenTouch screen)
        {
            ScreenTouchComp.Touch(screen);
        }
        //wrapper/decorator
        public void Play(object data)
        {
            PlaybackComp.Play(data);
        }
        public void Charge(IBatteryCharger data)
        {
            BatteryChargerComp.ChargeBattery(data);     
        }

        public string GetMobileComponentsDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine(GetScreenDescription());
            descriptionBuilder.AppendLine(GetBatteryChargerDescription());
            descriptionBuilder.AppendLine(GetBatteryDescription());
            descriptionBuilder.AppendLine(GetPlaybackDescription());
            return descriptionBuilder.ToString();
        }

        private string GetBatteryDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine("========================================");
            descriptionBuilder.AppendLine("Component: Battery");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"Battery Type: {BatteryComp.ToString()}");
            descriptionBuilder.AppendLine($"Battery Capacity: {BatteryComp.Capacity}");
            descriptionBuilder.AppendLine($"Battery Manufacturer: {BatteryComp.Manufacturer}");
            descriptionBuilder.AppendLine("========================================");
            return descriptionBuilder.ToString();
        }

        private string GetBatteryChargerDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine("========================================");
            descriptionBuilder.AppendLine("Component: Battery Charger");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"Battery Charger Type: {BatteryChargerComp.ToString()}");
            descriptionBuilder.AppendLine($"Battery Charger Technology: {BatteryChargerComp.ChargingTechnology}");
            descriptionBuilder.AppendLine($"Battery Charger MaxPower: {BatteryChargerComp.MaxPower}");
            descriptionBuilder.AppendLine($"Battery Charger Inductive Charge: {BatteryChargerComp.InductiveCharge}");
            descriptionBuilder.AppendLine("========================================");
            return descriptionBuilder.ToString();
        }

        private string GetScreenDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine("========================================");
            descriptionBuilder.AppendLine("Component: Screen");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"Touch Screen Type: {ScreenTouchComp.ToString()}");
            descriptionBuilder.AppendLine($"Screen Aspect Ratio: {ScreenTouchComp.AspectRatio}");
            descriptionBuilder.AppendLine($"Screen Diagonal In Inches: {ScreenTouchComp.DiagonalInInches}");
            descriptionBuilder.AppendLine("========================================");
            return descriptionBuilder.ToString();
        }
        private string GetPlaybackDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine("========================================");
            descriptionBuilder.AppendLine("Component: Playback");
            descriptionBuilder.AppendLine();
            descriptionBuilder.AppendLine($"Playback Device: {PlaybackComp.ToString()}");
            descriptionBuilder.AppendLine($"Volume set on: {PlaybackComp.Volume}");
            descriptionBuilder.AppendLine("========================================");
            return descriptionBuilder.ToString();
        }
        #endregion

    }
}
