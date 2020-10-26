using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;

namespace SimCorp.IMS.CSharpPrepCourse.GUI
{
    public class RichTextBox : IOutput
    {
        private System.Windows.Forms.RichTextBox rtbOutput;

        public RichTextBox(System.Windows.Forms.RichTextBox tb)
        {
            rtbOutput = tb;
        }

        public void WriteLine(string text)
        {
            rtbOutput.AppendText(text);
            rtbOutput.AppendText(Environment.NewLine);
        }
    }
}
