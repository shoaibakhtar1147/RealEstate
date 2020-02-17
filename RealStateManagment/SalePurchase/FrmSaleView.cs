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

        private void rdCash_CheckedChanged(object sender, EventArgs e)
        {
            dgvSale.DataSource = null;
            SaleBL obj = new SaleBL();
            var dt = obj.Select();
            if(dt.Count>0 && dt != null)
            {
                dgvSale.DataSource = dt;
            }
        }

        private void rdInstallment_CheckedChanged(object sender, EventArgs e)
        {
            dgvSale.DataSource = null;
            SaleInstallmentBL obj = new SaleInstallmentBL();
            var dt = obj.Select();
            if(dt.Count>0 && dt != null)
            {
                dgvSale.DataSource = dt;
                 this.dgvSale.Columns["ISaleId"].Visible = false;
                      this.dgvSale.Columns["ClientId"].Visible = false;
                      this.dgvSale.Columns["ColonyId"].Visible = false;
                      this.dgvSale.Columns["PlotId"].Visible = false;
                      this.dgvSale.Columns["DatOfPay"].Visible = false;
                      this.dgvSale.Columns["Size"].Visible = false;
                      this.dgvSale.Columns["ColonyName"].Visible = false;
                      this.dgvSale.Columns["SaleStatus"].Visible = false;
                      this.dgvSale.Columns["DownPayment"].Visible = false;
                      this.dgvSale.Columns["MobNo"].Visible = false;
                      this.dgvSale.Columns["ClientName"].Visible = false;
                      this.dgvSale.Columns["Area"].Visible = false;
            }
        }

        
    }
}
