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

namespace RealStateManagment.Accounts
{
    public partial class FrmAddPartner : MetroForm
    {
        public FrmAddPartner()
        {
            InitializeComponent();
        }

        private void FrmAddPartner_Load(object sender, EventArgs e)
        {
            FormDisable();
        }

        

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormEnable();
        }

        private void FormEnable()
        {
            txtPartnerName.Enabled = true;
            txtFName.Enabled = true;
            txtEmail.Enabled = true;
            txtCnic.Enabled = true;
            txtMobNo.Enabled = true;
            txtPhoneNo.Enabled = true;
            txtAddress.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAddNew.Enabled = false;
        }

        private void FormDisable()
        {
            txtPartnerName.Enabled = false;
            txtFName.Enabled = false;
            txtEmail.Enabled = false;
            txtCnic.Enabled = false;
            txtMobNo.Enabled = false;
            txtPhoneNo.Enabled = false;
            txtAddress.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private bool SearchCnic()
        {
            PartnerBL obj = new PartnerBL() 
            {
             Cnic=txtCnic.Text
            };
            var dt = obj.Search();
            if(dt.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                if(SearchCnic()!=true)
                {
                    PartnerBL objPart = new PartnerBL()    
                    {
                        PartnerName = txtPartnerName.Text,
                        FName = txtFName.Text,
                        Email = txtEmail.Text,
                        Cnic = txtCnic.Text,
                        MobileNo = txtMobNo.Text,
                        PhoneNo = txtPhoneNo.Text,
                        Address = txtAddress.Text,
                    };
                    objPart.Save();
                    MessageBox.Show(txtPartnerName.Text + " Saved Successfull");
                    ClearGroup();
                }
                else
                {
                    MessageBox.Show(txtCnic.Text+(" Cnic has already exist"));
                }
                
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
    }
}
