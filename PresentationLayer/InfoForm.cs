using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_MainProjectFile.PresentationLayer
{
    public partial class InfoForm : Form
    {
        public event Action OnFormClosed;
        public InfoForm()
        {
            InitializeComponent();
        }


        private void cbtnCloseChildFornInfo_Click(object sender, EventArgs e)
        {
            OnFormClosed?.Invoke();
            this.Close();
        }
    }
}
