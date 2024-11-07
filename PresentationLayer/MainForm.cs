
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_MainProjectFile.FileHandling;
using WinFormsApp_MainProjectFile.LogicLayer;
using WinFormsApp_MainProjectFile.PresentationLayer;




//Katryn TODO: implement Darkmode


namespace WinFormsApp_MainProjectFile.PresentationLayer
{ 
    public partial class MainForm : Form
    {
        // Importing the CreateRoundRectRgn function from Gdi32.dll for creating rounded rectangle regions
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                 int nLeftRect,
                 int nTopRect,
                 int nRightRect,
                 int nBottomRect,
                 int nWidthEllipse,
                 int nHeightEllipse
             );


        
        public MainForm()
        {
            InitializeComponent();

                   // Set the form's region to a rounded rectangle
                        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

                        // Initialize the navigation panel to the height and position of the Dashboard button
                        pnlNav.Height = btnDashboard.Height;
                        pnlNav.Top = btnDashboard.Top;
                        pnlNav.Left = btnDashboard.Left;
                        btnDashboard.BackColor = Color.FromArgb(240, 210, 144); //setting initial dashboard background colour




        }
		DataTable studentTable = new DataTable();
		BindingSource src = new BindingSource();
		List<Student> students = new List<Student>();
		private void MainForm_Load(object sender, EventArgs e)
        {
			studentTable.Columns.Add("ID", typeof(int));
			studentTable.Columns.Add("Name", typeof(string));
			studentTable.Columns.Add("Age", typeof(int));
			studentTable.Columns.Add("Course", typeof(string));

			populateStudents();

			src.DataSource = studentTable;

            dgvStudents_pnlMainTableContainer.DataSource = src;
		}
		private void populateStudents()
		{
			Read read = new Read("Students.txt");
			students = read.streamRead();

			foreach (Student pupil in students)
			{
				studentTable.Rows.Add(pupil.Id, pupil.Name, pupil.Age, pupil.Course);
			}

		}

		private void Timer_Sidebar_Menu_Tick(object sender, EventArgs e)
        {
   
        }   
        
        

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();
        }

        private void btnPrevious_pnlMainTableContainer_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_pnlMainTableContainer_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            lblTabTitle.Text = "Dashboard";
        
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(240, 210, 144); //put into theme handler class
            
           
        }
        private void TasksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnDashboard.BackColor = Color.Transparent;
            pnlNav.Height = btnStudentData.Height;
            pnlNav.Top = btnStudentData.Top;
            pnlNav.Left = btnStudentData.Left;
            btnStudentData.BackColor = Color.FromArgb(240, 210, 144); //put into theme handler class

        }

        private void btnStudentData_Click(object sender, EventArgs e)
        {
            TasksForm tasksForm = new TasksForm();

            tasksForm.Show();

            lblTabTitle.Text = "Student Data";
       
     

            pnlNav.Height = btnStudentData.Height;
            pnlNav.Top = btnStudentData.Top;
            pnlNav.Left = btnStudentData.Left;
            btnStudentData.BackColor = Color.FromArgb(240, 210, 144); //put into theme handler class
            btnDashboard.BackColor = Color.Transparent; //add to theme handler
        }

        private void btnDataSummary_Click(object sender, EventArgs e)
        {
            lblTabTitle.Text = "Summary";
            btnDashboard.BackColor = Color.Transparent;
            pnlNav.Height = btnDataSummary.Height;
            pnlNav.Top = btnDataSummary.Top;
            pnlNav.Left = btnDataSummary.Left;
            btnDataSummary.BackColor = Color.FromArgb(240, 210, 144); //put into theme handler class
        }

     

        private void btnSettings_Click(object sender, EventArgs e)
        {
            lblTabTitle.Text = "Settings";
            btnDashboard.BackColor = Color.Transparent;
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(240, 210, 144); //put into theme handler class
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            lblTabTitle.Text = "Info";
            btnDashboard.BackColor = Color.Transparent;
            pnlNav.Height = btnInfo.Height;
            pnlNav.Top = btnInfo.Top;
            pnlNav.Left = btnInfo.Left;
            btnInfo.BackColor = Color.FromArgb(240, 210, 144); //put into theme handler
        }





        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            //when clicking on another tab button the colour changes back to normal

            //add in check to make sure its one of the buttons on the panel first
            btnDashboard.BackColor = Color.Transparent; //add to theme handler
        }

        private void btnStudentData_Leave(object sender, EventArgs e)
        {
            //when clicking on another tab button the colour changes back to normal

            //add in check to make sure its one of the buttons on the panel first

            btnStudentData.BackColor = Color.Transparent; //add to theme handler
        }

        private void btnDataSummary_Leave(object sender, EventArgs e)
        {
            //when clicking on another tab button the colour changes back to normal

            //add in check to make sure its one of the buttons on the panel first

            btnDataSummary.BackColor = Color.Transparent; //add to theme handler
        }


        private void btnSettings_Leave(object sender, EventArgs e)
        {
            //when clicking on another tab button the colour changes back to normal

            //add in check to make sure its one of the buttons on the panel first

            btnSettings.BackColor = Color.Transparent; //add to theme handler
        }

        private void btnInfo_Leave(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.Transparent;
        }
        private void rtxtStatusContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
