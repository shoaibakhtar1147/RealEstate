using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealStateManagment.ColonyManagement
{
    class ComboBoxItem
    {


        public readonly string SelectedItem;
        public readonly int SelectedValue;
        private int? nullable;
        private int p;
        public ComboBoxItem(string name, int value)
        {
            SelectedItem = name; SelectedValue = value;
        }

        

      
        public override string ToString()
        {
            // Generates the text shown in the combo box
            return SelectedItem;
        }
    }
}
