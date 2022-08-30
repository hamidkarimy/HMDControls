using HMDControls;
using HMDControls.Controls;
using intelika.fontAwesome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 :HMDBaseForm
    {
        public Form1()
        {
            InitializeComponent();
            //this.Icon=  Icons.LightIcon.GetIcon(NormalIconType.alarm_clock, Color.GreenYellow);
        }
        private void hmdButton1_Click(object sender, EventArgs e)
        {
            LoadData( setProgress,"nafas");
        }

        private void Form1_Load(object sender, EventArgs e)
        {                  
        }

        private void setProgress(string text)
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(50);
                //backgroundWorker1.ReportProgress(i + 1);
            }
                hmdTextbox1.Text = text.ToString();

            hmdTextbox1.Icon = NormalIconType.search;
        }

        private int  GetPow(int a)
        {
            return a * a;
        }
        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                ThemeColor = HMDControls.ThemeDefine.ThemeColor.Red;
            }
            if (rbBlue.Checked)
            {
                ThemeColor = HMDControls.ThemeDefine.ThemeColor.Blue;
            }
            if (rbGreen.Checked)
            {
                ThemeColor = HMDControls.ThemeDefine.ThemeColor.Green;
            }
            panel1.BackColor = Theme.ForeColor;
            panel2.BackColor = Theme.ForeColorAccent;
            panel3.BackColor = Theme. ForeColorAccent1;
            panel4.BackColor = Theme.ForeColorDisable;
            panel5.BackColor = Theme.TextColor;
            panel6.BackColor = Theme.BackColorMain;
            panel7.BackColor = Theme.BackColorAccent;
            panel8.BackColor = Theme.BackColorAccent2;
            Refresh();
        }

        private void hmdButton2_Click(object sender, EventArgs e)
        {
            var a = hmdTextbox1.Enabled;
            MessageBox.Show(hmdTextbox1.Text);
            //var a =(int) LoadData1(4.);
        }

        private void hmdCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Theme.Mode==HMDControls.ThemeDefine.ThemeMode.Light)
            {
                Theme.Mode = HMDControls.ThemeDefine.ThemeMode.Dark;
            }
            else
            {
                Theme.Mode = HMDControls.ThemeDefine.ThemeMode.Light;
            }
            Refresh();
        }
    }
}
