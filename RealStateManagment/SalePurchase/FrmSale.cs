using MetroFramework.Forms;
using RealStateManagment.BL;
using RealStateManagment.ColonyManagement;
using RealStateManagment.Report;
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
            cmbDownPayment.Enabled = false;
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
            //LoadData(1);
            //LoadData(3);
            LoadClient();
            ContractNo();
           LoadColony();
           
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

        //private void LoadData(int option)
        //{
        //    switch (option)
        //    {
                
        //        case 1:
        //            var colonyname = (new ColonyBL()).Select();
        //            colonyname.OrderBy(a => a.ColonyId).ToList().ForEach(a =>
        //            {
        //                txtColonyName.Items.Add(new ComboBoxItem(a.ColonyName, a.ColonyId));
        //            });
        //            txtColonyName.DataSource = colonyname;
        //            txtColonyName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //            txtColonyName.AutoCompleteSource = AutoCompleteSource.ListItems;
        //            txtColonyName.ValueMember = "ColonyId";
        //            txtColonyName.DisplayMember = "ColonyName";
        //            txtColonyName.Text = "---Select---";

        //            break;

        //        case 2:
        //            var ColonyId = ((ComboBoxItem)txtColonyName.SelectedItem).SelectedValue;
        //            var plotId = (new PlotBL { ColonyId = ColonyId }.Search());
        //            txtPlotNo.DataSource = plotId;
        //                txtPlotNo.AutoCompleteMode = AutoCompleteMode.Suggest;
        //                txtPlotNo.AutoCompleteSource = AutoCompleteSource.ListItems;
        //                txtPlotNo.DisplayMember = "PlotNo";
        //                txtPlotNo.ValueMember = "PlotId";
        //                txtPlotNo.Text = "---Select---";
        //            //}
        //            break;

        //        case 3:

        //             var client=(new ClientBL()).Select();
        //            client.OrderBy(a=>a.ClientId).ToList().ForEach(a=>
        //                {
        //                    txtClientName.Items.Add(new ComboBoxItem(a.ClientName,a.ClientId));
        //                });
            
        //        txtClientName.DataSource = client;
        //        txtClientName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //        txtClientName.AutoCompleteSource = AutoCompleteSource.ListItems;
        //        txtClientName.DisplayMember = "ClientName";
        //        txtClientName.ValueMember = "ClientId";
        //        txtClientName.Text = "---Select---";
        //        break;
            
        //    }
        //}

        

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
            if (dt != null)
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
            if (dt != null)
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

       

        private void txtPlotNo_Leave(object sender, EventArgs e)
        {
           if(!string.IsNullOrEmpty(txtPlotNo.Text))
           {
               PlotBL obj = new PlotBL()
               {
                    ColonyId = Convert.ToInt32(txtColonyName.SelectedValue),
                    PlotId = Convert.ToInt32(txtPlotNo.SelectedValue)
               };
               var dt = obj.Search();
               if (dt.Count>0 && rdInstallment.Checked == true)
               {
                   txtArea.Text = Convert.ToString(dt[0].Size);
                   txtTotalAmount.Text = Convert.ToString(dt[0].Installment);
               }
               else if (dt.Count > 0 && rdCash.Checked == true)
               {

                   txtArea.Text = Convert.ToString(dt[0].Size);
                   txtTotalAmount.Text = Convert.ToString(dt[0].Cash);
               }
           }
        }

        //private void txtPaymentType_Leave(object sender, EventArgs e)
        //{
        //    if(rdInstallment.Checked&& rdCash.Checked==false)
        //    {
        //        MessageBox.Show("Please Enter Payment Type");
        //        return;
        //    }

        //    else if(rdInstallment.Checked==true)
        //    {
        //        PlotBL obj = new PlotBL()
        //        {
        //            ColonyName = txtColonyName.Text,
        //            PlotNo = Convert.ToInt32(txtPlotNo.Text)
        //        };
        //        var dt = obj.Search();
        //        {
        //            txtTotalAmount.Text= Convert.ToString(dt[0].Installment);
        //        }
        //        DownPament();
        //        Balance();
        //        //MonthlyPayment();
        //    }

        //    else if(rdCash.Checked==true)
        //    {
        //        PlotBL obj = new PlotBL()
        //        {
        //            ColonyName = txtColonyName.Text,
        //            PlotNo = Convert.ToInt32(txtPlotNo.Text)
        //        };
        //        var dt = obj.Search();
        //        {
        //            txtTotalAmount.Text = Convert.ToString(dt[0].Cash);
        //        }
        //    }
            
        //}

        private void DownPament()
        {
            if (!string.IsNullOrEmpty(cmbDownPayment.Text))
           {
               decimal val1 = Convert.ToDecimal(txtTotalAmount.Text);
               decimal val3 = Convert.ToDecimal(cmbDownPayment.Text);
               decimal val2 = Convert.ToDecimal((val1/100)*val3);
               txtDownPayment.Text = val3.ToString("N2");
               txtBalance.Text = val2.ToString();
           }
            else if (chkDownPayment.Checked == false&& string.IsNullOrEmpty(cmbDownPayment.Text))
            {
                decimal val1 = Convert.ToDecimal(txtTotalAmount.Text);
                decimal val4 = Convert.ToDecimal(33);
                decimal val2 = Convert.ToDecimal((val1 / 100) * val4);
                txtDownPayment.Text = val2.ToString("N2");
            }
        }

        private void Balance()
        {
            if (!string.IsNullOrEmpty(cmbDownPayment.Text))
           {
               decimal val = Convert.ToDecimal(txtTotalAmount.Text);
               decimal val3 = Convert.ToDecimal(cmbDownPayment.Text);
               decimal val2 = Convert.ToDecimal(val - val3);
               txtBalance.Text = val2.ToString("N2");
           }
            else if (chkDownPayment.Checked == false && string.IsNullOrEmpty(cmbDownPayment.Text))
            {
                decimal val = Convert.ToDecimal(txtTotalAmount.Text);
               // decimal val3 = Convert.ToDecimal(txtDownPayment.Text);
                decimal val4 = Convert.ToDecimal(txtDownPayment.Text);
                decimal val2 = Convert.ToDecimal(val-val4);
                txtBalance.Text = val2.ToString("N2");
            }
        }

        private void MonthlyPayment()
        {
           if(!string.IsNullOrEmpty(cmbDownPayment.Text))
           {
               decimal val = Convert.ToDecimal(txtBalance.Text);
               int val3 = Convert.ToInt32(txtMonths.Text);
               int val2 = Convert.ToInt32((val/val3));
               txtMonthlyPayment.Text = val2.ToString("N2");
           }
           else if (chkDownPayment.Checked == false && string.IsNullOrEmpty(cmbDownPayment.Text))
           {
               decimal val = Convert.ToDecimal(txtBalance.Text);
               int val1 = Convert.ToInt32(txtMonths.Text);
               decimal val2 = Convert.ToDecimal(val / val1);
               txtMonthlyPayment.Text = val2.ToString("N2");
           }
            
        }
        private void Years()
        {
            decimal val = Convert.ToDecimal(txtMonths.Text);
            decimal val2 = Convert.ToDecimal(val / 12);
            txtYears.Text = val2.ToString()+" y";
        }

        private void txtMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            Years();
            DownPament();
            Balance();
            MonthlyPayment();
           
        }

        private void rdInstallment_CheckedChanged(object sender, EventArgs e)
        {
            if(rdInstallment.Checked==true)
            {
                groupBox2.Visible = true;
            }
        }

        //private bool CheckPlot()
        //{
        //    PlotBL obj = new PlotBL() 
        //    { 
        //     PlotId=Convert.ToInt32(txtPlotNo.SelectedValue)
        //    };

        //    var dt = obj.Search();
        //    if(dt.Count>0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (rdCash.Checked == true)
                {
                    SaleBL objSale = new SaleBL()
                    {
                        ContractNo = txtContractID.Text,
                        ClientId = Convert.ToInt32(txtClientName.SelectedValue),
                        ColonyId = Convert.ToInt32(txtColonyName.SelectedValue),
                        PlotId = Convert.ToInt32(txtPlotNo.SelectedValue),
                        SaleStatus = "Cash",
                        SaleDate = Convert.ToDateTime(txtBuyDate.Text),
                        CashPayment = Convert.ToDecimal(txtTotalAmount.Text),
                    };
                    objSale.Save();
                    //SaleCashReport objRep = new SaleCashReport();
                    //FrmReportViewer objView = new FrmReportViewer();
                    //objRep.SetParameterValue("@ContractNo", txtContractID.Text);
                    //objView.crptViewer.ReportSource = objRep;
                    //objView.WindowState = FormWindowState.Maximized;
                    //objView.ShowDialog();

                   
                }

                else if (rdInstallment.Checked == true)
                {
                    SaleInstallmentBL objIns = new  SaleInstallmentBL()
                    {
                        ContractNo = txtContractID.Text,
                         ClienId = Convert.ToInt32(txtClientName.SelectedValue),
                        ColonyId = Convert.ToInt32(txtColonyName.SelectedValue),
                        PlotId = Convert.ToInt32(txtPlotNo.SelectedValue),
                        SaleStatus = "Installment",
                        SaleDate = Convert.ToDateTime(txtBuyDate.Text),
                          TotalInstall=Convert.ToInt32(txtMonths.Text),
                           DatOfPay=Convert.ToInt32(txtPayDate.Text),
                            Balance=Convert.ToDecimal(txtBalance.Text),
                             DownPayment=Convert.ToDecimal(txtDownPayment.Text),
                              MonthlyPayment=Convert.ToDecimal(txtMonthlyPayment.Text),
                               RemainingInstall=Convert.ToInt32(txtMonths.Text)
                    };
                    objIns.Save();
                    //SaleInstallReport objInsRep = new SaleInstallReport();
                    //FrmReportViewer objView = new FrmReportViewer();
                    //objInsRep.SetParameterValue("@contractNo", txtContractID.Text);
                    //objView.crptViewer.ReportSource = objInsRep;
                    //objView.WindowState = FormWindowState.Maximized;
                    //objView.ShowDialog();
                }
                
                PlotBL obj = new PlotBL() 
                {
                  PlotId=Convert.ToInt32(txtPlotNo.SelectedValue),
                  ColonyId=Convert.ToInt32(txtColonyName.SelectedValue),
                  Status = "Unavailable"
                };
                 obj.Update();

                MessageBox.Show("Contract Save Successfull");
                FromDisable();
                btnAddNew.Enabled = true;
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
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
            rdInstallment.Checked = false;
            rdCash.Checked = false;
        }

        private void rdCash_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGroup();
        }

        

        

     
        private void cmbDownPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthlyPayment();
            DownPament();
            Balance();
        }

       
        private void cmbDownPayment_TextChanged_1(object sender, EventArgs e)
        {
            DownPament();
            Balance();
            MonthlyPayment();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void txtPlotNo_Enter(object sender, EventArgs e)
        {

        }

        private void txtColonyName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void txtColonyName_Leave(object sender, EventArgs e)
        {
            PlotBL obj = new PlotBL()
            {
                ColonyName = txtColonyName.Text
            };
            var dt = obj.Search();
            if (dt.Count > 0 && dt != null )
            {
                txtPlotNo.DataSource = dt;
                txtPlotNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtPlotNo.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtPlotNo.ValueMember = "PlotId";
                txtPlotNo.DisplayMember = "PlotNo";
                txtPlotNo.Text = "---Select---";

            }
            //if (((ComboBoxItem)txtColonyName.SelectedItem).SelectedValue > 0)
            //{
            //    LoadData(2);
            //}
        }

        private void chkDownPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDownPayment.Checked == true)
            {
                cmbDownPayment.Enabled = true;
                txtDownPayment.Clear();
                txtBalance.Clear();
                txtMonthlyPayment.Clear();
            }
            else
            {
                cmbDownPayment.Enabled = true;
                txtDownPayment.Clear();
                txtBalance.Clear();
                txtMonthlyPayment.Clear();
                cmbDownPayment.Clear();
                cmbDownPayment.Enabled = false;
            }
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
