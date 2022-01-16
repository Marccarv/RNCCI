
namespace PatientClient.Forms
{
    partial class VisitsLog
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
            this.buttonCheckLogs = new System.Windows.Forms.Button();
            this.labelPatientUN = new System.Windows.Forms.Label();
            this.textBoxPatientUN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelBackground.Controls.Add(this.dataGridView1);
            this.panelBackground.Controls.Add(this.buttonCheckLogs);
            this.panelBackground.Controls.Add(this.labelPatientUN);
            this.panelBackground.Controls.Add(this.textBoxPatientUN);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(800, 450);
            this.panelBackground.TabIndex = 7;
            // 
            // buttonCheckLogs
            // 
            this.buttonCheckLogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCheckLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.buttonCheckLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCheckLogs.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.buttonCheckLogs.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCheckLogs.Location = new System.Drawing.Point(422, 98);
            this.buttonCheckLogs.Name = "buttonCheckLogs";
            this.buttonCheckLogs.Size = new System.Drawing.Size(200, 51);
            this.buttonCheckLogs.TabIndex = 12;
            this.buttonCheckLogs.Text = "Check";
            this.buttonCheckLogs.UseVisualStyleBackColor = false;
            this.buttonCheckLogs.Click += new System.EventHandler(this.buttonCheckLogs_Click);
            // 
            // labelPatientUN
            // 
            this.labelPatientUN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPatientUN.AutoSize = true;
            this.labelPatientUN.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelPatientUN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.labelPatientUN.Location = new System.Drawing.Point(180, 95);
            this.labelPatientUN.Name = "labelPatientUN";
            this.labelPatientUN.Size = new System.Drawing.Size(217, 29);
            this.labelPatientUN.TabIndex = 0;
            this.labelPatientUN.Text = "Patient Utent Number";
            // 
            // textBoxPatientUN
            // 
            this.textBoxPatientUN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPatientUN.Location = new System.Drawing.Point(185, 127);
            this.textBoxPatientUN.Name = "textBoxPatientUN";
            this.textBoxPatientUN.Size = new System.Drawing.Size(200, 22);
            this.textBoxPatientUN.TabIndex = 2;
            this.textBoxPatientUN.TextChanged += new System.EventHandler(this.textBoxPatientUN_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeIn,
            this.TimeOut});
            this.dataGridView1.Location = new System.Drawing.Point(185, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(437, 208);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TimeIn
            // 
            this.TimeIn.HeaderText = "Time In";
            this.TimeIn.MinimumWidth = 6;
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.ReadOnly = true;
            this.TimeIn.Width = 193;
            // 
            // TimeOut
            // 
            this.TimeOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeOut.HeaderText = "Time Out";
            this.TimeOut.MinimumWidth = 6;
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.ReadOnly = true;
            this.TimeOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VisitsLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackground);
            this.Name = "VisitsLog";
            this.Text = "VisitsLog";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelPatientUN;
        private System.Windows.Forms.TextBox textBoxPatientUN;
        private System.Windows.Forms.Button buttonCheckLogs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOut;
    }
}