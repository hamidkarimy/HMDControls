using HMDControls.ThemeDefine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDControls
{
    public static class Theme
    {
        private static ThemeMode mode;
        private static ThemeColor color;
        private static bool isFirstTime = true;
        /// <summary>
        /// for set Dark Or Light Mode
        /// </summary>
        [DefaultValue(ThemeMode.Default)]
        public static ThemeMode Mode 
        {
            get {
                if (isFirstTime)
                {
                   // ColorManagement.SetColor();
                }
                return mode; 
            }
            
            set {
                mode = value;
                ColorManagement.SetColor();
            }
        }      

        /// <summary>
        /// for set Color of Theme
        /// </summary>
        [DefaultValue(ThemeColor.Default)]
        public static ThemeColor Color
        {
            get { return color; }
            set
            {
                color = value;
                ColorManagement.SetColor();
            }
        }

        public static Color BackColorMain { get; set; }
        public static Color BackColorAccent { get; set; }
        public static Color BackColorAccent2 { get; set; }
        public static Color ErrorColor { get; set; }
        public static Color TextColor { get; set; }

        public static Color ForeColor { get; set; }
        public static Color ForeColorAccent { get; set; }
        public static Color ForeColorAccent1 { get; set; }
        public static Color ForeColorDesable { get; set; }
    }
}
