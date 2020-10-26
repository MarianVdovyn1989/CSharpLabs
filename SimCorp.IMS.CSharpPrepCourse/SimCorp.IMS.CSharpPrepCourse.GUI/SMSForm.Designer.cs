namespace SimCorp.IMS.CSharpPrepCourse.GUI
{
    partial class SMSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSMSBox = new System.Windows.Forms.RichTextBox();
            this.SMSBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.cboSMSFormatSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbSMSBox
            // 
            this.tbSMSBox.Location = new System.Drawing.Point(12, 129);
            this.tbSMSBox.Name = "tbSMSBox";
            this.tbSMSBox.ReadOnly = true;
            this.tbSMSBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbSMSBox.Size = new System.Drawing.Size(677, 309);
            this.tbSMSBox.TabIndex = 0;
            this.tbSMSBox.Text = "";
            this.tbSMSBox.TextChanged += new System.EventHandler(this.tbSMSBox_TextChanged);
            // 
            // SMSBackgroundWorker
            // 
            this.SMSBackgroundWorker.WorkerSupportsCancellation = true;
            this.SMSBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SMSBackgroundWorker_DoWork);
            this.SMSBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.SMSBackgroundWorker_ProgressChanged);
            this.SMSBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SMSBackgroundWorker_RunWorkerCompleted);
            // 
            // cboSMSFormatSelector
            // 
            this.cboSMSFormatSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSMSFormatSelector.FormattingEnabled = true;
            this.cboSMSFormatSelector.Items.AddRange(new object[] {
            "None",
            "LowerCase",
            "UpperCase",
            "End with DateTime",
            "Start with DateTime",
            "Custom"});
            this.cboSMSFormatSelector.Location = new System.Drawing.Point(12, 13);
            this.cboSMSFormatSelector.Name = "cboSMSFormatSelector";
            this.cboSMSFormatSelector.Size = new System.Drawing.Size(220, 21);
            this.cboSMSFormatSelector.TabIndex = 1;
            this.cboSMSFormatSelector.SelectedIndexChanged += new System.EventHandler(this.cboSMSFormatSelector_SelectedIndexChanged);
            this.cboSMSFormatSelector.SelectionChangeCommitted += new System.EventHandler(this.cboSMSFormatSelector_SelectionChangeCommitted);
            // 
            // SMSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.cboSMSFormatSelector);
            this.Controls.Add(this.tbSMSBox);
            this.Name = "SMSForm";
            this.Text = "SMS Form";
            this.Load += new System.EventHandler(this.SMSForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbSMSBox;
        private System.ComponentModel.BackgroundWorker SMSBackgroundWorker;
        private System.Windows.Forms.ComboBox cboSMSFormatSelector;
    }
}