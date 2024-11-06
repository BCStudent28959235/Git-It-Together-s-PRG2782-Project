using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace WinFormsApp_MainProjectFile.PresentationLayer.CustomControls
{
    public class CustomToggleButton : CheckBox
    {
        //Property fields for ON
        private Color OnBackColour = Color.MediumSlateBlue;
        private Color OnToggleColour = Color.WhiteSmoke;

        //Property fields for OFF
        private Color OffBackColour = Color.MediumSlateBlue;
        private Color OffToggleColour = Color.WhiteSmoke;

    }
}
