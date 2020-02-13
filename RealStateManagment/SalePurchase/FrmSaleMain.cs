using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealStateManagment.SalePurchase
{
    public partial class FrmSaleMain : Form
    {
        public FrmSaleMain()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmSale objSale = new FrmSale();
            objSale.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSaleInstallment obj = new FrmSaleInstallment();
            obj.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new FrmSaleLedger()).ShowDialog();
        }

        private void btnCustomerLedger_Click(object sender, EventArgs e)
        {
            (new FrmSaleView()).ShowDialog();
        }
    }
}
