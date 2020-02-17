using MetroFramework.Forms;
using RealStateManagment.BL;
using RealStateManagment.Report;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
              if(!string.IsNullOrEmpty(txtCnic.Text) && !string.IsNullOrEmpty(txtContractNo.Text))
              {
                  InstallDetailBL objBL = new InstallDetailBL()
                  {
                      Cnic = txtCnic.Text,
                      ContractNo = txtContractNo.Text
                  };
                  var dt = objBL.Search();
                  if (dt.Count > 0 && dt != null)
                  {
                      dgvSale.DataSource = dt;
                      this.dgvSale.Columns["IDetailId"].Visible = false;
                      this.dgvSale.Columns["ISaleId"].Visible = false;
                      this.dgvSale.Columns["ClientId"].Visible = false;
                      this.dgvSale.Columns["ColonyId"].Visible = false;
                      this.dgvSale.Columns["PlotId"].Visible = false;
                      this.dgvSale.Columns["DatOfPay"].Visible = false;
                      this.dgvSale.Columns["Size"].Visible = false;
                      this.dgvSale.Columns["ColonyName"].Visible = false;
                      this.dgvSale.Columns["PaidInstall"].Visible = false;
                      this.dgvSale.Columns["DownPayment"].Visible = false;
                      this.dgvSale.Columns["MobNo"].Visible = false;
                      this.dgvSale.Columns["ClientName"].Visible = false;

                  }

              }
                
                else
              {
                  MessageBox.Show("Please Enter Cnic And Contract No");
              }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void txtCnic_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCnic.Text))
            {
                SaleInstallmentBL obj = new SaleInstallmentBL()
                {
                    Cnic = txtCnic.Text
                };
                var dt = obj.Search();
                if (dt.Count > 0 && dt != null)
                {
                    txtContractNo.DataSource = dt;
                    txtContractNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtContractNo.AutoCompleteSource = AutoCompleteSource.ListItems;
                    txtContractNo.DisplayMember = "ContractNo";
                    txtContractNo.ValueMember = "ISaleId";

                }
                else
                {
                    MessageBox.Show("No record found against Cnic " + txtCnic.Text);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Cnic");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvSale.DataSource !=null)
            {
                //InstallDetailReport objRep = new InstallDetailReport();
                //FrmReportViewer objView = new FrmReportViewer();
                //objRep.SetParameterValue("@ContractNo", txtContractNo.Text);
                //objView.crptViewer.ReportSource = objRep;
                //objView.WindowState = FormWindowState.Maximized;
                //objView.ShowDialog();
                PrintDialog prinDialog = new PrintDialog();
                if (prinDialog.ShowDialog() == DialogResult.OK)
                {
                    CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                    reportDocument.Load(Application.StartupPath + "\\InstallDetailReport.rpt");
                    reportDocument.PrintOptions.PrinterName = prinDialog.PrinterSettings.PrinterName;
                    reportDocument.PrintToPrinter(prinDialog.PrinterSettings.Copies, prinDialog.PrinterSettings.Collate, prinDialog.PrinterSettings.FromPage, prinDialog.PrinterSettings.ToPage);

                }


            }

            else
            {
                MessageBox.Show("Please Enter Cnic and Contract No");
            }


            
        }
    }
}
