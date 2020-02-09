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
    public partial class ViewColony : MetroForm
    {
        public ViewColony()
        {
            InitializeComponent();
        }

        private void ViewColony_Load(object sender, EventArgs e)
        {
            Design.Designform(this);
            LoadData();
            
            //GridDesign();
        }

        private void GridDesign()
        {

            //designing code=:
            //dgvTest = Border3DStyle.Flat;
            dgvColony.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvColony.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvColony.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvColony.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvColony.BackgroundColor = Color.White;

            dgvColony.EnableHeadersVisualStyles = false;
            dgvColony.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvColony.ColumnHeadersDefaultCellStyle.BackColor = Color.Firebrick;
            dgvColony.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void LoadData()
        {
            ColonyBL obj = new ColonyBL();
            var dt = obj.Select();
            if(dt.Count>0 && dt != null)
            {
                dgvColony.DataSource = dt;
            }
        }

        private void txtTestname_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtColonyname.Text))
            {
                ColonyBL objSearch = new ColonyBL() 
                {
                 ColonyName=txtColonyname.Text
                };
                var dt = objSearch.Search();
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
                txtColonyname.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtColonyname.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtColonyname.AutoCompleteCustomSource = coll;
                if(dt.Count>0 && dt != null)
                {
                    dgvColony.DataSource = dt;
                }
            }
        }
    }
}
