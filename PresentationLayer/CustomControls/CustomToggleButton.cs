using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp_MainProjectFile.PresentationLayer.CustomControls
{
    public class CustomToggleButton : CheckBox
    {
        // Private fields for ON
        private Color onBackColour = Color.MediumSlateBlue;
        private Color onToggleColour = Color.WhiteSmoke;

        // Private fields for OFF
        private Color offBackColour = Color.Gray;
        private Color offToggleColour = Color.WhiteSmoke;

        private bool solidStyle = true;

        // Constructor
        public CustomToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
            this.CheckedChanged += (s, e) => this.Invalidate(); // Redraw on Checked change
        }

        // Public properties
        [Category("Customise")]
        public Color OnBackColour
        {
            get => onBackColour;
            set
            {
                onBackColour = value;
                this.Invalidate();
            }
        }

        [Category("Customise")]
        public Color OnToggleColour
        {
            get => onToggleColour;
            set
            {
                onToggleColour = value;
                this.Invalidate();
            }
        }

        [Category("Customise")]
        public Color OffBackColour
        {
            get => offBackColour;
            set
            {
                offBackColour = value;
                this.Invalidate();
            }
        }

        [Category("Customise")]
        public Color OffToggleColour
        {
            get => offToggleColour;
            set
            {
                offToggleColour = value;
                this.Invalidate();
            }
        }

        [Browsable(false)]
        public override string Text
        {
            get => base.Text;
            set { }
        }

        [Category("Customise")]
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get => solidStyle;
            set
            {
                solidStyle = value;
                this.Invalidate();
            }
        }

        // Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            // Draw toggle background
            using (GraphicsPath path = GetFigurePath())
            {
                if (this.Checked) // ON
                {
                    using (Brush backBrush = new SolidBrush(onBackColour))
                    using (Brush toggleBrush = new SolidBrush(onToggleColour))
                    {
                        if (solidStyle)
                            pevent.Graphics.FillPath(backBrush, path);
                        else
                            pevent.Graphics.DrawPath(new Pen(onBackColour, 2), path);

                        // Draw the toggle
                        pevent.Graphics.FillEllipse(toggleBrush, new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
                    }
                }
                else // OFF
                {
                    using (Brush backBrush = new SolidBrush(offBackColour))
                    using (Brush toggleBrush = new SolidBrush(offToggleColour))
                    {
                        if (solidStyle)
                            pevent.Graphics.FillPath(backBrush, path);
                        else
                            pevent.Graphics.DrawPath(new Pen(offBackColour, 2), path);

                        // Draw the toggle
                        pevent.Graphics.FillEllipse(toggleBrush, new Rectangle(2, 2, toggleSize, toggleSize));
                    }
                }
            }
        }
    }
}
