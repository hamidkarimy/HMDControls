using HMDControls.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMDControls.WinForms
{
   public class HMDTextBox:TextBox
    {
        [DefaultValue(Language.English)]
        private Language Language
        {
            get { return Language; }
            set
            {
                switch (value)
                {
                    case Language.English:
                        this.RightToLeft = RightToLeft.No;
                        break;
                    case Language.Farsi:
                        this.RightToLeft = RightToLeft.Yes;
                        break;
                    case Language.Arabic:
                        this.RightToLeft = RightToLeft.Yes;
                        break;
                    default:
                        this.RightToLeft = RightToLeft.No;
                        break;
                }
            }
        }
        [DefaultValue(TextBoxType.Text)]
        private TextBoxType Type { get; set; }
        [DefaultValue(false)]
        private bool Requred { get; set; }
        public bool Verified { get; set; }
        public string ErrorMessage { get; set; }

    }
}
