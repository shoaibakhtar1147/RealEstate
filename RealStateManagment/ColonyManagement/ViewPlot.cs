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

        private void txtColonyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlotBL obj = new PlotBL() 
            {
                 ColonyName=txtColonyName.Text
            };
            var dt = obj.Search();
            if(dt.Count>0 && dt != null)
            {
                txtPlotNo.DataSource = dt;
            }
        }

        private void txtPlotNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlotBL obj = new PlotBL()
            {
                PlotNo =Convert.ToInt32(txtPlotNo.Text),
                 ColonyId=Convert.ToInt32(txtColonyName.SelectedValue)
            };
            var dt = obj.Search();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            txtPlotNo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPlotNo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPlotNo.AutoCompleteCustomSource = coll;
            if (dt.Count > 0 && dt != null)
            {
                dgvPlot.DataSource = dt;
            }
        }
    }
}
