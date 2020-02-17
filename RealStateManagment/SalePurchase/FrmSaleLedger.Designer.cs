namespace RealStateManagment.SalePurchase
{
    partial class FrmSaleLedger
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCnic = new System.Windows.Forms.MaskedTextBox();
            this.txtContractNo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(755, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 24);
            this.button1.TabIndex = 64;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Firebrick;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(388, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 24);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(40, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Contract No:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSale);
            this.panel1.Location = new System.Drawing.Point(3, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 319);
            this.panel1.TabIndex = 60;
            // 
            // dgvSale
            // 
            this.dgvSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSale.Location = new System.Drawing.Point(0, 0);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.Size = new System.Drawing.Size(898, 319);
            this.dgvSale.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(40, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 75;
            this.label13.Text = "Client Cnic:";
            // 
            // txtCnic
            // 
            this.txtCnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCnic.Location = new System.Drawing.Point(144, 85);
            this.txtCnic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCnic.Mask = "00000-0000000-0";
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(184, 22);
            this.txtCnic.TabIndex = 74;
            this.txtCnic.Leave += new System.EventHandler(this.txtCnic_Leave);
            // 
            // txtContractNo
            // 
            this.txtContractNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtContractNo.FormattingEnabled = true;
            this.txtContractNo.Location = new System.Drawing.Point(144, 115);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.Size = new System.Drawing.Size(238, 24);
            this.txtContractNo.TabIndex = 76;
            // 
            // FrmSaleLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 500);
            this.Controls.Add(this.txtContractNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Name = "FrmSaleLedger";
            this.Text = "Sale Ledger";
            this.Load += new System.EventHandler(this.FrmSaleLedger_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtCnic;
        private System.Windows.Forms.ComboBox txtContractNo;
    }
}