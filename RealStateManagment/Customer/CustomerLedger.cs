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

namespace RealStateManagment.Customer
{
    public partial class CustomerLedger : MetroForm
    {
        public CustomerLedger()
        {
            InitializeComponent();
        }

        private void CustomerLedger_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            ClientBL objBL = new ClientBL();
            var dt = objBL.Select();
            if (dt.Count > 0)
            {
                dgvClient.DataSource = dt;
            }
        }

        private void txtTestname_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSearch.Text))
            {
                ClientBL objSearch = new ClientBL() 
                {
                 Cnic=txtSearch.Text
                };
                var dt = objSearch.Search();
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = coll;
                if(dt != null && dt.Count>0)
                {
                    dgvClient.DataSource = dt;
                }
            }
            else
            {
                LoadData();
            }
        }
    }
}
