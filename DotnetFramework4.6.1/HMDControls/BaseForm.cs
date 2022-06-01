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
    public class BaseForm :Form,IHMDControl
    {
        ThemeMode mode;
        ThemeColor color;


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
                Theme.Mode=value;
                Invalidate(true);
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
                Theme.Color = value;
                Invalidate(true);
            }

        }
        public override Color BackColor
        {
            get {
                //var m = Theme.Mode;
                return Theme.BackColorMain; 
            }          
        }       
    }
}
