using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp_MainProjectFile;
using System;
using System.Windows.Forms;


namespace WinFormsApp_MainProjectFile.LogicLayer
{
    public class ShowChildForm
    {
        private Panel pnlDockForm;
        public ShowChildForm(Panel panel)
        {
            pnlDockForm = panel;
        }

        public void DisplayForm(Form form)
        {
            if (form == null) return;

           
            foreach (Control ctrl in pnlDockForm.Controls)
            {
                if (ctrl is Form) ctrl.Hide(); 
            }
            pnlDockForm.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlDockForm.Controls.Add(form);
            form.Dock = DockStyle.Fill;

            form.Show();
        }
    }
}
