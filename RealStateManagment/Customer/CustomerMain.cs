using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealStateManagment.Customer
{
    public partial class CustomerMain : Form
    {
        public CustomerMain()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            
        }

        
        

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            //DisplayForm((new ViewClient()));
            ViewClient objView = new ViewClient();
            objView.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
           // DisplayForm(new AddClient());
            AddClient obj = new AddClient();
            obj.ShowDialog();
        }
        private void DisplayForm(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = false;
            frm.Width = 1000;
            frm.Height = 600;
            frm.ShowDialog();
        }

        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
           // DisplayForm(new CustomerReport());
            CustomerReport objRep = new CustomerReport();
            objRep.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerLedger_Click(object sender, EventArgs e)
        {
           // DisplayForm(new CustomerLedger());
            CustomerLedger objCus = new CustomerLedger();
            objCus.ShowDialog();
        }

        private void CustomerMain_Load(object sender, EventArgs e)
        {

        }
    }
}
