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
    public class CustomQuadColourGradientPanels : Panel
    {
        public Color ColorOne { get; set; }
        public Color ColorTwo { get; set; }
        public Color ColorThree { get; set; }
        public Color ColorFour { get; set; }

        public int OpacityColourOne { get; set; } = 255;
        public int OpacityColourTwo { get; set; } = 255;
        public int OpacityColourThree { get; set; } = 255;
        public int OpacityColourFour { get; set; } = 255;
        public float GradientAngle { get; set; } = 90F;

        public int GradientResolution { get; set; } = 1;
        public bool UseRadialGradient { get; set; } = true;
        public float GradientCenterX { get; set; } = 0.5f;
        public float GradientCenterY { get; set; } = 0.5f;
        public int Opacity { get; set; } = 255;

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap gradientBitmap = Gradient2D(ClientRectangle, ColorOne, ColorTwo, ColorThree, ColorFour);
            e.Graphics.DrawImage(gradientBitmap, 0, 0);
            gradientBitmap.Dispose();

            base.OnPaint(e);
        }

        private Bitmap Gradient2D(Rectangle r, Color c1, Color c2, Color c3, Color c4)
        {
            List<Color> colors = new List<Color>
        {
            Color.FromArgb(OpacityColourOne, c1),


            Color.FromArgb(OpacityColourTwo, c2),
             Color.FromArgb(OpacityColourThree, c3),
              Color.FromArgb(OpacityColourFour, c4)
        };

            Bitmap bmp = new Bitmap(r.Width, r.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int y = 0; y < r.Height; y += GradientResolution)
                {
                    using (PathGradientBrush pgb = new PathGradientBrush(getCorners(r).ToArray()))
                    {
                        pgb.CenterPoint = new PointF(r.Width * GradientCenterX, r.Height * GradientCenterY);
                        pgb.CenterColor = medianColor(colors);
                        pgb.SurroundColors = colors.ToArray();
                        g.FillRectangle(pgb, 0, y, r.Width, GradientResolution);
                    }
                }
            }
            return bmp;
        }

        private List<PointF> getCorners(RectangleF r)
        {
            return new List<PointF>() { r.Location, new PointF(r.Right, r.Top), new PointF(r.Right, r.Bottom), new PointF(r.Left, r.Bottom) };
        }

        private static Color medianColor(List<Color> cols)
        {
            int c = cols.Count;
            return Color.FromArgb(cols.Sum(x => x.A) / c, cols.Sum(x => x.R) / c, cols.Sum(x => x.G) / c, cols.Sum(x => x.B) / c);
        }
    }

}
