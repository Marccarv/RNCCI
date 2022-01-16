
namespace PatientClient.Forms
{
    partial class MaterialRequestLog
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
            this.buttonAllResults = new System.Windows.Forms.Button();
            this.labelAllResults = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelBackground.Controls.Add(this.buttonAllResults);
            this.panelBackground.Controls.Add(this.labelAllResults);
            this.panelBackground.Controls.Add(this.dataGridView1);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(800, 450);
            this.panelBackground.TabIndex = 10;
            // 
            // buttonAllResults
            // 
            this.buttonAllResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAllResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.buttonAllResults.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAllResults.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.buttonAllResults.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAllResults.Location = new System.Drawing.Point(41, 71);
            this.buttonAllResults.Name = "buttonAllResults";
            this.buttonAllResults.Size = new System.Drawing.Size(200, 51);
            this.buttonAllResults.TabIndex = 31;
            this.buttonAllResults.Text = "Search";
            this.buttonAllResults.UseVisualStyleBackColor = false;
            this.buttonAllResults.Click += new System.EventHandler(this.buttonAllResults_Click);
            // 
            // labelAllResults
            // 
            this.labelAllResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAllResults.AutoSize = true;
            this.labelAllResults.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F);
            this.labelAllResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.labelAllResults.Location = new System.Drawing.Point(36, 39);
            this.labelAllResults.Name = "labelAllResults";
            this.labelAllResults.Size = new System.Drawing.Size(112, 29);
            this.labelAllResults.TabIndex = 30;
            this.labelAllResults.Text = "All Results";
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
            this.Unit,
            this.MaterialName,
            this.MaterialAmount});
            this.dataGridView1.Location = new System.Drawing.Point(41, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(707, 272);
            this.dataGridView1.TabIndex = 6;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 125;
            // 
            // MaterialName
            // 
            this.MaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialName.HeaderText = "Material";
            this.MaterialName.MinimumWidth = 6;
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // MaterialAmount
            // 
            this.MaterialAmount.HeaderText = "Amount";
            this.MaterialAmount.MinimumWidth = 6;
            this.MaterialAmount.Name = "MaterialAmount";
            this.MaterialAmount.ReadOnly = true;
            this.MaterialAmount.Width = 175;
            // 
            // MaterialRequestLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBackground);
            this.Name = "MaterialRequestLog";
            this.Text = "MaterialRequestLog";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button buttonAllResults;
        private System.Windows.Forms.Label labelAllResults;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialAmount;
    }
}