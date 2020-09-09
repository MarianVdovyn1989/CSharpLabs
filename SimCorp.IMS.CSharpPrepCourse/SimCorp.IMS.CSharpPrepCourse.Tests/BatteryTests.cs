//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using SimCorp.IMS.CSharpPrepCourse;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SimCorp.IMS.CSharpPrepCourse.Tests
//{
//    [TestClass()]
//    public class BatteryTests
//    {
//        [TestMethod()]
//        public void Battery_Parameters_SetViaConstructor_0Par_DefaultValue()
//        {
//            //Arrenge
//            var ExpectedManufacturer= "Unknown but very reliable";
//            int? ExpectedCapacity = null;
//            //Act
//            BatteryBase battery = new BatteryBase();
//            //Assert
//            Assert.AreEqual(ExpectedManufacturer, battery.Manufacturer);
//            Assert.AreEqual(ExpectedCapacity, battery.Capacity);
//        }
//        [TestMethod()]
//        public void Battery_Parameters_SetViaConstructor_2Par()
//        {
//            //Arrenge
//            var ExpectedManufacturer = "Toshiba";
//            int? ExpectedCapacity = 4000;
//            //Act
//            BatteryBase battery = new BatteryBase(capacity: 4000, manufacturer:"Toshiba");
//            //Assert
//            Assert.AreEqual(ExpectedManufacturer, battery.Manufacturer);
//            Assert.AreEqual(ExpectedCapacity, battery.Capacity);
//        }
//        [TestMethod()]
//        public void Battery_Parameters_SetViaConstructor_1Par()
//        {
//            //Arrenge
//            var ExpectedManufacturer = "Unknown but very reliable";
//            int? ExpectedCapacity = 4000;
//            //Act
//            BatteryBase battery = new BatteryBase(capacity: 4000);
//            //Assert
//            Assert.AreEqual(ExpectedManufacturer, battery.Manufacturer);
//            Assert.AreEqual(ExpectedCapacity, battery.Capacity);
//        }
//    }
//}