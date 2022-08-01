using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDControls.ThemeDefine
{
    internal static class ColorManagement
    {
        internal static void SetColor()
        {
            switch (Theme.Color)
            {
                case ThemeColor.Default:
                    {
                        Theme.ErrorColor = Color.Red;
                        Theme.ForeColor = Color.FromArgb(69, 182, 220); 
                        Theme.ForeColorAccent = Color.FromArgb(43, 64, 77);
                        Theme.ForeColorAccent1 = Color.FromArgb(23, 36, 43);
                        Theme.ForeColorDisable = Color.FromArgb(134, 153, 165);
                        break;
                    }
                case ThemeColor.Red:
                    {
                        Theme.ErrorColor = Color.Brown;
                        Theme.ForeColor = Color.FromArgb(243, 67, 67); 
                        Theme.ForeColorAccent = Color.FromArgb(65, 161, 217);
                        Theme.ForeColorAccent1 = Color.FromArgb(85, 50, 45);
                        Theme.ForeColorDisable = Color.FromArgb(230, 152, 142);
                        break;
                    }
                case ThemeColor.Green:
                    {
                        Theme.ErrorColor = Color.Brown;
                        Theme.ForeColor = Color.FromArgb(82, 172, 64); 
                        Theme.ForeColorAccent = Color.FromArgb(36, 60, 36);
                        Theme.ForeColorAccent1 = Color.FromArgb(20, 34, 20);
                        Theme.ForeColorDisable = Color.FromArgb(169, 214, 169);
                        break;
                    }
                case ThemeColor.Blue:
                    {
                        Theme.ErrorColor = Color.Red;
                        Theme.ForeColor = Color.FromArgb(69, 182, 220); 
                        Theme.ForeColorAccent = Color.FromArgb(43, 64, 77);
                        Theme.ForeColorAccent1 = Color.FromArgb(23, 36, 43);
                        Theme.ForeColorDisable = Color.FromArgb(134, 153, 165);
                        break;
                    }
                default:
                    break;
            }
            switch (Theme.Mode)
            {
                case ThemeMode.Light:
                    {
                        Theme.BackColorMain = Color.White;
                        Theme.BackColorAccent = Color.FromArgb(241, 241, 241);
                        Theme.BackColorAccent2 = Color.FromArgb(153, 153, 153);
                        Theme.TextColor = Color.Black;
                        break;
                    }
                case ThemeMode.Dark:
                    {
                        Theme.BackColorMain = Color.FromArgb(24, 25, 29);
                        Theme.BackColorAccent = Color.FromArgb(61, 68, 75);
                        Theme.BackColorAccent2 = Color.FromArgb(128, 128, 128);
                        Theme.TextColor = Color.White;
                        Theme.ForeColorAccent = Theme.BackColorMain;
                        Theme.ForeColorAccent1 = Color.FromArgb(40, 46, 51);
                        //Theme.ForeColor = Color.FromArgb(40, 46, 51);
                        Theme.ForeColorDisable = Color.FromArgb(141, 147, 158);
                        break;
                    }
                case ThemeMode.Default:
                    {
                        Theme.BackColorMain = Color.White;
                        Theme.BackColorAccent = Color.FromArgb(241, 241, 241);
                        Theme.BackColorAccent2 = Color.FromArgb(153, 153, 153);
                        Theme.TextColor = Color.Black;
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
