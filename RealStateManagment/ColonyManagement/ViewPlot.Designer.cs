namespace RealStateManagment.ColonyManagement
{
    partial class ViewPlot
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPlot = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColonyName = new System.Windows.Forms.ComboBox();
            this.txtPlotNo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(42, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Plot No:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPlot);
            this.panel1.Location = new System.Drawing.Point(3, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 319);
            this.panel1.TabIndex = 50;
            // 
            // dgvPlot
            // 
            this.dgvPlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlot.Location = new System.Drawing.Point(0, 0);
            this.dgvPlot.Name = "dgvPlot";
            this.dgvPlot.Size = new System.Drawing.Size(898, 319);
            this.dgvPlot.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(40, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Colony name:";
            // 
            // txtColonyName
            // 
            this.txtColonyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtColonyName.FormattingEnabled = true;
            this.txtColonyName.Location = new System.Drawing.Point(144, 85);
            this.txtColonyName.Name = "txtColonyName";
            this.txtColonyName.Size = new System.Drawing.Size(238, 24);
            this.txtColonyName.TabIndex = 55;
            this.txtColonyName.SelectedIndexChanged += new System.EventHandler(this.txtColonyName_SelectedIndexChanged);
            // 
            // txtPlotNo
            // 
            this.txtPlotNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPlotNo.FormattingEnabled = true;
            this.txtPlotNo.Location = new System.Drawing.Point(144, 115);
            this.txtPlotNo.Name = "txtPlotNo";
            this.txtPlotNo.Size = new System.Drawing.Size(238, 24);
            this.txtPlotNo.TabIndex = 56;
            this.txtPlotNo.SelectedIndexChanged += new System.EventHandler(this.txtPlotNo_SelectedIndexChanged);
            // 
            // ViewPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 500);
            this.Controls.Add(this.txtPlotNo);
            this.Controls.Add(this.txtColonyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewPlot";
            this.Text = "View Plots";
            this.Load += new System.EventHandler(this.ViewPlot_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtColonyName;
        private System.Windows.Forms.ComboBox txtPlotNo;
    }
}