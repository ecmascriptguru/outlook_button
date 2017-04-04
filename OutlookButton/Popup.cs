using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookButton
{
    public partial class Popup : Form
    {
        private Microsoft.Office.Interop.Outlook.Application App;

        public Popup()
        {
            InitializeComponent();
        }

        public Popup(Microsoft.Office.Interop.Outlook.Application _app)
        {
            App = _app;
            InitializeComponent();
        }
    }
}
