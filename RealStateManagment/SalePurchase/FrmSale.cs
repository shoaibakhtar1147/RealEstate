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
    public partial class FrmSale : MetroForm
    {
        public FrmSale()
        {
            InitializeComponent();
        }

        private void FrmSale_Load(object sender, EventArgs e)
        {
            FromDisable();
        }

        private void FromDisable()
        {
            txtClientName.Enabled = false;
            txtColonyName.Enabled = false;
            txtContractID.Enabled = false;
            txtDownPayment.Enabled = false;
            txtMonthlyPayment.Enabled = false;
            txtArea.Enabled = false;
            txtMonths.Enabled = false;
            rdCash.Enabled = false;
            rdInstallment.Enabled = false;
            txtPlotNo.Enabled = false;
            txtTotalAmount.Enabled = false;
            txtBuyDate.Enabled = false;
            txtBalance.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            groupBox2.Visible = false;
        }


        private void FormEnable()
        {
            txtClientName.Enabled = true;
            txtColonyName.Enabled = true;
            txtMonths.Enabled = true;
            rdCash.Enabled = true;
            rdInstallment.Enabled = true;
            txtPlotNo.Enabled = true;
            txtBuyDate.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormEnable();
            LoadClient();
            LoadColony();
            ContractNo();
            //ContractNoBL objBL = new ContractNoBL() 
            //{  
            //    ColonyId=Convert.ToInt32(txtColonyName.SelectedIndex),
            //     PlotId=Convert.ToInt32(txtPlotNo.SelectedIndex)

            //};
            //var dt = objBL.CountContractNo();
            //if(dt != null)
            //{
                
            //    txtContractID.Text = Convert.ToString(dt.Rows[0]["PlotId"]);
            //}
            btnAddNew.Enabled = false;
           
        }

        private void ContractNo()
        {
            ContractNoBL objBL = new ContractNoBL() 
            {
             ColonyId=Convert.ToInt32(txtColonyName.SelectedIndex),
              PlotId=Convert.ToInt32(txtPlotNo.SelectedIndex)
            
            };
            var dt = objBL.CountContractNo();
          // var contract=("CN"+(objBL.ColonyId=Convert.ToInt32(txtColonyName.SelectedIndex))+"-PL"+(objBL.PlotId=Convert.ToInt32(txtPlotNo.SelectedIndex))+"-"+(objBL.CountContractNo().ToString().PadLeft(7-objBL.CountContractNo().ToString().Count(),'0')));
           if(dt != null)
           {
               txtContractID.Text =("CN"+(objBL.ColonyId=Convert.ToInt32(txtColonyName.SelectedIndex))+"-PL"+(objBL.PlotId=Convert.ToInt32(txtPlotNo.SelectedIndex))+"-"+(objBL.CountContractNo().ToString().PadLeft(7-objBL.CountContractNo().ToString().Count())));
           }
            
        }

        private void LoadClient()
        {
            ClientBL objClient = new ClientBL();
            var dt = objClient.Select();
            if(dt != null)
            {
                txtClientName.DataSource = dt;
                txtClientName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtClientName.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtClientName.DisplayMember = "ClientName";
                txtClientName.ValueMember = "ClientId";
            }

           else
            {
                MessageBox.Show("No Record Found");
            }
        }

        private void LoadColony()
        {
            ColonyBL objCol = new ColonyBL();
            var dt = objCol.Select();
            if(dt != null)
            {
                txtColonyName.DataSource = dt;
                txtColonyName.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtColonyName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtColonyName.ValueMember = "ColonyId";
                txtColonyName.DisplayMember = "ColonyName";
            }
            else
            {
                MessageBox.Show("No Record Found");
            }

        }

        private void txtColonyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlotBL obj = new PlotBL() 
            {
             ColonyName=txtColonyName.Text
            };
            var dt = obj.Search();
            if(dt.Count>0 && dt != null)
            {
                txtPlotNo.Text =Convert.ToString(dt[0].PlotNo);
               
                //txtPlotNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //txtPlotNo.AutoCompleteSource = AutoCompleteSource.ListItems;
                //txtPlotNo.ValueMember = "PlotId";
                //txtPlotNo.DisplayMember = "PlotNo";
            }
            
        }

        private void txtPlotNo_Leave(object sender, EventArgs e)
        {
            PlotBL obj = new PlotBL() 
            {
                ColonyName=txtColonyName.Text,
                PlotNo=Convert.ToInt32(txtPlotNo.Text)
            };
            var dt = obj.Search();
            if(rdInstallment.Checked==true)
            {
                txtArea.Text = Convert.ToString(dt[0].Size);
                txtTotalAmount.Text = Convert.ToString(dt[0].Installment);
            }
            else if(rdCash.Checked==true)
            {

                txtArea.Text = Convert.ToString(dt[0].Size);
                txtTotalAmount.Text = Convert.ToString(dt[0].Cash);
            }
        }

        private void txtPaymentType_Leave(object sender, EventArgs e)
        {
            if(rdInstallment.Checked&& rdCash.Checked==false)
            {
                MessageBox.Show("Please Enter Payment Type");
                return;
            }

            else if(rdInstallment.Checked==true)
            {
                PlotBL obj = new PlotBL()
                {
                    ColonyName = txtColonyName.Text,
                    PlotNo = Convert.ToInt32(txtPlotNo.Text)
                };
                var dt = obj.Search();
                {
                    txtTotalAmount.Text= Convert.ToString(dt[0].Installment);
                }
                DownPament();
                Balance();
                //MonthlyPayment();
            }

            else if(rdCash.Checked==true)
            {
                PlotBL obj = new PlotBL()
                {
                    ColonyName = txtColonyName.Text,
                    PlotNo = Convert.ToInt32(txtPlotNo.Text)
                };
                var dt = obj.Search();
                {
                    txtTotalAmount.Text = Convert.ToString(dt[0].Cash);
                }
            }
            
        }

        private void DownPament()
        {
            decimal val1 = Convert.ToDecimal(txtTotalAmount.Text);
            decimal val=Convert.ToDecimal( 33.33);
            decimal val2 = Convert.ToDecimal((val1 /100) * val);
            txtDownPayment.Text = val2.ToString("N2");
        }

        private void Balance()
        {
            decimal val = Convert.ToDecimal(txtTotalAmount.Text);
            decimal val1 = Convert.ToDecimal(txtDownPayment.Text);
            decimal val2 = Convert.ToDecimal(val - val1);
            txtBalance.Text = val2.ToString("N2");
        }

        private void MonthlyPayment()
        {
            decimal val = Convert.ToDecimal(txtTotalAmount.Text);
            decimal val1 = Convert.ToDecimal(txtMonths.Text);
            decimal val2 = Convert.ToDecimal(val / val1);
            txtMonthlyPayment.Text = val2.ToString("N2");
            
        }

        private void txtMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthlyPayment();
            DownPament();
            Balance();
        }

        private void rdInstallment_CheckedChanged(object sender, EventArgs e)
        {
            if(rdInstallment.Checked==true)
            {
                groupBox2.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = true;
        }

        private void rdCash_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        

        //private void rdCash_CheckedChanged(object sender, EventArgs e)
        //{
        //    PlotBL obj = new PlotBL()
        //    {
        //        ColonyName = txtColonyName.Text,
        //        PlotNo = Convert.ToInt32(txtPlotNo.Text)
        //    };
        //    var dt = obj.Search();
        //    if (rdInstallment.Checked == true)
        //    {
        //        txtArea.Text = Convert.ToString(dt[0].Size);
        //        txtTotalAmount.Text = Convert.ToString(dt[0].Installment);
        //    }
        //    else if (rdCash.Checked == true)
        //    {

        //        txtArea.Text = Convert.ToString(dt[0].Size);
        //        txtTotalAmount.Text = Convert.ToString(dt[0].Cash);
        //    }

        //}
       
    }
}
