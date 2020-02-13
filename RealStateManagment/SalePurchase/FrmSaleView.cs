using MetroFramework.Forms;
using RealStateManagment.BL;
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
    public partial class FrmSaleView : MetroForm
    {
        public FrmSaleView()
        {
            InitializeComponent();
        }

        private void FrmSaleView_Load(object sender, EventArgs e)
        {
            Design.Designform(this);
        
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SaleBL objSearch = new SaleBL() 
            {
            ContractNo=txtSearch.Text
            };
            var dt = objSearch.Search();
            if(dt.Count>0 && dt != null)
            {
                dgvSale.DataSource = dt;
                this.dgvSale.Columns["SaleId"].Visible = false;
                this.dgvSale.Columns["ContractId"].Visible = false;
                this.dgvSale.Columns["FName"].Visible = false;
                this.dgvSale.Columns["MobNo"].Visible = false;
                this.dgvSale.Columns["ColonyId"].Visible = false;
                this.dgvSale.Columns["PlotId"].Visible = false;
                this.dgvSale.Columns["ContractId"].Visible = false;
            }
            else
            {
                MessageBox.Show("No record found against Contract Id " + txtSearch.Text);
            }
        }

        
    }
}
