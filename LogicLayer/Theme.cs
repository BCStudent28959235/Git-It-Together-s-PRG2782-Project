using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp_MainProjectFile.LogicLayer
{
    public class Theme
    {
        //  properties for theme colours
        public Color BackgroundColor { get; set; }
        public Color BackColour1 { get; set; }
        public Color BackColour2 { get; set; }
        public Color ForegroundColor { get; set; }
        public Color LightFontColor { get; set; }
        public Color TextBoxBackgroundColor { get; set; }
        public Color PanelColor { get; set; }
        public Color ButtonColor { get; set; }
        public Color ReturnButtonColor { get; set; }
        public Color PanelButtonColor { get; set; }

        public Color QuadPanelColor1 { get; set; }
        public Color QuadPanelColor2 { get; set; }
        public Color QuadPanelColor3 { get; set; }
        public Color QuadPanelColor4 { get; set; }
        

        public Color TabColour1 { get; set; }
        public Color TabColour2 { get; set; }

      


        public bool getD {  get; set; }



        public static Theme DarkTheme { get; } = new Theme
        {
            getD = true,
            BackgroundColor = Color.FromArgb(33, 42, 62),
            ForegroundColor = Color.FromArgb(255, 255, 255),
            LightFontColor = Color.FromArgb(255, 255, 255),
            TextBoxBackgroundColor = Color.FromArgb(45, 45, 48),
            PanelColor = Color.FromArgb(50, 50, 50),
            ButtonColor = Color.FromArgb(57, 72, 103),
            ReturnButtonColor = Color.FromArgb(57, 72, 103),
            PanelButtonColor = Color.FromArgb(70, 70, 70),


            QuadPanelColor1 = Color.FromArgb(70, 70, 70),
            QuadPanelColor2 = Color.FromArgb(70, 70, 70),
            QuadPanelColor3 = Color.FromArgb(70, 70, 70),
            QuadPanelColor4 = Color.FromArgb(70, 70, 70),


            TabColour1 = Color.FromArgb(237, 140, 65),

            TabColour2 = Color.FromArgb(255, 192, 128),
         

           

        };

    public static Theme LightTheme { get; } = new Theme 
    {
        getD = false,
        BackColour1=Color.FromArgb(254, 242, 232), //for CustomGradientPanels 254, 242, 232
        BackColour2 = Color.White,//for Custom Gradient Panels


        BackgroundColor = Color.White,//For forms back and foreground
        ForegroundColor = Color.Black,//For forms back and foreground



        LightFontColor = Color.Black,//for forms font colour
        TextBoxBackgroundColor = Color.FromArgb(255, 251, 254),//for textboxes

        PanelColor = Color.White, //for regular panels

        ButtonColor = Color.FromArgb(245, 235, 224), //for regular buttons but theyre on top of a CustomGradientPanels  or a CustomQuadGradientPanels

        ReturnButtonColor = Color.FromArgb(255, 192, 192), //for CustomButtons thatre on top of  a CustomGradientPanels  or a CustomQuadGradientPanels

        PanelButtonColor = Color.FromArgb(208, 187, 195), //for regular buttons on top of regular panels


        QuadPanelColor1 = Color.FromArgb(255, 224, 192), // for CustomQuadGradientPanels
        QuadPanelColor2 = Color.FromArgb(255, 192, 192),// for CustomQuadGradientPanels
        QuadPanelColor3 = Color.FromArgb(255, 224, 192),// for CustomQuadGradientPanels
        QuadPanelColor4 = Color.FromArgb(255, 192, 192),// for CustomQuadGradientPanels

        TabColour1 = Color.Black, //for anything with gpnlBorder in their name eg. gpnlBorder1, gpnlBorder2

        TabColour2 = Color.DimGray,//for anything with gpnlBorder in their name eg. gpnlBorder1, gpnlBorder2



    };

       
}
}