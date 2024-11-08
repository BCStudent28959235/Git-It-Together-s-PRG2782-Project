using WinFormsApp_MainProjectFile.PresentationLayer.CustomControls;

namespace WinFormsApp_MainProjectFile.PresentationLayer
{
    partial class ChangelogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangelogForm));
            customQuadColourGradientPanels1 = new CustomQuadColourGradientPanels();
            cbtnCloseChildForm1 = new CustomButtons();
            panel1 = new Panel();
            panel2 = new Panel();
            cbtnTaskFormOpen = new CustomButtons();
            rtxtDisplayChangelog = new RichTextBox();
            customQuadColourGradientPanels1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // customQuadColourGradientPanels1
            // 
            customQuadColourGradientPanels1.ColorFour = Color.FromArgb(255, 224, 192);
            customQuadColourGradientPanels1.ColorOne = Color.FromArgb(255, 224, 192);
            customQuadColourGradientPanels1.ColorThree = Color.FromArgb(255, 224, 192);
            customQuadColourGradientPanels1.ColorTwo = Color.FromArgb(255, 192, 192);
            customQuadColourGradientPanels1.Controls.Add(cbtnTaskFormOpen);
            customQuadColourGradientPanels1.Controls.Add(panel2);
            customQuadColourGradientPanels1.Controls.Add(cbtnCloseChildForm1);
            customQuadColourGradientPanels1.Dock = DockStyle.Fill;
            customQuadColourGradientPanels1.GradientAngle = 90F;
            customQuadColourGradientPanels1.GradientCenterX = 0.1F;
            customQuadColourGradientPanels1.GradientCenterY = 0.9F;
            customQuadColourGradientPanels1.GradientResolution = 1000;
            customQuadColourGradientPanels1.Location = new Point(0, 0);
            customQuadColourGradientPanels1.Margin = new Padding(4, 3, 4, 3);
            customQuadColourGradientPanels1.Name = "customQuadColourGradientPanels1";
            customQuadColourGradientPanels1.Opacity = 255;
            customQuadColourGradientPanels1.OpacityColourFour = 100;
            customQuadColourGradientPanels1.OpacityColourOne = 255;
            customQuadColourGradientPanels1.OpacityColourThree = 50;
            customQuadColourGradientPanels1.OpacityColourTwo = 20;
            customQuadColourGradientPanels1.Size = new Size(1285, 825);
            customQuadColourGradientPanels1.TabIndex = 0;
            customQuadColourGradientPanels1.UseRadialGradient = true;
            // 
            // cbtnCloseChildForm1
            // 
            cbtnCloseChildForm1.BackColor = Color.FromArgb(255, 192, 192);
            cbtnCloseChildForm1.BackgroundColor = Color.FromArgb(255, 192, 192);
            cbtnCloseChildForm1.BorderColor = Color.Black;
            cbtnCloseChildForm1.BorderRadius = 20;
            cbtnCloseChildForm1.BorderSize = 0;
            cbtnCloseChildForm1.FlatAppearance.BorderColor = Color.Black;
            cbtnCloseChildForm1.FlatAppearance.BorderSize = 0;
            cbtnCloseChildForm1.FlatStyle = FlatStyle.Flat;
            cbtnCloseChildForm1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbtnCloseChildForm1.ForeColor = Color.White;
            cbtnCloseChildForm1.Image = (Image)resources.GetObject("cbtnCloseChildForm1.Image");
            cbtnCloseChildForm1.Location = new Point(1184, 12);
            cbtnCloseChildForm1.Name = "cbtnCloseChildForm1";
            cbtnCloseChildForm1.Size = new Size(89, 76);
            cbtnCloseChildForm1.TabIndex = 10;
            cbtnCloseChildForm1.TextColor = Color.White;
            cbtnCloseChildForm1.UseVisualStyleBackColor = false;
            cbtnCloseChildForm1.Click += cbtnCloseChildForm1_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 825);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 64, 0);
            panel2.Controls.Add(rtxtDisplayChangelog);
            panel2.Location = new Point(460, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(507, 720);
            panel2.TabIndex = 11;
            // 
            // cbtnTaskFormOpen
            // 
            cbtnTaskFormOpen.BackColor = Color.FromArgb(255, 192, 192);
            cbtnTaskFormOpen.BackgroundColor = Color.FromArgb(255, 192, 192);
            cbtnTaskFormOpen.BorderColor = Color.Black;
            cbtnTaskFormOpen.BorderRadius = 20;
            cbtnTaskFormOpen.BorderSize = 0;
            cbtnTaskFormOpen.FlatAppearance.BorderColor = Color.Black;
            cbtnTaskFormOpen.FlatAppearance.BorderSize = 0;
            cbtnTaskFormOpen.FlatStyle = FlatStyle.Flat;
            cbtnTaskFormOpen.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbtnTaskFormOpen.ForeColor = Color.White;
            cbtnTaskFormOpen.Image = (Image)resources.GetObject("cbtnTaskFormOpen.Image");
            cbtnTaskFormOpen.Location = new Point(1184, 150);
            cbtnTaskFormOpen.Name = "cbtnTaskFormOpen";
            cbtnTaskFormOpen.Size = new Size(89, 76);
            cbtnTaskFormOpen.TabIndex = 12;
            cbtnTaskFormOpen.TextColor = Color.White;
            cbtnTaskFormOpen.UseVisualStyleBackColor = false;
            cbtnTaskFormOpen.Click += cbtnTaskFormOpen_Click;
            // 
            // rtxtDisplayChangelog
            // 
            rtxtDisplayChangelog.BorderStyle = BorderStyle.None;
            rtxtDisplayChangelog.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtDisplayChangelog.Location = new Point(26, 23);
            rtxtDisplayChangelog.Name = "rtxtDisplayChangelog";
            rtxtDisplayChangelog.ReadOnly = true;
            rtxtDisplayChangelog.Size = new Size(460, 648);
            rtxtDisplayChangelog.TabIndex = 0;
            rtxtDisplayChangelog.Text = "";
            // 
            // ChangelogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 825);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(customQuadColourGradientPanels1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChangelogForm";
            Text = "TesterForm";
            Load += TesterForm_Load;
            customQuadColourGradientPanels1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomQuadColourGradientPanels customQuadColourGradientPanels1;
        private CustomButtons cbtnCloseChildForm1;
        private Panel panel1;
        private Panel panel2;
        private CustomButtons cbtnTaskFormOpen;
        private RichTextBox rtxtDisplayChangelog;
    }
}