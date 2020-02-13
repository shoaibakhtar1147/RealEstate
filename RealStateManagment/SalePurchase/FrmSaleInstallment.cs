using MetroFramework.Forms;
using RealStateManagment.BL;
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
    public partial class FrmSaleInstallment : MetroForm
    {
        public FrmSaleInstallment()
        {
            InitializeComponent();
        }

        private void FrmInstallment_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SaleBL obj = new SaleBL() 
            {
            Cnic=txtCnic.Text
            };
            var dt = obj.Search();
            if(dt.Count>0 && dt != null)
            {
                txtContractId.DataSource = dt;
                txtContractId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtContractId.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtContractId.DisplayMember = "ContractId";
                txtContractId.ValueMember = "SaleId";
                
            }
            else
            {
                MessageBox.Show("No record found against Cnic " + txtCnic.Text);
            }
        }

        private void txtContractId_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBalance.Visible = true;
            //SaleBL obj = new SaleBL() 
            //{
            // ContractNo=txtContractId.Text
            //};
            //var dt = obj.Search();
            //if(dt.Count>0 && dt != null)
            //{
                //txtClientName.Text = Convert.ToString(dt[0].ClientName);
                //txtPlotNo.Text = Convert.ToString(dt[0].PlotNo);
                //txtSize.Text = Convert.ToString(dt[0].Size);
                //txtArea.Text = Convert.ToString(dt[0].Area);
                //txtTotalAmount.Text = Convert.ToString(dt[0].AmountOnInstall);
                //txtDownPayment.Text = Convert.ToString(dt[0].DownPayment);
                //txtRemainInstall.Text = Convert.ToString(dt[0].NoOfMonth);
                //txtMonthlyPayment.Text = Convert.ToString(dt[0].MonthlyPayment);
           // }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmSaleInstallment_Load(object sender, EventArgs e)
        {
            FormDisable();
        }

        private void FormDisable()
        {
            txtCnic.Enabled = false;
            btnSearch.Enabled = false;
            txtContractId.Enabled = false;
            txtClientName.Enabled = false;
            txtColonyName.Enabled = false;
            lblBalance.Enabled = false;
            txtArea.Enabled = false;
            txtSize.Enabled = false;
            txtPayment.Enabled = false;
            txtRemainInstall.Enabled = false;
            txtPlotNo.Enabled = false;
            txtTotalAmount.Enabled = false;
            txtNoInstallment.Enabled = false;
            txtMonthlyPayment.Enabled = false;
            txtDownPayment.Enabled = false;
            txtDate.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            lblBalance.Visible = false;
        }

        private void FormEnable()
        {
            txtCnic.Enabled = true;
            btnSearch.Enabled = true;
            txtContractId.Enabled = true;
            txtPayment.Enabled = true;
            txtNoInstallment.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAddNew.Enabled = false;

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormEnable();
        }

        
    }
}
