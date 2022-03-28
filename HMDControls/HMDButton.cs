using HMDControls.ThemeDefine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDControls
{
    public class HMDButton : Button, IHMDControl
    {
        ThemeMode mode;
        ThemeColor color;


        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Choose Theme Mode.")]
        [Browsable(true)]
        [Bindable(true)]
        public ThemeMode ThemeMode
        {
            get
            {
                return mode;
            }
            set
            {
                Theme.Mode = value;
                Invalidate();
            }

        }
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Description("Choose Theme Color.")]
        [Browsable(true)]
        [Bindable(true)]
        public ThemeColor ThemeColor
        {
            get
            {
                return color;
            }
            set
            {
                Theme.Color = value;
                Invalidate();
            }

        }
        public override Color BackColor
        {
            get
            {
                var m = Theme.Mode;
                return Theme.ForeColor;
            }
        }         
    }
}
