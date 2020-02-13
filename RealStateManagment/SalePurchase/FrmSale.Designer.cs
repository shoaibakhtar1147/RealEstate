namespace RealStateManagment.SalePurchase
{
    partial class FrmSale
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtColonyName = new System.Windows.Forms.ComboBox();
            this.txtContractID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDownPayment = new System.Windows.Forms.CheckBox();
            this.cmbDownPayment = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtPayDate = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonths = new System.Windows.Forms.ComboBox();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdInstallment = new System.Windows.Forms.RadioButton();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.rdCash = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.ComboBox();
            this.txtBuyDate = new System.Windows.Forms.DateTimePicker();
            this.txtPlotNo = new System.Windows.Forms.ComboBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtColonyName);
            this.groupBox1.Controls.Add(this.txtContractID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rdInstallment);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.rdCash);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtClientName);
            this.groupBox1.Controls.Add(this.txtBuyDate);
            this.groupBox1.Controls.Add(this.txtPlotNo);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(109, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(818, 474);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Information";
            // 
            // txtColonyName
            // 
            this.txtColonyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonyName.FormattingEnabled = true;
            this.txtColonyName.Location = new System.Drawing.Point(145, 154);
            this.txtColonyName.Name = "txtColonyName";
            this.txtColonyName.Size = new System.Drawing.Size(228, 23);
            this.txtColonyName.TabIndex = 77;
            this.txtColonyName.SelectedIndexChanged += new System.EventHandler(this.txtColonyName_SelectedIndexChanged_1);
            this.txtColonyName.Leave += new System.EventHandler(this.txtColonyName_Leave);
            // 
            // txtContractID
            // 
            this.txtContractID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractID.FormattingEnabled = true;
            this.txtContractID.Location = new System.Drawing.Point(145, 198);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.Size = new System.Drawing.Size(228, 23);
            this.txtContractID.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(424, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "Date Buy:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDownPayment);
            this.groupBox2.Controls.Add(this.cmbDownPayment);
            this.groupBox2.Controls.Add(this.txtYears);
            this.groupBox2.Controls.Add(this.txtPayDate);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDownPayment);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMonths);
            this.groupBox2.Controls.Add(this.txtMonthlyPayment);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 193);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // chkDownPayment
            // 
            this.chkDownPayment.AutoSize = true;
            this.chkDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkDownPayment.Location = new System.Drawing.Point(19, 85);
            this.chkDownPayment.Name = "chkDownPayment";
            this.chkDownPayment.Size = new System.Drawing.Size(117, 20);
            this.chkDownPayment.TabIndex = 77;
            this.chkDownPayment.Text = "DownPayment:";
            this.chkDownPayment.UseVisualStyleBackColor = true;
            this.chkDownPayment.CheckedChanged += new System.EventHandler(this.chkDownPayment_CheckedChanged);
            // 
            // cmbDownPayment
            // 
            this.cmbDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbDownPayment.Location = new System.Drawing.Point(142, 83);
            this.cmbDownPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDownPayment.Name = "cmbDownPayment";
            this.cmbDownPayment.Size = new System.Drawing.Size(148, 22);
            this.cmbDownPayment.TabIndex = 76;
            this.cmbDownPayment.TextChanged += new System.EventHandler(this.cmbDownPayment_TextChanged_1);
            // 
            // txtYears
            // 
            this.txtYears.Enabled = false;
            this.txtYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtYears.Location = new System.Drawing.Point(296, 37);
            this.txtYears.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(74, 22);
            this.txtYears.TabIndex = 73;
            // 
            // txtPayDate
            // 
            this.txtPayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayDate.FormattingEnabled = true;
            this.txtPayDate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.txtPayDate.Location = new System.Drawing.Point(142, 130);
            this.txtPayDate.Name = "txtPayDate";
            this.txtPayDate.Size = new System.Drawing.Size(148, 23);
            this.txtPayDate.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(39, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 72;
            this.label11.Text = "Pay Date:";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBalance.Location = new System.Drawing.Point(509, 127);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(228, 22);
            this.txtBalance.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(395, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Down Payment:";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDownPayment.Location = new System.Drawing.Point(509, 83);
            this.txtDownPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(228, 22);
            this.txtDownPayment.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(395, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 70;
            this.label12.Text = "Balance:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(38, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "No of  Months:";
            // 
            // txtMonths
            // 
            this.txtMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMonths.FormattingEnabled = true;
            this.txtMonths.Items.AddRange(new object[] {
            "6",
            "12",
            "18",
            "24",
            "30",
            "36",
            "42",
            "48",
            "54",
            "60",
            "66",
            "72",
            "78",
            "84",
            "90",
            "96",
            "102",
            "108",
            "114",
            "120"});
            this.txtMonths.Location = new System.Drawing.Point(142, 36);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(148, 24);
            this.txtMonths.TabIndex = 1;
            this.txtMonths.SelectedIndexChanged += new System.EventHandler(this.txtMonths_SelectedIndexChanged);
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMonthlyPayment.Location = new System.Drawing.Point(509, 36);
            this.txtMonthlyPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.Size = new System.Drawing.Size(228, 22);
            this.txtMonthlyPayment.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(395, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "Monthly Payment:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(42, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 56;
            this.label9.Text = "Total Amont::";
            // 
            // rdInstallment
            // 
            this.rdInstallment.AutoSize = true;
            this.rdInstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdInstallment.Location = new System.Drawing.Point(268, 55);
            this.rdInstallment.Name = "rdInstallment";
            this.rdInstallment.Size = new System.Drawing.Size(105, 24);
            this.rdInstallment.TabIndex = 2;
            this.rdInstallment.TabStop = true;
            this.rdInstallment.Text = "Installment";
            this.rdInstallment.UseVisualStyleBackColor = true;
            this.rdInstallment.CheckedChanged += new System.EventHandler(this.rdInstallment_CheckedChanged);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTotalAmount.Location = new System.Drawing.Point(146, 248);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(228, 22);
            this.txtTotalAmount.TabIndex = 59;
            // 
            // rdCash
            // 
            this.rdCash.AutoSize = true;
            this.rdCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdCash.Location = new System.Drawing.Point(145, 55);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(64, 24);
            this.rdCash.TabIndex = 1;
            this.rdCash.TabStop = true;
            this.rdCash.Text = "Cash";
            this.rdCash.UseVisualStyleBackColor = true;
            this.rdCash.CheckedChanged += new System.EventHandler(this.rdCash_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(41, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Contract No:";
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.FormattingEnabled = true;
            this.txtClientName.Location = new System.Drawing.Point(145, 106);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(359, 23);
            this.txtClientName.TabIndex = 3;
            // 
            // txtBuyDate
            // 
            this.txtBuyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBuyDate.Location = new System.Drawing.Point(512, 245);
            this.txtBuyDate.Name = "txtBuyDate";
            this.txtBuyDate.Size = new System.Drawing.Size(228, 22);
            this.txtBuyDate.TabIndex = 69;
            // 
            // txtPlotNo
            // 
            this.txtPlotNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlotNo.FormattingEnabled = true;
            this.txtPlotNo.Location = new System.Drawing.Point(512, 154);
            this.txtPlotNo.Name = "txtPlotNo";
            this.txtPlotNo.Size = new System.Drawing.Size(228, 23);
            this.txtPlotNo.TabIndex = 5;
            this.txtPlotNo.Enter += new System.EventHandler(this.txtPlotNo_Enter);
            this.txtPlotNo.Leave += new System.EventHandler(this.txtPlotNo_Leave);
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtArea.Location = new System.Drawing.Point(512, 199);
            this.txtArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(228, 22);
            this.txtArea.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(423, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Area:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(41, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Colony:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(424, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Plot No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(41, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Firebrick;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(637, 566);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 41);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Firebrick;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(434, 566);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 41);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Firebrick;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(234, 566);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(180, 41);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // FrmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 651);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSale";
            this.Text = "Sale Plots";
            this.Load += new System.EventHandler(this.FrmSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txtBuyDate;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtMonths;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtClientName;
        private System.Windows.Forms.ComboBox txtPlotNo;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.RadioButton rdInstallment;
        private System.Windows.Forms.RadioButton rdCash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtPayDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox cmbDownPayment;
        private System.Windows.Forms.CheckBox chkDownPayment;
        private System.Windows.Forms.ComboBox txtContractID;
        private System.Windows.Forms.ComboBox txtColonyName;
    }
}