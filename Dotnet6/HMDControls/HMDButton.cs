using HMDControls.ThemeDefine;
using intelika.fontAwesome;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms.Design;

namespace HMDControls
{   
    public class HMDButton : Button, IHMDControl
    {
        ThemeMode mode;
        ThemeColor color;
        NormalIconType  icon;
        [Category("Appearance")]
        [Description("Choose Theme Mode.")]
        public ThemeMode ThemeMode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
                Theme.Mode = value;  
                Refresh();
            }

        }
        [Category("Appearance")]
        [Description("Choose Theme Color.")]
        public ThemeColor ThemeColor
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                Theme.Color = value;
                Refresh();
            }

        }


        [Category("Appearance")]
        [Description("Choose Icon.")]
        public NormalIconType Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                Image = Icons.RegularIcon.GetImage(icon, color: Color.White, size: 32);                
                Refresh();

            }
        }
        public override Color BackColor
        {
            get
            {
                var m = Theme.Mode;
                if (Enabled)
                {
                    return Theme.ForeColor;
                }
                return Theme.ForeColorDisable;
            }
        }
        public override Color ForeColor 
        {
            get
            {
                return Color.White;
            }
        }
        protected override void InitLayout()
        {
            base.InitLayout();
            FlatStyle=FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }
    }
}
