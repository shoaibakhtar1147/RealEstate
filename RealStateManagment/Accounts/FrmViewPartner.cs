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
    public partial class FrmViewPartner : MetroForm
    {
        public FrmViewPartner()
        {
            InitializeComponent();
        }

        private void FrmViewPartner_Load(object sender, EventArgs e)
        {
            LoadPartner(); 
        }

        private void LoadPartner()
        {
            PartnerBL objBL = new PartnerBL();
            var dt = objBL.Select();
            if (dt.Count > 0 && dt != null)
            {
                dgvPartner.DataSource = dt;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            PartnerBL objBL = new PartnerBL() 
            {
             PartnerName=txtSearch.Text
            };
            var dt = objBL.Search();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = coll;
            if (dt.Count > 0 && dt != null)
            {
                dgvPartner.DataSource = dt;
            }
        }
    }
}
