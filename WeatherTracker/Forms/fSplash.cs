using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WeatherTracker.Forms
{
    public partial class fSplash : Form
    {
        public fSplash() {
            InitializeComponent();
            lblApplicationTitle.Text = Application.ProductName;
            lblVersion.Text = Application.ProductVersion;
            lblCopyright.Text = "George Papadas © 2019";
        }

    }
}