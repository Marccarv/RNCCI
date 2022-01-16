
namespace PatientClient.Forms
{
    partial class VehicleRequest
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTeamNumber = new System.Windows.Forms.Label();
            this.textBoxTeamNumber = new System.Windows.Forms.TextBox();
            this.textBoxPlate = new System.Windows.Forms.TextBox();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.labelContact = new System.Windows.Forms.Label();
            this.comboBoxZone = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonZone = new System.Windows.Forms.Button();
            this.labelZone = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelBackground.Controls.Add(this.dateTimePicker1);
            this.panelBackground.Controls.Add(this.labelTeamNumber);
            this.panelBackground.Controls.Add(this.textBoxTeamNumber);
            this.panelBackground.Controls.Add(this.textBoxPlate);
            this.panelBackground.Controls.Add(this.buttonRequest);
            this.panelBackground.Controls.Add(this.labelContact);
            this.panelBackground.Controls.Add(this.comboBoxZone);
            this.panelBackground.Controls.Add(this.dataGridView1);
            this.panelBackground.Controls.Add(this.buttonZone);
            this.panelBackground.Controls.Add(this.labelZone);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(800, 450);
            this.panelBackground.TabIndex = 8;
            this.panelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackground_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(600, 428);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelTeamNumber
            // 
            this.labelTeamNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTeamNumber.AutoSize = true;
            this.labelTeamNumber.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelTeamNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.labelTeamNumber.Location = new System.Drawing.Point(267, 349);
            this.labelTeamNumber.Name = "labelTeamNumber";
            this.labelTeamNumber.Size = new System.Drawing.Size(146, 29);
            this.labelTeamNumber.TabIndex = 32;
            this.labelTeamNumber.Text = "Team Number";
            this.labelTeamNumber.Click += new System.EventHandler(this.labelTeamNumber_Click);
            // 
            // textBoxTeamNumber
            // 
            this.textBoxTeamNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTeamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeamNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.textBoxTeamNumber.Location = new System.Drawing.Point(272, 381);
            this.textBoxTeamNumber.Name = "textBoxTeamNumber";
            this.textBoxTeamNumber.Size = new System.Drawing.Size(200, 26);
            this.textBoxTeamNumber.TabIndex = 31;
            this.textBoxTeamNumber.TextChanged += new System.EventHandler(this.textBoxTeamNumber_TextChanged);
            // 
            // textBoxPlate
            // 
            this.textBoxPlate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.textBoxPlate.Location = new System.Drawing.Point(32, 381);
            this.textBoxPlate.Name = "textBoxPlate";
            this.textBoxPlate.Size = new System.Drawing.Size(200, 26);
            this.textBoxPlate.TabIndex = 29;
            this.textBoxPlate.TextChanged += new System.EventHandler(this.textBoxPlate_TextChanged);
            // 
            // buttonRequest
            // 
            this.buttonRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.buttonRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRequest.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.buttonRequest.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRequest.Location = new System.Drawing.Point(539, 356);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(200, 51);
            this.buttonRequest.TabIndex = 28;
            this.buttonRequest.Text = "Request";
            this.buttonRequest.UseVisualStyleBackColor = false;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // labelContact
            // 
            this.labelContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.labelContact.Location = new System.Drawing.Point(27, 349);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(61, 29);
            this.labelContact.TabIndex = 26;
            this.labelContact.Text = "Plate";
            // 
            // comboBoxZone
            // 
            this.comboBoxZone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.comboBoxZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.comboBoxZone.FormattingEnabled = true;
            this.comboBoxZone.Items.AddRange(new object[] {
            "FAMALICAO",
            "POVOA DE LANHOSO",
            "BRAGA",
            "PORTO",
            "LISBOA"});
            this.comboBoxZone.Location = new System.Drawing.Point(32, 52);
            this.comboBoxZone.Name = "comboBoxZone";
            this.comboBoxZone.Size = new System.Drawing.Size(200, 28);
            this.comboBoxZone.TabIndex = 7;
            this.comboBoxZone.SelectedIndexChanged += new System.EventHandler(this.comboBoxZone_SelectedIndexChanged);
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
            this.Brand,
            this.Plate,
            this.Type});
            this.dataGridView1.Location = new System.Drawing.Point(32, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(707, 230);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 150;
            // 
            // Plate
            // 
            this.Plate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Plate.HeaderText = "Plate";
            this.Plate.MinimumWidth = 6;
            this.Plate.Name = "Plate";
            this.Plate.ReadOnly = true;
            this.Plate.Width = 150;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // buttonZone
            // 
            this.buttonZone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.buttonZone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZone.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.buttonZone.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonZone.Location = new System.Drawing.Point(539, 25);
            this.buttonZone.Name = "buttonZone";
            this.buttonZone.Size = new System.Drawing.Size(200, 51);
            this.buttonZone.TabIndex = 5;
            this.buttonZone.Text = "Search";
            this.buttonZone.UseVisualStyleBackColor = false;
            this.buttonZone.Click += new System.EventHandler(this.buttonZone_Click);
            // 
            // labelZone
            // 
            this.labelZone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelZone.AutoSize = true;
            this.labelZone.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.labelZone.Location = new System.Drawing.Point(27, 22);
            this.labelZone.Name = "labelZone";
            this.labelZone.Size = new System.Drawing.Size(59, 29);
            this.labelZone.TabIndex = 3;
            this.labelZone.Text = "Zone";
            this.labelZone.Click += new System.EventHandler(this.labelZone_Click);
            // 
            // VehicleRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackground);
            this.Name = "VehicleRequest";
            this.Text = "VehicleRequest";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelZone;
        private System.Windows.Forms.Button buttonZone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxZone;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.TextBox textBoxPlate;
        private System.Windows.Forms.TextBox textBoxTeamNumber;
        private System.Windows.Forms.Label labelTeamNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}