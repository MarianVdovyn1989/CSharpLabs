using System.ComponentModel;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    public class SMSProvider
    {
        public delegate void SMSReceivedDelegate(string message);
        public static event SMSReceivedDelegate SMSReceived;

        public static void RaiseSMSReceivedEvent(string message)
        {
            var smsDelegate = SMSReceived as SMSReceivedDelegate;
            if (smsDelegate != null)
                    smsDelegate(message);
        }

        public static void SendSMS(BackgroundWorker sender, int smsInterval)
        {
            int counter = 0;
            while (true)
            {
                counter++;
                System.Threading.Thread.Sleep(smsInterval);
                RaiseSMSReceivedEvent($"Message # {counter} received");
            } 
        }
    }
}
