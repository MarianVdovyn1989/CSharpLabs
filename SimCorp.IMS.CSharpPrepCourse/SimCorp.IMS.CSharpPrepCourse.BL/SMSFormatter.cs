using System;

namespace SimCorp.IMS.CSharpPrepCourse.BL
{
    public class SMSFormatter
    {
        public delegate string SMSFormatDelegate(string message);
        public static string FormatStartWithDateTime(string message)
        {
            return $"{DateTime.Now}: {message}";
        }
        public static string FormatEndWithDateTime(string message)
        {
            return $"{message} {DateTime.Now}";
        }

        public static string FormatNone(string message)
        {
            return $"{message}";
        }
        public static string FormatToLowerCase(string message)
        {
            return $"{message.ToLower()}";
        }
        public static string FormatToUpperCase(string message)
        {
            return $"{message.ToUpper()}";
        }
        public static string FormatToCustom(string message)
        {
            return $"{message.Replace('e', 'E')}";
        }
    }
}
