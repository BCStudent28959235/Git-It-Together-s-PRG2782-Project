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
using WinFormsApp_MainProjectFile.LogicLayer;
using WinFormsApp_MainProjectFile.PresentationLayer.UserControls;

namespace WinFormsApp_MainProjectFile.PresentationLayer.UserControls
{
    public partial class SettingsForm : Form
    {
        public Image return_D;
        public Image return_L;
        public ImageList imageList = new ImageList();
        public string iconsPath;

        public event Action OnFormClosed;

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
            getIniFont();  // Load font settings
            iconsPath = Application.StartupPath + @"PersonalResources\icons";
            Image return_D = Image.FromFile(iconsPath + @"\Return_D.png");
            Image return_L = Image.FromFile(iconsPath + @"\Return_L.png");

            imageList.Images.Add(return_L);
            imageList.Images.Add(return_D);

            cbtnCloseChildForm2.Image = imageList.Images[0];

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
            }
            else
            {
                lblDarkLight.Text = "Light";
                ctbtnThemeToggle.Checked = false;
                ThemeHandler.ApplyLightMode(this); // Apply light mode when light is selected
            }
        }

        // Method to read the font setting from INI and apply it
        public void getIniFont()
        {
            Settings get = new Settings();
            get.readIniFont();
            if (get.fontD == "on")
            {
                lblFonts.Text = "Dyslexic friendly mode ON";
                ctbntFontToggle.Checked = true;
                // Apply dyslexic-friendly fonts (You should define this logic if needed)
            }
            else
            {
                lblFonts.Text = "Dyslexic friendly mode OFF";
                ctbntFontToggle.Checked = false;
                // Reset to default fonts if needed
            }
        }

        // Close the settings form
        private void cbtnCloseChildForm2_Click(object sender, EventArgs e)
        {
            OnFormClosed?.Invoke();
            this.Close();
        }

        // Theme toggle event (dark/light mode)
        public void ctbtnThemeToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings set = new Settings();
            if (ctbtnThemeToggle.Checked == true)
            {
                set.writeIni("SECTION", "key", "dark");  // Save the dark theme in the INI
                ThemeHandler.ApplyDarkMode(this);  // Apply dark theme
            }
            else
            {
                set.writeIni("SECTION", "key", "light");  // Save the light theme in the INI
                ThemeHandler.ApplyLightMode(this);  // Apply light theme
            }
            getIni();  // Re-read the INI to apply changes
        }

        // Font toggle event (dyslexic-friendly font)
        private void ctbntFontToggle_CheckedChanged(object sender, EventArgs e)
        {
            Settings set = new Settings();
            if (ctbntFontToggle.Checked == true)
            {
                set.writeFontIni("SECTION", "key", "on");  // Enable dyslexic-friendly font
                // Apply dyslexic-friendly fonts here
            }
            else
            {
                set.writeFontIni("SECTION", "key", "off");  // Disable dyslexic-friendly font
                // Revert to default fonts here
            }
            getIniFont();  // Re-read font settings
        }
    }
}