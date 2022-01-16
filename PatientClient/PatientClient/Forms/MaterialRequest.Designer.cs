
namespace PatientClient.Forms
{
    partial class MaterialRequest
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
            this.comboBoxMaterialID = new System.Windows.Forms.ComboBox();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.textBoxMaterialAmount = new System.Windows.Forms.TextBox();
            this.labelMaterialAmount = new System.Windows.Forms.Label();
            this.labelMaterialID = new System.Windows.Forms.Label();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.labelRNCCI = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaterialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelBackground.Controls.Add(this.comboBoxMaterialID);
            this.panelBackground.Controls.Add(this.buttonPlaceOrder);
            this.panelBackground.Controls.Add(this.textBoxMaterialAmount);
            this.panelBackground.Controls.Add(this.labelMaterialAmount);
            this.panelBackground.Controls.Add(this.labelMaterialID);
            this.panelBackground.Controls.Add(this.comboBoxUnit);
            this.panelBackground.Controls.Add(this.labelRNCCI);
            this.panelBackground.Controls.Add(this.dataGridView1);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(800, 450);
            this.panelBackground.TabIndex = 8;
            this.panelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackground_Paint);
            // 
            // comboBoxMaterialID
            // 
            this.comboBoxMaterialID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxMaterialID.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxMaterialID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterialID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxMaterialID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.comboBoxMaterialID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.comboBoxMaterialID.FormattingEnabled = true;
            this.comboBoxMaterialID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxMaterialID.Location = new System.Drawing.Point(45, 169);
            this.comboBoxMaterialID.Name = "comboBoxMaterialID";
            this.comboBoxMaterialID.Size = new System.Drawing.Size(200, 28);
            this.comboBoxMaterialID.TabIndex = 42;
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.buttonPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlaceOrder.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.buttonPlaceOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPlaceOrder.Location = new System.Drawing.Point(47, 343);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(200, 51);
            this.buttonPlaceOrder.TabIndex = 41;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = false;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // textBoxMaterialAmount
            // 
            this.textBoxMaterialAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMaterialAmount.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMaterialAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaterialAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.textBoxMaterialAmount.Location = new System.Drawing.Point(47, 259);
            this.textBoxMaterialAmount.Name = "textBoxMaterialAmount";
            this.textBoxMaterialAmount.Size = new System.Drawing.Size(200, 26);
            this.textBoxMaterialAmount.TabIndex = 38;
            this.textBoxMaterialAmount.TextChanged += new System.EventHandler(this.textBoxMaterialAmount_TextChanged);
            // 
            // labelMaterialAmount
            // 
            this.labelMaterialAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMaterialAmount.AutoSize = true;
            this.labelMaterialAmount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelMaterialAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.labelMaterialAmount.Location = new System.Drawing.Point(40, 227);
            this.labelMaterialAmount.Name = "labelMaterialAmount";
            this.labelMaterialAmount.Size = new System.Drawing.Size(171, 29);
            this.labelMaterialAmount.TabIndex = 35;
            this.labelMaterialAmount.Text = "Material Amount";
            // 
            // labelMaterialID
            // 
            this.labelMaterialID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMaterialID.AutoSize = true;
            this.labelMaterialID.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelMaterialID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.labelMaterialID.Location = new System.Drawing.Point(40, 137);
            this.labelMaterialID.Name = "labelMaterialID";
            this.labelMaterialID.Size = new System.Drawing.Size(120, 29);
            this.labelMaterialID.TabIndex = 33;
            this.labelMaterialID.Text = "Material ID";
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUnit.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.comboBoxUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Items.AddRange(new object[] {
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
            this.comboBoxUnit.Location = new System.Drawing.Point(45, 69);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(200, 28);
            this.comboBoxUnit.TabIndex = 32;
            this.comboBoxUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnit_SelectedIndexChanged);
            // 
            // labelRNCCI
            // 
            this.labelRNCCI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRNCCI.AutoSize = true;
            this.labelRNCCI.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelRNCCI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.labelRNCCI.Location = new System.Drawing.Point(42, 37);
            this.labelRNCCI.Name = "labelRNCCI";
            this.labelRNCCI.Size = new System.Drawing.Size(51, 29);
            this.labelRNCCI.TabIndex = 31;
            this.labelRNCCI.Text = "Unit";
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
            this.MaterialID,
            this.MaterialName,
            this.MaterialAmount});
            this.dataGridView1.Location = new System.Drawing.Point(386, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(310, 369);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaterialID
            // 
            this.MaterialID.HeaderText = "ID";
            this.MaterialID.MinimumWidth = 6;
            this.MaterialID.Name = "MaterialID";
            this.MaterialID.ReadOnly = true;
            this.MaterialID.Width = 30;
            // 
            // MaterialName
            // 
            this.MaterialName.HeaderText = "Material";
            this.MaterialName.MinimumWidth = 6;
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            this.MaterialName.Width = 145;
            // 
            // MaterialAmount
            // 
            this.MaterialAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialAmount.HeaderText = "Amount";
            this.MaterialAmount.MinimumWidth = 6;
            this.MaterialAmount.Name = "MaterialAmount";
            this.MaterialAmount.ReadOnly = true;
            // 
            // MaterialRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackground);
            this.Name = "MaterialRequest";
            this.Text = "MaterialRequest";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Label labelRNCCI;
        private System.Windows.Forms.Label labelMaterialID;
        private System.Windows.Forms.Label labelMaterialAmount;
        protected internal System.Windows.Forms.TextBox textBoxMaterialAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialAmount;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.ComboBox comboBoxMaterialID;
    }
}