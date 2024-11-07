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
            customQuadColourGradientPanels1 = new CustomQuadColourGradientPanels();
            SuspendLayout();
            // 
            // customQuadColourGradientPanels1
            // 
            customQuadColourGradientPanels1.ColorFour = Color.Blue;
            customQuadColourGradientPanels1.ColorOne = Color.Black;
            customQuadColourGradientPanels1.ColorThree = Color.Black;
            customQuadColourGradientPanels1.ColorTwo = Color.Black;
            customQuadColourGradientPanels1.Dock = DockStyle.Fill;
            customQuadColourGradientPanels1.GradientAngle = 90F;
            customQuadColourGradientPanels1.GradientCenterX = 0.1F;
            customQuadColourGradientPanels1.GradientCenterY = 0.9F;
            customQuadColourGradientPanels1.GradientResolution = 1000;
            customQuadColourGradientPanels1.Location = new Point(0, 0);
            customQuadColourGradientPanels1.Margin = new Padding(4, 3, 4, 3);
            customQuadColourGradientPanels1.Name = "customQuadColourGradientPanels1";
            customQuadColourGradientPanels1.Opacity = 255;
            customQuadColourGradientPanels1.OpacityColourFour = 255;
            customQuadColourGradientPanels1.OpacityColourOne = 255;
            customQuadColourGradientPanels1.OpacityColourThree = 255;
            customQuadColourGradientPanels1.OpacityColourTwo = 255;
            customQuadColourGradientPanels1.Size = new Size(1148, 621);
            customQuadColourGradientPanels1.TabIndex = 0;
            customQuadColourGradientPanels1.UseRadialGradient = true;
            // 
            // TesterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 621);
            Controls.Add(customQuadColourGradientPanels1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TesterForm";
            Text = "TesterForm";
            Load += TesterForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private CustomQuadColourGradientPanels customQuadColourGradientPanels1;
    }
}