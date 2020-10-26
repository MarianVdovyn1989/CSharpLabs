using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Test
{
	[TestClass]
	public class SMSProviderTest
	{
        public class FakeSMSProvider : SMSProvider
        {
            private string _myProperty;

            public string MyProperty
            {
                set
                {
                    if (_myProperty != value)
                    {
                        _myProperty = value;
                        RaiseSMSReceivedEvent("message: SMS event is raised");
                    }
                }
            }
        }

        [TestMethod]
		public void TestThatEventIsRaised()
		{
            //Arrenge
            List<string> actualEvents = new List<string>();
            FakeSMSProvider smsProvider  = new FakeSMSProvider();
            //Assign Anonymous Event Handler
            SMSProvider.SMSReceived += (string message)=>
                actualEvents.Add(message);
            //Act
            smsProvider.MyProperty = "SMS Event Invoked";
            //Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsNotNull(actualEvents[0].ToString());
            Assert.AreEqual("message: SMS event is raised", actualEvents[0].ToString());
        }
	}
}
