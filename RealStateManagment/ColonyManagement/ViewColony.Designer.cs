namespace RealStateManagment.ColonyManagement
{
    partial class ViewColony
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTestname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvColony = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColony)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(40, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Colony name:";
            // 
            // txtTestname
            // 
            this.txtTestname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTestname.Location = new System.Drawing.Point(144, 116);
            this.txtTestname.Name = "txtTestname";
            this.txtTestname.Size = new System.Drawing.Size(282, 22);
            this.txtTestname.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvColony);
            this.panel1.Location = new System.Drawing.Point(3, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 319);
            this.panel1.TabIndex = 47;
            // 
            // dgvColony
            // 
            this.dgvColony.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColony.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColony.Location = new System.Drawing.Point(0, 0);
            this.dgvColony.Name = "dgvColony";
            this.dgvColony.Size = new System.Drawing.Size(898, 319);
            this.dgvColony.TabIndex = 0;
            // 
            // ViewColony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTestname);
            this.Controls.Add(this.panel1);
            this.Name = "ViewColony";
            this.Text = "View Colony";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColony)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTestname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvColony;
    }
}