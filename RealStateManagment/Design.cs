using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RealStateManagment
{
    class Design
    {

        public static void Designform(Form frm)
        {

            foreach (Control control in frm.Controls)
            {
                if (control is Panel)
                {
                    foreach (var iControl in control.Controls)
                    {
                        if (iControl is DataGridView)
                        {
                            var grid = (DataGridView)iControl;
                            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                            grid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                            grid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                            grid.BackgroundColor = Color.White;

                            grid.EnableHeadersVisualStyles = false;
                            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Firebrick;
                            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        }

                    }
                }



            }
        }
    }
}

