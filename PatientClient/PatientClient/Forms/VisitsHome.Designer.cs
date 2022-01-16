
namespace PatientClient.Forms
{
    partial class VisitsHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitsHome));
            this.panelregisterCenter = new System.Windows.Forms.Panel();
            this.labelVehicles = new System.Windows.Forms.Label();
            this.panelRegisterLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMenuVisitsLog = new System.Windows.Forms.Button();
            this.panelpanelIconTestando = new System.Windows.Forms.Panel();
            this.panelIconRegister = new System.Windows.Forms.Panel();
            this.buttonMenuRegisterOut = new System.Windows.Forms.Button();
            this.buttonMenuRegisterIn = new System.Windows.Forms.Button();
            this.panelregisterCenter.SuspendLayout();
            this.panelRegisterLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelregisterCenter
            // 
            this.panelregisterCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelregisterCenter.Controls.Add(this.labelVehicles);
            this.panelregisterCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelregisterCenter.Location = new System.Drawing.Point(220, 0);
            this.panelregisterCenter.Name = "panelregisterCenter";
            this.panelregisterCenter.Size = new System.Drawing.Size(662, 503);
            this.panelregisterCenter.TabIndex = 5;
            this.panelregisterCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelregisterCenter_Paint);
            // 
            // labelVehicles
            // 
            this.labelVehicles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVehicles.AutoSize = true;
            this.labelVehicles.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 40F);
            this.labelVehicles.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelVehicles.Location = new System.Drawing.Point(235, 181);
            this.labelVehicles.Name = "labelVehicles";
            this.labelVehicles.Size = new System.Drawing.Size(176, 80);
            this.labelVehicles.TabIndex = 1;
            this.labelVehicles.Text = "Visits";
            this.labelVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRegisterLeft
            // 
            this.panelRegisterLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.panelRegisterLeft.Controls.Add(this.panel1);
            this.panelRegisterLeft.Controls.Add(this.buttonMenuVisitsLog);
            this.panelRegisterLeft.Controls.Add(this.panelpanelIconTestando);
            this.panelRegisterLeft.Controls.Add(this.panelIconRegister);
            this.panelRegisterLeft.Controls.Add(this.buttonMenuRegisterOut);
            this.panelRegisterLeft.Controls.Add(this.buttonMenuRegisterIn);
            this.panelRegisterLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRegisterLeft.Location = new System.Drawing.Point(0, 0);
            this.panelRegisterLeft.Name = "panelRegisterLeft";
            this.panelRegisterLeft.Size = new System.Drawing.Size(220, 503);
            this.panelRegisterLeft.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 50);
            this.panel1.TabIndex = 5;
            // 
            // buttonMenuVisitsLog
            // 
            this.buttonMenuVisitsLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenuVisitsLog.FlatAppearance.BorderSize = 0;
            this.buttonMenuVisitsLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuVisitsLog.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F);
            this.buttonMenuVisitsLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMenuVisitsLog.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuVisitsLog.Image")));
            this.buttonMenuVisitsLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuVisitsLog.Location = new System.Drawing.Point(0, 120);
            this.buttonMenuVisitsLog.Name = "buttonMenuVisitsLog";
            this.buttonMenuVisitsLog.Size = new System.Drawing.Size(220, 60);
            this.buttonMenuVisitsLog.TabIndex = 6;
            this.buttonMenuVisitsLog.Text = "         Visits Log";
            this.buttonMenuVisitsLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuVisitsLog.UseVisualStyleBackColor = true;
            this.buttonMenuVisitsLog.Click += new System.EventHandler(this.buttonMenuVisitsLog_Click);
            // 
            // panelpanelIconTestando
            // 
            this.panelpanelIconTestando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.panelpanelIconTestando.Location = new System.Drawing.Point(0, 64);
            this.panelpanelIconTestando.Name = "panelpanelIconTestando";
            this.panelpanelIconTestando.Size = new System.Drawing.Size(5, 50);
            this.panelpanelIconTestando.TabIndex = 1;
            // 
            // panelIconRegister
            // 
            this.panelIconRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.panelIconRegister.Location = new System.Drawing.Point(0, 4);
            this.panelIconRegister.Name = "panelIconRegister";
            this.panelIconRegister.Size = new System.Drawing.Size(5, 50);
            this.panelIconRegister.TabIndex = 0;
            // 
            // buttonMenuRegisterOut
            // 
            this.buttonMenuRegisterOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenuRegisterOut.FlatAppearance.BorderSize = 0;
            this.buttonMenuRegisterOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuRegisterOut.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F);
            this.buttonMenuRegisterOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMenuRegisterOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuRegisterOut.Image")));
            this.buttonMenuRegisterOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuRegisterOut.Location = new System.Drawing.Point(0, 60);
            this.buttonMenuRegisterOut.Name = "buttonMenuRegisterOut";
            this.buttonMenuRegisterOut.Size = new System.Drawing.Size(220, 60);
            this.buttonMenuRegisterOut.TabIndex = 4;
            this.buttonMenuRegisterOut.Text = "         Register OUT";
            this.buttonMenuRegisterOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuRegisterOut.UseVisualStyleBackColor = true;
            this.buttonMenuRegisterOut.Click += new System.EventHandler(this.buttonMenuRegisterOut_Click);
            // 
            // buttonMenuRegisterIn
            // 
            this.buttonMenuRegisterIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenuRegisterIn.FlatAppearance.BorderSize = 0;
            this.buttonMenuRegisterIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuRegisterIn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F);
            this.buttonMenuRegisterIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMenuRegisterIn.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuRegisterIn.Image")));
            this.buttonMenuRegisterIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuRegisterIn.Location = new System.Drawing.Point(0, 0);
            this.buttonMenuRegisterIn.Name = "buttonMenuRegisterIn";
            this.buttonMenuRegisterIn.Size = new System.Drawing.Size(220, 60);
            this.buttonMenuRegisterIn.TabIndex = 3;
            this.buttonMenuRegisterIn.Text = "         Register IN";
            this.buttonMenuRegisterIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenuRegisterIn.UseVisualStyleBackColor = true;
            this.buttonMenuRegisterIn.Click += new System.EventHandler(this.buttonMenuRegisterIn_Click);
            // 
            // VisitsHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.panelregisterCenter);
            this.Controls.Add(this.panelRegisterLeft);
            this.Name = "VisitsHome";
            this.Text = "VisitsHome";
            this.panelregisterCenter.ResumeLayout(false);
            this.panelregisterCenter.PerformLayout();
            this.panelRegisterLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelregisterCenter;
        private System.Windows.Forms.Panel panelRegisterLeft;
        private System.Windows.Forms.Panel panelIconRegister;
        private System.Windows.Forms.Button buttonMenuRegisterOut;
        private System.Windows.Forms.Button buttonMenuRegisterIn;
        private System.Windows.Forms.Panel panelpanelIconTestando;
        private System.Windows.Forms.Label labelVehicles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMenuVisitsLog;
    }
}