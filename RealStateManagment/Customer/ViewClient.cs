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
    public partial class ViewClient : MetroForm
    {
        public ViewClient()
        {
            InitializeComponent();
        }

        private void ViewClient_Load(object sender, EventArgs e)
        {
            LoadData();
            GridDesign();
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

        private void GridDesign()
        {

            //designing code=:
            //dgvTest = Border3DStyle.Flat;
            dgvClient.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvClient.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClient.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvClient.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvClient.BackgroundColor = Color.White;

            dgvClient.EnableHeadersVisualStyles = false;
            dgvClient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClient.ColumnHeadersDefaultCellStyle.BackColor = Color.Firebrick;
            dgvClient.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtTestname_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSearch.Text))
            {
                ClientBL objSearch = new ClientBL() 
                {
                 ClientName=txtSearch.Text
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
