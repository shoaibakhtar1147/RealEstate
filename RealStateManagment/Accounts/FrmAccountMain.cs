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
    public partial class FrmAccountMain : Form
    {
        public FrmAccountMain()
        {
            InitializeComponent();
        }

        private void FrmAccountMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddPartner objPart = new FrmAddPartner();
            objPart.ShowDialog();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            FrmViewPartner objView = new FrmViewPartner();
            objView.ShowDialog();
        }

        private void btnCustomerLedger_Click(object sender, EventArgs e)
        {
            PartnerLedger objled = new PartnerLedger();
            objled.ShowDialog();
        }
    }
}
