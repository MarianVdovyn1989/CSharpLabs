using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Test
{
    [TestClass]
    public class SMSFormatterTest
    {
        [TestMethod]
        public void FormatEndWithDateTime()
        {
            //Arrenge
            string expected = $"Test message received {DateTime.Now}";
            //Act
            var actual=SMSFormatter.FormatEndWithDateTime("Test message received");
            //Assert
            Assert.AreEqual(expected,actual);

        }
        [TestMethod]
        public void FormatStartWithDateTime()
        {
            //Arrenge
            string expected = $"{DateTime.Now}: Test message received";
            //Act
            var actual = SMSFormatter.FormatStartWithDateTime("Test message received");
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FormatNone()
        {
            //Arrenge
            string expected = $"Test message received";
            //Act
            var actual = SMSFormatter.FormatNone("Test message received");
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FormatToLowerCase()
        {
            //Arrenge
            string expected = $"test message received";
            //Act
            var actual = SMSFormatter.FormatToLowerCase("Test message received");
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FormatToUpperCase()
        {
            //Arrenge
            string expected = $"TEST MESSAGE RECEIVED";
            //Act
            var actual = SMSFormatter.FormatToUpperCase("Test message received");
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FormatToCustom()
        {
            //Arrenge
            string expected = $"TEst mEssagE rEcEivEd";
            //Act
            var actual = SMSFormatter.FormatToCustom("Test message received");
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
