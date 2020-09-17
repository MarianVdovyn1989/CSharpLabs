using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.Console
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string text)
        {
            System.Console.Write(text);
        }

        public void WriteLine(string text)
        {
            System.Console.WriteLine(text);
        }
    }
}
