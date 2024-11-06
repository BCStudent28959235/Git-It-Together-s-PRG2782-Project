using WinFormsApp_MainProjectFile.PresentationLayer.CustomControls;

namespace WinFormsApp_MainProjectFile.PresentationLayer
{
    partial class TesterForm
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
            this.customQuadColourGradientPanels1 = new WinFormsApp_MainProjectFile.PresentationLayer.CustomControls.CustomQuadColourGradientPanels();
            this.SuspendLayout();
            // 
            // customQuadColourGradientPanels1
            // 
            this.customQuadColourGradientPanels1.ColorFour = System.Drawing.Color.Blue;
            this.customQuadColourGradientPanels1.ColorOne = System.Drawing.Color.Black;
            this.customQuadColourGradientPanels1.ColorThree = System.Drawing.Color.Black;
            this.customQuadColourGradientPanels1.ColorTwo = System.Drawing.Color.Black;
            this.customQuadColourGradientPanels1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customQuadColourGradientPanels1.GradientAngle = 90F;
            this.customQuadColourGradientPanels1.GradientCenterX = 0.1F;
            this.customQuadColourGradientPanels1.GradientCenterY = 0.9F;
            this.customQuadColourGradientPanels1.GradientResolution = 1000;
            this.customQuadColourGradientPanels1.Location = new System.Drawing.Point(0, 0);
            this.customQuadColourGradientPanels1.Name = "customQuadColourGradientPanels1";
            this.customQuadColourGradientPanels1.Opacity = 255;
            this.customQuadColourGradientPanels1.OpacityColourFour = 255;
            this.customQuadColourGradientPanels1.OpacityColourOne = 255;
            this.customQuadColourGradientPanels1.OpacityColourThree = 255;
            this.customQuadColourGradientPanels1.OpacityColourTwo = 255;
            this.customQuadColourGradientPanels1.Size = new System.Drawing.Size(984, 538);
            this.customQuadColourGradientPanels1.TabIndex = 0;
            this.customQuadColourGradientPanels1.UseRadialGradient = true;
            // 
            // TesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 538);
            this.Controls.Add(this.customQuadColourGradientPanels1);
            this.Name = "TesterForm";
            this.Text = "TesterForm";
            this.Load += new System.EventHandler(this.TesterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomQuadColourGradientPanels customQuadColourGradientPanels1;
    }
}