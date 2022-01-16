
namespace PatientClient.Forms
{
    partial class VehicleHome
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
            this.labelVehicles = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.panelBackground.Controls.Add(this.labelVehicles);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(800, 450);
            this.panelBackground.TabIndex = 10;
            // 
            // labelVehicles
            // 
            this.labelVehicles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVehicles.AutoSize = true;
            this.labelVehicles.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 40F);
            this.labelVehicles.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelVehicles.Location = new System.Drawing.Point(279, 157);
            this.labelVehicles.Name = "labelVehicles";
            this.labelVehicles.Size = new System.Drawing.Size(243, 80);
            this.labelVehicles.TabIndex = 0;
            this.labelVehicles.Text = "Vehicles";
            this.labelVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehicleHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackground);
            this.Name = "VehicleHome";
            this.Text = "VehicleHome";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelVehicles;
    }
}