using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp_MainProjectFile.PresentationLayer;
using WinFormsApp_MainProjectFile.PresentationLayer.CustomControls;
using System.Diagnostics;

namespace WinFormsApp_MainProjectFile.LogicLayer
{
    public class ThemeHandler
    {
        public void ApplyTheme(Form form, Theme theme)
        {
           
            form.BackColor = theme.BackgroundColor;

     
            foreach (Control control in form.Controls)
            {
                ApplyControlTheme(control, theme);
            }
        }

        private void ApplyControlTheme(Control control, Theme theme)
        {
            var controlsToSkip = new List<string>
{
  
    "pnlSliderHolder1",
    "pnlSliderHolder2",
    "pnlNavContainer"
};

            
            if (controlsToSkip.Contains(control.Name) ||
                controlsToSkip.Contains(control.Parent?.Name))
            {
              
                return;
            }
           
            if (control.Name == "gpnlBorder1" || control.Name == "gpnlBorder2" || control.Name == "gpnlBorder3")
            {
              
                return;
            }

           
            if (controlsToSkip.Contains(control.Name) ||
                controlsToSkip.Contains(control.Parent?.Name))
            {
               
                return;
            }

            // Apply theme based on control type
            if (control is Panel panel)
            {
                // Apply panel color for regular panels
                panel.BackColor = theme.PanelColor;

                // If the panel is a CustomGradientPanel, apply gradient colors
                if (panel is CustomGradientPanels customGradientPanel)
                {
                    customGradientPanel.ColorOne = theme.BackColour1;
                    customGradientPanel.ColorTwo = theme.BackColour2;
                }
                // If it's a CustomQuadGradientPanel, apply different colors
                else if (panel is CustomQuadColourGradientPanels customQuadGradientPanel)
                {
                    customQuadGradientPanel.ColorOne = theme.BackColour1;
                    customQuadGradientPanel.ColorTwo = theme.BackColour2;
                    customQuadGradientPanel.ColorThree = theme.BackColour2;
                    customQuadGradientPanel.ColorFour = theme.BackColour1;
                }
            }
            else if (control is Button button)
            {
                // Check the immediate parent of the button 
                Control parentControl = button.Parent;

                // Check if it's a regular button or a CustomButton
                bool isCustomButton = button is CustomButtons;

                // Debugging: Log button type
                Debug.WriteLine($"Applying theme to Button: {button.Name}, Is CustomButton: {isCustomButton}");

                // Check if the parent is a CustomGradientPanel or CustomQuadGradientPanel
                if (parentControl is CustomGradientPanels || parentControl is CustomQuadColourGradientPanels)
                {
                    // Debugging: Log parent type
                    Debug.WriteLine($"Parent is CustomGradientPanel or CustomQuadGradientPanel: {parentControl.Name}");

                    // If it's a CustomButton on a CustomGradientPanel or CustomQuadGradientPanel
                    if (isCustomButton)
                    {
                        button.BackColor = theme.ReturnButtonColor; // Custom button color
                        Debug.WriteLine($"Applied ReturnButtonColor: {theme.ReturnButtonColor}");
                    }
                    else
                    {
                        button.BackColor = theme.ButtonColor; // Regular button on custom panels
                        Debug.WriteLine($"Applied ButtonColor: {theme.ButtonColor}");
                    }
                }
                else if (parentControl is Panel)
                {
                    // Debugging: Log if it's a regular panel
                    Debug.WriteLine($"Parent is a regular Panel: {parentControl.Name}");

                    // If it's a regular button on a regular Panel
                    if (isCustomButton)
                    {
                        button.BackColor = theme.PanelButtonColor; // Custom button color
                        Debug.WriteLine($"Applied ReturnButtonColor: {theme.ReturnButtonColor}");
                    }
                    else
                    {
                        button.BackColor = theme.PanelButtonColor; // Regular button on regular panel
                        Debug.WriteLine($"Applied PanelButtonColor: {theme.PanelButtonColor}");
                    }
                }
                else
                {
                    // Default button color if it's not directly on any of the above panels
                    button.BackColor = theme.ButtonColor;
                    Debug.WriteLine($"Applied default ButtonColor: {theme.ButtonColor}");
                }

                // Set the text color for the button
                button.ForeColor = theme.ForegroundColor;
                Debug.WriteLine($"Applied ForegroundColor: {theme.ForegroundColor}");
            }

            else if (control is TextBox textBox)
            {
                // Apply background and font color for textboxes
                textBox.BackColor = theme.TextBoxBackgroundColor;
                textBox.ForeColor = theme.LightFontColor;
            }
            else if (control is Label label)
            {
                // Apply label font color
                label.ForeColor = theme.LightFontColor;
            }
            else if (control is TabControl tabControl)
            {
                // Apply tab control colors
                tabControl.BackColor = theme.TabColour1;
                tabControl.ForeColor = theme.TabColour2;
            }
            // If you have more controls, you can extend the logic here as needed
            else
            {
                // Default behavior for other controls
                control.ForeColor = theme.ForegroundColor;
            }

            // Recursively apply the theme to child controls (if any)
            foreach (Control childControl in control.Controls)
            {
                ApplyControlTheme(childControl, theme);
            }
        }

        public static void ApplyLightMode(Form form)
        {
            ThemeHandler themeHandler = new ThemeHandler();
            themeHandler.ApplyTheme(form, Theme.LightTheme);
        }

        public static void ApplyDarkMode(Form form)
        {
            ThemeHandler themeHandler = new ThemeHandler();
            themeHandler.ApplyTheme(form, Theme.DarkTheme);
        }
    }
}