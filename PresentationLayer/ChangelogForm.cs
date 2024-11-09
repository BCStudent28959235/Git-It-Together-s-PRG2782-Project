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
    public partial class ChangelogForm : Form
    {
        public Image return_D;
        public Image return_L;
        public ImageList imageList = new ImageList();
        public string iconsPath;

        public event Action OnFormClosed;
        private Settings settings;
        private ThemeHandler themeHandler;
        public ChangelogForm()
        {
            InitializeComponent();

            settings = new Settings();
            themeHandler = new ThemeHandler();

            settings.readIni();






            iconsPath = Application.StartupPath + @"PersonalResources\icons";
            Image return_D = Image.FromFile(iconsPath + @"\Return_D.png");
            Image return_L = Image.FromFile(iconsPath + @"\Return_L.png");

            imageList.Images.Add(return_L);
            imageList.Images.Add(return_D);
            if (settings.theme.ToLower() == "dark")
            {
                ThemeHandler.ApplyDarkMode(this);
              
                cbtnCloseChildForm1.Image = imageList.Images[1]; // Set the dark icon
            }
            else
            {
                ThemeHandler.ApplyLightMode(this);
                pnlHoldsChangelog.BackColor = Color.FromArgb(245, 235, 224);

                cbtnCloseChildForm1.Image = imageList.Images[0]; // Set the light icon
            }

          
        }

        private void TesterForm_Load(object sender, EventArgs e)
        {
            //Display latest changes
            lsvChangeLog.View = View.Details;
            lsvChangeLog.Columns.Add("Change Log", -2, HorizontalAlignment.Left);

            // Populate ListView with the last 3 entries from the change log
            List<string> changeLog = new List<string>();
            Read r = new Read();
            changeLog = r.changeLogReadAll();

            foreach (string log in changeLog)
            {
                ListViewItem row = new ListViewItem(log); // Initialize ListViewItem with the log text
                lsvChangeLog.Items.Add(row); // Add the item to the ListView
            }
        }





        private void cbtnCloseChildForm1_Click(object sender, EventArgs e)
        {
            OnFormClosed?.Invoke();
            this.Close();
        }

        private void cbtnTaskFormOpen_Click(object sender, EventArgs e)
        {
            OnFormClosed?.Invoke();
            this.Close();
          


        }
    }
}
