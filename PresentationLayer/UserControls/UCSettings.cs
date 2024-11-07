using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_MainProjectFile.PresentationLayer.UserControls
{
    public partial class UCSettings : UserControl
    {

        public UCSettings()
        {
            InitializeComponent();
        }

        private void customToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (customToggleButton1.Checked == true) { lblDarkLight.Text = "Dark Mode"; }
            else
            {
                lblDarkLight.Text = "Light Mode";
            }

        }

        private void cbtnCloseApp_Click(object sender, EventArgs e)
        {
          
        }
    }
}
