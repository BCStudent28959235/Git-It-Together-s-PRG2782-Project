﻿using System;
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
using WinFormsApp_MainProjectFile.PresentationLayer.CustomControls;
using WinFormsApp_MainProjectFile.PresentationLayer.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




//Katryn TODO: implement Darkmode


namespace WinFormsApp_MainProjectFile.PresentationLayer
{
    public partial class MainForm : Form
    {
        public SettingsForm ucSettings = new SettingsForm();
        public CustomGradientPanels childFormPanel = new CustomGradientPanels();
        private ShowChildForm childFormDisplayer;
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

        private Settings settings;

        public MainForm()
        {
            InitializeComponent();
            //ucSettings.ThemeChanged += OnThemeChanged;


            settings = new Settings();


            settings.readIni();

            ucSettings.ThemeChanged += OnThemeChanged;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));


            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(240, 210, 144); //setting initial dashboard background colour

           



            this.Controls.Add(childFormPanel);
            childFormPanel.Dock = DockStyle.Fill;
            childFormPanel.Location = new Point(0, 0);
            childFormPanel.Size = new Size(1285, 825);
            childFormPanel.BringToFront();
            childFormPanel.Visible = false;
            childFormPanel.BackColor = Color.Transparent;
            pnlNavContainer.BringToFront();


            childFormDisplayer = new ShowChildForm(childFormPanel);
            settings.readIni();
       

            if (settings.theme.ToLower() == "dark")
            {
                // Apply Dark Theme
                ThemeHandler.ApplyDarkMode(this);
        
                pnlNavContainer.ColorOne = Color.FromArgb(33, 42, 62);
                pnlNavContainer.ColorTwo = Color.FromArgb(51, 65, 95);
                btnDashboard.Image = IconLibrary.Instance.GetImage("HomeS", "Dark");
                btnStudentData.Image = IconLibrary.Instance.GetImage("Data", "Dark");
                btnChangelog.Image = IconLibrary.Instance.GetImage("Changelog", "Dark");
                btnSettings.Image = IconLibrary.Instance.GetImage("Data", "Dark");
                btnInfo.Image = IconLibrary.Instance.GetImage("Data", "Dark");
                cbtnCloseApp.Image = IconLibrary.Instance.GetImage("Close", "Dark");
                dgvStudents_pnlMainTableContainer.ForeColor = Color.Black;
                btnDashboard.ForeColor = Color.White;
                btnStudentData.ForeColor = Color.White;
                btnChangelog.ForeColor = Color.White;
                btnSettings.ForeColor = Color.White;
                btnInfo.ForeColor = Color.White;
                lsvRecentChanges.ForeColor = Color.White;
                gpnlBorder1.ColorOne = Color.FromArgb(155, 164, 181);
                gpnlBorder1.ColorTwo = Color.FromArgb(33, 42, 62);
                lblTabTitle.ForeColor = Color.White;
                //
                lsvRecentChanges.BackColor = Color.Black;
            }
            else
            {
                // Apply Light Theme
                ThemeHandler.ApplyLightMode(this);
                pnlNavContainer.ColorOne = Color.FromArgb(223, 105, 13);
                pnlNavContainer.ColorTwo = Color.FromArgb(237, 140, 65);
                btnDashboard.Image = IconLibrary.Instance.GetImage("HomeS", "Light");
                btnStudentData.Image = IconLibrary.Instance.GetImage("Data", "Light");
                btnChangelog.Image = IconLibrary.Instance.GetImage("Changelog", "Light");
                btnSettings.Image = IconLibrary.Instance.GetImage("Data", "Light");
                btnInfo.Image = IconLibrary.Instance.GetImage("Data", "Light");
                cbtnCloseApp.Image = IconLibrary.Instance.GetImage("Close", "Light");
                gpnlBorder1.ColorOne = Color.Black;
                gpnlBorder1.ColorTwo = Color.DimGray;
                lsvRecentChanges.ForeColor = Color.Black;
                lsvRecentChanges.BackColor = Color.White;
                 lblTabTitle.ForeColor = Color.Black;
            }

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

