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
            pnlSide2 = new Panel();
            customQuadColourGradientPanels1 = new CustomControls.CustomQuadColourGradientPanels();
            cbtnCloseChildFornInfo = new CustomControls.CustomButtons();
            pnlInfoUpper = new Panel();
            lblContent1 = new Label();
            lblUpperTitle = new Label();
            customQuadColourGradientPanels1.SuspendLayout();
            pnlInfoUpper.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSide2
            // 
            pnlSide2.BackColor = Color.Transparent;
            pnlSide2.Dock = DockStyle.Left;
            pnlSide2.Location = new Point(0, 0);
            pnlSide2.Name = "pnlSide2";
            pnlSide2.Size = new Size(217, 786);
            pnlSide2.TabIndex = 37;
            // 
            // customQuadColourGradientPanels1
            // 
            customQuadColourGradientPanels1.ColorFour = Color.FromArgb(254, 242, 232);
            customQuadColourGradientPanels1.ColorOne = Color.FromArgb(254, 242, 232);
            customQuadColourGradientPanels1.ColorThree = Color.White;
            customQuadColourGradientPanels1.ColorTwo = Color.White;
            customQuadColourGradientPanels1.Controls.Add(cbtnCloseChildFornInfo);
            customQuadColourGradientPanels1.Controls.Add(pnlInfoUpper);
            customQuadColourGradientPanels1.Dock = DockStyle.Fill;
            customQuadColourGradientPanels1.GradientAngle = 315F;
            customQuadColourGradientPanels1.GradientCenterX = 0.2F;
            customQuadColourGradientPanels1.GradientCenterY = 0.6F;
            customQuadColourGradientPanels1.GradientResolution = 1;
            customQuadColourGradientPanels1.Location = new Point(217, 0);
            customQuadColourGradientPanels1.Name = "customQuadColourGradientPanels1";
            customQuadColourGradientPanels1.Opacity = 255;
            customQuadColourGradientPanels1.OpacityColourFour = 255;
            customQuadColourGradientPanels1.OpacityColourOne = 255;
            customQuadColourGradientPanels1.OpacityColourThree = 255;
            customQuadColourGradientPanels1.OpacityColourTwo = 255;
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
            // pnlInfoUpper
            // 
            pnlInfoUpper.BackColor = Color.White;
            pnlInfoUpper.Controls.Add(lblContent1);
            pnlInfoUpper.Controls.Add(lblUpperTitle);
            pnlInfoUpper.Location = new Point(44, 147);
            pnlInfoUpper.Name = "pnlInfoUpper";
            pnlInfoUpper.Size = new Size(946, 459);
            pnlInfoUpper.TabIndex = 0;
            // 
            // lblContent1
            // 
            lblContent1.AutoSize = true;
            lblContent1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContent1.Location = new Point(25, 64);
            lblContent1.Name = "lblContent1";
            lblContent1.Size = new Size(830, 110);
            lblContent1.TabIndex = 1;
            lblContent1.Text = resources.GetString("lblContent1.Text");
            // 
            // lblUpperTitle
            // 
            lblUpperTitle.AutoSize = true;
            lblUpperTitle.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpperTitle.Location = new Point(25, 11);
            lblUpperTitle.Name = "lblUpperTitle";
            lblUpperTitle.Size = new Size(400, 29);
            lblUpperTitle.TabIndex = 0;
            lblUpperTitle.Text = "Git It Together's PRG282 project";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 786);
            Controls.Add(customQuadColourGradientPanels1);
            Controls.Add(pnlSide2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoForm";
            Text = "InfoForm";
            customQuadColourGradientPanels1.ResumeLayout(false);
            pnlInfoUpper.ResumeLayout(false);
            pnlInfoUpper.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSide2;
        private CustomControls.CustomQuadColourGradientPanels customQuadColourGradientPanels1;
        private Panel pnlInfoUpper;
        private CustomControls.CustomButtons cbtnCloseChildFornInfo;
        private Label lblContent1;
        private Label lblUpperTitle;
    }
}