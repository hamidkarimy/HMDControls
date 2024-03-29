﻿using HMDControls.ThemeDefine;
using intelika.fontAwesome;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms.Design;

namespace HMDControls.Controls
{   
    public class HMDButton : Button, IHMDControl
    {
        ThemeMode mode;
        ThemeColor color;
        NormalIconType  icon;       
        public bool Enabled
        {
            get
            {
                return base.Enabled;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() => base.Enabled = value, this);
            }
        }
        public bool Visible
        {
            get
            {
                return base.Visible;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() => base.Visible = value, this);
            }
        }
        public string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() => base.Text = value, this);
            }
        }

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
                StaticHelper.InvokeIfRequired(() =>
                {
                    mode = value;
                    Theme.Mode = value;
                    Refresh();
                }, this);
                
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
                StaticHelper.InvokeIfRequired(() =>
                {
                    color = value;
                    Theme.Color = value;
                    Refresh();
                }, this);
               
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
                StaticHelper.InvokeIfRequired(() =>
                {
                    icon = value;
                    Image = Icons.RegularIcon.GetImage(icon, color: Color.White, size: 32);
                    Refresh();
                }, this);
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
