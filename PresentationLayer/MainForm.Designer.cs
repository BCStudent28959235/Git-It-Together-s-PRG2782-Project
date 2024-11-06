
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        
            this.Timer_Sidebar_Menu = new System.Windows.Forms.Timer(this.components);
            this.pnlCalendarContainer = new System.Windows.Forms.Panel();
            this.mcCalendar_pnlCalendarContainer = new System.Windows.Forms.MonthCalendar();
            this.pnlContainerMiddle = new System.Windows.Forms.Panel();
            this.rtxtStatusContent = new System.Windows.Forms.RichTextBox();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.pnlContainerBottom = new System.Windows.Forms.Panel();
            this.rtxtStatusContextLower = new System.Windows.Forms.RichTextBox();
            this.lblStatusLower = new System.Windows.Forms.Label();
            this.pnlMainTableContainer = new System.Windows.Forms.Panel();
            this.btnNext_pnlMainTableContainer = new System.Windows.Forms.Button();
            this.btnPrevious_pnlMainTableContainer = new System.Windows.Forms.Button();
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            this.dgvStudents_pnlMainTableContainer = new System.Windows.Forms.DataGridView();
            this.dgvStudentIDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentNameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentAgeC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentCourseC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentMarkC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.pnlNavContainer = new CustomControls.CustomGradientPanels();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDataSummary = new System.Windows.Forms.Button();
            this.btnStudentData = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlTabTitleContainer = new System.Windows.Forms.Panel();
            this.lblTabTitle = new System.Windows.Forms.Label();
            this.gpnlContainerBottomTop = new CustomControls.CustomGradientPanels();
            this.gpnlContainerMiddleTop = new CustomControls.CustomGradientPanels();
            this.gpnlCalenderContainerTop = new CustomControls.CustomGradientPanels();
            this.gpnlTopTableContainer = new CustomControls.CustomGradientPanels();
            this.mainFormPnlContainer = new CustomControls.CustomGradientPanels();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.pnlCalendarContainer.SuspendLayout();
            this.pnlContainerMiddle.SuspendLayout();
            this.pnlContainerBottom.SuspendLayout();
            this.pnlMainTableContainer.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents_pnlMainTableContainer)).BeginInit();
            this.pnlNavContainer.SuspendLayout();
            this.pnlTabTitleContainer.SuspendLayout();
            this.mainFormPnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse_Form
            // 
           
            // 
            // DragControl_Form
            // 
           
            // 
            // Timer_Sidebar_Menu
            // 
            this.Timer_Sidebar_Menu.Interval = 10;
            this.Timer_Sidebar_Menu.Tick += new System.EventHandler(this.Timer_Sidebar_Menu_Tick);
            // 
            // pnlCalendarContainer
            // 
            this.pnlCalendarContainer.BackColor = System.Drawing.Color.White;
            this.pnlCalendarContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCalendarContainer.Controls.Add(this.gpnlCalenderContainerTop);
            this.pnlCalendarContainer.Controls.Add(this.mcCalendar_pnlCalendarContainer);
            this.pnlCalendarContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(27)))));
            this.pnlCalendarContainer.Location = new System.Drawing.Point(620, 89);
            this.pnlCalendarContainer.Name = "pnlCalendarContainer";
            this.pnlCalendarContainer.Size = new System.Drawing.Size(407, 278);
            this.pnlCalendarContainer.TabIndex = 3;
            // 
            // mcCalendar_pnlCalendarContainer
            // 
            this.mcCalendar_pnlCalendarContainer.BackColor = System.Drawing.Color.White;
            this.mcCalendar_pnlCalendarContainer.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcCalendar_pnlCalendarContainer.Location = new System.Drawing.Point(83, 30);
            this.mcCalendar_pnlCalendarContainer.Name = "mcCalendar_pnlCalendarContainer";
            this.mcCalendar_pnlCalendarContainer.TabIndex = 0;
            // 
            // pnlContainerMiddle
            // 
            this.pnlContainerMiddle.BackColor = System.Drawing.Color.White;
            this.pnlContainerMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainerMiddle.Controls.Add(this.rtxtStatusContent);
            this.pnlContainerMiddle.Controls.Add(this.lblStatusTitle);
            this.pnlContainerMiddle.Controls.Add(this.gpnlContainerMiddleTop);
            this.pnlContainerMiddle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(27)))));
            this.pnlContainerMiddle.Location = new System.Drawing.Point(620, 390);
            this.pnlContainerMiddle.Name = "pnlContainerMiddle";
            this.pnlContainerMiddle.Size = new System.Drawing.Size(407, 103);
            this.pnlContainerMiddle.TabIndex = 4;
            // 
            // rtxtStatusContent
            // 
            this.rtxtStatusContent.AcceptsTab = true;
            this.rtxtStatusContent.BackColor = System.Drawing.Color.White;
            this.rtxtStatusContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtStatusContent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtxtStatusContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtStatusContent.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtStatusContent.ForeColor = System.Drawing.Color.Black;
            this.rtxtStatusContent.Location = new System.Drawing.Point(0, 32);
            this.rtxtStatusContent.Margin = new System.Windows.Forms.Padding(0);
            this.rtxtStatusContent.MaxLength = 500;
            this.rtxtStatusContent.Name = "rtxtStatusContent";
            this.rtxtStatusContent.ReadOnly = true;
            this.rtxtStatusContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtStatusContent.Size = new System.Drawing.Size(405, 69);
            this.rtxtStatusContent.TabIndex = 0;
            this.rtxtStatusContent.Text = "heyheyhey Put in status content here";
            this.rtxtStatusContent.TextChanged += new System.EventHandler(this.rtxtStatusContent_TextChanged);
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatusTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.ForeColor = System.Drawing.Color.Black;
            this.lblStatusTitle.Location = new System.Drawing.Point(18, 11);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(64, 18);
            this.lblStatusTitle.TabIndex = 0;
            this.lblStatusTitle.Text = "Status";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSearchBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(204, 36);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(399, 20);
            this.txtSearchBox.TabIndex = 7;
            this.txtSearchBox.Text = "search...";
            // 
            // pnlContainerBottom
            // 
            this.pnlContainerBottom.BackColor = System.Drawing.Color.White;
            this.pnlContainerBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainerBottom.Controls.Add(this.rtxtStatusContextLower);
            this.pnlContainerBottom.Controls.Add(this.lblStatusLower);
            this.pnlContainerBottom.Controls.Add(this.gpnlContainerBottomTop);
            this.pnlContainerBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(27)))));
            this.pnlContainerBottom.Location = new System.Drawing.Point(620, 509);
            this.pnlContainerBottom.Name = "pnlContainerBottom";
            this.pnlContainerBottom.Size = new System.Drawing.Size(407, 176);
            this.pnlContainerBottom.TabIndex = 10;
            // 
            // rtxtStatusContextLower
            // 
            this.rtxtStatusContextLower.AcceptsTab = true;
            this.rtxtStatusContextLower.BackColor = System.Drawing.Color.White;
            this.rtxtStatusContextLower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtStatusContextLower.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtxtStatusContextLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtStatusContextLower.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtStatusContextLower.ForeColor = System.Drawing.Color.Black;
            this.rtxtStatusContextLower.Location = new System.Drawing.Point(0, 41);
            this.rtxtStatusContextLower.Margin = new System.Windows.Forms.Padding(0);
            this.rtxtStatusContextLower.MaxLength = 500;
            this.rtxtStatusContextLower.Name = "rtxtStatusContextLower";
            this.rtxtStatusContextLower.ReadOnly = true;
            this.rtxtStatusContextLower.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtStatusContextLower.Size = new System.Drawing.Size(405, 133);
            this.rtxtStatusContextLower.TabIndex = 0;
            this.rtxtStatusContextLower.Text = "heyheyhey Put in status content here";
            // 
            // lblStatusLower
            // 
            this.lblStatusLower.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblStatusLower.AutoSize = true;
            this.lblStatusLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatusLower.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusLower.ForeColor = System.Drawing.Color.Black;
            this.lblStatusLower.Location = new System.Drawing.Point(18, 11);
            this.lblStatusLower.Name = "lblStatusLower";
            this.lblStatusLower.Size = new System.Drawing.Size(64, 18);
            this.lblStatusLower.TabIndex = 0;
            this.lblStatusLower.Text = "Status";
            // 
            // pnlMainTableContainer
            // 
            this.pnlMainTableContainer.BackColor = System.Drawing.Color.White;
            this.pnlMainTableContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainTableContainer.Controls.Add(this.gpnlTopTableContainer);
            this.pnlMainTableContainer.Controls.Add(this.btnNext_pnlMainTableContainer);
            this.pnlMainTableContainer.Controls.Add(this.btnPrevious_pnlMainTableContainer);
            this.pnlMainTableContainer.Controls.Add(this.pnlTableContainer);
            this.pnlMainTableContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(27)))));
            this.pnlMainTableContainer.Location = new System.Drawing.Point(204, 90);
            this.pnlMainTableContainer.Name = "pnlMainTableContainer";
            this.pnlMainTableContainer.Size = new System.Drawing.Size(399, 594);
            this.pnlMainTableContainer.TabIndex = 1;
            // 
            // btnNext_pnlMainTableContainer
            // 
            this.btnNext_pnlMainTableContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            this.btnNext_pnlMainTableContainer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnNext_pnlMainTableContainer.FlatAppearance.BorderSize = 0;
            this.btnNext_pnlMainTableContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext_pnlMainTableContainer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext_pnlMainTableContainer.ForeColor = System.Drawing.Color.Black;
            this.btnNext_pnlMainTableContainer.Location = new System.Drawing.Point(199, 514);
            this.btnNext_pnlMainTableContainer.Name = "btnNext_pnlMainTableContainer";
            this.btnNext_pnlMainTableContainer.Size = new System.Drawing.Size(81, 30);
            this.btnNext_pnlMainTableContainer.TabIndex = 2;
            this.btnNext_pnlMainTableContainer.Text = "Next";
            this.btnNext_pnlMainTableContainer.UseVisualStyleBackColor = false;
            this.btnNext_pnlMainTableContainer.Click += new System.EventHandler(this.btnNext_pnlMainTableContainer_Click);
            // 
            // btnPrevious_pnlMainTableContainer
            // 
            this.btnPrevious_pnlMainTableContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            this.btnPrevious_pnlMainTableContainer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnPrevious_pnlMainTableContainer.FlatAppearance.BorderSize = 0;
            this.btnPrevious_pnlMainTableContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious_pnlMainTableContainer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious_pnlMainTableContainer.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious_pnlMainTableContainer.Location = new System.Drawing.Point(112, 514);
            this.btnPrevious_pnlMainTableContainer.Name = "btnPrevious_pnlMainTableContainer";
            this.btnPrevious_pnlMainTableContainer.Size = new System.Drawing.Size(81, 30);
            this.btnPrevious_pnlMainTableContainer.TabIndex = 1;
            this.btnPrevious_pnlMainTableContainer.Text = "Previous";
            this.btnPrevious_pnlMainTableContainer.UseVisualStyleBackColor = false;
            this.btnPrevious_pnlMainTableContainer.Click += new System.EventHandler(this.btnPrevious_pnlMainTableContainer_Click);
            // 
            // pnlTableContainer
            // 
            this.pnlTableContainer.Controls.Add(this.dgvStudents_pnlMainTableContainer);
            this.pnlTableContainer.Location = new System.Drawing.Point(16, 44);
            this.pnlTableContainer.Name = "pnlTableContainer";
            this.pnlTableContainer.Size = new System.Drawing.Size(360, 456);
            this.pnlTableContainer.TabIndex = 0;
            // 
            // dgvStudents_pnlMainTableContainer
            // 
            this.dgvStudents_pnlMainTableContainer.AllowUserToAddRows = false;
            this.dgvStudents_pnlMainTableContainer.AllowUserToDeleteRows = false;
            this.dgvStudents_pnlMainTableContainer.AllowUserToOrderColumns = true;
            this.dgvStudents_pnlMainTableContainer.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents_pnlMainTableContainer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(210)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(93)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents_pnlMainTableContainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents_pnlMainTableContainer.ColumnHeadersHeight = 35;
            this.dgvStudents_pnlMainTableContainer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvStudentIDC,
            this.dgvStudentNameC,
            this.dgvStudentAgeC,
            this.dgvStudentCourseC,
            this.dgvStudentMarkC});
            this.dgvStudents_pnlMainTableContainer.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents_pnlMainTableContainer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents_pnlMainTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents_pnlMainTableContainer.EnableHeadersVisualStyles = false;
            this.dgvStudents_pnlMainTableContainer.GridColor = System.Drawing.Color.Black;
            this.dgvStudents_pnlMainTableContainer.Location = new System.Drawing.Point(0, 0);
            this.dgvStudents_pnlMainTableContainer.Name = "dgvStudents_pnlMainTableContainer";
            this.dgvStudents_pnlMainTableContainer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(169)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents_pnlMainTableContainer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudents_pnlMainTableContainer.RowHeadersWidth = 10;
            this.dgvStudents_pnlMainTableContainer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStudents_pnlMainTableContainer.Size = new System.Drawing.Size(360, 456);
            this.dgvStudents_pnlMainTableContainer.TabIndex = 0;
            // 
            // dgvStudentIDC
            // 
            this.dgvStudentIDC.DividerWidth = 1;
            this.dgvStudentIDC.FillWeight = 120F;
            this.dgvStudentIDC.HeaderText = "ID";
            this.dgvStudentIDC.MaxInputLength = 13;
            this.dgvStudentIDC.Name = "dgvStudentIDC";
            this.dgvStudentIDC.ReadOnly = true;
            this.dgvStudentIDC.Width = 35;
            // 
            // dgvStudentNameC
            // 
            this.dgvStudentNameC.DividerWidth = 1;
            this.dgvStudentNameC.FillWeight = 120F;
            this.dgvStudentNameC.HeaderText = "Name";
            this.dgvStudentNameC.MaxInputLength = 30;
            this.dgvStudentNameC.Name = "dgvStudentNameC";
            this.dgvStudentNameC.ReadOnly = true;
            // 
            // dgvStudentAgeC
            // 
            this.dgvStudentAgeC.DividerWidth = 1;
            this.dgvStudentAgeC.FillWeight = 120F;
            this.dgvStudentAgeC.HeaderText = "Age";
            this.dgvStudentAgeC.MaxInputLength = 3;
            this.dgvStudentAgeC.Name = "dgvStudentAgeC";
            this.dgvStudentAgeC.ReadOnly = true;
            this.dgvStudentAgeC.Width = 60;
            // 
            // dgvStudentCourseC
            // 
            this.dgvStudentCourseC.DividerWidth = 1;
            this.dgvStudentCourseC.FillWeight = 120F;
            this.dgvStudentCourseC.HeaderText = "Course";
            this.dgvStudentCourseC.MaxInputLength = 30;
            this.dgvStudentCourseC.Name = "dgvStudentCourseC";
            this.dgvStudentCourseC.ReadOnly = true;
            this.dgvStudentCourseC.Width = 90;
            // 
            // dgvStudentMarkC
            // 
            this.dgvStudentMarkC.DividerWidth = 1;
            this.dgvStudentMarkC.FillWeight = 120F;
            this.dgvStudentMarkC.HeaderText = "Final Mark";
            this.dgvStudentMarkC.MaxInputLength = 4;
            this.dgvStudentMarkC.Name = "dgvStudentMarkC";
            this.dgvStudentMarkC.ReadOnly = true;
            this.dgvStudentMarkC.Width = 70;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(210)))), ((int)(((byte)(144)))));
            this.btnCloseApp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.Black;
            this.btnCloseApp.Location = new System.Drawing.Point(984, 8);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(75, 48);
            this.btnCloseApp.TabIndex = 9;
            this.btnCloseApp.Text = "X";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // pnlNavContainer
            // 
            this.pnlNavContainer.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(105)))), ((int)(((byte)(13)))));
            this.pnlNavContainer.ColorTwo = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.pnlNavContainer.Controls.Add(this.pnlNav);
            this.pnlNavContainer.Controls.Add(this.btnSettings);
            this.pnlNavContainer.Controls.Add(this.btnInfo);
            this.pnlNavContainer.Controls.Add(this.btnDataSummary);
            this.pnlNavContainer.Controls.Add(this.btnStudentData);
            this.pnlNavContainer.Controls.Add(this.btnDashboard);
            this.pnlNavContainer.Controls.Add(this.pnlTabTitleContainer);
            this.pnlNavContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavContainer.GradientAngle = 0F;

            this.pnlNavContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlNavContainer.Name = "pnlNavContainer";
            this.pnlNavContainer.Size = new System.Drawing.Size(186, 775);
            this.pnlNavContainer.TabIndex = 11;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(51)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 100);
            this.pnlNav.TabIndex = 35;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(0, 647);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(186, 64);
            this.btnSettings.TabIndex = 20;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(0, 711);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(186, 64);
            this.btnInfo.TabIndex = 19;
            this.btnInfo.Text = "Information";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            this.btnInfo.Leave += new System.EventHandler(this.btnInfo_Leave);
            // 
            // btnDataSummary
            // 
            this.btnDataSummary.BackColor = System.Drawing.Color.Transparent;
            this.btnDataSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataSummary.FlatAppearance.BorderSize = 0;
            this.btnDataSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataSummary.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataSummary.ForeColor = System.Drawing.Color.Black;
            this.btnDataSummary.Image = ((System.Drawing.Image)(resources.GetObject("btnDataSummary.Image")));
            this.btnDataSummary.Location = new System.Drawing.Point(0, 218);
            this.btnDataSummary.Name = "btnDataSummary";
            this.btnDataSummary.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDataSummary.Size = new System.Drawing.Size(186, 64);
            this.btnDataSummary.TabIndex = 17;
            this.btnDataSummary.Text = "Data Summary";
            this.btnDataSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataSummary.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDataSummary.UseVisualStyleBackColor = false;
            this.btnDataSummary.Click += new System.EventHandler(this.btnDataSummary_Click);
            this.btnDataSummary.Leave += new System.EventHandler(this.btnDataSummary_Leave);
            // 
            // btnStudentData
            // 
            this.btnStudentData.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentData.FlatAppearance.BorderSize = 0;
            this.btnStudentData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentData.ForeColor = System.Drawing.Color.Black;
            this.btnStudentData.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentData.Image")));
            this.btnStudentData.Location = new System.Drawing.Point(0, 154);
            this.btnStudentData.Name = "btnStudentData";
            this.btnStudentData.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnStudentData.Size = new System.Drawing.Size(186, 64);
            this.btnStudentData.TabIndex = 14;
            this.btnStudentData.Text = "Student Data";
            this.btnStudentData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStudentData.UseVisualStyleBackColor = false;
            this.btnStudentData.Click += new System.EventHandler(this.btnStudentData_Click);
            this.btnStudentData.Leave += new System.EventHandler(this.btnStudentData_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(0, 90);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(186, 64);
            this.btnDashboard.TabIndex = 15;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // pnlTabTitleContainer
            // 
            this.pnlTabTitleContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlTabTitleContainer.Controls.Add(this.lblTabTitle);
            this.pnlTabTitleContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabTitleContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlTabTitleContainer.Name = "pnlTabTitleContainer";
            this.pnlTabTitleContainer.Size = new System.Drawing.Size(186, 90);
            this.pnlTabTitleContainer.TabIndex = 13;
            // 
            // lblTabTitle
            // 
            this.lblTabTitle.AutoSize = true;
            this.lblTabTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTabTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTabTitle.Location = new System.Drawing.Point(29, 31);
            this.lblTabTitle.Name = "lblTabTitle";
            this.lblTabTitle.Size = new System.Drawing.Size(104, 29);
            this.lblTabTitle.TabIndex = 0;
            this.lblTabTitle.Text = "TabTitle";
            // 
            // gpnlContainerBottomTop
            // 
            this.gpnlContainerBottomTop.ColorOne = System.Drawing.Color.Black;
            this.gpnlContainerBottomTop.ColorTwo = System.Drawing.Color.DimGray;
            this.gpnlContainerBottomTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpnlContainerBottomTop.GradientAngle = 90F;

            this.gpnlContainerBottomTop.Location = new System.Drawing.Point(0, 0);
            this.gpnlContainerBottomTop.Name = "gpnlContainerBottomTop";
            this.gpnlContainerBottomTop.Size = new System.Drawing.Size(405, 18);
            this.gpnlContainerBottomTop.TabIndex = 1;
            // 
            // gpnlContainerMiddleTop
            // 
            this.gpnlContainerMiddleTop.ColorOne = System.Drawing.Color.Black;
            this.gpnlContainerMiddleTop.ColorTwo = System.Drawing.Color.DimGray;
            this.gpnlContainerMiddleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpnlContainerMiddleTop.GradientAngle = 90F;

            this.gpnlContainerMiddleTop.Location = new System.Drawing.Point(0, 0);
            this.gpnlContainerMiddleTop.Name = "gpnlContainerMiddleTop";
            this.gpnlContainerMiddleTop.Size = new System.Drawing.Size(405, 16);
            this.gpnlContainerMiddleTop.TabIndex = 1;
            // 
            // gpnlCalenderContainerTop
            // 
            this.gpnlCalenderContainerTop.ColorOne = System.Drawing.Color.Black;
            this.gpnlCalenderContainerTop.ColorTwo = System.Drawing.Color.DimGray;
            this.gpnlCalenderContainerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpnlCalenderContainerTop.GradientAngle = 90F;

            this.gpnlCalenderContainerTop.Location = new System.Drawing.Point(0, 0);
            this.gpnlCalenderContainerTop.Name = "gpnlCalenderContainerTop";
            this.gpnlCalenderContainerTop.Size = new System.Drawing.Size(405, 20);
            this.gpnlCalenderContainerTop.TabIndex = 1;
            // 
            // gpnlTopTableContainer
            // 
            this.gpnlTopTableContainer.ColorOne = System.Drawing.Color.Black;
            this.gpnlTopTableContainer.ColorTwo = System.Drawing.Color.DimGray;
            this.gpnlTopTableContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpnlTopTableContainer.GradientAngle = 90F;

            this.gpnlTopTableContainer.Location = new System.Drawing.Point(0, 0);
            this.gpnlTopTableContainer.Name = "gpnlTopTableContainer";
            this.gpnlTopTableContainer.Size = new System.Drawing.Size(397, 19);
            this.gpnlTopTableContainer.TabIndex = 3;
            // 
            // mainFormPnlContainer
            // 
            this.mainFormPnlContainer.ColorOne = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(235)))));
            this.mainFormPnlContainer.ColorTwo = System.Drawing.Color.White;
            this.mainFormPnlContainer.Controls.Add(this.btnCloseApp);
            this.mainFormPnlContainer.Controls.Add(this.btnClearSearch);
            this.mainFormPnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormPnlContainer.GradientAngle = 315F;

            this.mainFormPnlContainer.Location = new System.Drawing.Point(0, 0);
            this.mainFormPnlContainer.Name = "mainFormPnlContainer";
            this.mainFormPnlContainer.Size = new System.Drawing.Size(1071, 775);
            this.mainFormPnlContainer.TabIndex = 12;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnClearSearch.FlatAppearance.BorderSize = 0;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.Location = new System.Drawing.Point(609, 33);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(17, 24);
            this.btnClearSearch.TabIndex = 8;
            this.btnClearSearch.Text = "X";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCloseApp;
            this.ClientSize = new System.Drawing.Size(1071, 775);
            this.Controls.Add(this.pnlNavContainer);
            this.Controls.Add(this.pnlContainerBottom);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.pnlContainerMiddle);
            this.Controls.Add(this.pnlCalendarContainer);
            this.Controls.Add(this.pnlMainTableContainer);
            this.Controls.Add(this.mainFormPnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlCalendarContainer.ResumeLayout(false);
            this.pnlContainerMiddle.ResumeLayout(false);
            this.pnlContainerMiddle.PerformLayout();
            this.pnlContainerBottom.ResumeLayout(false);
            this.pnlContainerBottom.PerformLayout();
            this.pnlMainTableContainer.ResumeLayout(false);
            this.pnlTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents_pnlMainTableContainer)).EndInit();
            this.pnlNavContainer.ResumeLayout(false);
            this.pnlTabTitleContainer.ResumeLayout(false);
            this.pnlTabTitleContainer.PerformLayout();
            this.mainFormPnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentIDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentNameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentAgeC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentCourseC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentMarkC;
        public CustomGradientPanels gpnlContainerMiddleTop;
        public System.Windows.Forms.Button btnSettings;
        public CustomGradientPanels gpnlTopTableContainer;
        private CustomGradientPanels gpnlCalenderContainerTop;
        public CustomGradientPanels gpnlContainerBottomTop;
        public System.Windows.Forms.Button btnCloseApp;
    }
}

