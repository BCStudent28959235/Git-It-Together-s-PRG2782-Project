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
            lsvChangeLog = new ListView();
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
            cgpMainInfoContainer.Margin = new Padding(6, 5, 6, 5);
            cgpMainInfoContainer.Name = "cgpMainInfoContainer";
            cgpMainInfoContainer.Opacity = 255;
            cgpMainInfoContainer.OpacityColourFour = 255;
            cgpMainInfoContainer.OpacityColourOne = 255;
            cgpMainInfoContainer.OpacityColourThree = 255;
            cgpMainInfoContainer.OpacityColourTwo = 255;
            cgpMainInfoContainer.Size = new Size(1836, 1375);
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
            cbtnTaskFormOpen.Location = new Point(1691, 250);
            cbtnTaskFormOpen.Margin = new Padding(4, 5, 4, 5);
            cbtnTaskFormOpen.Name = "cbtnTaskFormOpen";
            cbtnTaskFormOpen.Size = new Size(127, 127);
            cbtnTaskFormOpen.TabIndex = 12;
            cbtnTaskFormOpen.TextColor = Color.White;
            cbtnTaskFormOpen.UseVisualStyleBackColor = false;
            cbtnTaskFormOpen.Click += cbtnTaskFormOpen_Click;
            // 
            // pnlHoldsChangelog
            // 
            pnlHoldsChangelog.BackColor = Color.FromArgb(245, 235, 224);
            pnlHoldsChangelog.Controls.Add(lsvChangeLog);
            pnlHoldsChangelog.Location = new Point(657, 70);
            pnlHoldsChangelog.Margin = new Padding(4, 5, 4, 5);
            pnlHoldsChangelog.Name = "pnlHoldsChangelog";
            pnlHoldsChangelog.Size = new Size(724, 1200);
            pnlHoldsChangelog.TabIndex = 11;
            // 
            // lsvChangeLog
            // 
            lsvChangeLog.Location = new Point(3, 3);
            lsvChangeLog.Name = "lsvChangeLog";
            lsvChangeLog.Size = new Size(718, 1197);
            lsvChangeLog.TabIndex = 0;
            lsvChangeLog.UseCompatibleStateImageBehavior = false;
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
            cbtnCloseChildForm1.Location = new Point(1691, 20);
            cbtnCloseChildForm1.Margin = new Padding(4, 5, 4, 5);
            cbtnCloseChildForm1.Name = "cbtnCloseChildForm1";
            cbtnCloseChildForm1.Size = new Size(127, 127);
            cbtnCloseChildForm1.TabIndex = 10;
            cbtnCloseChildForm1.TextColor = Color.White;
            cbtnCloseChildForm1.UseVisualStyleBackColor = false;
            cbtnCloseChildForm1.Click += cbtnCloseChildForm1_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 1375);
            panel1.TabIndex = 1;
            // 
            // ChangelogForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1836, 1375);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(cgpMainInfoContainer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "ChangelogForm";
            Text = "TesterForm";
            Load += TesterForm_Load;
            cgpMainInfoContainer.ResumeLayout(false);
            pnlHoldsChangelog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        public CustomQuadColourGradientPanels cgpMainInfoContainer;
        public CustomButtons cbtnCloseChildForm1;
        public Panel pnlHoldsChangelog;
        public CustomButtons cbtnTaskFormOpen;
        private ListView lsvChangeLog;
    }
}