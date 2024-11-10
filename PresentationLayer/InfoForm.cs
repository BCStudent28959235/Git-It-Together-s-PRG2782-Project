using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_MainProjectFile.FileHandling;
using WinFormsApp_MainProjectFile.LogicLayer;

namespace WinFormsApp_MainProjectFile.PresentationLayer
{
    public partial class InfoForm : Form
    {
        public event Action OnFormClosed;
        private Settings settings;
        IconLibrary iconLibrary;

        public InfoForm()
        {
            InitializeComponent();
            settings = new Settings();
          

            settings.readIni();

            iconLibrary = IconLibrary.Instance;
            if (settings.theme.ToLower() == "dark")
            {
                // Apply Dark Theme
               ThemeHandler.ApplyDarkMode(this);
                cbtnCloseChildFornInfo.Image = iconLibrary.GetImage("HomeB", "Dark");
            }
            else
            {
                // Apply Light Theme
                ThemeHandler.ApplyLightMode(this);
                cbtnCloseChildFornInfo.Image = iconLibrary.GetImage("HomeB", "Light");
            }
        }


        private void cbtnCloseChildFornInfo_Click(object sender, EventArgs e)
        {
            OnFormClosed?.Invoke();
            this.Close();
        }
    }
}
