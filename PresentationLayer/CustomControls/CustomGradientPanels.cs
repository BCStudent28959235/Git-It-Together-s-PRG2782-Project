using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace WinFormsApp_MainProjectFile.PresentationLayer.CustomControls
{
    public class CustomGradientPanels : Panel
    {


        /*this class defines a custom panel with a gradient background
        it creates a panel and then it transitions the background colour between two colors:
        ColorOne and ColorTwo
        Gradient Angle sets the angle at which the gradient will fill in from
        Gradient resolution sets the amount of pixels per strip 
        */
        //CustomGradientPanel is set to inherit from the Panel Class

        public Color ColorOne { get; set; } = Color.Black;  // Default colors
        public Color ColorTwo { get; set; } = Color.White;
        public float GradientAngle { get; set; } = 90F;  // Default gradient angle
        public int OpacityColourOne { get; set; } = 255; // Default is not transparent
        public int OpacityColourTwo { get; set; } = 255;  // Default is not transparent

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush lgb = new LinearGradientBrush(
                ClientRectangle,
                Color.FromArgb(OpacityColourOne, ColorOne),
                Color.FromArgb(OpacityColourTwo, ColorTwo),
                GradientAngle))
            {
                e.Graphics.FillRectangle(lgb, ClientRectangle);
            }



            /*
             * LinearGradientBrush makes the gradient by using using this.ClientRectangle,
             * which represents the rectangles bounds/borders
             *the two colours are set to ColorOne and ColorTwo.
             *GradientAngle specifies which angle the gradient is going to be going to
             *g.FillRectangle uses the brush to fill the entire area of the panel with the gradient
             */

            base.OnPaint(e); //calling the OnPaint method
        }





    }
}