            //Display latest changes
            lsvRecentChanges.View = View.Details;
            lsvRecentChanges.Columns.Add("Change Log", -2, HorizontalAlignment.Left);

            // Populate ListView with the last 3 entries from the change log
            List<string> changeLog = new List<string>();
            Read r = new Read();
            changeLog = r.changeLogRead();

            foreach (string log in changeLog)
            {
                ListViewItem row = new ListViewItem(log); // Initialize ListViewItem with the log text
                lsvRecentChanges.Items.Add(row); // Add the item to the ListView
            }
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


        public void OnThemeChanged()
        {
           
            settings.readIni();

            if (settings.theme.ToLower() == "dark")
            {
                ThemeHandler.ApplyDarkMode(this);
            }
            else
            {
                ThemeHandler.ApplyLightMode(this);
            }

            // Trigger a refresh of the main form's appearance
            RefreshFormAppearance();
        }

        public void RefreshFormAppearance()
        {
            
            this.Invalidate();
            this.Update();
        }

        private void btnPrevious_pnlMainTableContainer_Click(object sender, EventArgs e)
        {
            src.MovePrevious();
            //Implement  logic
        }

        private void btnNext_pnlMainTableContainer_Click(object sender, EventArgs e)
        {
            src.MoveNext();
            //Implement next logic

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            settings.readIni();
            if (settings.theme.ToLower() == "dark")
            {
                // Apply Dark Theme
                ThemeHandler.ApplyDarkMode(this);

                pnlNavContainer.ColorOne = Color.FromArgb(33, 42, 62);
                pnlNavContainer.ColorTwo = Color.FromArgb(51, 65, 95);
                btnDashboard.Image = IconLibrary.Instance.GetImage("HomeS", "Dark");
                btnStudentData.Image = IconLibrary.Instance.GetImage("Data", "Dark");
                btnChangelog.Image = IconLibrary.Instance.GetImage("Changelog", "Dark");
                btnSettings.Image = IconLibrary.Instance.GetImage("Data", "Dark");
                btnInfo.Image = IconLibrary.Instance.GetImage("Data", "Dark");
                cbtnCloseApp.Image = IconLibrary.Instance.GetImage("Close", "Dark");
                dgvStudents_pnlMainTableContainer.ForeColor = Color.Black;
                btnDashboard.ForeColor = Color.White;
                btnStudentData.ForeColor = Color.White;
                btnChangelog.ForeColor = Color.White;
                btnSettings.ForeColor = Color.White;
                btnInfo.ForeColor = Color.White;
                lsvRecentChanges.ForeColor = Color.White;
                gpnlBorder1.ColorOne = Color.FromArgb(155, 164, 181);
                gpnlBorder1.ColorTwo = Color.FromArgb(33, 42, 62);
                lblTabTitle.ForeColor = Color.White;
                //
                lsvRecentChanges.BackColor = Color.Black;
            }
            else
            {
                // Apply Light Theme
                ThemeHandler.ApplyLightMode(this);
                pnlNavContainer.ColorOne = Color.FromArgb(223, 105, 13);
                pnlNavContainer.ColorTwo = Color.FromArgb(237, 140, 65);
                btnDashboard.Image = IconLibrary.Instance.GetImage("HomeS", "Light");
                btnStudentData.Image = IconLibrary.Instance.GetImage("Data", "Light");
                btnChangelog.Image = IconLibrary.Instance.GetImage("Changelog", "Light");
                btnSettings.Image = IconLibrary.Instance.GetImage("Data", "Light");
                btnInfo.Image = IconLibrary.Instance.GetImage("Data", "Light");
                cbtnCloseApp.Image = IconLibrary.Instance.GetImage("Close", "Light");
                gpnlBorder1.ColorOne = Color.Black;
                gpnlBorder1.ColorTwo = Color.DimGray;
                lsvRecentChanges.ForeColor = Color.Black;
                lsvRecentChanges.BackColor = Color.White;
                lblTabTitle.ForeColor = Color.Black;
            }

            lblTabTitle.Text = "Dashboard";

            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(240, 210, 144); 
            childFormPanel.Controls.Clear();
            childFormPanel.Hide();

        }



