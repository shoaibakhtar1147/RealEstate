using MetroFramework.Forms;
using RealStateManagment.BL;
using RealStateManagment.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealStateManagment.Accounts
{
    public partial class PartnerLedger : MetroForm
    {
        public PartnerLedger()
        {
            InitializeComponent();
        }

        private void PartnerLedger_Load(object sender, EventArgs e)
        {
            //LoadData();
            Design.Designform(this);
        }

       


        private void btnSearch_Click(object sender, EventArgs e)
        {
            TransactionBL obj = new TransactionBL()
            {
                Cnic = txtSearch.Text
            };
            var dt = obj.Search();
            if (dt.Count > 0 && dt != null)
            {
                dgvPartner.DataSource = dt;
                this.dgvPartner.Columns["PartnerId"].Visible = false;
                this.dgvPartner.Columns["MobileNo"].Visible = false;
                this.dgvPartner.Columns["PartnerName"].Visible = false;
                this.dgvPartner.Columns["PhoneNo"].Visible = false;
                this.dgvPartner.Columns["FName"].Visible = false;
               

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSearch.Text))
            {
              PartnerTransactionReport objRep = new  PartnerTransactionReport();
                FrmReportViewer objView = new FrmReportViewer();
                objRep.SetParameterValue("@Cnic", txtSearch.Text);
                objView.crptViewer.ReportSource = objRep;
                objView.WindowState = FormWindowState.Maximized;
                objView.ShowDialog();


            }
        }
    }
}
