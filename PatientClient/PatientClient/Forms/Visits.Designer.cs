
namespace PatientClient.Forms
{
    partial class Visits
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
            this.labelPatientUN = new System.Windows.Forms.Label();
            this.labelTimeIn = new System.Windows.Forms.Label();
            this.textBoxPatientUN = new System.Windows.Forms.TextBox();
            this.buttonRegisterTimeIn = new System.Windows.Forms.Button();
            this.dateTimePickerTimeIn = new System.Windows.Forms.DateTimePicker();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCheckPatient = new System.Windows.Forms.Button();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.labelPatientUN.Click += new System.EventHandler(this.labelPatientUN_Click);
            // 
            // labelTimeIn
            // 
            this.labelTimeIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimeIn.AutoSize = true;
            this.labelTimeIn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelTimeIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.labelTimeIn.Location = new System.Drawing.Point(180, 166);
            this.labelTimeIn.Name = "labelTimeIn";
            this.labelTimeIn.Size = new System.Drawing.Size(82, 29);
            this.labelTimeIn.TabIndex = 1;
            this.labelTimeIn.Text = "Time In";
            this.labelTimeIn.Click += new System.EventHandler(this.labelTimeIn_Click);
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
            // buttonRegisterTimeIn
            // 
            this.buttonRegisterTimeIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegisterTimeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.buttonRegisterTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegisterTimeIn.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.buttonRegisterTimeIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRegisterTimeIn.Location = new System.Drawing.Point(185, 245);
            this.buttonRegisterTimeIn.Name = "buttonRegisterTimeIn";
            this.buttonRegisterTimeIn.Size = new System.Drawing.Size(200, 51);
            this.buttonRegisterTimeIn.TabIndex = 4;
            this.buttonRegisterTimeIn.Text = "Register In";
            this.buttonRegisterTimeIn.UseVisualStyleBackColor = false;
            this.buttonRegisterTimeIn.Click += new System.EventHandler(this.buttonRegisterTimeIn_Click);
            // 
            // dateTimePickerTimeIn
            // 
            this.dateTimePickerTimeIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTimeIn.Location = new System.Drawing.Point(185, 198);
            this.dateTimePickerTimeIn.Name = "dateTimePickerTimeIn";
            this.dateTimePickerTimeIn.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTimeIn.TabIndex = 5;
            this.dateTimePickerTimeIn.ValueChanged += new System.EventHandler(this.dateTimePickerTimeIn_ValueChanged);
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelBackground.Controls.Add(this.dataGridView1);
            this.panelBackground.Controls.Add(this.buttonCheckPatient);
            this.panelBackground.Controls.Add(this.labelPatientUN);
            this.panelBackground.Controls.Add(this.buttonRegisterTimeIn);
            this.panelBackground.Controls.Add(this.dateTimePickerTimeIn);
            this.panelBackground.Controls.Add(this.textBoxPatientUN);
            this.panelBackground.Controls.Add(this.labelTimeIn);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(800, 450);
            this.panelBackground.TabIndex = 6;
            this.panelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackground_Paint);
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
            this.Patient});
            this.dataGridView1.Location = new System.Drawing.Point(422, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(200, 98);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Patient
            // 
            this.Patient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Patient.HeaderText = "Patient";
            this.Patient.MinimumWidth = 6;
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            this.Patient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonCheckPatient
            // 
            this.buttonCheckPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCheckPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(111)))), ((int)(((byte)(248)))));
            this.buttonCheckPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCheckPatient.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.buttonCheckPatient.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCheckPatient.Location = new System.Drawing.Point(422, 127);
            this.buttonCheckPatient.Name = "buttonCheckPatient";
            this.buttonCheckPatient.Size = new System.Drawing.Size(200, 51);
            this.buttonCheckPatient.TabIndex = 7;
            this.buttonCheckPatient.Text = "Check";
            this.buttonCheckPatient.UseVisualStyleBackColor = false;
            this.buttonCheckPatient.Click += new System.EventHandler(this.buttonCheckPatient_Click);
            // 
            // Visits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackground);
            this.Name = "Visits";
            this.Text = "Visits";
            this.Load += new System.EventHandler(this.Visits_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPatientUN;
        private System.Windows.Forms.Label labelTimeIn;
        private System.Windows.Forms.TextBox textBoxPatientUN;
        private System.Windows.Forms.Button buttonRegisterTimeIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeIn;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCheckPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
    }
}