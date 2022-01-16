
namespace PatientClient.Forms
{
    partial class MaterialHome
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
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.panelBackground.Controls.Add(this.labelVehicles);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(800, 450);
            this.panelBackground.TabIndex = 8;
            // 
            // labelVehicles
            // 
            this.labelVehicles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVehicles.AutoSize = true;
            this.labelVehicles.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 40F);
            this.labelVehicles.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelVehicles.Location = new System.Drawing.Point(277, 146);
            this.labelVehicles.Name = "labelVehicles";
            this.labelVehicles.Size = new System.Drawing.Size(253, 80);
            this.labelVehicles.TabIndex = 1;
            this.labelVehicles.Text = "Material";
            this.labelVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaterialHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackground);
            this.Name = "MaterialHome";
            this.Text = "MaterialHome";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelVehicles;
    }
}