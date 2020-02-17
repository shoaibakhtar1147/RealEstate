namespace RealStateManagment.SalePurchase
{
    partial class FrmSaleInstallment
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
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRemainInstall = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtContractId = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPlotNo = new System.Windows.Forms.TextBox();
            this.txtColonyName = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCnic = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoInstallment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.txtPayment);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtRemainInstall);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtContractId);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtPlotNo);
            this.groupBox1.Controls.Add(this.txtColonyName);
            this.groupBox1.Controls.Add(this.txtClientName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCnic);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMonthlyPayment);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDownPayment);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNoInstallment);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
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
            this.groupBox1.Size = new System.Drawing.Size(824, 392);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installment Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBalance.Location = new System.Drawing.Point(546, 301);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(91, 24);
            this.lblBalance.TabIndex = 88;
            this.lblBalance.Text = "Balance:";
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPayment.Location = new System.Drawing.Point(549, 208);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(184, 22);
            this.txtPayment.TabIndex = 86;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            this.txtPayment.Leave += new System.EventHandler(this.txtPayment_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(431, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 87;
            this.label15.Text = "Payment:";
            // 
            // txtRemainInstall
            // 
            this.txtRemainInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtRemainInstall.Location = new System.Drawing.Point(169, 256);
            this.txtRemainInstall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemainInstall.Name = "txtRemainInstall";
            this.txtRemainInstall.Size = new System.Drawing.Size(184, 22);
            this.txtRemainInstall.TabIndex = 85;
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSize.Location = new System.Drawing.Point(550, 127);
            this.txtSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(184, 22);
            this.txtSize.TabIndex = 84;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(438, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 83;
            this.label14.Text = "Size:";
            // 
            // txtContractId
            // 
            this.txtContractId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtContractId.FormattingEnabled = true;
            this.txtContractId.Location = new System.Drawing.Point(550, 42);
            this.txtContractId.Name = "txtContractId";
            this.txtContractId.Size = new System.Drawing.Size(184, 24);
            this.txtContractId.TabIndex = 3;
            this.txtContractId.SelectedIndexChanged += new System.EventHandler(this.txtContractId_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Firebrick;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(371, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 22);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "***";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPlotNo
            // 
            this.txtPlotNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPlotNo.Location = new System.Drawing.Point(549, 88);
            this.txtPlotNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlotNo.Name = "txtPlotNo";
            this.txtPlotNo.Size = new System.Drawing.Size(184, 22);
            this.txtPlotNo.TabIndex = 78;
            // 
            // txtColonyName
            // 
            this.txtColonyName.Enabled = false;
            this.txtColonyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtColonyName.Location = new System.Drawing.Point(169, 127);
            this.txtColonyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColonyName.Name = "txtColonyName";
            this.txtColonyName.Size = new System.Drawing.Size(184, 22);
            this.txtColonyName.TabIndex = 77;
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtClientName.Location = new System.Drawing.Point(169, 88);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(184, 22);
            this.txtClientName.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(21, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 73;
            this.label13.Text = "Client Cnic:";
            // 
            // txtCnic
            // 
            this.txtCnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCnic.Location = new System.Drawing.Point(169, 42);
            this.txtCnic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCnic.Mask = "00000-0000000-0";
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(184, 22);
            this.txtCnic.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(431, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 70;
            this.label12.Text = "Balance:";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(169, 295);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(184, 22);
            this.txtDate.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(21, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 68;
            this.label11.Text = "Date:";
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMonthlyPayment.Location = new System.Drawing.Point(550, 259);
            this.txtMonthlyPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.Size = new System.Drawing.Size(184, 22);
            this.txtMonthlyPayment.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(431, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "Monthly Payment:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(21, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "Remaining Installment:";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDownPayment.Location = new System.Drawing.Point(169, 343);
            this.txtDownPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(184, 22);
            this.txtDownPayment.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(21, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Down Payment:";
            // 
            // txtNoInstallment
            // 
            this.txtNoInstallment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNoInstallment.FormattingEnabled = true;
            this.txtNoInstallment.Items.AddRange(new object[] {
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
            this.txtNoInstallment.Location = new System.Drawing.Point(169, 206);
            this.txtNoInstallment.Name = "txtNoInstallment";
            this.txtNoInstallment.Size = new System.Drawing.Size(184, 24);
            this.txtNoInstallment.TabIndex = 4;
            this.txtNoInstallment.SelectedIndexChanged += new System.EventHandler(this.txtNoInstallment_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(21, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "No of Installment:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTotalAmount.Location = new System.Drawing.Point(169, 167);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(184, 22);
            this.txtTotalAmount.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(431, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Contract No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(21, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 56;
            this.label9.Text = "Total Amont::";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtArea.Location = new System.Drawing.Point(549, 167);
            this.txtArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(184, 22);
            this.txtArea.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(437, 170);
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
            this.label4.Location = new System.Drawing.Point(21, 130);
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
            this.label2.Location = new System.Drawing.Point(437, 94);
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
            this.label1.Location = new System.Drawing.Point(21, 94);
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
            this.btnClear.Location = new System.Drawing.Point(637, 484);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 41);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Firebrick;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(434, 484);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 41);
            this.btnSave.TabIndex = 3;
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
            this.btnAddNew.Location = new System.Drawing.Point(234, 484);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(180, 41);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // FrmSaleInstallment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 557);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSaleInstallment";
            this.Text = "Installment";
            this.Load += new System.EventHandler(this.FrmSaleInstallment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPlotNo;
        private System.Windows.Forms.TextBox txtColonyName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtCnic;
        private System.Windows.Forms.ComboBox txtContractId;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox txtNoInstallment;
        private System.Windows.Forms.TextBox txtRemainInstall;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label15;
    }
}