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
    public partial class FrmAddPlot : MetroForm
    {
        public FrmAddPlot()
        {
            InitializeComponent();
        }

        private void FrmAddPlot_Load(object sender, EventArgs e)
        {
            FormDisable();
        }

        private void FormDisable()
        {
            txtAmount.Enabled = false;
            txtColonyName.Enabled = false;
            txtKanal.Enabled = false;
            txtMarla.Enabled = false;
            txtLength.Enabled = false;
            txtWidth.Enabled = false;
            txtPlotNo.Enabled = false;
            txtStatus.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }


        private void FormEnable()
        {
            txtAmount.Enabled = true;
            txtColonyName.Enabled = true;
            txtKanal.Enabled = true;
            txtMarla.Enabled = true;
            txtLength.Enabled = true;
            txtWidth.Enabled = true;
            txtPlotNo.Enabled = true;
            txtStatus.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAddNew.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                PlotBL obj = new PlotBL();
                if(txtLength.Text !="" && txtWidth.Text !="")
                {
                    obj.PlotNo = Convert.ToInt32(txtPlotNo.Text);
                    obj.PlotArea = txtLength.Text + "x" + txtWidth.Text;
                    obj.PlotAmount = Convert.ToDecimal(txtAmount.Text);
                    obj.Status = txtStatus.Text;
                    obj.ColonyId = Convert.ToInt32(txtColonyName.SelectedValue);
                    obj.Save();
                }

                else if(txtKanal.Text !="" &&txtMarla.Text !="")
                {
                    obj.PlotNo = Convert.ToInt32(txtPlotNo.Text);
                    obj.PlotArea = txtKanal.Text +" Kanal " + txtMarla.Text+" Marla";
                    obj.PlotAmount = Convert.ToDecimal(txtAmount.Text);
                    obj.Status = txtStatus.Text;
                    obj.ColonyId = Convert.ToInt32(txtColonyName.SelectedValue);
                    obj.Save();
                }

                else if(txtKanal.Text != "")
                {
                    obj.PlotNo = Convert.ToInt32(txtPlotNo.Text);
                    obj.PlotArea = txtKanal.Text+" Kanal";
                    obj.PlotAmount = Convert.ToDecimal(txtAmount.Text);
                    obj.Status = txtStatus.Text;
                    obj.ColonyId = Convert.ToInt32(txtColonyName.SelectedValue);
                    obj.Save();
                }
                else if(txtMarla.Text != "")
                {
                    obj.PlotNo = Convert.ToInt32(txtPlotNo.Text);
                    obj.PlotArea =  txtMarla.Text +" Marla";
                    obj.PlotAmount = Convert.ToDecimal(txtAmount.Text);
                    obj.Status = txtStatus.Text;
                    obj.ColonyId = Convert.ToInt32(txtColonyName.SelectedValue);
                    obj.Save();
                }

                MessageBox.Show("Saved Successfull");
                ClearGroup();
                btnAddNew.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormEnable();
            LoadColony();
        }

        

        private void LoadColony()
        {
            ColonyBL obj = new ColonyBL();
            var dt = obj.Select();
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
            ClearGroup();
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
