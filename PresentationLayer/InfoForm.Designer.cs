namespace WinFormsApp_MainProjectFile.PresentationLayer
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            panel3 = new Panel();
            customQuadColourGradientPanels1 = new CustomControls.CustomQuadColourGradientPanels();
            cbtnCloseChildFornInfo = new CustomControls.CustomButtons();
            panel5 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            pnlInfoUpper = new Panel();
            lblUpperTitle = new Label();
            lblContent1 = new Label();
            lblKatryn = new Label();
            lblThian = new Label();
            lblTiaan = new Label();
            customQuadColourGradientPanels1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            pnlInfoUpper.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(217, 786);
            panel3.TabIndex = 37;
            // 
            // customQuadColourGradientPanels1
            // 
            customQuadColourGradientPanels1.ColorFour = Color.FromArgb(255, 192, 255);
            customQuadColourGradientPanels1.ColorOne = Color.FromArgb(255, 192, 192);
            customQuadColourGradientPanels1.ColorThree = Color.FromArgb(255, 224, 192);
            customQuadColourGradientPanels1.ColorTwo = Color.FromArgb(255, 128, 0);
            customQuadColourGradientPanels1.Controls.Add(cbtnCloseChildFornInfo);
            customQuadColourGradientPanels1.Controls.Add(panel5);
            customQuadColourGradientPanels1.Controls.Add(panel4);
            customQuadColourGradientPanels1.Controls.Add(panel2);
            customQuadColourGradientPanels1.Controls.Add(pnlInfoUpper);
            customQuadColourGradientPanels1.Dock = DockStyle.Fill;
            customQuadColourGradientPanels1.GradientAngle = 90F;
            customQuadColourGradientPanels1.GradientCenterX = 0.5F;
            customQuadColourGradientPanels1.GradientCenterY = 0.5F;
            customQuadColourGradientPanels1.GradientResolution = 1;
            customQuadColourGradientPanels1.Location = new Point(217, 0);
            customQuadColourGradientPanels1.Name = "customQuadColourGradientPanels1";
            customQuadColourGradientPanels1.Opacity = 200;
            customQuadColourGradientPanels1.OpacityColourFour = 100;
            customQuadColourGradientPanels1.OpacityColourOne = 255;
            customQuadColourGradientPanels1.OpacityColourThree = 100;
            customQuadColourGradientPanels1.OpacityColourTwo = 20;
            customQuadColourGradientPanels1.Size = new Size(1052, 786);
            customQuadColourGradientPanels1.TabIndex = 38;
            customQuadColourGradientPanels1.UseRadialGradient = true;
            // 
            // cbtnCloseChildFornInfo
            // 
            cbtnCloseChildFornInfo.BackColor = Color.FromArgb(255, 192, 192);
            cbtnCloseChildFornInfo.BackgroundColor = Color.FromArgb(255, 192, 192);
            cbtnCloseChildFornInfo.BorderColor = Color.Black;
            cbtnCloseChildFornInfo.BorderRadius = 10;
            cbtnCloseChildFornInfo.BorderSize = 0;
            cbtnCloseChildFornInfo.FlatAppearance.BorderSize = 0;
            cbtnCloseChildFornInfo.FlatStyle = FlatStyle.Flat;
            cbtnCloseChildFornInfo.ForeColor = Color.White;
            cbtnCloseChildFornInfo.Image = (Image)resources.GetObject("cbtnCloseChildFornInfo.Image");
            cbtnCloseChildFornInfo.Location = new Point(961, 12);
            cbtnCloseChildFornInfo.Name = "cbtnCloseChildFornInfo";
            cbtnCloseChildFornInfo.Size = new Size(79, 72);
            cbtnCloseChildFornInfo.TabIndex = 5;
            cbtnCloseChildFornInfo.TextColor = Color.White;
            cbtnCloseChildFornInfo.UseVisualStyleBackColor = false;
            cbtnCloseChildFornInfo.Click += cbtnCloseChildFornInfo_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblTiaan);
            panel5.Location = new Point(690, 98);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 360);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblThian);
            panel4.Location = new Point(370, 98);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 360);
            panel4.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblKatryn);
            panel2.Location = new Point(44, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 360);
            panel2.TabIndex = 1;
            // 
            // pnlInfoUpper
            // 
            pnlInfoUpper.Controls.Add(lblContent1);
            pnlInfoUpper.Controls.Add(lblUpperTitle);
            pnlInfoUpper.Location = new Point(44, 479);
            pnlInfoUpper.Name = "pnlInfoUpper";
            pnlInfoUpper.Size = new Size(946, 247);
            pnlInfoUpper.TabIndex = 0;
            // 
            // lblUpperTitle
            // 
            lblUpperTitle.AutoSize = true;
            lblUpperTitle.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpperTitle.Location = new Point(25, 11);
            lblUpperTitle.Name = "lblUpperTitle";
            lblUpperTitle.Size = new Size(63, 29);
            lblUpperTitle.TabIndex = 0;
            lblUpperTitle.Text = "Title";
            // 
            // lblContent1
            // 
            lblContent1.AutoSize = true;
            lblContent1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContent1.Location = new Point(25, 71);
            lblContent1.Name = "lblContent1";
            lblContent1.Size = new Size(80, 22);
            lblContent1.TabIndex = 1;
            lblContent1.Text = "Content";
            // 
            // lblKatryn
            // 
            lblKatryn.AutoSize = true;
            lblKatryn.Font = new Font("Verdana", 15.75F);
            lblKatryn.Location = new Point(94, 19);
            lblKatryn.Name = "lblKatryn";
            lblKatryn.Size = new Size(81, 25);
            lblKatryn.TabIndex = 0;
            lblKatryn.Text = "Katryn";
            // 
            // lblThian
            // 
            lblThian.AutoSize = true;
            lblThian.Font = new Font("Verdana", 15.75F);
            lblThian.Location = new Point(116, 19);
            lblThian.Name = "lblThian";
            lblThian.Size = new Size(70, 25);
            lblThian.TabIndex = 0;
            lblThian.Text = "Thian";
            // 
            // lblTiaan
            // 
            lblTiaan.AutoSize = true;
            lblTiaan.Font = new Font("Verdana", 15.75F);
            lblTiaan.Location = new Point(114, 19);
            lblTiaan.Name = "lblTiaan";
            lblTiaan.Size = new Size(70, 25);
            lblTiaan.TabIndex = 0;
            lblTiaan.Text = "Tiaan";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 786);
            Controls.Add(customQuadColourGradientPanels1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoForm";
            Text = "InfoForm";
            customQuadColourGradientPanels1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlInfoUpper.ResumeLayout(false);
            pnlInfoUpper.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private CustomControls.CustomQuadColourGradientPanels customQuadColourGradientPanels1;
        private Panel panel2;
        private Panel pnlInfoUpper;
        private Panel panel5;
        private Panel panel4;
        private CustomControls.CustomButtons cbtnCloseChildFornInfo;
        private Label lblContent1;
        private Label lblUpperTitle;
        private Label lblThian;
        private Label lblKatryn;
        private Label lblTiaan;
    }
}