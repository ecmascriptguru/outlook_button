using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace OutlookButton
{
    public partial class Ribbon
    {
        private Popup popup = null;
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void showForm()
        {
            if (popup == null)
            {
                popup = new Popup(Globals.ThisAddIn.Application);
            }
            popup.ShowDialog();
        }

        private void alex_click_Click(object sender, RibbonControlEventArgs e)
        {
            showForm();
        }
    }
}
