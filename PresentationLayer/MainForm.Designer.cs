
using WinFormsApp_MainProjectFile.PresentationLayer.CustomControls;

namespace WinFormsApp_MainProjectFile.PresentationLayer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlNavContainer = new CustomGradientPanels();
            pnlNav = new Panel();
            btnSettings = new Button();
            btnInfo = new Button();
            btnChangelog = new Button();
            btnStudentData = new Button();
            btnDashboard = new Button();
            pnlTabTitleContainer = new Panel();
            lblTabTitle = new Label();
            gpnlMainFormContainer = new CustomGradientPanels();
            cbtnCloseApp = new CustomButtons();
            btnClearSearch = new Button();
            pnlCalendarContainer = new Panel();
            gpnlCalenderContainerTop = new CustomGradientPanels();
            mcCalendar_pnlCalendarContainer = new MonthCalendar();
            pnlContainerMiddle = new Panel();
            rtxtStatusContent = new RichTextBox();
            lblStatusTitle = new Label();
            gpnlContainerMiddleTop = new CustomGradientPanels();
            pnlTableContainer = new Panel();
            dgvStudents_pnlMainTableContainer = new DataGridView();
            btnPrevious_pnlMainTableContainer = new Button();
            btnNext_pnlMainTableContainer = new Button();
            gpnlTopTableContainer = new CustomGradientPanels();
            pnlMainTableContainer = new Panel();
            txtSearchBox = new TextBox();
            pnlNavContainer.SuspendLayout();
            pnlTabTitleContainer.SuspendLayout();
            gpnlMainFormContainer.SuspendLayout();
            pnlCalendarContainer.SuspendLayout();
            pnlContainerMiddle.SuspendLayout();
            pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents_pnlMainTableContainer).BeginInit();
            pnlMainTableContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavContainer
            // 
            pnlNavContainer.ColorOne = Color.FromArgb(223, 105, 13);
            pnlNavContainer.ColorTwo = Color.FromArgb(237, 140, 65);
            pnlNavContainer.Controls.Add(pnlNav);
            pnlNavContainer.Controls.Add(btnSettings);
            pnlNavContainer.Controls.Add(btnInfo);
            pnlNavContainer.Controls.Add(btnChangelog);
            pnlNavContainer.Controls.Add(btnStudentData);
            pnlNavContainer.Controls.Add(btnDashboard);
            pnlNavContainer.Controls.Add(pnlTabTitleContainer);
            pnlNavContainer.Dock = DockStyle.Left;
            pnlNavContainer.GradientAngle = 0F;
            pnlNavContainer.Location = new Point(0, 0);
            pnlNavContainer.Margin = new Padding(4);
            pnlNavContainer.Name = "pnlNavContainer";
            pnlNavContainer.OpacityColourOne = 255;
            pnlNavContainer.OpacityColourTwo = 255;
            pnlNavContainer.Size = new Size(217, 825);
            pnlNavContainer.TabIndex = 0;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(255, 219, 51);
            pnlNav.Location = new Point(0, 223);
            pnlNav.Margin = new Padding(4);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(4, 116);
            pnlNav.TabIndex = 35;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.Black;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new Point(0, 677);
            btnSettings.Margin = new Padding(4);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(24, 0, 0, 0);
            btnSettings.Size = new Size(217, 74);
            btnSettings.TabIndex = 20;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            btnSettings.Leave += btnSettings_Leave;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Transparent;
            btnInfo.Dock = DockStyle.Bottom;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInfo.ForeColor = Color.Black;
            btnInfo.Image = (Image)resources.GetObject("btnInfo.Image");
            btnInfo.Location = new Point(0, 751);
            btnInfo.Margin = new Padding(4);
            btnInfo.Name = "btnInfo";
            btnInfo.Padding = new Padding(24, 0, 0, 0);
            btnInfo.Size = new Size(217, 74);
            btnInfo.TabIndex = 19;
            btnInfo.Text = "Information";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            btnInfo.Leave += btnInfo_Leave;
            // 
            // btnChangelog
            // 
            btnChangelog.BackColor = Color.Transparent;
            btnChangelog.Dock = DockStyle.Top;
            btnChangelog.FlatAppearance.BorderSize = 0;
            btnChangelog.FlatStyle = FlatStyle.Flat;
            btnChangelog.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangelog.ForeColor = Color.Black;
            btnChangelog.Image = (Image)resources.GetObject("btnChangelog.Image");
            btnChangelog.Location = new Point(0, 252);
            btnChangelog.Margin = new Padding(4);
            btnChangelog.Name = "btnChangelog";
            btnChangelog.Padding = new Padding(24, 0, 0, 0);
            btnChangelog.Size = new Size(217, 74);
            btnChangelog.TabIndex = 17;
            btnChangelog.Text = "Changelog\r";
            btnChangelog.TextAlign = ContentAlignment.MiddleLeft;
            btnChangelog.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnChangelog.UseVisualStyleBackColor = false;
            btnChangelog.Click += btnChangelog_Click;
            btnChangelog.Leave += btnDataSummary_Leave;
            // 
            // btnStudentData
            // 
            btnStudentData.BackColor = Color.Transparent;
            btnStudentData.Dock = DockStyle.Top;
            btnStudentData.FlatAppearance.BorderSize = 0;
            btnStudentData.FlatStyle = FlatStyle.Flat;
            btnStudentData.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentData.ForeColor = Color.Black;
            btnStudentData.Image = (Image)resources.GetObject("btnStudentData.Image");
            btnStudentData.Location = new Point(0, 178);
            btnStudentData.Margin = new Padding(4);
            btnStudentData.Name = "btnStudentData";
            btnStudentData.Padding = new Padding(24, 0, 0, 0);
            btnStudentData.Size = new Size(217, 74);
            btnStudentData.TabIndex = 14;
            btnStudentData.Text = "Student Data";
            btnStudentData.TextAlign = ContentAlignment.MiddleLeft;
            btnStudentData.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnStudentData.UseVisualStyleBackColor = false;
            btnStudentData.Click += btnStudentData_Click;
            btnStudentData.Leave += btnStudentData_Leave;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.Location = new Point(0, 104);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(24, 0, 0, 0);
            btnDashboard.Size = new Size(217, 74);
            btnDashboard.TabIndex = 15;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.Leave += btnDashboard_Leave;
            // 
            // pnlTabTitleContainer
            // 
            pnlTabTitleContainer.BackColor = Color.Transparent;
            pnlTabTitleContainer.Controls.Add(lblTabTitle);
            pnlTabTitleContainer.Dock = DockStyle.Top;
            pnlTabTitleContainer.Location = new Point(0, 0);
            pnlTabTitleContainer.Margin = new Padding(4);
            pnlTabTitleContainer.Name = "pnlTabTitleContainer";
            pnlTabTitleContainer.Size = new Size(217, 104);
            pnlTabTitleContainer.TabIndex = 13;
            // 
            // lblTabTitle
            // 
            lblTabTitle.AutoSize = true;
            lblTabTitle.FlatStyle = FlatStyle.Flat;
            lblTabTitle.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTabTitle.ForeColor = Color.Black;
            lblTabTitle.Location = new Point(34, 36);
            lblTabTitle.Margin = new Padding(4, 0, 4, 0);
            lblTabTitle.Name = "lblTabTitle";
            lblTabTitle.Size = new Size(104, 29);
            lblTabTitle.TabIndex = 0;
            lblTabTitle.Text = "TabTitle";
            // 
            // gpnlMainFormContainer
            // 
            gpnlMainFormContainer.ColorOne = Color.FromArgb(255, 192, 128);
            gpnlMainFormContainer.ColorTwo = Color.FromArgb(255, 192, 192);
            gpnlMainFormContainer.Controls.Add(cbtnCloseApp);
            gpnlMainFormContainer.Controls.Add(btnClearSearch);
            gpnlMainFormContainer.Controls.Add(pnlCalendarContainer);
            gpnlMainFormContainer.Controls.Add(pnlContainerMiddle);
            gpnlMainFormContainer.Dock = DockStyle.Fill;
            gpnlMainFormContainer.GradientAngle = 315F;
            gpnlMainFormContainer.Location = new Point(0, 0);
            gpnlMainFormContainer.Margin = new Padding(4);
            gpnlMainFormContainer.Name = "gpnlMainFormContainer";
            gpnlMainFormContainer.OpacityColourOne = 100;
            gpnlMainFormContainer.OpacityColourTwo = 50;
            gpnlMainFormContainer.Size = new Size(1285, 825);
            gpnlMainFormContainer.TabIndex = 0;
            // 
            // cbtnCloseApp
            // 
            cbtnCloseApp.BackColor = Color.FromArgb(255, 192, 192);
            cbtnCloseApp.BackgroundColor = Color.FromArgb(255, 192, 192);
            cbtnCloseApp.BorderColor = Color.Black;
            cbtnCloseApp.BorderRadius = 10;
            cbtnCloseApp.BorderSize = 0;
            cbtnCloseApp.FlatAppearance.BorderSize = 0;
            cbtnCloseApp.FlatStyle = FlatStyle.Popup;
            cbtnCloseApp.ForeColor = Color.Black;
            cbtnCloseApp.Image = (Image)resources.GetObject("cbtnCloseApp.Image");
            cbtnCloseApp.Location = new Point(1210, -7);
            cbtnCloseApp.Name = "cbtnCloseApp";
            cbtnCloseApp.Size = new Size(75, 68);
            cbtnCloseApp.TabIndex = 9;
            cbtnCloseApp.TextColor = Color.Black;
            cbtnCloseApp.UseVisualStyleBackColor = false;
            cbtnCloseApp.Click += cbtnCloseApp_Click;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.Transparent;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearSearch.Location = new Point(710, 38);
            btnClearSearch.Margin = new Padding(4);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(20, 28);
            btnClearSearch.TabIndex = 8;
            btnClearSearch.Text = "X";
            btnClearSearch.UseVisualStyleBackColor = false;
            // 
            // pnlCalendarContainer
            // 
            pnlCalendarContainer.BackColor = Color.White;
            pnlCalendarContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlCalendarContainer.Controls.Add(gpnlCalenderContainerTop);
            pnlCalendarContainer.Controls.Add(mcCalendar_pnlCalendarContainer);
            pnlCalendarContainer.ForeColor = Color.FromArgb(50, 12, 27);
            pnlCalendarContainer.Location = new Point(772, 105);
            pnlCalendarContainer.Margin = new Padding(4);
            pnlCalendarContainer.Name = "pnlCalendarContainer";
            pnlCalendarContainer.Size = new Size(474, 361);
            pnlCalendarContainer.TabIndex = 3;
            // 
            // gpnlCalenderContainerTop
            // 
            gpnlCalenderContainerTop.ColorOne = Color.Black;
            gpnlCalenderContainerTop.ColorTwo = Color.DimGray;
            gpnlCalenderContainerTop.Dock = DockStyle.Top;
            gpnlCalenderContainerTop.GradientAngle = 90F;
            gpnlCalenderContainerTop.Location = new Point(0, 0);
            gpnlCalenderContainerTop.Margin = new Padding(4);
            gpnlCalenderContainerTop.Name = "gpnlCalenderContainerTop";
            gpnlCalenderContainerTop.OpacityColourOne = 255;
            gpnlCalenderContainerTop.OpacityColourTwo = 255;
            gpnlCalenderContainerTop.Size = new Size(472, 23);
            gpnlCalenderContainerTop.TabIndex = 1;
            // 
            // mcCalendar_pnlCalendarContainer
            // 
            mcCalendar_pnlCalendarContainer.BackColor = Color.White;
            mcCalendar_pnlCalendarContainer.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcCalendar_pnlCalendarContainer.Location = new Point(128, 56);
            mcCalendar_pnlCalendarContainer.Margin = new Padding(10);
            mcCalendar_pnlCalendarContainer.Name = "mcCalendar_pnlCalendarContainer";
            mcCalendar_pnlCalendarContainer.TabIndex = 0;
            // 
            // pnlContainerMiddle
            // 
            pnlContainerMiddle.BackColor = Color.White;
            pnlContainerMiddle.BorderStyle = BorderStyle.FixedSingle;
            pnlContainerMiddle.Controls.Add(rtxtStatusContent);
            pnlContainerMiddle.Controls.Add(lblStatusTitle);
            pnlContainerMiddle.Controls.Add(gpnlContainerMiddleTop);
            pnlContainerMiddle.ForeColor = Color.FromArgb(50, 12, 27);
            pnlContainerMiddle.Location = new Point(773, 506);
            pnlContainerMiddle.Margin = new Padding(4);
            pnlContainerMiddle.Name = "pnlContainerMiddle";
            pnlContainerMiddle.Size = new Size(474, 283);
            pnlContainerMiddle.TabIndex = 4;
            // 
            // rtxtStatusContent
            // 
            rtxtStatusContent.AcceptsTab = true;
            rtxtStatusContent.BackColor = Color.White;
            rtxtStatusContent.BorderStyle = BorderStyle.None;
            rtxtStatusContent.Dock = DockStyle.Bottom;
            rtxtStatusContent.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtStatusContent.ForeColor = Color.Black;
            rtxtStatusContent.Location = new Point(0, 65);
            rtxtStatusContent.Margin = new Padding(0);
            rtxtStatusContent.MaxLength = 500;
            rtxtStatusContent.Name = "rtxtStatusContent";
            rtxtStatusContent.ReadOnly = true;
            rtxtStatusContent.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtxtStatusContent.Size = new Size(472, 216);
            rtxtStatusContent.TabIndex = 0;
            rtxtStatusContent.Text = "";
            rtxtStatusContent.TextChanged += rtxtStatusContent_TextChanged;
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.Anchor = AnchorStyles.Bottom;
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.BackColor = Color.Transparent;
            lblStatusTitle.FlatStyle = FlatStyle.Flat;
            lblStatusTitle.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusTitle.ForeColor = Color.Black;
            lblStatusTitle.Location = new Point(4, 33);
            lblStatusTitle.Margin = new Padding(4, 0, 4, 0);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(151, 18);
            lblStatusTitle.TabIndex = 0;
            lblStatusTitle.Text = "Recent Changes";
            // 
            // gpnlContainerMiddleTop
            // 
            gpnlContainerMiddleTop.ColorOne = Color.Black;
            gpnlContainerMiddleTop.ColorTwo = Color.DimGray;
            gpnlContainerMiddleTop.Dock = DockStyle.Top;
            gpnlContainerMiddleTop.GradientAngle = 90F;
            gpnlContainerMiddleTop.Location = new Point(0, 0);
            gpnlContainerMiddleTop.Margin = new Padding(4);
            gpnlContainerMiddleTop.Name = "gpnlContainerMiddleTop";
            gpnlContainerMiddleTop.OpacityColourOne = 255;
            gpnlContainerMiddleTop.OpacityColourTwo = 255;
            gpnlContainerMiddleTop.Size = new Size(472, 19);
            gpnlContainerMiddleTop.TabIndex = 1;
            // 
            // pnlTableContainer
            // 
            pnlTableContainer.Controls.Add(dgvStudents_pnlMainTableContainer);
            pnlTableContainer.Location = new Point(22, 40);
            pnlTableContainer.Margin = new Padding(4);
            pnlTableContainer.Name = "pnlTableContainer";
            pnlTableContainer.Size = new Size(420, 526);
            pnlTableContainer.TabIndex = 0;
            // 
            // dgvStudents_pnlMainTableContainer
            // 
            dgvStudents_pnlMainTableContainer.AllowUserToAddRows = false;
            dgvStudents_pnlMainTableContainer.AllowUserToDeleteRows = false;
            dgvStudents_pnlMainTableContainer.AllowUserToOrderColumns = true;
            dgvStudents_pnlMainTableContainer.BackgroundColor = Color.White;
            dgvStudents_pnlMainTableContainer.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 210, 189);
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(198, 93, 123);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(254, 252, 243);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudents_pnlMainTableContainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudents_pnlMainTableContainer.ColumnHeadersHeight = 35;
            dgvStudents_pnlMainTableContainer.Cursor = Cursors.Cross;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(235, 227, 213);
            dataGridViewCellStyle2.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(50, 12, 27);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(184, 180, 171);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStudents_pnlMainTableContainer.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStudents_pnlMainTableContainer.Dock = DockStyle.Fill;
            dgvStudents_pnlMainTableContainer.EnableHeadersVisualStyles = false;
            dgvStudents_pnlMainTableContainer.GridColor = Color.Black;
            dgvStudents_pnlMainTableContainer.Location = new Point(0, 0);
            dgvStudents_pnlMainTableContainer.Margin = new Padding(4);
            dgvStudents_pnlMainTableContainer.MultiSelect = false;
            dgvStudents_pnlMainTableContainer.Name = "dgvStudents_pnlMainTableContainer";
            dgvStudents_pnlMainTableContainer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(119, 107, 93);
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(254, 250, 246);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(179, 169, 157);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(251, 236, 221);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvStudents_pnlMainTableContainer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvStudents_pnlMainTableContainer.RowHeadersWidth = 10;
            dgvStudents_pnlMainTableContainer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents_pnlMainTableContainer.Size = new Size(420, 526);
            dgvStudents_pnlMainTableContainer.TabIndex = 0;
            // 
            // btnPrevious_pnlMainTableContainer
            // 
            btnPrevious_pnlMainTableContainer.BackColor = Color.FromArgb(208, 187, 195);
            btnPrevious_pnlMainTableContainer.FlatAppearance.BorderColor = Color.FromArgb(7, 25, 82);
            btnPrevious_pnlMainTableContainer.FlatAppearance.BorderSize = 0;
            btnPrevious_pnlMainTableContainer.FlatStyle = FlatStyle.Flat;
            btnPrevious_pnlMainTableContainer.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevious_pnlMainTableContainer.ForeColor = Color.Black;
            btnPrevious_pnlMainTableContainer.Location = new Point(130, 593);
            btnPrevious_pnlMainTableContainer.Margin = new Padding(4);
            btnPrevious_pnlMainTableContainer.Name = "btnPrevious_pnlMainTableContainer";
            btnPrevious_pnlMainTableContainer.Size = new Size(94, 34);
            btnPrevious_pnlMainTableContainer.TabIndex = 1;
            btnPrevious_pnlMainTableContainer.Text = "Previous";
            btnPrevious_pnlMainTableContainer.UseVisualStyleBackColor = false;
            btnPrevious_pnlMainTableContainer.Click += btnPrevious_pnlMainTableContainer_Click;
            // 
            // btnNext_pnlMainTableContainer
            // 
            btnNext_pnlMainTableContainer.BackColor = Color.FromArgb(208, 187, 195);
            btnNext_pnlMainTableContainer.FlatAppearance.BorderColor = Color.FromArgb(7, 25, 82);
            btnNext_pnlMainTableContainer.FlatAppearance.BorderSize = 0;
            btnNext_pnlMainTableContainer.FlatStyle = FlatStyle.Flat;
            btnNext_pnlMainTableContainer.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext_pnlMainTableContainer.ForeColor = Color.Black;
            btnNext_pnlMainTableContainer.Location = new Point(232, 593);
            btnNext_pnlMainTableContainer.Margin = new Padding(4);
            btnNext_pnlMainTableContainer.Name = "btnNext_pnlMainTableContainer";
            btnNext_pnlMainTableContainer.Size = new Size(94, 34);
            btnNext_pnlMainTableContainer.TabIndex = 2;
            btnNext_pnlMainTableContainer.Text = "Next";
            btnNext_pnlMainTableContainer.UseVisualStyleBackColor = false;
            btnNext_pnlMainTableContainer.Click += btnNext_pnlMainTableContainer_Click;
            // 
            // gpnlTopTableContainer
            // 
            gpnlTopTableContainer.ColorOne = Color.Black;
            gpnlTopTableContainer.ColorTwo = Color.DimGray;
            gpnlTopTableContainer.Dock = DockStyle.Top;
            gpnlTopTableContainer.GradientAngle = 90F;
            gpnlTopTableContainer.Location = new Point(0, 0);
            gpnlTopTableContainer.Margin = new Padding(4);
            gpnlTopTableContainer.Name = "gpnlTopTableContainer";
            gpnlTopTableContainer.OpacityColourOne = 255;
            gpnlTopTableContainer.OpacityColourTwo = 255;
            gpnlTopTableContainer.Size = new Size(463, 22);
            gpnlTopTableContainer.TabIndex = 3;
            // 
            // pnlMainTableContainer
            // 
            pnlMainTableContainer.BackColor = Color.White;
            pnlMainTableContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlMainTableContainer.Controls.Add(gpnlTopTableContainer);
            pnlMainTableContainer.Controls.Add(btnNext_pnlMainTableContainer);
            pnlMainTableContainer.Controls.Add(btnPrevious_pnlMainTableContainer);
            pnlMainTableContainer.Controls.Add(pnlTableContainer);
            pnlMainTableContainer.ForeColor = Color.FromArgb(50, 12, 27);
            pnlMainTableContainer.Location = new Point(238, 104);
            pnlMainTableContainer.Margin = new Padding(4);
            pnlMainTableContainer.Name = "pnlMainTableContainer";
            pnlMainTableContainer.Size = new Size(465, 685);
            pnlMainTableContainer.TabIndex = 1;
            // 
            // txtSearchBox
            // 
            txtSearchBox.BackColor = Color.FromArgb(255, 251, 254);
            txtSearchBox.BorderStyle = BorderStyle.FixedSingle;
            txtSearchBox.CharacterCasing = CharacterCasing.Lower;
            txtSearchBox.Font = new Font("Consolas", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSearchBox.Location = new Point(238, 41);
            txtSearchBox.Margin = new Padding(4);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(465, 20);
            txtSearchBox.TabIndex = 7;
            txtSearchBox.Text = "search...";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1285, 825);
            Controls.Add(pnlNavContainer);
            Controls.Add(txtSearchBox);
            Controls.Add(pnlMainTableContainer);
            Controls.Add(gpnlMainFormContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            pnlNavContainer.ResumeLayout(false);
            pnlTabTitleContainer.ResumeLayout(false);
            pnlTabTitleContainer.PerformLayout();
            gpnlMainFormContainer.ResumeLayout(false);
            pnlCalendarContainer.ResumeLayout(false);
            pnlContainerMiddle.ResumeLayout(false);
            pnlContainerMiddle.PerformLayout();
            pnlTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents_pnlMainTableContainer).EndInit();
            pnlMainTableContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public System.Windows.Forms.Button btnClearSearch;
        private CustomGradientPanels pnlNavContainer;
        public System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel pnlNav;
     
        public System.Windows.Forms.Button btnChangelog;
        public System.Windows.Forms.Button btnStudentData;
        public System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlTabTitleContainer;
        public System.Windows.Forms.Label lblTabTitle;
        public CustomGradientPanels gpnlMainFormContainer;
        public System.Windows.Forms.Button btnSettings;
        public CustomGradientPanels gpnlContainerMiddleTop;
        public Label lblStatusTitle;
        public RichTextBox rtxtStatusContent;
        public Panel pnlContainerMiddle;
        private MonthCalendar mcCalendar_pnlCalendarContainer;
        private CustomGradientPanels gpnlCalenderContainerTop;
        public Panel pnlCalendarContainer;
        private Panel pnlTableContainer;
        public DataGridView dgvStudents_pnlMainTableContainer;
        public Button btnPrevious_pnlMainTableContainer;
        public Button btnNext_pnlMainTableContainer;
        public CustomGradientPanels gpnlTopTableContainer;
        public Panel pnlMainTableContainer;
        public TextBox txtSearchBox;
        private CustomButtons cbtnCloseApp;
    }
}

