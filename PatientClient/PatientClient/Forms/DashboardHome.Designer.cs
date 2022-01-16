
namespace PatientClient.Forms
{
    partial class DashboardHome
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDashboardVisits = new System.Windows.Forms.Button();
            this.buttonDashboardVehicles = new System.Windows.Forms.Button();
            this.buttonDashboardPatients = new System.Windows.Forms.Button();
            this.panelregisterCenter = new System.Windows.Forms.Panel();
            this.labelDashboards = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.panelregisterCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(194)))), ((int)(((byte)(222)))));
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.03883F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.92233F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.03883F));
            this.tableLayoutPanel.Controls.Add(this.buttonDashboardVisits, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonDashboardVehicles, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonDashboardPatients, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 66);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // buttonDashboardVisits
            // 
            this.buttonDashboardVisits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(194)))), ((int)(((byte)(222)))));
            this.buttonDashboardVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDashboardVisits.FlatAppearance.BorderSize = 0;
            this.buttonDashboardVisits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardVisits.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F);
            this.buttonDashboardVisits.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDashboardVisits.Location = new System.Drawing.Point(259, 3);
            this.buttonDashboardVisits.Name = "buttonDashboardVisits";
            this.buttonDashboardVisits.Size = new System.Drawing.Size(281, 60);
            this.buttonDashboardVisits.TabIndex = 0;
            this.buttonDashboardVisits.Text = "Dashboard Visits";
            this.buttonDashboardVisits.UseVisualStyleBackColor = false;
            this.buttonDashboardVisits.Click += new System.EventHandler(this.buttonDashboardVisits_Click_1);
            // 
            // buttonDashboardVehicles
            // 
            this.buttonDashboardVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(194)))), ((int)(((byte)(222)))));
            this.buttonDashboardVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDashboardVehicles.FlatAppearance.BorderSize = 0;
            this.buttonDashboardVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardVehicles.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F);
            this.buttonDashboardVehicles.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDashboardVehicles.Location = new System.Drawing.Point(546, 3);
            this.buttonDashboardVehicles.Name = "buttonDashboardVehicles";
            this.buttonDashboardVehicles.Size = new System.Drawing.Size(251, 60);
            this.buttonDashboardVehicles.TabIndex = 1;
            this.buttonDashboardVehicles.Text = "Dashboard Vehicles";
            this.buttonDashboardVehicles.UseVisualStyleBackColor = false;
            this.buttonDashboardVehicles.Click += new System.EventHandler(this.buttonDashboardVehicles_Click_1);
            // 
            // buttonDashboardPatients
            // 
            this.buttonDashboardPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(194)))), ((int)(((byte)(222)))));
            this.buttonDashboardPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDashboardPatients.FlatAppearance.BorderSize = 0;
            this.buttonDashboardPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardPatients.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F);
            this.buttonDashboardPatients.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDashboardPatients.Location = new System.Drawing.Point(3, 3);
            this.buttonDashboardPatients.Name = "buttonDashboardPatients";
            this.buttonDashboardPatients.Size = new System.Drawing.Size(250, 60);
            this.buttonDashboardPatients.TabIndex = 2;
            this.buttonDashboardPatients.Text = "Dashboard Patients";
            this.buttonDashboardPatients.UseVisualStyleBackColor = false;
            this.buttonDashboardPatients.Click += new System.EventHandler(this.buttonDashboardPatients_Click_1);
            // 
            // panelregisterCenter
            // 
            this.panelregisterCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelregisterCenter.Controls.Add(this.labelDashboards);
            this.panelregisterCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelregisterCenter.Location = new System.Drawing.Point(0, 66);
            this.panelregisterCenter.Name = "panelregisterCenter";
            this.panelregisterCenter.Size = new System.Drawing.Size(800, 384);
            this.panelregisterCenter.TabIndex = 1;
            // 
            // labelDashboards
            // 
            this.labelDashboards.AutoSize = true;
            this.labelDashboards.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 40F);
            this.labelDashboards.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDashboards.Location = new System.Drawing.Point(231, 150);
            this.labelDashboards.Name = "labelDashboards";
            this.labelDashboards.Size = new System.Drawing.Size(335, 80);
            this.labelDashboards.TabIndex = 0;
            this.labelDashboards.Text = "Dashboards";
            // 
            // DashboardHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelregisterCenter);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "DashboardHome";
            this.Text = "DashboardHome";
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelregisterCenter.ResumeLayout(false);
            this.panelregisterCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonDashboardVisits;
        private System.Windows.Forms.Button buttonDashboardVehicles;
        private System.Windows.Forms.Button buttonDashboardPatients;
        private System.Windows.Forms.Panel panelregisterCenter;
        private System.Windows.Forms.Label labelDashboards;
    }
}