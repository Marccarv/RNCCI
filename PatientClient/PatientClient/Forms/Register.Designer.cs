
namespace PatientClient.Forms
{
    partial class Register
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
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelregisterCenter = new System.Windows.Forms.Panel();
            this.textBoxUtentNumber = new System.Windows.Forms.TextBox();
            this.labelUtentNumber = new System.Windows.Forms.Label();
            this.dateTimePickerCurrentDay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelCurrentDay = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelRNCCI = new System.Windows.Forms.Label();
            this.comboBoxRNCCI = new System.Windows.Forms.ComboBox();
            this.panelregisterCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxContact
            // 
            this.textBoxContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.textBoxContact.Location = new System.Drawing.Point(172, 180);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(200, 26);
            this.textBoxContact.TabIndex = 25;
            this.textBoxContact.TextChanged += new System.EventHandler(this.textBoxContact_TextChanged);
            // 
            // labelContact
            // 
            this.labelContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.labelContact.Location = new System.Drawing.Point(167, 148);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(79, 29);
            this.labelContact.TabIndex = 20;
            this.labelContact.Text = "Contact";
            this.labelContact.Click += new System.EventHandler(this.labelContact_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegister.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.buttonRegister.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRegister.Location = new System.Drawing.Point(441, 331);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(200, 51);
            this.buttonRegister.TabIndex = 19;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.textBoxUsername.Location = new System.Drawing.Point(172, 100);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 26);
            this.textBoxUsername.TabIndex = 18;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.labelUsername.Location = new System.Drawing.Point(169, 68);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(69, 29);
            this.labelUsername.TabIndex = 17;
            this.labelUsername.Text = "Name";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // panelregisterCenter
            // 
            this.panelregisterCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelregisterCenter.Controls.Add(this.textBoxUtentNumber);
            this.panelregisterCenter.Controls.Add(this.labelUtentNumber);
            this.panelregisterCenter.Controls.Add(this.comboBoxRNCCI);
            this.panelregisterCenter.Controls.Add(this.dateTimePickerCurrentDay);
            this.panelregisterCenter.Controls.Add(this.dateTimePickerBirthday);
            this.panelregisterCenter.Controls.Add(this.textBoxAddress);
            this.panelregisterCenter.Controls.Add(this.textBoxContact);
            this.panelregisterCenter.Controls.Add(this.labelCurrentDay);
            this.panelregisterCenter.Controls.Add(this.labelBirthday);
            this.panelregisterCenter.Controls.Add(this.labelAddress);
            this.panelregisterCenter.Controls.Add(this.labelRNCCI);
            this.panelregisterCenter.Controls.Add(this.labelContact);
            this.panelregisterCenter.Controls.Add(this.buttonRegister);
            this.panelregisterCenter.Controls.Add(this.textBoxUsername);
            this.panelregisterCenter.Controls.Add(this.labelUsername);
            this.panelregisterCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelregisterCenter.Location = new System.Drawing.Point(0, 0);
            this.panelregisterCenter.Name = "panelregisterCenter";
            this.panelregisterCenter.Size = new System.Drawing.Size(800, 450);
            this.panelregisterCenter.TabIndex = 3;
            this.panelregisterCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelregisterCenter_Paint);
            // 
            // textBoxUtentNumber
            // 
            this.textBoxUtentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUtentNumber.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUtentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUtentNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.textBoxUtentNumber.Location = new System.Drawing.Point(441, 100);
            this.textBoxUtentNumber.Name = "textBoxUtentNumber";
            this.textBoxUtentNumber.Size = new System.Drawing.Size(200, 26);
            this.textBoxUtentNumber.TabIndex = 32;
            this.textBoxUtentNumber.TextChanged += new System.EventHandler(this.textBoxUtentNumber_TextChanged);
            // 
            // labelUtentNumber
            // 
            this.labelUtentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUtentNumber.AutoSize = true;
            this.labelUtentNumber.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelUtentNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.labelUtentNumber.Location = new System.Drawing.Point(436, 68);
            this.labelUtentNumber.Name = "labelUtentNumber";
            this.labelUtentNumber.Size = new System.Drawing.Size(145, 29);
            this.labelUtentNumber.TabIndex = 31;
            this.labelUtentNumber.Text = "Utent Number";
            this.labelUtentNumber.Click += new System.EventHandler(this.labelUtentNumber_Click);
            // 
            // dateTimePickerCurrentDay
            // 
            this.dateTimePickerCurrentDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerCurrentDay.CalendarFont = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F);
            this.dateTimePickerCurrentDay.Location = new System.Drawing.Point(441, 262);
            this.dateTimePickerCurrentDay.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerCurrentDay.MinDate = new System.DateTime(2021, 12, 30, 0, 0, 0, 0);
            this.dateTimePickerCurrentDay.Name = "dateTimePickerCurrentDay";
            this.dateTimePickerCurrentDay.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCurrentDay.TabIndex = 29;
            this.dateTimePickerCurrentDay.ValueChanged += new System.EventHandler(this.dateTimePickerCurrentDay_ValueChanged);
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerBirthday.CalendarFont = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F);
            this.dateTimePickerBirthday.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(441, 180);
            this.dateTimePickerBirthday.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBirthday.TabIndex = 28;
            this.dateTimePickerBirthday.ValueChanged += new System.EventHandler(this.dateTimePickerBirthday_ValueChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.textBoxAddress.Location = new System.Drawing.Point(172, 331);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(200, 51);
            this.textBoxAddress.TabIndex = 27;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // labelCurrentDay
            // 
            this.labelCurrentDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrentDay.AutoSize = true;
            this.labelCurrentDay.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelCurrentDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.labelCurrentDay.Location = new System.Drawing.Point(436, 230);
            this.labelCurrentDay.Name = "labelCurrentDay";
            this.labelCurrentDay.Size = new System.Drawing.Size(125, 29);
            this.labelCurrentDay.TabIndex = 24;
            this.labelCurrentDay.Text = "Current Day";
            this.labelCurrentDay.Click += new System.EventHandler(this.labelCurrentDay_Click);
            // 
            // labelBirthday
            // 
            this.labelBirthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.labelBirthday.Location = new System.Drawing.Point(436, 148);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(94, 29);
            this.labelBirthday.TabIndex = 23;
            this.labelBirthday.Text = "Birthday";
            this.labelBirthday.Click += new System.EventHandler(this.labelBirthday_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.labelAddress.Location = new System.Drawing.Point(169, 299);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(90, 29);
            this.labelAddress.TabIndex = 22;
            this.labelAddress.Text = "Address";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // labelRNCCI
            // 
            this.labelRNCCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRNCCI.AutoSize = true;
            this.labelRNCCI.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelRNCCI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.labelRNCCI.Location = new System.Drawing.Point(169, 230);
            this.labelRNCCI.Name = "labelRNCCI";
            this.labelRNCCI.Size = new System.Drawing.Size(71, 29);
            this.labelRNCCI.TabIndex = 21;
            this.labelRNCCI.Text = "RNCCI";
            this.labelRNCCI.Click += new System.EventHandler(this.labelRNCCI_Click);
            // 
            // comboBoxRNCCI
            // 
            this.comboBoxRNCCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRNCCI.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxRNCCI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRNCCI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxRNCCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.comboBoxRNCCI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(155)))), ((int)(((byte)(79)))));
            this.comboBoxRNCCI.FormattingEnabled = true;
            this.comboBoxRNCCI.Items.AddRange(new object[] {
            "IPP Braga",
            "ULDM Braga",
            "UMDR Braga",
            "IPP Famalicão",
            "UC Famalicão",
            "UMDR Famalicão",
            "IPP Lisboa",
            "ULDM Lisboa",
            "UC Porto",
            "UMDR Porto",
            "UC Póvoa de Lanhoso",
            "ULDM Póvoa de Lanhoso"});
            this.comboBoxRNCCI.Location = new System.Drawing.Point(172, 262);
            this.comboBoxRNCCI.Name = "comboBoxRNCCI";
            this.comboBoxRNCCI.Size = new System.Drawing.Size(200, 28);
            this.comboBoxRNCCI.TabIndex = 30;
            this.comboBoxRNCCI.SelectedIndexChanged += new System.EventHandler(this.comboBoxRNCCI_SelectedIndexChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelregisterCenter);
            this.Name = "Register";
            this.Text = "Register";
            this.panelregisterCenter.ResumeLayout(false);
            this.panelregisterCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelregisterCenter;
        private System.Windows.Forms.DateTimePicker dateTimePickerCurrentDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelCurrentDay;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelRNCCI;
        protected internal System.Windows.Forms.TextBox textBoxUsername;
        protected internal System.Windows.Forms.TextBox textBoxUtentNumber;
        private System.Windows.Forms.Label labelUtentNumber;
        private System.Windows.Forms.ComboBox comboBoxRNCCI;
    }
}