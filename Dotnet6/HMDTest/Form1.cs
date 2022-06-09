using HMDControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMDTest
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hmdButton1_Click(object sender, EventArgs e)
        {
            ActiveWaitingProgress();
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ActiveWaitingProgress();
            backgroundWorker1.RunWorkerAsync();
        }

        private void ActiveWaitingProgress()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType()!=typeof(ProgressBar))
                {
                    control.Visible = false;
                }
            }
            hmdProgressBar1.Show();
            progressBar1.Show();
            hmdProgressBar1.Value = 0;
        }
        private void DeActiveWaitingProgress()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(ProgressBar))
                {
                    control.Visible = true;
                }
            }
            hmdProgressBar1.Hide();
            progressBar1.Hide();
        }

        private void setProgress()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                //backgroundWorker1.ReportProgress(i + 1);
            }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            setProgress();           
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
            Refresh();
        }

        private void hmdCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hmdCheckBox1.Checked)
            {
                ThemeMode = HMDControls.ThemeDefine.ThemeMode.Dark;
            }
            else
            {
                ThemeMode = HMDControls.ThemeDefine.ThemeMode.Light;
            }
            Refresh();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DeActiveWaitingProgress();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ++hmdProgressBar1.Value;
        }
    }
}
