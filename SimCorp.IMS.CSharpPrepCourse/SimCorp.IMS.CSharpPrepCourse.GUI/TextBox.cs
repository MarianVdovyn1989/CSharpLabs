using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.GUI
{
    class TextBox:IOutput
    {
        private System.Windows.Forms.TextBox tbOutput;

        public TextBox(System.Windows.Forms.TextBox tb)
        {
            tbOutput = tb;
        }

        public void WriteLine(string text)
        {
            tbOutput.AppendText(text);
            tbOutput.AppendText(Environment.NewLine);
        }
    }
}
