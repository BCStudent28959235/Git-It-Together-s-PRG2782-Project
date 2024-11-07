namespace WinFormsApp_MainProjectFile.PresentationLayer.UserControls
{
    partial class UCSettings
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
            cgpMainContainer = new CustomControls.CustomGradientPanels();
            cbtnCloseApp = new CustomControls.CustomButtons();
            panel1 = new Panel();
            lblDarkLight = new Label();
            customToggleButton1 = new CustomControls.CustomToggleButton();
            panel2 = new Panel();
            lblFonts = new Label();
            ctbntFontToggle = new CustomControls.CustomToggleButton();
            cgpMainContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cgpMainContainer
            // 
            cgpMainContainer.BackColor = Color.Transparent;
            cgpMainContainer.ColorOne = Color.FromArgb(255, 224, 192);
            cgpMainContainer.ColorTwo = Color.FromArgb(255, 192, 255);
            cgpMainContainer.Controls.Add(panel2);
            cgpMainContainer.Controls.Add(cbtnCloseApp);
            cgpMainContainer.Controls.Add(panel1);
            cgpMainContainer.Dock = DockStyle.Fill;
            cgpMainContainer.ForeColor = SystemColors.ActiveBorder;
            cgpMainContainer.GradientAngle = 315F;
            cgpMainContainer.Location = new Point(0, 0);
            cgpMainContainer.Name = "cgpMainContainer";
            cgpMainContainer.OpacityColourOne = 255;
            cgpMainContainer.OpacityColourTwo = 150;
            cgpMainContainer.Size = new Size(1250, 825);
            cgpMainContainer.TabIndex = 0;
            // 
            // cbtnCloseApp
            // 
            cbtnCloseApp.BackColor = Color.FromArgb(255, 128, 0);
            cbtnCloseApp.BackgroundColor = Color.FromArgb(255, 128, 0);
            cbtnCloseApp.BorderColor = Color.Black;
            cbtnCloseApp.BorderRadius = 10;
            cbtnCloseApp.BorderSize = 0;
            cbtnCloseApp.FlatAppearance.BorderColor = Color.Black;
            cbtnCloseApp.FlatAppearance.BorderSize = 0;
            cbtnCloseApp.FlatStyle = FlatStyle.Flat;
            cbtnCloseApp.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbtnCloseApp.ForeColor = Color.White;
            cbtnCloseApp.Location = new Point(913, 125);
            cbtnCloseApp.Name = "cbtnCloseApp";
            cbtnCloseApp.Size = new Size(70, 56);
            cbtnCloseApp.TabIndex = 1;
            cbtnCloseApp.Text = "X";
            cbtnCloseApp.TextColor = Color.White;
            cbtnCloseApp.UseVisualStyleBackColor = false;
            cbtnCloseApp.Click += cbtnCloseApp_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblDarkLight);
            panel1.Controls.Add(customToggleButton1);
            panel1.Location = new Point(410, 337);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 101);
            panel1.TabIndex = 0;
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
            // customToggleButton1
            // 
            customToggleButton1.AutoSize = true;
            customToggleButton1.ForeColor = SystemColors.WindowText;
            customToggleButton1.Location = new Point(13, 25);
            customToggleButton1.MinimumSize = new Size(80, 40);
            customToggleButton1.Name = "customToggleButton1";
            customToggleButton1.OffBackColour = Color.FromArgb(223, 105, 13);
            customToggleButton1.OffToggleColour = Color.FromArgb(253, 243, 235);
            customToggleButton1.OnBackColour = Color.Navy;
            customToggleButton1.OnToggleColour = Color.FromArgb(192, 192, 255);
            customToggleButton1.Size = new Size(80, 40);
            customToggleButton1.TabIndex = 0;
            customToggleButton1.UseVisualStyleBackColor = true;
            customToggleButton1.CheckedChanged += customToggleButton1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblFonts);
            panel2.Controls.Add(ctbntFontToggle);
            panel2.Location = new Point(410, 467);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 101);
            panel2.TabIndex = 2;
            // 
            // lblFonts
            // 
            lblFonts.AutoSize = true;
            lblFonts.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFonts.ForeColor = Color.Black;
            lblFonts.Location = new Point(99, 9);
            lblFonts.Name = "lblFonts";
            lblFonts.Size = new Size(113, 87);
            lblFonts.TabIndex = 1;
            lblFonts.Text = "Dyslexia\r\nfriendly\r\nfonts";
            // 
            // ctbntFontToggle
            // 
            ctbntFontToggle.AutoSize = true;
            ctbntFontToggle.ForeColor = SystemColors.WindowText;
            ctbntFontToggle.Location = new Point(13, 25);
            ctbntFontToggle.MinimumSize = new Size(80, 40);
            ctbntFontToggle.Name = "ctbntFontToggle";
            ctbntFontToggle.OffBackColour = Color.FromArgb(223, 105, 13);
            ctbntFontToggle.OffToggleColour = Color.FromArgb(253, 243, 235);
            ctbntFontToggle.OnBackColour = Color.Navy;
            ctbntFontToggle.OnToggleColour = Color.FromArgb(192, 192, 255);
            ctbntFontToggle.Size = new Size(80, 40);
            ctbntFontToggle.TabIndex = 0;
            ctbntFontToggle.UseVisualStyleBackColor = true;
            // 
            // UCSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cgpMainContainer);
            Name = "UCSettings";
            Size = new Size(1250, 825);
            cgpMainContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.CustomGradientPanels cgpMainContainer;
        private Panel panel1;
        private CustomControls.CustomToggleButton customToggleButton1;
        private Label lblDarkLight;
        private CustomControls.CustomButtons cbtnCloseApp;
        private Panel panel2;
        private Label lblFonts;
        private CustomControls.CustomToggleButton ctbntFontToggle;
    }
}
