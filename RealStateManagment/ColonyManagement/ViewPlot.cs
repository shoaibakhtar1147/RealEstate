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
    public partial class ViewPlot : MetroForm
    {
        public ViewPlot()
        {
            InitializeComponent();
        }

        private void ViewPlot_Load(object sender, EventArgs e)
        {
            LoadColony();
            LoadData();
            GridDesign();
        }
        private void GridDesign()
        {

            //designing code=:
            //dgvTest = Border3DStyle.Flat;
            dgvPlot.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPlot.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPlot.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvPlot.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPlot.BackgroundColor = Color.White;

            dgvPlot.EnableHeadersVisualStyles = false;
            dgvPlot.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPlot.ColumnHeadersDefaultCellStyle.BackColor = Color.Firebrick;
            dgvPlot.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void LoadData()
        {
            PlotBL objSelect = new PlotBL();
            var dt = objSelect.Select();
            if(dt.Count>0)
            {
                dgvPlot.DataSource = dt;
            }
        }

        private void LoadColony()
        {
            ColonyBL objSelect = new ColonyBL();
            var dt = objSelect.Select();
            if(dt.Count>0)
            {
                txtColonyName.DataSource = dt;
                txtColonyName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtColonyName.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtColonyName.ValueMember = "ColonyId";
                txtColonyName.DisplayMember = "ColonyName";
            }
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            PlotBL obj = new PlotBL()
            {

                ColonyName = txtColonyName.Text,
                PlotNo =Convert.ToInt32(txtPlotNo.Text)
                
            };
            var dt = obj.Search();
            
            if (dt.Count > 0 && dt != null)
            {
                dgvPlot.DataSource = dt;
            }  
        }

        private void txtColonyName_Leave(object sender, EventArgs e)
        {
            PlotBL obj = new PlotBL()
            {
                ColonyName = txtColonyName.Text
            };
            var dt = obj.Search();
            if (dt.Count > 0 && dt != null)
            {
                txtPlotNo.DataSource = dt;
                txtPlotNo.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtPlotNo.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtPlotNo.DisplayMember = "PlotNo";
                txtPlotNo.ValueMember = "PlotId";
            }
        }
    }
}
