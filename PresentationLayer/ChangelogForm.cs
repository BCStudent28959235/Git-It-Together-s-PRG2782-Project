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
    public partial class ChangelogForm : Form
    {
        public Image return_D;
        public Image return_L;
        public ImageList imageList = new ImageList();
        public string iconsPath;

        public event Action OnFormClosed;
        public ChangelogForm()
        {
            InitializeComponent();

            iconsPath = Application.StartupPath + @"PersonalResources\icons";
            Image return_D = Image.FromFile(iconsPath + @"\Return_D.png");
            Image return_L = Image.FromFile(iconsPath + @"\Return_L.png");

            imageList.Images.Add(return_L);
            imageList.Images.Add(return_D);


            cbtnCloseChildForm1.Image = imageList.Images[0];
        }

        private void TesterForm_Load(object sender, EventArgs e)
        {

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
            //rest of logic


        }
    }
}
