using HMDControls.ThemeDefine;
using System.Drawing;

namespace HMDControls
{
    public static class Theme
    {
        private static ThemeMode mode;
        private static ThemeColor color;

        public static ThemeMode Mode
        {
            get
            {
                return mode;
            }

            set
            {
                mode = value;
                ColorManagement.SetColor();
            }
        }
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
        public static Color ForeColorDisable { get; set; }
    }
}
