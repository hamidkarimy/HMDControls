using HMDControls.ThemeDefine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMDControls
{
    public class HMDButton : Button, IHMDControl
    {
        ThemeMode mode;
        ThemeColor color;
        
        Size size;

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
                mode = value;
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
                color = value;
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
            MinimumSize = new Size(100, 30);
            FlatAppearance.BorderSize = 0;
            AutoSize = true;   
            
        }
    }
}
