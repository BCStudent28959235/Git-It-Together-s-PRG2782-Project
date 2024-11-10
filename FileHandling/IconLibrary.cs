using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;



namespace WinFormsApp_MainProjectFile.FileHandling
{
    public class IconLibrary : IDisposable
    {
        public string iconsPath;
        private Dictionary<string, Dictionary<string, Image>> modeImages;
        private bool disposed = false; // To detect redundant calls

        // Private static instance for Singleton
        private static IconLibrary _instance;

        // Private constructor to prevent instantiation outside the class
        private IconLibrary()
        {
            iconsPath = Application.StartupPath + @"\PersonalResources\icons";
            modeImages = new Dictionary<string, Dictionary<string, Image>>();
            modeImages["Light"] = new Dictionary<string, Image>();
            modeImages["Dark"] = new Dictionary<string, Image>();

            // Add images for both light and dark modes
            AddImage("Plus", "Plus_L.png", "Light");
            AddImage("Plus", "Plus_D.png", "Dark");
            AddImage("Return", "Return_L.png", "Light");
            AddImage("Return", "Return_D.png", "Dark");
            AddImage("Search", "Search_L.png", "Light");
            AddImage("Search", "Search_D.png", "Dark");
            AddImage("Settings", "Settings_L.png", "Light");
            AddImage("Settings", "Settings_D.png", "Dark");
            AddImage("Summary", "Summary_L.png", "Light");
            AddImage("Summary", "Summary_D.png", "Dark");
            AddImage("Changelog", "Changelog_L.png", "Light");
            AddImage("Changelog", "Changelog_D.png", "Dark");
            AddImage("Close", "Close_L.png", "Light");
            AddImage("Close", "Close_D.png", "Dark");
            AddImage("Dashboard", "Dashboard_L.png", "Light");
            AddImage("Dashboard", "Dashboard_D.png", "Dark");
            AddImage("Data", "Data_L.png", "Light");
            AddImage("Data", "Data_D.png", "Dark");
            AddImage("HomeB", "Home_BL.png", "Light");
            AddImage("HomeB", "Home_BD.png", "Dark");
            AddImage("Minus", "Minus_L.png", "Light");
            AddImage("Minus", "Minus_D.png", "Dark");
            AddImage("HomeS", "Home_L_32.png", "Light");
            AddImage("HomeS", "Home_D_32.png", "Dark");
        }

       
        public static IconLibrary Instance
        {
            get
            {
               
                if (_instance == null)
                {
                    _instance = new IconLibrary();
                }
                return _instance;
            }
        }

        private void AddImage(string imageKey, string imageFileName, string mode)
        {
            if (!modeImages.ContainsKey(mode))
            {
                modeImages[mode] = new Dictionary<string, Image>();
            }

            string imagePath = Path.Combine(iconsPath, imageFileName);
            modeImages[mode][imageKey] = Image.FromFile(imagePath);
        }

      
        public Image GetImage(string imageKey, string mode)
        {
            if (modeImages.ContainsKey(mode) && modeImages[mode].ContainsKey(imageKey))
            {
                return modeImages[mode][imageKey];
            }
            return null; 
        }

        public void Dispose()
        {
           
            if (!disposed)
            {
                foreach (var mode in modeImages.Values)
                {
                    foreach (var image in mode.Values)
                    {
                        image.Dispose(); // Dispose of each image
                    }
                }

                disposed = true;
            }

            GC.SuppressFinalize(this);
        }
    }
}