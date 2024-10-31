using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//still need a check to ensure id stays unique
namespace PRG282_02
{

	public partial class Tasks : Form
	{
        List<Student> students = new List<Student>();

        DataTable studentTable = new DataTable();
        BindingSource src = new BindingSource();

        public Tasks()
		{
			InitializeComponent();
		}



	

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
         
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
 
        }

     
        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
   
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
          
        }

  
        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

    }
}
