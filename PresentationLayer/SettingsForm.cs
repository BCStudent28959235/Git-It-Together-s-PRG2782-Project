using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_MainProjectFile.LogicLayer;

namespace WinFormsApp_MainProjectFile.PresentationLayer.UserControls
{
    public partial class SettingsForm : Form
    {
        public Image return_D;
        public Image return_L;
        public ImageList imageList = new ImageList();
        public string iconsPath;


        public event Action OnFormClosed;

        public SettingsForm()
        {
            InitializeComponent();

            iconsPath = Application.StartupPath + @"PersonalResources\icons";
            Image return_D = Image.FromFile(iconsPath + @"\Return_D.png");
            Image return_L = Image.FromFile(iconsPath + @"\Return_L.png");

            imageList.Images.Add(return_L);
            imageList.Images.Add(return_D);


            cbtnCloseChildForm2.Image = imageList.Images[0];

        }

        private void customToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (customToggleButton1.Checked == true) { lblDarkLight.Text = "Dark Mode"; }
            else
            {
                lblDarkLight.Text = "Light Mode";
            }

        }



        private void cbtnCloseChildForm2_Click(object sender, EventArgs e)
        {
            OnFormClosed?.Invoke(); 
            this.Close();
        }
    }
}
