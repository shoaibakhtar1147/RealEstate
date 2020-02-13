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
            Design.Designform(this);
            LoadData(1);
            LoadData(2);
           
        }
       
        private void LoadData(int option)
        {
           switch(option)
           {
               case 1:
                    PlotBL objSelect = new PlotBL();
            var dt = objSelect.Select();
            if(dt.Count>0)
            {
                dgvPlot.DataSource = dt;
            }
            break;

               case 2:
            var colonyname = (new ColonyBL()).Select();
            colonyname.OrderBy(a => a.ColonyId).ToList().ForEach(a =>
                {
                    txtColonyName.Items.Add(new ComboBoxItem(a.ColonyName, a.ColonyId));
                });
                txtColonyName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtColonyName.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtColonyName.ValueMember = "ColonyId";
                txtColonyName.DisplayMember = "ColonyName";
                txtColonyName.Text = "---Select---";
          
            break;

               case 3:
            var ColonyId = ((ComboBoxItem)txtColonyName.SelectedItem).SelectedValue;
            var plotId = (new PlotBL { ColonyId = ColonyId }.Search());
                txtPlotNo.DataSource = plotId;
                txtPlotNo.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtPlotNo.AutoCompleteSource = AutoCompleteSource.ListItems;
                txtPlotNo.DisplayMember = "PlotNo";
                txtPlotNo.ValueMember = "PlotId";
                
            //}
            break;

           }
        }

       

        

       
       
        private void txtColonyName_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (((ComboBoxItem)txtColonyName.SelectedItem).SelectedValue > 0)
            {
                LoadData(3);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PlotBL obj = new PlotBL()
            {

                ColonyName = txtColonyName.Text,
                PlotNo = Convert.ToInt32(txtPlotNo.Text)

            };
            var dt = obj.Search();

            if (dt.Count > 0 && dt != null)
            {
                dgvPlot.DataSource = dt;
            }  
        }
    }
}
