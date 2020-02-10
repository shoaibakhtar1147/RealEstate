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
using System.Windows.Forms;

namespace RealStateManagment.Accounts
{
    public partial class FrmTransaction : MetroForm
    {
        public FrmTransaction()
        {
            InitializeComponent();
        }

        private void FrmTransaction_Load(object sender, EventArgs e)
        {
            FormDisable();
        }

        private void FormDisable()
        {
            txtPartnerName.Enabled = false;
            txtNewAmount.Enabled = false;
            txtAmount.Enabled = false;
            btnSearch.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            rdDebit.Enabled = false;
            rdCredit.Enabled = false;
            txtDate.Enabled = false;
            txtTransactionId.Enabled = false;
            txtDescription.Enabled = false;
        }

        private void FormEnable()
        {
            txtPartnerName.Enabled = true;
            txtDescription.Enabled = true;
            txtAmount.Enabled = true;
            rdCredit.Enabled = true;
            rdDebit.Enabled = true;
            btnSearch.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAddNew.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            TransactionBL obj = new TransactionBL();
            var dt = obj.AddNew();
            if (dt != null)
            {
                txtTransactionId.Text = Convert.ToString(dt.Rows[0]["TransactionId"]);
                FormEnable();

                LoadPartner();
            }
        }

        private void LoadPartner()
        {
            PartnerBL objBL = new PartnerBL();
            var dt = objBL.Select();
            if (dt.Count > 0 && dt != null)
            {
                txtPartnerName.DataSource = dt;
                txtPartnerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtPartnerName.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtPartnerName.ValueMember = "PartnerId";
                txtPartnerName.DisplayMember = "PartnerName";
                txtPartnerName.Text = "---Select----";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PartnerBL obj = new PartnerBL()
            {
                PartnerName = txtPartnerName.Text
            };
            var dt = obj.Search();
            if (dt.Count > 0 && dt != null)
            {
                txtFName.Text = Convert.ToString(dt[0].FName);
                txtMobNo.Text = Convert.ToString(dt[0].MobileNo);
                txtPhoneNo.Text = Convert.ToString(dt[0].PhoneNo);
                txtCnic.Text = Convert.ToString(dt[0].Cnic);
                txtPreAmount.Text = Convert.ToString(dt[0].Amount);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TransactionBL obj = new TransactionBL();
            obj.PartnerId = Convert.ToInt32(txtPartnerName.SelectedValue);
            obj.Amount = Convert.ToDecimal(txtNewAmount.Text);
            obj.TransactionDate = Convert.ToDateTime(txtDate.Text);
            obj.Description = txtDescription.Text;
            obj.Credit = (rdCredit.Checked == true) ? Convert.ToDecimal(txtAmount.Text) : 0;
            obj.Debit = (rdDebit.Checked == true) ? Convert.ToDecimal(txtAmount.Text) : 0;
            //obj.CreditAmount();
            obj.Save();
            (new PartnerBL()).UpdateBalance(obj.Amount,obj.PartnerId);
            MessageBox.Show(" Transaction Successfull");
            //TransactionReport objRep = new TransactionReport();
            //FrmReportViewer objView = new FrmReportViewer();
            //objRep.SetParameterValue("@TransactionId", txtTransactionId.Text);
            //objView.crptViewer.ReportSource = objRep;
            //objView.WindowState = FormWindowState.Normal;
           // objView.ShowDialog();
            ClearGroup();
            FormDisable();
            btnAddNew.Enabled = true;


        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (rdDebit.Checked == true && !string.IsNullOrEmpty(txtAmount.Text))
            {

                decimal val = Convert.ToDecimal(txtAmount.Text);
                decimal val1 = Convert.ToDecimal(txtPreAmount.Text) + val;
                txtNewAmount.Text = val1.ToString();

            }
            else if (rdCredit.Checked == true && !string.IsNullOrEmpty(txtAmount.Text))
            {
                decimal val = Convert.ToDecimal(txtAmount.Text);
                decimal val1 = Convert.ToDecimal(txtPreAmount.Text) - val;
                txtNewAmount.Text = val1.ToString();

            }
            else
            {
                txtNewAmount.Clear();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNewAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGroup();
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
            rdCredit.Checked = false;
            rdDebit.Checked = false;
        }



    }
}
