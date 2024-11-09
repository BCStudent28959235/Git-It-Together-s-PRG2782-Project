
namespace  WinFormsApp_MainProjectFile.PresentationLayer
{ 
    partial class TasksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksForm));
            btnCloseTasksForm = new Button();
            pnlMainPanel = new Panel();
            pnlSide3 = new Panel();
            pnlTasksTableContainer = new CustomControls.CustomQuadColourGradientPanels();
            cbtnCloseChildFormTasks = new CustomControls.CustomButtons();
            pnlSliderHolder1 = new Panel();
            cqpSlidingPanel1 = new CustomControls.CustomQuadColourGradientPanels();
            pnlEditTableContainer = new Panel();
            label8 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            txtCourse = new TextBox();
            lblCourse = new Label();
            txtAge = new TextBox();
            lblAge = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtID = new TextBox();
            lblID = new Label();
            cgpSliderTab1 = new CustomControls.CustomGradientPanels();
            btnOpenCloseSliderpnl1 = new Button();
            pnlSliderHolder2 = new Panel();
            cqpSlidingPanel2 = new CustomControls.CustomQuadColourGradientPanels();
            pnlSummaryContainer = new Panel();
            lblSummaryLabel = new Label();
            txtAvgStdAge = new TextBox();
            txtTotalStudents = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnGenerateSummary = new Button();
            cgpSliderTab2 = new CustomControls.CustomGradientPanels();
            btnOpenCloseSliderpnl2 = new Button();
            btnDisplayAllStudents = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnNext = new Button();
            btnPrevious = new Button();
            dgvStudents = new DataGridView();
            btnSearch = new Button();
            tmerSlidePanelOpen = new System.Windows.Forms.Timer(components);
            tmerSlidePanelOpen2 = new System.Windows.Forms.Timer(components);
            pnlMainPanel.SuspendLayout();
            pnlTasksTableContainer.SuspendLayout();
            pnlSliderHolder1.SuspendLayout();
            cqpSlidingPanel1.SuspendLayout();
            pnlEditTableContainer.SuspendLayout();
            cgpSliderTab1.SuspendLayout();
            pnlSliderHolder2.SuspendLayout();
            cqpSlidingPanel2.SuspendLayout();
            pnlSummaryContainer.SuspendLayout();
            cgpSliderTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btnCloseTasksForm
            // 
            btnCloseTasksForm.DialogResult = DialogResult.Cancel;
            btnCloseTasksForm.FlatAppearance.BorderSize = 0;
            btnCloseTasksForm.FlatStyle = FlatStyle.Flat;
            btnCloseTasksForm.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseTasksForm.Location = new Point(1206, -2);
            btnCloseTasksForm.Margin = new Padding(4, 3, 4, 3);
            btnCloseTasksForm.Name = "btnCloseTasksForm";
            btnCloseTasksForm.Size = new Size(12, 55);
            btnCloseTasksForm.TabIndex = 24;
            btnCloseTasksForm.Text = "X";
            btnCloseTasksForm.UseVisualStyleBackColor = true;
            btnCloseTasksForm.Click += btnCloseTasksForm_Click;
            // 
            // pnlMainPanel
            // 
            pnlMainPanel.Controls.Add(pnlSide3);
            pnlMainPanel.Controls.Add(pnlTasksTableContainer);
            pnlMainPanel.Dock = DockStyle.Fill;
            pnlMainPanel.Location = new Point(0, 0);
            pnlMainPanel.Margin = new Padding(4, 3, 4, 3);
            pnlMainPanel.Name = "pnlMainPanel";
            pnlMainPanel.Size = new Size(1285, 825);
            pnlMainPanel.TabIndex = 25;
            // 
            // pnlSide3
            // 
            pnlSide3.BackColor = Color.Transparent;
            pnlSide3.Dock = DockStyle.Left;
            pnlSide3.Location = new Point(0, 0);
            pnlSide3.Name = "pnlSide3";
            pnlSide3.Size = new Size(217, 825);
            pnlSide3.TabIndex = 35;
            // 
            // pnlTasksTableContainer
            // 
            pnlTasksTableContainer.BackColor = Color.FromArgb(253, 243, 235);
            pnlTasksTableContainer.ColorFour = Color.FromArgb(254, 242, 232);
            pnlTasksTableContainer.ColorOne = Color.FromArgb(254, 242, 232);
            pnlTasksTableContainer.ColorThree = Color.White;
            pnlTasksTableContainer.ColorTwo = Color.White;
            pnlTasksTableContainer.Controls.Add(cbtnCloseChildFormTasks);
            pnlTasksTableContainer.Controls.Add(pnlSliderHolder1);
            pnlTasksTableContainer.Controls.Add(pnlSliderHolder2);
            pnlTasksTableContainer.Controls.Add(btnDisplayAllStudents);
            pnlTasksTableContainer.Controls.Add(lblSearch);
            pnlTasksTableContainer.Controls.Add(txtSearch);
            pnlTasksTableContainer.Controls.Add(btnNext);
            pnlTasksTableContainer.Controls.Add(btnPrevious);
            pnlTasksTableContainer.Controls.Add(dgvStudents);
            pnlTasksTableContainer.Controls.Add(btnSearch);
            pnlTasksTableContainer.Dock = DockStyle.Fill;
            pnlTasksTableContainer.GradientAngle = 315F;
            pnlTasksTableContainer.GradientCenterX = 0.2F;
            pnlTasksTableContainer.GradientCenterY = 0.6F;
            pnlTasksTableContainer.GradientResolution = 1;
            pnlTasksTableContainer.Location = new Point(0, 0);
            pnlTasksTableContainer.Margin = new Padding(4, 3, 4, 3);
            pnlTasksTableContainer.Name = "pnlTasksTableContainer";
            pnlTasksTableContainer.Opacity = 255;
            pnlTasksTableContainer.OpacityColourFour = 200;
            pnlTasksTableContainer.OpacityColourOne = 255;
            pnlTasksTableContainer.OpacityColourThree = 255;
            pnlTasksTableContainer.OpacityColourTwo = 255;
            pnlTasksTableContainer.Size = new Size(1285, 825);
            pnlTasksTableContainer.TabIndex = 34;
            pnlTasksTableContainer.UseRadialGradient = true;
            // 
            // cbtnCloseChildFormTasks
            // 
            cbtnCloseChildFormTasks.BackColor = Color.FromArgb(255, 192, 192);
            cbtnCloseChildFormTasks.BackgroundColor = Color.FromArgb(255, 192, 192);
            cbtnCloseChildFormTasks.BorderColor = Color.Black;
            cbtnCloseChildFormTasks.BorderRadius = 20;
            cbtnCloseChildFormTasks.BorderSize = 0;
            cbtnCloseChildFormTasks.FlatAppearance.BorderColor = Color.Black;
            cbtnCloseChildFormTasks.FlatAppearance.BorderSize = 0;
            cbtnCloseChildFormTasks.FlatStyle = FlatStyle.Flat;
            cbtnCloseChildFormTasks.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbtnCloseChildFormTasks.ForeColor = Color.White;
            cbtnCloseChildFormTasks.Image = (Image)resources.GetObject("cbtnCloseChildFormTasks.Image");
            cbtnCloseChildFormTasks.Location = new Point(1189, 12);
            cbtnCloseChildFormTasks.Name = "cbtnCloseChildFormTasks";
            cbtnCloseChildFormTasks.Size = new Size(89, 76);
            cbtnCloseChildFormTasks.TabIndex = 36;
            cbtnCloseChildFormTasks.TextColor = Color.White;
            cbtnCloseChildFormTasks.UseVisualStyleBackColor = false;
            cbtnCloseChildFormTasks.Click += cbtnCloseChildFormTasks_Click;
            // 
            // pnlSliderHolder1
            // 
            pnlSliderHolder1.Controls.Add(cqpSlidingPanel1);
            pnlSliderHolder1.Controls.Add(cgpSliderTab1);
            pnlSliderHolder1.Location = new Point(231, 158);
            pnlSliderHolder1.Margin = new Padding(4, 3, 4, 3);
            pnlSliderHolder1.Name = "pnlSliderHolder1";
            pnlSliderHolder1.Size = new Size(324, 438);
            pnlSliderHolder1.TabIndex = 35;
            // 
            // cqpSlidingPanel1
            // 
            cqpSlidingPanel1.ColorFour = Color.FromArgb(255, 192, 192);
            cqpSlidingPanel1.ColorOne = Color.FromArgb(255, 224, 192);
            cqpSlidingPanel1.ColorThree = Color.FromArgb(255, 192, 192);
            cqpSlidingPanel1.ColorTwo = Color.FromArgb(255, 224, 192);
            cqpSlidingPanel1.Controls.Add(pnlEditTableContainer);
            cqpSlidingPanel1.Dock = DockStyle.Right;
            cqpSlidingPanel1.GradientAngle = 90F;
            cqpSlidingPanel1.GradientCenterX = 1F;
            cqpSlidingPanel1.GradientCenterY = 0.1F;
            cqpSlidingPanel1.GradientResolution = 1;
            cqpSlidingPanel1.Location = new Point(6, 0);
            cqpSlidingPanel1.Margin = new Padding(4, 3, 4, 3);
            cqpSlidingPanel1.Name = "cqpSlidingPanel1";
            cqpSlidingPanel1.Opacity = 255;
            cqpSlidingPanel1.OpacityColourFour = 255;
            cqpSlidingPanel1.OpacityColourOne = 255;
            cqpSlidingPanel1.OpacityColourThree = 255;
            cqpSlidingPanel1.OpacityColourTwo = 255;
            cqpSlidingPanel1.Size = new Size(271, 438);
            cqpSlidingPanel1.TabIndex = 32;
            cqpSlidingPanel1.UseRadialGradient = true;
            // 
            // pnlEditTableContainer
            // 
            pnlEditTableContainer.BackColor = Color.White;
            pnlEditTableContainer.Controls.Add(label8);
            pnlEditTableContainer.Controls.Add(btnDelete);
            pnlEditTableContainer.Controls.Add(btnUpdate);
            pnlEditTableContainer.Controls.Add(btnClear);
            pnlEditTableContainer.Controls.Add(btnAdd);
            pnlEditTableContainer.Controls.Add(txtCourse);
            pnlEditTableContainer.Controls.Add(lblCourse);
            pnlEditTableContainer.Controls.Add(txtAge);
            pnlEditTableContainer.Controls.Add(lblAge);
            pnlEditTableContainer.Controls.Add(txtName);
            pnlEditTableContainer.Controls.Add(lblName);
            pnlEditTableContainer.Controls.Add(txtID);
            pnlEditTableContainer.Controls.Add(lblID);
            pnlEditTableContainer.Location = new Point(22, 45);
            pnlEditTableContainer.Margin = new Padding(4, 3, 4, 3);
            pnlEditTableContainer.Name = "pnlEditTableContainer";
            pnlEditTableContainer.Size = new Size(249, 362);
            pnlEditTableContainer.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(78, 17);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(95, 18);
            label8.TabIndex = 32;
            label8.Text = "Edit Table";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(208, 187, 195);
            btnDelete.FlatAppearance.BorderColor = Color.Gray;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(147, 301);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(62, 39);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(208, 187, 195);
            btnUpdate.FlatAppearance.BorderColor = Color.Gray;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(63, 301);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(65, 39);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(208, 187, 195);
            btnClear.FlatAppearance.BorderColor = Color.Gray;
            btnClear.FlatAppearance.BorderSize = 2;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(147, 240);
            btnClear.Margin = new Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(62, 39);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(208, 187, 195);
            btnAdd.FlatAppearance.BorderColor = Color.Gray;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(72, 240);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(56, 39);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCourse
            // 
            txtCourse.BackColor = Color.FromArgb(255, 251, 254);
            txtCourse.Font = new Font("Consolas", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCourse.Location = new Point(89, 192);
            txtCourse.Margin = new Padding(2, 3, 2, 3);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(119, 20);
            txtCourse.TabIndex = 8;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourse.Location = new Point(15, 195);
            lblCourse.Margin = new Padding(2, 0, 2, 0);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(48, 13);
            lblCourse.TabIndex = 7;
            lblCourse.Text = "Course";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(255, 251, 254);
            txtAge.Font = new Font("Consolas", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(89, 148);
            txtAge.Margin = new Padding(2, 3, 2, 3);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(119, 20);
            txtAge.TabIndex = 6;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(31, 152);
            lblAge.Margin = new Padding(2, 0, 2, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(29, 13);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(255, 251, 254);
            txtName.Font = new Font("Consolas", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtName.Location = new Point(89, 115);
            txtName.Margin = new Padding(2, 3, 2, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(119, 20);
            txtName.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(24, 119);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 13);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(255, 251, 254);
            txtID.Font = new Font("Consolas", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtID.Location = new Point(89, 75);
            txtID.Margin = new Padding(2, 3, 2, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(119, 20);
            txtID.TabIndex = 2;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(41, 78);
            lblID.Margin = new Padding(2, 0, 2, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 13);
            lblID.TabIndex = 1;
            lblID.Text = "ID";
            // 
            // cgpSliderTab1
            // 
            cgpSliderTab1.ColorOne = Color.FromArgb(237, 140, 65);
            cgpSliderTab1.ColorTwo = Color.FromArgb(255, 192, 128);
            cgpSliderTab1.Controls.Add(btnOpenCloseSliderpnl1);
            cgpSliderTab1.Dock = DockStyle.Right;
            cgpSliderTab1.GradientAngle = 180F;
            cgpSliderTab1.Location = new Point(277, 0);
            cgpSliderTab1.Margin = new Padding(4, 3, 4, 3);
            cgpSliderTab1.Name = "cgpSliderTab1";
            cgpSliderTab1.OpacityColourOne = 255;
            cgpSliderTab1.OpacityColourTwo = 255;
            cgpSliderTab1.Size = new Size(47, 438);
            cgpSliderTab1.TabIndex = 0;
            // 
            // btnOpenCloseSliderpnl1
            // 
            btnOpenCloseSliderpnl1.BackColor = Color.Transparent;
            btnOpenCloseSliderpnl1.Dock = DockStyle.Fill;
            btnOpenCloseSliderpnl1.FlatStyle = FlatStyle.Flat;
            btnOpenCloseSliderpnl1.ForeColor = Color.White;
            btnOpenCloseSliderpnl1.Image = Properties.Resources.Plus_L;
            btnOpenCloseSliderpnl1.Location = new Point(0, 0);
            btnOpenCloseSliderpnl1.Margin = new Padding(4, 3, 4, 3);
            btnOpenCloseSliderpnl1.Name = "btnOpenCloseSliderpnl1";
            btnOpenCloseSliderpnl1.Size = new Size(47, 438);
            btnOpenCloseSliderpnl1.TabIndex = 0;
            btnOpenCloseSliderpnl1.UseVisualStyleBackColor = false;
            btnOpenCloseSliderpnl1.Click += btnOpenCloseSliderpnl1_Click;
            // 
            // pnlSliderHolder2
            // 
            pnlSliderHolder2.Controls.Add(cqpSlidingPanel2);
            pnlSliderHolder2.Controls.Add(cgpSliderTab2);
            pnlSliderHolder2.Location = new Point(954, 158);
            pnlSliderHolder2.Margin = new Padding(4, 3, 4, 3);
            pnlSliderHolder2.Name = "pnlSliderHolder2";
            pnlSliderHolder2.Size = new Size(324, 438);
            pnlSliderHolder2.TabIndex = 35;
            // 
            // cqpSlidingPanel2
            // 
            cqpSlidingPanel2.ColorFour = Color.FromArgb(255, 192, 192);
            cqpSlidingPanel2.ColorOne = Color.FromArgb(255, 224, 192);
            cqpSlidingPanel2.ColorThree = Color.FromArgb(255, 192, 192);
            cqpSlidingPanel2.ColorTwo = Color.FromArgb(255, 224, 192);
            cqpSlidingPanel2.Controls.Add(pnlSummaryContainer);
            cqpSlidingPanel2.Dock = DockStyle.Left;
            cqpSlidingPanel2.GradientAngle = 90F;
            cqpSlidingPanel2.GradientCenterX = 0F;
            cqpSlidingPanel2.GradientCenterY = 0.1F;
            cqpSlidingPanel2.GradientResolution = 100;
            cqpSlidingPanel2.Location = new Point(47, 0);
            cqpSlidingPanel2.Margin = new Padding(4, 3, 4, 3);
            cqpSlidingPanel2.Name = "cqpSlidingPanel2";
            cqpSlidingPanel2.Opacity = 255;
            cqpSlidingPanel2.OpacityColourFour = 255;
            cqpSlidingPanel2.OpacityColourOne = 255;
            cqpSlidingPanel2.OpacityColourThree = 255;
            cqpSlidingPanel2.OpacityColourTwo = 255;
            cqpSlidingPanel2.Size = new Size(271, 438);
            cqpSlidingPanel2.TabIndex = 33;
            cqpSlidingPanel2.UseRadialGradient = true;
            // 
            // pnlSummaryContainer
            // 
            pnlSummaryContainer.BackColor = Color.White;
            pnlSummaryContainer.Controls.Add(lblSummaryLabel);
            pnlSummaryContainer.Controls.Add(txtAvgStdAge);
            pnlSummaryContainer.Controls.Add(txtTotalStudents);
            pnlSummaryContainer.Controls.Add(label6);
            pnlSummaryContainer.Controls.Add(label5);
            pnlSummaryContainer.Controls.Add(btnGenerateSummary);
            pnlSummaryContainer.Location = new Point(4, 45);
            pnlSummaryContainer.Margin = new Padding(4, 3, 4, 3);
            pnlSummaryContainer.Name = "pnlSummaryContainer";
            pnlSummaryContainer.Size = new Size(233, 362);
            pnlSummaryContainer.TabIndex = 28;
            // 
            // lblSummaryLabel
            // 
            lblSummaryLabel.AutoSize = true;
            lblSummaryLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryLabel.Location = new Point(30, 23);
            lblSummaryLabel.Margin = new Padding(4, 0, 4, 0);
            lblSummaryLabel.Name = "lblSummaryLabel";
            lblSummaryLabel.Size = new Size(145, 18);
            lblSummaryLabel.TabIndex = 31;
            lblSummaryLabel.Text = "Table Summary";
            // 
            // txtAvgStdAge
            // 
            txtAvgStdAge.BackColor = Color.FromArgb(255, 251, 254);
            txtAvgStdAge.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAvgStdAge.Location = new Point(13, 233);
            txtAvgStdAge.Margin = new Padding(2);
            txtAvgStdAge.Name = "txtAvgStdAge";
            txtAvgStdAge.ReadOnly = true;
            txtAvgStdAge.Size = new Size(194, 21);
            txtAvgStdAge.TabIndex = 30;
            txtAvgStdAge.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTotalStudents
            // 
            txtTotalStudents.BackColor = Color.FromArgb(255, 251, 254);
            txtTotalStudents.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalStudents.Location = new Point(34, 117);
            txtTotalStudents.Margin = new Padding(2);
            txtTotalStudents.Name = "txtTotalStudents";
            txtTotalStudents.ReadOnly = true;
            txtTotalStudents.Size = new Size(146, 21);
            txtTotalStudents.TabIndex = 29;
            txtTotalStudents.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 202);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 13);
            label6.TabIndex = 28;
            label6.Text = "Average Student Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 85);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 13);
            label5.TabIndex = 27;
            label5.Text = "Total Students";
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.BackColor = Color.FromArgb(208, 187, 195);
            btnGenerateSummary.FlatAppearance.BorderColor = Color.Gray;
            btnGenerateSummary.FlatAppearance.BorderSize = 2;
            btnGenerateSummary.FlatStyle = FlatStyle.Flat;
            btnGenerateSummary.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateSummary.Location = new Point(52, 285);
            btnGenerateSummary.Margin = new Padding(2);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(111, 40);
            btnGenerateSummary.TabIndex = 26;
            btnGenerateSummary.Text = "Generate";
            btnGenerateSummary.UseVisualStyleBackColor = false;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // cgpSliderTab2
            // 
            cgpSliderTab2.ColorOne = Color.FromArgb(237, 140, 65);
            cgpSliderTab2.ColorTwo = Color.FromArgb(255, 192, 128);
            cgpSliderTab2.Controls.Add(btnOpenCloseSliderpnl2);
            cgpSliderTab2.Dock = DockStyle.Left;
            cgpSliderTab2.GradientAngle = 90F;
            cgpSliderTab2.Location = new Point(0, 0);
            cgpSliderTab2.Margin = new Padding(4, 3, 4, 3);
            cgpSliderTab2.Name = "cgpSliderTab2";
            cgpSliderTab2.OpacityColourOne = 255;
            cgpSliderTab2.OpacityColourTwo = 255;
            cgpSliderTab2.Size = new Size(47, 438);
            cgpSliderTab2.TabIndex = 0;
            // 
            // btnOpenCloseSliderpnl2
            // 
            btnOpenCloseSliderpnl2.BackColor = Color.Transparent;
            btnOpenCloseSliderpnl2.Dock = DockStyle.Fill;
            btnOpenCloseSliderpnl2.FlatStyle = FlatStyle.Flat;
            btnOpenCloseSliderpnl2.ForeColor = Color.White;
            btnOpenCloseSliderpnl2.Location = new Point(0, 0);
            btnOpenCloseSliderpnl2.Margin = new Padding(4, 3, 4, 3);
            btnOpenCloseSliderpnl2.Name = "btnOpenCloseSliderpnl2";
            btnOpenCloseSliderpnl2.Size = new Size(47, 438);
            btnOpenCloseSliderpnl2.TabIndex = 1;
            btnOpenCloseSliderpnl2.UseVisualStyleBackColor = false;
            btnOpenCloseSliderpnl2.Click += btnOpenCloseSliderpnl2_Click;
            // 
            // btnDisplayAllStudents
            // 
            btnDisplayAllStudents.BackColor = Color.FromArgb(245, 235, 224);
            btnDisplayAllStudents.FlatAppearance.BorderColor = Color.Gray;
            btnDisplayAllStudents.FlatAppearance.BorderSize = 2;
            btnDisplayAllStudents.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 237, 227);
            btnDisplayAllStudents.FlatStyle = FlatStyle.Flat;
            btnDisplayAllStudents.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDisplayAllStudents.Location = new Point(700, 688);
            btnDisplayAllStudents.Margin = new Padding(2);
            btnDisplayAllStudents.Name = "btnDisplayAllStudents";
            btnDisplayAllStudents.Size = new Size(125, 53);
            btnDisplayAllStudents.TabIndex = 26;
            btnDisplayAllStudents.Text = "Display all";
            btnDisplayAllStudents.UseVisualStyleBackColor = false;
            btnDisplayAllStudents.Click += btnDisplayAllStudents_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(585, 107);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(121, 14);
            lblSearch.TabIndex = 24;
            lblSearch.Text = "Search student ID";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(255, 251, 254);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Consolas", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(710, 106);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(130, 22);
            txtSearch.TabIndex = 23;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(245, 235, 224);
            btnNext.FlatAppearance.BorderColor = Color.Gray;
            btnNext.FlatAppearance.BorderSize = 2;
            btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 237, 227);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(765, 631);
            btnNext.Margin = new Padding(2, 3, 2, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(126, 40);
            btnNext.TabIndex = 13;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(245, 235, 224);
            btnPrevious.FlatAppearance.BorderColor = Color.Gray;
            btnPrevious.FlatAppearance.BorderSize = 2;
            btnPrevious.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 237, 227);
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrevious.Location = new Point(627, 631);
            btnPrevious.Margin = new Padding(2, 3, 2, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(126, 40);
            btnPrevious.TabIndex = 12;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AccessibleRole = AccessibleRole.None;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvStudents.Location = new Point(556, 135);
            dgvStudents.Margin = new Padding(2, 3, 2, 3);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.Height = 24;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(397, 485);
            dgvStudents.TabIndex = 0;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged_1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.FlatAppearance.BorderColor = Color.Black;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(844, 91);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(47, 39);
            btnSearch.TabIndex = 25;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tmerSlidePanelOpen
            // 
            tmerSlidePanelOpen.Interval = 25;
            tmerSlidePanelOpen.Tick += tmerSlidePanelOpen_Tick;
            // 
            // tmerSlidePanelOpen2
            // 
            tmerSlidePanelOpen2.Interval = 35;
            tmerSlidePanelOpen2.Tick += tmerSlidePanelOpen2_Tick;
            // 
            // TasksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCloseTasksForm;
            ClientSize = new Size(1285, 825);
            Controls.Add(pnlMainPanel);
            Controls.Add(btnCloseTasksForm);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "TasksForm";
            Load += Form1_Load;
            pnlMainPanel.ResumeLayout(false);
            pnlTasksTableContainer.ResumeLayout(false);
            pnlTasksTableContainer.PerformLayout();
            pnlSliderHolder1.ResumeLayout(false);
            cqpSlidingPanel1.ResumeLayout(false);
            pnlEditTableContainer.ResumeLayout(false);
            pnlEditTableContainer.PerformLayout();
            cgpSliderTab1.ResumeLayout(false);
            pnlSliderHolder2.ResumeLayout(false);
            cqpSlidingPanel2.ResumeLayout(false);
            pnlSummaryContainer.ResumeLayout(false);
            pnlSummaryContainer.PerformLayout();
            cgpSliderTab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.Button btnCloseTasksForm;
        public System.Windows.Forms.Button btnDisplayAllStudents;
        public System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.Button btnPrevious;
        public System.Windows.Forms.DataGridView dgvStudents;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtCourse;
        public System.Windows.Forms.Label lblCourse;
        public System.Windows.Forms.TextBox txtAge;
        public System.Windows.Forms.Label lblAge;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtAvgStdAge;
        public System.Windows.Forms.TextBox txtTotalStudents;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnGenerateSummary;
        public CustomControls.CustomQuadColourGradientPanels pnlTasksTableContainer;
        public System.Windows.Forms.Panel pnlSliderHolder1;
        private CustomControls.CustomQuadColourGradientPanels cqpSlidingPanel1;
        public System.Windows.Forms.Panel pnlEditTableContainer;
        public System.Windows.Forms.Label label8;
        private CustomControls.CustomGradientPanels cgpSliderTab1;
        public System.Windows.Forms.Button btnOpenCloseSliderpnl1;
        public System.Windows.Forms.Panel pnlSliderHolder2;
        private CustomControls.CustomQuadColourGradientPanels cqpSlidingPanel2;
        public System.Windows.Forms.Panel pnlSummaryContainer;
        public System.Windows.Forms.Label lblSummaryLabel;
        private CustomControls.CustomGradientPanels cgpSliderTab2;
        public System.Windows.Forms.Button btnOpenCloseSliderpnl2;
        public System.Windows.Forms.Panel pnlMainPanel;
        public System.Windows.Forms.Timer tmerSlidePanelOpen;
        private System.Windows.Forms.Timer tmerSlidePanelOpen2;
        private Panel pnlSide3;
        public CustomControls.CustomButtons cbtnCloseChildFormTasks;
    }
}

