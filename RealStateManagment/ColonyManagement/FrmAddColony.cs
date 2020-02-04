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

namespace RealStateManagment.ColonyManagement
{
    public partial class FrmAddColony : MetroForm
    {
        public FrmAddColony()
        {
            InitializeComponent();
        }

        private void FrmAddColony_Load(object sender, EventArgs e)
        {
            FormDisable();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormEnaable();

        }

        private void FormEnaable()
        {
            txtColonyName.Enabled = true;
            txtKanal.Enabled = true;
            txtMarla.Enabled = true;
            txtLocation.Enabled = true;
            txtOwnerName.Enabled = true;
            txtFName.Enabled = true;
            txtCnic.Enabled = true;
            txtAddress.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAddNew.Enabled = false;
        }

        private void FormDisable()
        {
            txtColonyName.Enabled = false;
            txtKanal.Enabled = false;
            txtMarla.Enabled = false;
            txtLocation.Enabled = false;
            txtOwnerName.Enabled = false;
            txtFName.Enabled = false;
            txtCnic.Enabled = false;
            txtAddress.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ColonyBL objSave = new ColonyBL() 
                {
                     ColonyName=txtColonyName.Text,
                     Location=txtLocation.Text,
                     Area=txtKanal.Text+" Kanal ."+txtMarla.Text+" Marla",
                      OwnerName=txtOwnerName.Text,
                      FName=txtFName.Text,
                      Cnic=txtCnic.Text,
                       Address=txtAddress.Text
                };
                objSave.Save();
                MessageBox.Show(txtColonyName.Text + " Saved Successfull");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGroup();
        }

      

        
    }
}
