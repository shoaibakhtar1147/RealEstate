using RealStateManagment.Accounts;
using RealStateManagment.ColonyManagement;
using RealStateManagment.Customer;
using RealStateManagment.SalePurchase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealStateManagment
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowForm((new Dashboard()));
           
        }

        private void ShowForm(Form frm)
        {
            if (pnlmain.Controls.Count > 0)
            {
                pnlmain.Controls.Clear();
            }
            
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(frm);
            frm.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                    }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ShowForm((new CustomerMain()));
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ShowForm((new Dashboard()));
        }

      
        

      
        private void btnCustomer_Click_2(object sender, EventArgs e)
        {
            ShowForm((new CustomerMain()));

        }

        private void btnLogOff_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnColony_Click(object sender, EventArgs e)
        {
            ShowForm((new FrmColony()));
        }

        private void btnSalePurchase_Click(object sender, EventArgs e)
        {
            ShowForm((new FrmSaleMain()));
           
        }

        private void btnAccounts_Click_1(object sender, EventArgs e)
        {
            ShowForm((new FrmAccountMain()));
        }

      
    }
}