        private void btnStudentData_Click(object sender, EventArgs e)
        {
            lblTabTitle.Text = "Student Data";

            pnlNav.Height = btnStudentData.Height;
            pnlNav.Top = btnStudentData.Top;
            pnlNav.Left = btnStudentData.Left;
            btnStudentData.BackColor = Color.FromArgb(240, 210, 144); //put into theme handler class 
            btnDashboard.BackColor = Color.Transparent; //add to theme handler
                                                        // Show the child form in the panel
            childFormPanel.Visible = true;
            TasksForm testerForm = new TasksForm();
            testerForm.OnFormClosed += TesterForm_OnFormClosed;
            childFormDisplayer.DisplayForm(testerForm);




        }

        private void btnDataSummary_Click(object sender, EventArgs e)
        {
            lblTabTitle.Text = "Changelog";
            btnDashboard.BackColor = Color.Transparent;
            pnlNav.Height = btnChangelog.Height;
            pnlNav.Top = btnChangelog.Top;
            pnlNav.Left = btnChangelog.Left;
            btnChangelog.BackColor = Color.FromArgb(240, 210, 144);


            childFormPanel.Visible = true;
            ChangelogForm testerForm = new ChangelogForm();
            testerForm.OnFormClosed += TesterForm_OnFormClosed;
            childFormDisplayer.DisplayForm(testerForm);
        }

        private void btnChangelog_Click(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(240, 210, 144);
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;

            // Show the child form in the panel
            childFormPanel.Visible = true;
            ChangelogForm testerForm = new ChangelogForm();
            testerForm.OnFormClosed += TesterForm_OnFormClosed;
            childFormDisplayer.DisplayForm(testerForm);

        }
        private void TesterForm_OnFormClosed()
        {

            btnDashboard.BackColor = Color.FromArgb(240, 210, 144);
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;



            childFormPanel.Controls.Clear();
            childFormPanel.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {



            lblTabTitle.Text = "Settings";
            btnDashboard.BackColor = Color.Transparent;
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(240, 210, 144); //put into theme handler class


            // Show the child form in the panel
            childFormPanel.Visible = true;
            SettingsForm testerForm = new SettingsForm();
            testerForm.OnFormClosed += TesterForm_OnFormClosed;
         
            childFormDisplayer.DisplayForm(testerForm);



        }
        private void btnInfo_Click(object sender, EventArgs e)
        {

            lblTabTitle.Text = "Info";
            btnDashboard.BackColor = Color.Transparent;
            pnlNav.Height = btnInfo.Height;
            pnlNav.Top = btnInfo.Top;
            pnlNav.Left = btnInfo.Left;
            btnInfo.BackColor = Color.FromArgb(240, 210, 144); //put into theme handler

            childFormPanel.Visible = true;
            InfoForm testerForm = new InfoForm();
            testerForm.OnFormClosed += TesterForm_OnFormClosed; // Subscribe to the event
            childFormDisplayer.DisplayForm(testerForm);

        }





        private void btnDashboard_Leave(object sender, EventArgs e)
        {

            btnDashboard.BackColor = Color.Transparent;
        }

        private void btnStudentData_Leave(object sender, EventArgs e)
        {


            btnStudentData.BackColor = Color.Transparent;
        }

        private void btnDataSummary_Leave(object sender, EventArgs e)
        {


            btnChangelog.BackColor = Color.Transparent; //add to theme handler
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


        private void cbtnCloseApp_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}