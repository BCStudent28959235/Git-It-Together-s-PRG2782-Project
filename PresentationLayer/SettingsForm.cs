using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_MainProjectFile.FileHandling;
using WinFormsApp_MainProjectFile.LogicLayer;
using WinFormsApp_MainProjectFile.PresentationLayer.UserControls;
using System.Diagnostics;


namespace WinFormsApp_MainProjectFile.PresentationLayer.UserControls
{
    public partial class SettingsForm : Form
    {
        public event Action OnFormClosed;
        public event Action ThemeChanged;  // Event to notify other forms of theme change
        public Color color1;
        public Color color2;
        private IconLibrary iconLibrary;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
           );

        public SettingsForm()
        {
            InitializeComponent();
            getIni();  // Load settings (theme and font)
           
          Settings settings = new Settings();


            settings.readIni();


            iconLibrary = IconLibrary.Instance;



            if (settings.theme.ToLower() == "dark")
            {
                ThemeHandler.ApplyDarkMode(this);

                cbtnCloseChildForm2.Image = iconLibrary.GetImage("HomeB", "Dark");
            }
            else
            {
                ThemeHandler.ApplyLightMode(this);
               

                cbtnCloseChildForm2.Image = iconLibrary.GetImage("HomeB", "Light");
            }

            // Apply rounded corners to the form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        // Method to read the theme setting from INI and apply the theme
        public void getIni()
        {
            Settings get = new Settings();
            get.readIni();
            if (get.theme == "dark")
            {
                lblDarkLight.Text = "Dark";
                ctbtnThemeToggle.Checked = true;
                ThemeHandler.ApplyDarkMode(this); // Apply dark mode when dark is selected
                ThemeChanged?.Invoke();
            }
            else
            {
                lblDarkLight.Text = "Light";
                ctbtnThemeToggle.Checked = false;
                ThemeHandler.ApplyLightMode(this); // Apply light mode when light is selected
                ThemeChanged?.Invoke();
            }
        }

     
     

      
        private void cbtnCloseChildForm2_Click(object sender, EventArgs e)
        {
            OnFormClosed?.Invoke();

            this.Close();
        }

        // Theme toggle event (dark/light mode)
        public void ctbtnThemeToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings set = new Settings();
            if (ctbtnThemeToggle.Checked)
            {
                set.writeIni("SECTION", "key", "dark");  // Save the dark theme in the INI
                ThemeHandler.ApplyDarkMode(this);  // Apply dark theme
                cbtnCloseChildForm2.Image = IconLibrary.Instance.GetImage("HomeB", "Dark");
                ThemeChanged?.Invoke();

            }
            else
            {
                set.writeIni("SECTION", "key", "light");  // Save the light theme in the INI
                ThemeHandler.ApplyLightMode(this);  // Apply light theme
                cbtnCloseChildForm2.Image = IconLibrary.Instance.GetImage("HomeB", "Light");
                ThemeChanged?.Invoke();
                color1 = Color.FromArgb(223, 105, 13);
                color2 = Color.FromArgb(237, 140, 65);
            }
        }

        // Font toggle event (dyslexic-friendly font)
    

        // Form closing event
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            IconLibrary.Instance.Dispose(); // Dispose of resources when the form is closing
        }
    }
}