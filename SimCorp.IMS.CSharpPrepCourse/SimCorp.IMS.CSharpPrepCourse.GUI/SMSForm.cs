using SimCorp.IMS.CSharpPrepCourse.BL;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static SimCorp.IMS.CSharpPrepCourse.BL.SMSFormatter;

namespace SimCorp.IMS.CSharpPrepCourse.GUI
{
    public partial class SMSForm : Form
    {
        private IOutput Output;
        private SMSFormatDelegate smsFormatDelegate = new SMSFormatDelegate(FormatNone);//default value

        public SMSForm()
        {
            InitializeComponent();
            Output = new RichTextBox(tbSMSBox);
            SMSProvider.SMSReceived += tbSMSBox_TextChanged;
            Shown += SMSForm_Shown;
        }
        private void SMSForm_Load(object sender, EventArgs e)
        {
            cboSMSFormatSelector.SelectedIndex = 0;
        }
        private void SMSForm_Shown(object sender, EventArgs e)
        {
            SMSBackgroundWorker.RunWorkerAsync();
        }

        private void tbSMSBox_TextChanged(string message)
        {
            if (InvokeRequired)
            {
                //recursive call to switch threads if InvokeRequired
                Invoke(new SMSProvider.SMSReceivedDelegate(tbSMSBox_TextChanged), message);
                return;
            }
            else
            {
                string formattedMessage = smsFormatDelegate(message);
                Output.WriteLine(formattedMessage);
            }
        }

        private void SMSBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SMSProvider.SendSMS(sender as BackgroundWorker, smsInterval: 1500);
        }

        private void SMSBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void SMSBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void tbSMSBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboSMSFormatSelector_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedIndex = cboSMSFormatSelector.SelectedIndex;
            switch (selectedIndex)
            {
                case 1://LowerCase
                    smsFormatDelegate = new SMSFormatDelegate(FormatToLowerCase);
                    break;
                case 2://UpperCase
                    smsFormatDelegate = new SMSFormatDelegate(FormatToUpperCase);
                    break;
                case 3://EndWithDateTime
                    smsFormatDelegate = new SMSFormatDelegate(FormatEndWithDateTime);
                    break;
                case 4://StartWithDateTime
                    smsFormatDelegate = new SMSFormatDelegate(FormatStartWithDateTime);
                    break;
                case 5://Custom
                    smsFormatDelegate = new SMSFormatDelegate(FormatToCustom);
                    break;
                default://None
                    smsFormatDelegate = new SMSFormatDelegate(FormatNone);
                    break;
            }

        }

        private void cboSMSFormatSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
