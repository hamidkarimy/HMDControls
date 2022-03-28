using HMDControls.ThemeDefine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDControls
{
    internal interface IHMDControl
    {
        public ThemeColor ThemeColor { get; set; }
        public ThemeMode ThemeMode { get; set; }
    }
}
