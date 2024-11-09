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

namespace WinFormsApp_MainProjectFile.PresentationLayer
{
    public partial class InfoForm : Form
    {
        public event Action OnFormClosed;
        private Settings settings;
 

        public InfoForm()
        {
            InitializeComponent();
            settings = new Settings();
          

            settings.readIni();

            if (settings.theme.ToLower() == "dark")
            {
                // Apply Dark Theme
               ThemeHandler.ApplyDarkMode(this);
            }
            else
            {
                // Apply Light Theme
                ThemeHandler.ApplyLightMode(this);
            }
        }


        private void cbtnCloseChildFornInfo_Click(object sender, EventArgs e)
        {
            OnFormClosed?.Invoke();
            this.Close();
        }
    }
}
