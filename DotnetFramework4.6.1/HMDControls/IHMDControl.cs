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
         ThemeColor ThemeColor { get; set; }
         ThemeMode ThemeMode { get; set; }
    }
}
