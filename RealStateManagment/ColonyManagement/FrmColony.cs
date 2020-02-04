using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealStateManagment.ColonyManagement
{
    public partial class FrmColony : Form
    {
        public FrmColony()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddColony obj = new FrmAddColony();
            obj.ShowDialog();
        }

        private void btnCustomerLedger_Click(object sender, EventArgs e)
        {
            ViewColony obj = new ViewColony();
            obj.ShowDialog();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            FrmAddPlot objPlot = new FrmAddPlot();
            objPlot.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewPlot objView = new ViewPlot();
            objView.ShowDialog();
        }
    }
}
