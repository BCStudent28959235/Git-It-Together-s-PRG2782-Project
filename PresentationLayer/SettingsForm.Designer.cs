namespace WinFormsApp_MainProjectFile.PresentationLayer.UserControls
{
    partial class SettingsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            cgpMainContainer = new CustomControls.CustomGradientPanels();
            cbtnCloseChildForm2 = new CustomControls.CustomButtons();
            pnlThemeToggle = new Panel();
            lblDarkLight = new Label();
            ctbtnThemeToggle = new CustomControls.CustomToggleButton();
            pnlSide1 = new Panel();
            cgpMainContainer.SuspendLayout();
            pnlThemeToggle.SuspendLayout();
            SuspendLayout();
            // 
            // cgpMainContainer
            // 
            cgpMainContainer.BackColor = Color.Transparent;
            cgpMainContainer.ColorOne = Color.FromArgb(254, 242, 232);
            cgpMainContainer.ColorTwo = Color.White;
            cgpMainContainer.Controls.Add(cbtnCloseChildForm2);
            cgpMainContainer.Controls.Add(pnlThemeToggle);
            cgpMainContainer.Dock = DockStyle.Fill;
            cgpMainContainer.ForeColor = SystemColors.ActiveBorder;
            cgpMainContainer.GradientAngle = 315F;
            cgpMainContainer.Location = new Point(0, 0);
            cgpMainContainer.Name = "cgpMainContainer";
            cgpMainContainer.OpacityColourOne = 255;
            cgpMainContainer.OpacityColourTwo = 255;
            cgpMainContainer.Size = new Size(1285, 825);
            cgpMainContainer.TabIndex = 0;
            // 
            // cbtnCloseChildForm2
            // 
            cbtnCloseChildForm2.BackColor = Color.FromArgb(255, 192, 192);
            cbtnCloseChildForm2.BackgroundColor = Color.FromArgb(255, 192, 192);
            cbtnCloseChildForm2.BorderColor = Color.Black;
            cbtnCloseChildForm2.BorderRadius = 20;
            cbtnCloseChildForm2.BorderSize = 0;
            cbtnCloseChildForm2.FlatAppearance.BorderColor = Color.Black;
            cbtnCloseChildForm2.FlatAppearance.BorderSize = 0;
            cbtnCloseChildForm2.FlatStyle = FlatStyle.Flat;
            cbtnCloseChildForm2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbtnCloseChildForm2.ForeColor = Color.White;
            cbtnCloseChildForm2.Image = (Image)resources.GetObject("cbtnCloseChildForm2.Image");
            cbtnCloseChildForm2.Location = new Point(1166, 12);
            cbtnCloseChildForm2.Name = "cbtnCloseChildForm2";
            cbtnCloseChildForm2.Size = new Size(89, 76);
            cbtnCloseChildForm2.TabIndex = 11;
            cbtnCloseChildForm2.TextColor = Color.White;
            cbtnCloseChildForm2.UseVisualStyleBackColor = false;
            cbtnCloseChildForm2.Click += cbtnCloseChildForm2_Click;
            // 
            // pnlThemeToggle
            // 
            pnlThemeToggle.BackColor = Color.White;
            pnlThemeToggle.Controls.Add(lblDarkLight);
            pnlThemeToggle.Controls.Add(ctbtnThemeToggle);
            pnlThemeToggle.Location = new Point(602, 140);
            pnlThemeToggle.Name = "pnlThemeToggle";
            pnlThemeToggle.Size = new Size(261, 101);
            pnlThemeToggle.TabIndex = 0;
            // 
            // lblDarkLight
            // 
            lblDarkLight.AutoSize = true;
            lblDarkLight.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDarkLight.ForeColor = Color.Black;
            lblDarkLight.Location = new Point(99, 30);
            lblDarkLight.Name = "lblDarkLight";
            lblDarkLight.Size = new Size(143, 29);
            lblDarkLight.TabIndex = 1;
            lblDarkLight.Text = "Light Mode";
            // 
            // ctbtnThemeToggle
            // 
            ctbtnThemeToggle.AutoSize = true;
            ctbtnThemeToggle.ForeColor = SystemColors.WindowText;
            ctbtnThemeToggle.Location = new Point(13, 25);
            ctbtnThemeToggle.MinimumSize = new Size(80, 40);
            ctbtnThemeToggle.Name = "ctbtnThemeToggle";
            ctbtnThemeToggle.OffBackColour = Color.FromArgb(223, 105, 13);
            ctbtnThemeToggle.OffToggleColour = Color.FromArgb(253, 243, 235);
            ctbtnThemeToggle.OnBackColour = Color.Navy;
            ctbtnThemeToggle.OnToggleColour = Color.FromArgb(192, 192, 255);
            ctbtnThemeToggle.Size = new Size(80, 40);
            ctbtnThemeToggle.TabIndex = 0;
            ctbtnThemeToggle.UseVisualStyleBackColor = true;
            ctbtnThemeToggle.CheckedChanged += ctbtnThemeToggle_CheckedChanged;
            // 
            // pnlSide1
            // 
            pnlSide1.BackColor = Color.Transparent;
            pnlSide1.Dock = DockStyle.Left;
            pnlSide1.Location = new Point(0, 0);
            pnlSide1.Name = "pnlSide1";
            pnlSide1.Size = new Size(217, 825);
            pnlSide1.TabIndex = 36;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 825);
            ControlBox = false;
            Controls.Add(pnlSide1);
            Controls.Add(cgpMainContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            cgpMainContainer.ResumeLayout(false);
            pnlThemeToggle.ResumeLayout(false);
            pnlThemeToggle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomGradientPanels cgpMainContainer;
        private CustomControls.CustomToggleButton ctbtnThemeToggle;
        private Panel pnlSide1;
        public Panel pnlThemeToggle;
        public CustomControls.CustomButtons cbtnCloseChildForm2;
        public Label lblDarkLight;
    }
}
