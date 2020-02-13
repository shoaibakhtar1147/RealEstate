using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealStateManagment.SalePurchase
{
    public partial class FrmSaleLedger : MetroForm
    {
        public FrmSaleLedger()
        {
            InitializeComponent();
        }

        private void FrmSaleLedger_Load(object sender, EventArgs e)
        {
            Design.Designform(this);
        }
    }
}
