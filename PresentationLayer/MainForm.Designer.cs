
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
			components = new System.ComponentModel.Container();
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			Timer_Sidebar_Menu = new System.Windows.Forms.Timer(components);
			pnlCalendarContainer = new Panel();
			gpnlCalenderContainerTop = new CustomGradientPanels();
			mcCalendar_pnlCalendarContainer = new MonthCalendar();
			pnlContainerMiddle = new Panel();
			rtxtStatusContent = new RichTextBox();
			lblStatusTitle = new Label();
			gpnlContainerMiddleTop = new CustomGradientPanels();
			txtSearchBox = new TextBox();
			pnlContainerBottom = new Panel();
			rtxtStatusContextLower = new RichTextBox();
			lblStatusLower = new Label();
			gpnlContainerBottomTop = new CustomGradientPanels();
			pnlMainTableContainer = new Panel();
			gpnlTopTableContainer = new CustomGradientPanels();
			btnNext_pnlMainTableContainer = new Button();
			btnPrevious_pnlMainTableContainer = new Button();
			pnlTableContainer = new Panel();
			dgvStudents_pnlMainTableContainer = new DataGridView();
			btnCloseApp = new Button();
			pnlNavContainer = new CustomGradientPanels();
			pnlNav = new Panel();
			btnSettings = new Button();
			btnInfo = new Button();
			btnDataSummary = new Button();
			btnStudentData = new Button();
			btnDashboard = new Button();
			pnlTabTitleContainer = new Panel();
			lblTabTitle = new Label();
			mainFormPnlContainer = new CustomGradientPanels();
			btnClearSearch = new Button();
			pnlCalendarContainer.SuspendLayout();
			pnlContainerMiddle.SuspendLayout();
			pnlContainerBottom.SuspendLayout();
			pnlMainTableContainer.SuspendLayout();
			pnlTableContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvStudents_pnlMainTableContainer).BeginInit();
			pnlNavContainer.SuspendLayout();
			pnlTabTitleContainer.SuspendLayout();
			mainFormPnlContainer.SuspendLayout();
			SuspendLayout();
			// 
			// Timer_Sidebar_Menu
			// 
			Timer_Sidebar_Menu.Interval = 10;
			Timer_Sidebar_Menu.Tick += Timer_Sidebar_Menu_Tick;
			// 
			// pnlCalendarContainer
			// 
			pnlCalendarContainer.BackColor = Color.White;
			pnlCalendarContainer.BorderStyle = BorderStyle.FixedSingle;
			pnlCalendarContainer.Controls.Add(gpnlCalenderContainerTop);
			pnlCalendarContainer.Controls.Add(mcCalendar_pnlCalendarContainer);
			pnlCalendarContainer.ForeColor = Color.FromArgb(50, 12, 27);
			pnlCalendarContainer.Location = new Point(827, 137);
			pnlCalendarContainer.Margin = new Padding(4, 5, 4, 5);
			pnlCalendarContainer.Name = "pnlCalendarContainer";
			pnlCalendarContainer.Size = new Size(542, 427);
			pnlCalendarContainer.TabIndex = 3;
			// 
			// gpnlCalenderContainerTop
			// 
			gpnlCalenderContainerTop.ColorOne = Color.Black;
			gpnlCalenderContainerTop.ColorTwo = Color.DimGray;
			gpnlCalenderContainerTop.Dock = DockStyle.Top;
			gpnlCalenderContainerTop.GradientAngle = 90F;
			gpnlCalenderContainerTop.Location = new Point(0, 0);
			gpnlCalenderContainerTop.Margin = new Padding(4, 5, 4, 5);
			gpnlCalenderContainerTop.Name = "gpnlCalenderContainerTop";
			gpnlCalenderContainerTop.OpacityColourOne = 255;
			gpnlCalenderContainerTop.OpacityColourTwo = 255;
			gpnlCalenderContainerTop.Size = new Size(540, 31);
			gpnlCalenderContainerTop.TabIndex = 1;
			// 
			// mcCalendar_pnlCalendarContainer
			// 
			mcCalendar_pnlCalendarContainer.BackColor = Color.White;
			mcCalendar_pnlCalendarContainer.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			mcCalendar_pnlCalendarContainer.Location = new Point(111, 46);
			mcCalendar_pnlCalendarContainer.Margin = new Padding(12, 14, 12, 14);
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
			pnlContainerMiddle.Location = new Point(827, 600);
			pnlContainerMiddle.Margin = new Padding(4, 5, 4, 5);
			pnlContainerMiddle.Name = "pnlContainerMiddle";
			pnlContainerMiddle.Size = new Size(542, 157);
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
			rtxtStatusContent.Location = new Point(0, 49);
			rtxtStatusContent.Margin = new Padding(0);
			rtxtStatusContent.MaxLength = 500;
			rtxtStatusContent.Name = "rtxtStatusContent";
			rtxtStatusContent.ReadOnly = true;
			rtxtStatusContent.ScrollBars = RichTextBoxScrollBars.Vertical;
			rtxtStatusContent.Size = new Size(540, 106);
			rtxtStatusContent.TabIndex = 0;
			rtxtStatusContent.Text = "heyheyhey Put in status content here";
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
			lblStatusTitle.Location = new Point(24, 17);
			lblStatusTitle.Margin = new Padding(4, 0, 4, 0);
			lblStatusTitle.Name = "lblStatusTitle";
			lblStatusTitle.Size = new Size(83, 25);
			lblStatusTitle.TabIndex = 0;
			lblStatusTitle.Text = "Status";
			// 
			// gpnlContainerMiddleTop
			// 
			gpnlContainerMiddleTop.ColorOne = Color.Black;
			gpnlContainerMiddleTop.ColorTwo = Color.DimGray;
			gpnlContainerMiddleTop.Dock = DockStyle.Top;
			gpnlContainerMiddleTop.GradientAngle = 90F;
			gpnlContainerMiddleTop.Location = new Point(0, 0);
			gpnlContainerMiddleTop.Margin = new Padding(4, 5, 4, 5);
			gpnlContainerMiddleTop.Name = "gpnlContainerMiddleTop";
			gpnlContainerMiddleTop.OpacityColourOne = 255;
			gpnlContainerMiddleTop.OpacityColourTwo = 255;
			gpnlContainerMiddleTop.Size = new Size(540, 25);
			gpnlContainerMiddleTop.TabIndex = 1;
			// 
			// txtSearchBox
			// 
			txtSearchBox.BackColor = Color.FromArgb(255, 251, 254);
			txtSearchBox.BorderStyle = BorderStyle.FixedSingle;
			txtSearchBox.CharacterCasing = CharacterCasing.Lower;
			txtSearchBox.Font = new Font("Consolas", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
			txtSearchBox.Location = new Point(272, 55);
			txtSearchBox.Margin = new Padding(4, 5, 4, 5);
			txtSearchBox.Name = "txtSearchBox";
			txtSearchBox.Size = new Size(531, 24);
			txtSearchBox.TabIndex = 7;
			txtSearchBox.Text = "search...";
			// 
			// pnlContainerBottom
			// 
			pnlContainerBottom.BackColor = Color.White;
			pnlContainerBottom.BorderStyle = BorderStyle.FixedSingle;
			pnlContainerBottom.Controls.Add(rtxtStatusContextLower);
			pnlContainerBottom.Controls.Add(lblStatusLower);
			pnlContainerBottom.Controls.Add(gpnlContainerBottomTop);
			pnlContainerBottom.ForeColor = Color.FromArgb(50, 12, 27);
			pnlContainerBottom.Location = new Point(827, 783);
			pnlContainerBottom.Margin = new Padding(4, 5, 4, 5);
			pnlContainerBottom.Name = "pnlContainerBottom";
			pnlContainerBottom.Size = new Size(542, 270);
			pnlContainerBottom.TabIndex = 10;
			// 
			// rtxtStatusContextLower
			// 
			rtxtStatusContextLower.AcceptsTab = true;
			rtxtStatusContextLower.BackColor = Color.White;
			rtxtStatusContextLower.BorderStyle = BorderStyle.None;
			rtxtStatusContextLower.Dock = DockStyle.Bottom;
			rtxtStatusContextLower.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			rtxtStatusContextLower.ForeColor = Color.Black;
			rtxtStatusContextLower.Location = new Point(0, 63);
			rtxtStatusContextLower.Margin = new Padding(0);
			rtxtStatusContextLower.MaxLength = 500;
			rtxtStatusContextLower.Name = "rtxtStatusContextLower";
			rtxtStatusContextLower.ReadOnly = true;
			rtxtStatusContextLower.ScrollBars = RichTextBoxScrollBars.Vertical;
			rtxtStatusContextLower.Size = new Size(540, 205);
			rtxtStatusContextLower.TabIndex = 0;
			rtxtStatusContextLower.Text = "heyheyhey Put in status content here";
			// 
			// lblStatusLower
			// 
			lblStatusLower.Anchor = AnchorStyles.Bottom;
			lblStatusLower.AutoSize = true;
			lblStatusLower.FlatStyle = FlatStyle.Flat;
			lblStatusLower.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblStatusLower.ForeColor = Color.Black;
			lblStatusLower.Location = new Point(24, 17);
			lblStatusLower.Margin = new Padding(4, 0, 4, 0);
			lblStatusLower.Name = "lblStatusLower";
			lblStatusLower.Size = new Size(83, 25);
			lblStatusLower.TabIndex = 0;
			lblStatusLower.Text = "Status";
			// 
			// gpnlContainerBottomTop
			// 
			gpnlContainerBottomTop.ColorOne = Color.Black;
			gpnlContainerBottomTop.ColorTwo = Color.DimGray;
			gpnlContainerBottomTop.Dock = DockStyle.Top;
			gpnlContainerBottomTop.GradientAngle = 90F;
			gpnlContainerBottomTop.Location = new Point(0, 0);
			gpnlContainerBottomTop.Margin = new Padding(4, 5, 4, 5);
			gpnlContainerBottomTop.Name = "gpnlContainerBottomTop";
			gpnlContainerBottomTop.OpacityColourOne = 255;
			gpnlContainerBottomTop.OpacityColourTwo = 255;
			gpnlContainerBottomTop.Size = new Size(540, 28);
			gpnlContainerBottomTop.TabIndex = 1;
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
			pnlMainTableContainer.Location = new Point(272, 138);
			pnlMainTableContainer.Margin = new Padding(4, 5, 4, 5);
			pnlMainTableContainer.Name = "pnlMainTableContainer";
			pnlMainTableContainer.Size = new Size(531, 913);
			pnlMainTableContainer.TabIndex = 1;
			// 
			// gpnlTopTableContainer
			// 
			gpnlTopTableContainer.ColorOne = Color.Black;
			gpnlTopTableContainer.ColorTwo = Color.DimGray;
			gpnlTopTableContainer.Dock = DockStyle.Top;
			gpnlTopTableContainer.GradientAngle = 90F;
			gpnlTopTableContainer.Location = new Point(0, 0);
			gpnlTopTableContainer.Margin = new Padding(4, 5, 4, 5);
			gpnlTopTableContainer.Name = "gpnlTopTableContainer";
			gpnlTopTableContainer.OpacityColourOne = 255;
			gpnlTopTableContainer.OpacityColourTwo = 255;
			gpnlTopTableContainer.Size = new Size(529, 29);
			gpnlTopTableContainer.TabIndex = 3;
			// 
			// btnNext_pnlMainTableContainer
			// 
			btnNext_pnlMainTableContainer.BackColor = Color.FromArgb(208, 187, 195);
			btnNext_pnlMainTableContainer.FlatAppearance.BorderColor = Color.FromArgb(7, 25, 82);
			btnNext_pnlMainTableContainer.FlatAppearance.BorderSize = 0;
			btnNext_pnlMainTableContainer.FlatStyle = FlatStyle.Flat;
			btnNext_pnlMainTableContainer.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnNext_pnlMainTableContainer.ForeColor = Color.Black;
			btnNext_pnlMainTableContainer.Location = new Point(265, 791);
			btnNext_pnlMainTableContainer.Margin = new Padding(4, 5, 4, 5);
			btnNext_pnlMainTableContainer.Name = "btnNext_pnlMainTableContainer";
			btnNext_pnlMainTableContainer.Size = new Size(108, 46);
			btnNext_pnlMainTableContainer.TabIndex = 2;
			btnNext_pnlMainTableContainer.Text = "Next";
			btnNext_pnlMainTableContainer.UseVisualStyleBackColor = false;
			btnNext_pnlMainTableContainer.Click += btnNext_pnlMainTableContainer_Click;
			// 
			// btnPrevious_pnlMainTableContainer
			// 
			btnPrevious_pnlMainTableContainer.BackColor = Color.FromArgb(208, 187, 195);
			btnPrevious_pnlMainTableContainer.FlatAppearance.BorderColor = Color.FromArgb(7, 25, 82);
			btnPrevious_pnlMainTableContainer.FlatAppearance.BorderSize = 0;
			btnPrevious_pnlMainTableContainer.FlatStyle = FlatStyle.Flat;
			btnPrevious_pnlMainTableContainer.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnPrevious_pnlMainTableContainer.ForeColor = Color.Black;
			btnPrevious_pnlMainTableContainer.Location = new Point(149, 791);
			btnPrevious_pnlMainTableContainer.Margin = new Padding(4, 5, 4, 5);
			btnPrevious_pnlMainTableContainer.Name = "btnPrevious_pnlMainTableContainer";
			btnPrevious_pnlMainTableContainer.Size = new Size(108, 46);
			btnPrevious_pnlMainTableContainer.TabIndex = 1;
			btnPrevious_pnlMainTableContainer.Text = "Previous";
			btnPrevious_pnlMainTableContainer.UseVisualStyleBackColor = false;
			btnPrevious_pnlMainTableContainer.Click += btnPrevious_pnlMainTableContainer_Click;
			// 
			// pnlTableContainer
			// 
			pnlTableContainer.Controls.Add(dgvStudents_pnlMainTableContainer);
			pnlTableContainer.Location = new Point(21, 68);
			pnlTableContainer.Margin = new Padding(4, 5, 4, 5);
			pnlTableContainer.Name = "pnlTableContainer";
			pnlTableContainer.Size = new Size(480, 702);
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
			dgvStudents_pnlMainTableContainer.Margin = new Padding(4, 5, 4, 5);
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
			dgvStudents_pnlMainTableContainer.Size = new Size(480, 702);
			dgvStudents_pnlMainTableContainer.TabIndex = 0;
			// 
			// btnCloseApp
			// 
			btnCloseApp.BackColor = Color.FromArgb(240, 210, 144);
			btnCloseApp.DialogResult = DialogResult.Cancel;
			btnCloseApp.FlatStyle = FlatStyle.Flat;
			btnCloseApp.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnCloseApp.ForeColor = Color.Black;
			btnCloseApp.Location = new Point(1312, 12);
			btnCloseApp.Margin = new Padding(4, 5, 4, 5);
			btnCloseApp.Name = "btnCloseApp";
			btnCloseApp.Size = new Size(100, 74);
			btnCloseApp.TabIndex = 9;
			btnCloseApp.Text = "X";
			btnCloseApp.UseVisualStyleBackColor = false;
			btnCloseApp.Click += btnCloseApp_Click;
			// 
			// pnlNavContainer
			// 
			pnlNavContainer.ColorOne = Color.FromArgb(223, 105, 13);
			pnlNavContainer.ColorTwo = Color.FromArgb(237, 140, 65);
			pnlNavContainer.Controls.Add(pnlNav);
			pnlNavContainer.Controls.Add(btnSettings);
			pnlNavContainer.Controls.Add(btnInfo);
			pnlNavContainer.Controls.Add(btnDataSummary);
			pnlNavContainer.Controls.Add(btnStudentData);
			pnlNavContainer.Controls.Add(btnDashboard);
			pnlNavContainer.Controls.Add(pnlTabTitleContainer);
			pnlNavContainer.Dock = DockStyle.Left;
			pnlNavContainer.GradientAngle = 0F;
			pnlNavContainer.Location = new Point(0, 0);
			pnlNavContainer.Margin = new Padding(4, 5, 4, 5);
			pnlNavContainer.Name = "pnlNavContainer";
			pnlNavContainer.OpacityColourOne = 255;
			pnlNavContainer.OpacityColourTwo = 255;
			pnlNavContainer.Size = new Size(248, 1102);
			pnlNavContainer.TabIndex = 11;
			// 
			// pnlNav
			// 
			pnlNav.BackColor = Color.FromArgb(255, 219, 51);
			pnlNav.Location = new Point(0, 297);
			pnlNav.Margin = new Padding(4, 5, 4, 5);
			pnlNav.Name = "pnlNav";
			pnlNav.Size = new Size(5, 154);
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
			btnSettings.Location = new Point(0, 906);
			btnSettings.Margin = new Padding(4, 5, 4, 5);
			btnSettings.Name = "btnSettings";
			btnSettings.Padding = new Padding(27, 0, 0, 0);
			btnSettings.Size = new Size(248, 98);
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
			btnInfo.Location = new Point(0, 1004);
			btnInfo.Margin = new Padding(4, 5, 4, 5);
			btnInfo.Name = "btnInfo";
			btnInfo.Padding = new Padding(27, 0, 0, 0);
			btnInfo.Size = new Size(248, 98);
			btnInfo.TabIndex = 19;
			btnInfo.Text = "Information";
			btnInfo.TextAlign = ContentAlignment.MiddleLeft;
			btnInfo.TextImageRelation = TextImageRelation.TextBeforeImage;
			btnInfo.UseVisualStyleBackColor = false;
			btnInfo.Click += btnInfo_Click;
			btnInfo.Leave += btnInfo_Leave;
			// 
			// btnDataSummary
			// 
			btnDataSummary.BackColor = Color.Transparent;
			btnDataSummary.Dock = DockStyle.Top;
			btnDataSummary.FlatAppearance.BorderSize = 0;
			btnDataSummary.FlatStyle = FlatStyle.Flat;
			btnDataSummary.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDataSummary.ForeColor = Color.Black;
			btnDataSummary.Image = (Image)resources.GetObject("btnDataSummary.Image");
			btnDataSummary.Location = new Point(0, 334);
			btnDataSummary.Margin = new Padding(4, 5, 4, 5);
			btnDataSummary.Name = "btnDataSummary";
			btnDataSummary.Padding = new Padding(27, 0, 0, 0);
			btnDataSummary.Size = new Size(248, 98);
			btnDataSummary.TabIndex = 17;
			btnDataSummary.Text = "Data Summary";
			btnDataSummary.TextAlign = ContentAlignment.MiddleLeft;
			btnDataSummary.TextImageRelation = TextImageRelation.TextBeforeImage;
			btnDataSummary.UseVisualStyleBackColor = false;
			btnDataSummary.Click += btnDataSummary_Click;
			btnDataSummary.Leave += btnDataSummary_Leave;
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
			btnStudentData.Location = new Point(0, 236);
			btnStudentData.Margin = new Padding(4, 5, 4, 5);
			btnStudentData.Name = "btnStudentData";
			btnStudentData.Padding = new Padding(27, 0, 0, 0);
			btnStudentData.Size = new Size(248, 98);
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
			btnDashboard.Location = new Point(0, 138);
			btnDashboard.Margin = new Padding(4, 5, 4, 5);
			btnDashboard.Name = "btnDashboard";
			btnDashboard.Padding = new Padding(27, 0, 0, 0);
			btnDashboard.Size = new Size(248, 98);
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
			pnlTabTitleContainer.Margin = new Padding(4, 5, 4, 5);
			pnlTabTitleContainer.Name = "pnlTabTitleContainer";
			pnlTabTitleContainer.Size = new Size(248, 138);
			pnlTabTitleContainer.TabIndex = 13;
			// 
			// lblTabTitle
			// 
			lblTabTitle.AutoSize = true;
			lblTabTitle.FlatStyle = FlatStyle.Flat;
			lblTabTitle.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTabTitle.ForeColor = Color.Black;
			lblTabTitle.Location = new Point(39, 48);
			lblTabTitle.Margin = new Padding(4, 0, 4, 0);
			lblTabTitle.Name = "lblTabTitle";
			lblTabTitle.Size = new Size(132, 36);
			lblTabTitle.TabIndex = 0;
			lblTabTitle.Text = "TabTitle";
			// 
			// mainFormPnlContainer
			// 
			mainFormPnlContainer.ColorOne = Color.FromArgb(253, 243, 235);
			mainFormPnlContainer.ColorTwo = Color.White;
			mainFormPnlContainer.Controls.Add(btnCloseApp);
			mainFormPnlContainer.Controls.Add(btnClearSearch);
			mainFormPnlContainer.Dock = DockStyle.Fill;
			mainFormPnlContainer.GradientAngle = 315F;
			mainFormPnlContainer.Location = new Point(0, 0);
			mainFormPnlContainer.Margin = new Padding(4, 5, 4, 5);
			mainFormPnlContainer.Name = "mainFormPnlContainer";
			mainFormPnlContainer.OpacityColourOne = 255;
			mainFormPnlContainer.OpacityColourTwo = 255;
			mainFormPnlContainer.Size = new Size(1428, 1102);
			mainFormPnlContainer.TabIndex = 12;
			// 
			// btnClearSearch
			// 
			btnClearSearch.BackColor = Color.Transparent;
			btnClearSearch.FlatAppearance.BorderSize = 0;
			btnClearSearch.FlatStyle = FlatStyle.Flat;
			btnClearSearch.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnClearSearch.Location = new Point(812, 51);
			btnClearSearch.Margin = new Padding(4, 5, 4, 5);
			btnClearSearch.Name = "btnClearSearch";
			btnClearSearch.Size = new Size(23, 37);
			btnClearSearch.TabIndex = 8;
			btnClearSearch.Text = "X";
			btnClearSearch.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			CancelButton = btnCloseApp;
			ClientSize = new Size(1428, 1102);
			Controls.Add(pnlNavContainer);
			Controls.Add(pnlContainerBottom);
			Controls.Add(txtSearchBox);
			Controls.Add(pnlContainerMiddle);
			Controls.Add(pnlCalendarContainer);
			Controls.Add(pnlMainTableContainer);
			Controls.Add(mainFormPnlContainer);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 5, 4, 5);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Load += MainForm_Load;
			pnlCalendarContainer.ResumeLayout(false);
			pnlContainerMiddle.ResumeLayout(false);
			pnlContainerMiddle.PerformLayout();
			pnlContainerBottom.ResumeLayout(false);
			pnlContainerBottom.PerformLayout();
			pnlMainTableContainer.ResumeLayout(false);
			pnlTableContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvStudents_pnlMainTableContainer).EndInit();
			pnlNavContainer.ResumeLayout(false);
			pnlTabTitleContainer.ResumeLayout(false);
			pnlTabTitleContainer.PerformLayout();
			mainFormPnlContainer.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion


		private System.Windows.Forms.Timer Timer_Sidebar_Menu;
        public System.Windows.Forms.Panel pnlContainerMiddle;
        public System.Windows.Forms.Panel pnlCalendarContainer;
        public System.Windows.Forms.Button btnClearSearch;
        public System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.MonthCalendar mcCalendar_pnlCalendarContainer;
        public System.Windows.Forms.Label lblStatusTitle;
        public System.Windows.Forms.RichTextBox rtxtStatusContent;
        public System.Windows.Forms.Panel pnlContainerBottom;
        public System.Windows.Forms.RichTextBox rtxtStatusContextLower;
        public System.Windows.Forms.Label lblStatusLower;
        private CustomGradientPanels pnlNavContainer;
        public System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel pnlNav;
     
        public System.Windows.Forms.Button btnDataSummary;
        public System.Windows.Forms.Button btnStudentData;
        public System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlTabTitleContainer;
        public System.Windows.Forms.Label lblTabTitle;
        public CustomGradientPanels mainFormPnlContainer;
        public System.Windows.Forms.Panel pnlMainTableContainer;
        public System.Windows.Forms.Button btnNext_pnlMainTableContainer;
        public System.Windows.Forms.Button btnPrevious_pnlMainTableContainer;
        private System.Windows.Forms.Panel pnlTableContainer;
        public System.Windows.Forms.DataGridView dgvStudents_pnlMainTableContainer;
        public CustomGradientPanels gpnlContainerMiddleTop;
        public System.Windows.Forms.Button btnSettings;
        public CustomGradientPanels gpnlTopTableContainer;
        private CustomGradientPanels gpnlCalenderContainerTop;
        public CustomGradientPanels gpnlContainerBottomTop;
        public System.Windows.Forms.Button btnCloseApp;
    }
}

