
namespace PatientClient.Forms
{
    partial class VisitsOut
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.dateTimePickerTimeOut = new System.Windows.Forms.DateTimePicker();
            this.labelPatientUN = new System.Windows.Forms.Label();
            this.buttonRegisterTimeOut = new System.Windows.Forms.Button();
            this.textBoxPatientUN = new System.Windows.Forms.TextBox();
            this.labelTimeIn = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelBackground.Controls.Add(this.dateTimePickerTimeOut);
            this.panelBackground.Controls.Add(this.labelPatientUN);
            this.panelBackground.Controls.Add(this.buttonRegisterTimeOut);
            this.panelBackground.Controls.Add(this.textBoxPatientUN);
            this.panelBackground.Controls.Add(this.labelTimeIn);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(800, 450);
            this.panelBackground.TabIndex = 7;
            this.panelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackground_Paint);
            // 
            // dateTimePickerTimeOut
            // 
            this.dateTimePickerTimeOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTimeOut.Location = new System.Drawing.Point(299, 208);
            this.dateTimePickerTimeOut.Name = "dateTimePickerTimeOut";
            this.dateTimePickerTimeOut.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTimeOut.TabIndex = 6;
            this.dateTimePickerTimeOut.ValueChanged += new System.EventHandler(this.dateTimePickerTimeOut_ValueChanged);
            // 
            // labelPatientUN
            // 
            this.labelPatientUN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPatientUN.AutoSize = true;
            this.labelPatientUN.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelPatientUN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.labelPatientUN.Location = new System.Drawing.Point(294, 105);
            this.labelPatientUN.Name = "labelPatientUN";
            this.labelPatientUN.Size = new System.Drawing.Size(217, 29);
            this.labelPatientUN.TabIndex = 0;
            this.labelPatientUN.Text = "Patient Utent Number";
            // 
            // buttonRegisterTimeOut
            // 
            this.buttonRegisterTimeOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegisterTimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.buttonRegisterTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegisterTimeOut.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.buttonRegisterTimeOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRegisterTimeOut.Location = new System.Drawing.Point(299, 255);
            this.buttonRegisterTimeOut.Name = "buttonRegisterTimeOut";
            this.buttonRegisterTimeOut.Size = new System.Drawing.Size(200, 51);
            this.buttonRegisterTimeOut.TabIndex = 4;
            this.buttonRegisterTimeOut.Text = "Register Out";
            this.buttonRegisterTimeOut.UseVisualStyleBackColor = false;
            this.buttonRegisterTimeOut.Click += new System.EventHandler(this.buttonRegisterTimeOut_Click);
            // 
            // textBoxPatientUN
            // 
            this.textBoxPatientUN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPatientUN.Location = new System.Drawing.Point(299, 137);
            this.textBoxPatientUN.Name = "textBoxPatientUN";
            this.textBoxPatientUN.Size = new System.Drawing.Size(200, 22);
            this.textBoxPatientUN.TabIndex = 2;
            this.textBoxPatientUN.TextChanged += new System.EventHandler(this.textBoxPatientUN_TextChanged);
            // 
            // labelTimeIn
            // 
            this.labelTimeIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimeIn.AutoSize = true;
            this.labelTimeIn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelTimeIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.labelTimeIn.Location = new System.Drawing.Point(294, 176);
            this.labelTimeIn.Name = "labelTimeIn";
            this.labelTimeIn.Size = new System.Drawing.Size(95, 29);
            this.labelTimeIn.TabIndex = 1;
            this.labelTimeIn.Text = "Time Out";
            // 
            // VisitsOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackground);
            this.Name = "VisitsOut";
            this.Text = "VisitsOut";
            this.Load += new System.EventHandler(this.VisitsOut_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelPatientUN;
        private System.Windows.Forms.Button buttonRegisterTimeOut;
        private System.Windows.Forms.TextBox textBoxPatientUN;
        private System.Windows.Forms.Label labelTimeIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeOut;
    }
}