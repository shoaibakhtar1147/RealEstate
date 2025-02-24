﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using RealStateManagment.BL;
namespace RealStateManagment.Customer
{
    public partial class AddClient : MetroForm
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            FromDisble();
        }

        private void FromDisble()
        {
            txtClientName.Enabled = false;
            txtFName.Enabled = false;
            txtEmail.Enabled = false;
            txtCnic.Enabled = false;
            txtMobNo.Enabled = false;
            txtPhoneNo.Enabled = false;
            txtAddress.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void FormEnable()
        {
            txtClientName.Enabled = true;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGroup();
        }

        private bool SearchCnic()
        {
            ClientBL obj = new ClientBL()
            {
                Cnic = txtCnic.Text
            };
            var dt = obj.Search();
            if (dt.Count > 0)
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
                if (SearchCnic() != true)
                {
                    ClientBL objClient = new ClientBL()
                    {
                        ClientName = txtClientName.Text,
                        FatherName = txtFName.Text,
                        Cnic = txtCnic.Text,
                        Email = txtEmail.Text,
                        MobNo = txtMobNo.Text,
                        PhoneNo = txtPhoneNo.Text,
                        Address = txtAddress.Text
                    };
                    objClient.Save();
                    MessageBox.Show(txtClientName.Text + " Save Successfully ");
                    ClearGroup();
                }
                else
                {
                    MessageBox.Show(txtCnic.Text + (" Cnic has already exist"));
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormEnable();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
