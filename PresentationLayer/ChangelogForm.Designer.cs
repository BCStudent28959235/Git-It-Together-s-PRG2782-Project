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
            cgpMainInfoContainer = new CustomQuadColourGradientPanels();
            cbtnTaskFormOpen = new CustomButtons();
            pnlHoldsChangelog = new Panel();
            rtxtDisplayChangelog = new RichTextBox();
            cbtnCloseChildForm1 = new CustomButtons();
            panel1 = new Panel();
            cgpMainInfoContainer.SuspendLayout();
            pnlHoldsChangelog.SuspendLayout();
            SuspendLayout();
            // 
            // cgpMainInfoContainer
            // 
            cgpMainInfoContainer.ColorFour = Color.FromArgb(254, 242, 232);
            cgpMainInfoContainer.ColorOne = Color.White;
            cgpMainInfoContainer.ColorThree = Color.White;
            cgpMainInfoContainer.ColorTwo = Color.White;
            cgpMainInfoContainer.Controls.Add(cbtnTaskFormOpen);
            cgpMainInfoContainer.Controls.Add(pnlHoldsChangelog);
            cgpMainInfoContainer.Controls.Add(cbtnCloseChildForm1);
            cgpMainInfoContainer.Dock = DockStyle.Fill;
            cgpMainInfoContainer.GradientAngle = 0F;
            cgpMainInfoContainer.GradientCenterX = 0.1F;
            cgpMainInfoContainer.GradientCenterY = 0.5F;
            cgpMainInfoContainer.GradientResolution = 1000;
            cgpMainInfoContainer.Location = new Point(0, 0);
            cgpMainInfoContainer.Margin = new Padding(4, 3, 4, 3);
            cgpMainInfoContainer.Name = "cgpMainInfoContainer";
            cgpMainInfoContainer.Opacity = 255;
            cgpMainInfoContainer.OpacityColourFour = 255;
            cgpMainInfoContainer.OpacityColourOne = 255;
            cgpMainInfoContainer.OpacityColourThree = 255;
            cgpMainInfoContainer.OpacityColourTwo = 255;
            cgpMainInfoContainer.Size = new Size(1285, 825);
            cgpMainInfoContainer.TabIndex = 0;
            cgpMainInfoContainer.UseRadialGradient = true;
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
            // pnlHoldsChangelog
            // 
            pnlHoldsChangelog.BackColor = Color.FromArgb(245, 235, 224);
            pnlHoldsChangelog.Controls.Add(rtxtDisplayChangelog);
            pnlHoldsChangelog.Location = new Point(460, 42);
            pnlHoldsChangelog.Name = "pnlHoldsChangelog";
            pnlHoldsChangelog.Size = new Size(507, 720);
            pnlHoldsChangelog.TabIndex = 11;
            // 
            // rtxtDisplayChangelog
            // 
            rtxtDisplayChangelog.BackColor = Color.White;
            rtxtDisplayChangelog.BorderStyle = BorderStyle.None;
            rtxtDisplayChangelog.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtDisplayChangelog.Location = new Point(26, 23);
            rtxtDisplayChangelog.Name = "rtxtDisplayChangelog";
            rtxtDisplayChangelog.ReadOnly = true;
            rtxtDisplayChangelog.Size = new Size(460, 648);
            rtxtDisplayChangelog.TabIndex = 0;
            rtxtDisplayChangelog.Text = "";
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
            // ChangelogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 825);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(cgpMainInfoContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChangelogForm";
            Text = "TesterForm";
            Load += TesterForm_Load;
            cgpMainInfoContainer.ResumeLayout(false);
            pnlHoldsChangelog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private RichTextBox rtxtDisplayChangelog;
        public CustomQuadColourGradientPanels cgpMainInfoContainer;
        public CustomButtons cbtnCloseChildForm1;
        public Panel pnlHoldsChangelog;
        public CustomButtons cbtnTaskFormOpen;
    }
}