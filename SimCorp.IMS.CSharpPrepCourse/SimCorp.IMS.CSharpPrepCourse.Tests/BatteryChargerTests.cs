//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using SimCorp.IMS.CSharpPrepCourse;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SimCorp.IMS.CSharpPrepCourse.Tests
//{
//    [TestClass()]
//    public class BatteryChargerTests
//    {
//        [TestMethod()]
//        public void BatteryCharger_Parameters_SetViaConstructor_1Par()
//        {
//            //Arrange
//            BatteryCharger.SupportInductiveCharge ExpectedInductiveCharge = BatteryCharger.SupportInductiveCharge.yes;
//            //Act
//            BatteryCharger batteryCharger = new BatteryCharger(BatteryCharger.SupportInductiveCharge.yes);
//            //Asset
//            Assert.AreEqual(ExpectedInductiveCharge, batteryCharger.supportInductiveCharge);
//        }
//        [TestMethod()]
//        public void BatteryCharger_Parameters_SetViaConstructor_2Par()
//        {
//            //Arrange
//            BatteryCharger.SupportInductiveCharge ExpectedInductiveCharge = BatteryCharger.SupportInductiveCharge.yes;
//            BatteryCharger.ChargingTechnology ExpectedChargingTechnology = BatteryCharger.ChargingTechnology.Oppo_SuperVOOC;
//            //Act
//            BatteryCharger batteryCharger = new BatteryCharger(BatteryCharger.SupportInductiveCharge.yes, BatteryCharger.ChargingTechnology.Oppo_SuperVOOC);
//            //Asset
//            Assert.AreEqual(ExpectedInductiveCharge, batteryCharger.supportInductiveCharge);
//            Assert.AreEqual(ExpectedChargingTechnology, batteryCharger.chargingTechnology);
//        }
//        [TestMethod()]
//        public void BatteryCharger_Parameters_SetViaConstructor_0Par_DefaultValues()
//        {
//            //Arrange
//            BatteryCharger.SupportInductiveCharge ExpectedDefaultInductiveCharge = BatteryCharger.SupportInductiveCharge.no;
//            BatteryCharger.ChargingTechnology ExpectedDefaultChargingTechnology = BatteryCharger.ChargingTechnology.USB2_0;
//            double ExpectedDefaultMaxPower = 2.5;
//            //Act
//            BatteryCharger batteryCharger = new BatteryCharger();
//            //Asset
//            Assert.AreEqual(ExpectedDefaultInductiveCharge, batteryCharger.supportInductiveCharge);
//            Assert.AreEqual(ExpectedDefaultChargingTechnology, batteryCharger.chargingTechnology);
//            Assert.AreEqual(ExpectedDefaultMaxPower, batteryCharger.MaxPower);
//        }
//        [TestMethod()]
//        public void BatteryCharger_Parameters_SetViaPar()
//        {
//            //Arrange
//            BatteryCharger.SupportInductiveCharge ExpectedInductiveCharge = BatteryCharger.SupportInductiveCharge.yes;
//            BatteryCharger.ChargingTechnology ExpectedChargingTechnology = BatteryCharger.ChargingTechnology.Apple_FastChanrge;
//            double ExpectedMaxPower = 18;
//            //Act
//            BatteryCharger batteryCharger = new BatteryCharger();
//            batteryCharger.supportInductiveCharge = BatteryCharger.SupportInductiveCharge.yes;
//            batteryCharger.chargingTechnology = BatteryCharger.ChargingTechnology.Apple_FastChanrge;
            
//            //Asset
//            Assert.AreEqual(ExpectedInductiveCharge, batteryCharger.supportInductiveCharge);
//            Assert.AreEqual(ExpectedChargingTechnology, batteryCharger.chargingTechnology);
//            Assert.AreEqual(ExpectedMaxPower, batteryCharger.MaxPower);
//        }
//    }
//}