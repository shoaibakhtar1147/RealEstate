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
            SaleInstallmentBL obj = new SaleInstallmentBL() 
            {
            Cnic=txtCnic.Text
            };
            var dt = obj.Search();
            if(dt.Count>0 && dt != null)
            {
                txtContractId.DataSource = dt;
                txtContractId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtContractId.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtContractId.DisplayMember = "ContractNo";
                txtContractId.ValueMember = "ISaleId";
                
            }
            else
            {
                MessageBox.Show("No record found against Cnic " + txtCnic.Text);
            }
        }

        private void txtContractId_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBalance.Visible = true;
            SaleInstallmentBL obj = new  SaleInstallmentBL()
            {
                ContractNo = txtContractId.Text
            };
            var dt = obj.Search();
            if (dt.Count > 0 && dt != null)
            {
                txtClientName.Text = Convert.ToString(dt[0].ClientName);
                txtPlotNo.Text = Convert.ToString(dt[0].PlotNo);
                txtSize.Text = Convert.ToString(dt[0].Size);
                txtArea.Text = Convert.ToString(dt[0].Area);
                txtTotalAmount.Text = Convert.ToString(dt[0].AmountOnInstall);
                txtDownPayment.Text = Convert.ToString(dt[0].DownPayment);
                txtRemainInstall.Text = Convert.ToString(dt[0].TotalInstall);
                txtMonthlyPayment.Text = Convert.ToString(dt[0].MonthlyPayment);
                txtColonyName.Text = Convert.ToString(dt[0].ColonyName);
                lblBalance.Text = Convert.ToString(dt[0].Balance);
            }
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

        private void txtNoInstallment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Installment();
        }

        private void Installment()
        {

            SaleInstallmentBL obj = new  SaleInstallmentBL()
            {
                ContractNo = txtContractId.Text
            };
            var dt = obj.Search();
            if (dt.Count > 0 && dt != null)
            {
                txtMonthlyPayment.Text = Convert.ToString(dt[0].MonthlyPayment);
                int NoIstall=Convert.ToInt32(txtNoInstallment.Text);
                if (NoIstall<= 10)
                {
                   
                    decimal val1 = Convert.ToDecimal(txtMonthlyPayment.Text);
                    decimal val2 = Convert.ToDecimal(val1 * NoIstall);
                    txtMonthlyPayment.Text = val2.ToString();
                    int remainIns = Convert.ToInt32(txtRemainInstall.Text);
                    txtRemainInstall.Text = (Convert.ToInt32(remainIns - NoIstall)).ToString();
                   
                }

                
            }
           
           
        }

         private void Balance()
        {
            
                 decimal val = Convert.ToDecimal(lblBalance.Text);
                 decimal val1 = Convert.ToDecimal(txtPayment.Text);
                 decimal val2=Convert.ToDecimal(val - val1); 
             lblBalance.Text = val2.ToString();
            
        }
        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
          

        }


        private void MonthlyInstall()
        {
            int remainIns = Convert.ToInt32(txtRemainInstall.Text);
            decimal val = Convert.ToDecimal(lblBalance.Text);
            txtMonthlyPayment.Text = Convert.ToString(Convert.ToDecimal(val / remainIns));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int val=Convert.ToInt32(txtRemainInstall.Text );
                int val1=Convert.ToInt32(txtNoInstallment.Text);
                int remainInstall=Convert.ToInt32(val - val1);
                MonthlyInstall();
                InstallDetailBL objdetail = new InstallDetailBL() 
                {
                 Balance=Convert.ToDecimal(lblBalance.Text),
                  InstallmentDate=Convert.ToDateTime(txtDate.Text),
                   PaidInstall=Convert.ToInt32(txtNoInstallment.Text),
                    ISaleId=Convert.ToInt32(txtContractId.SelectedValue),
                     RemainingInstall=Convert.ToInt32(remainInstall),
                     InstallmentAmount=Convert.ToDecimal(txtPayment.Text),
                      MonthlyInstallment=Convert.ToDecimal(txtMonthlyPayment.Text)
                };
                objdetail.Save();
                objdetail.RemainingInstall=Convert.ToInt32(txtRemainInstall.Text);
                (new SaleInstallmentBL()).UpdateBalance(objdetail.Balance, objdetail.ISaleId,objdetail.RemainingInstall);
                MessageBox.Show("Installment Paid");
                ClearGroup();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearGroup()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void txtPayment_Leave(object sender, EventArgs e)
        {
            Balance();
        }
        

    }
}
