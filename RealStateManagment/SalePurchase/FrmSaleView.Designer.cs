namespace RealStateManagment.SalePurchase
{
    partial class FrmSaleView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.rdInstallment = new System.Windows.Forms.RadioButton();
            this.rdCash = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(40, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Contract No:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSearch.Location = new System.Drawing.Point(144, 116);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(228, 22);
            this.txtSearch.TabIndex = 48;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSale);
            this.panel1.Location = new System.Drawing.Point(3, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 319);
            this.panel1.TabIndex = 47;
            // 
            // dgvSale
            // 
            this.dgvSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSale.Location = new System.Drawing.Point(0, 0);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.Size = new System.Drawing.Size(898, 319);
            this.dgvSale.TabIndex = 0;
            // 
            // rdInstallment
            // 
            this.rdInstallment.AutoSize = true;
            this.rdInstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdInstallment.Location = new System.Drawing.Point(267, 75);
            this.rdInstallment.Name = "rdInstallment";
            this.rdInstallment.Size = new System.Drawing.Size(105, 24);
            this.rdInstallment.TabIndex = 51;
            this.rdInstallment.TabStop = true;
            this.rdInstallment.Text = "Installment";
            this.rdInstallment.UseVisualStyleBackColor = true;
            this.rdInstallment.CheckedChanged += new System.EventHandler(this.rdInstallment_CheckedChanged);
            // 
            // rdCash
            // 
            this.rdCash.AutoSize = true;
            this.rdCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdCash.Location = new System.Drawing.Point(144, 75);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(64, 24);
            this.rdCash.TabIndex = 50;
            this.rdCash.TabStop = true;
            this.rdCash.Text = "Cash";
            this.rdCash.UseVisualStyleBackColor = true;
            this.rdCash.CheckedChanged += new System.EventHandler(this.rdCash_CheckedChanged);
            // 
            // FrmSaleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 500);
            this.Controls.Add(this.rdInstallment);
            this.Controls.Add(this.rdCash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSaleView";
            this.Text = "Sale View";
            this.Load += new System.EventHandler(this.FrmSaleView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.RadioButton rdInstallment;
        private System.Windows.Forms.RadioButton rdCash;
    }
}