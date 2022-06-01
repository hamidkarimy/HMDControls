using HMDControls;
using HMDControls.ThemeDefine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(ThemeMode));
            comboBox2.DataSource = Enum.GetValues(typeof(ThemeColor));         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeMode mode;
            Enum.TryParse<ThemeMode>(comboBox1.SelectedValue.ToString(), out mode);
            Theme.Mode = mode;
            panel1.BackColor = Theme.ForeColor;
            hmdButton1.Image = Properties.Resources.account_hard_hat_outline
            Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeColor color;
            Enum.TryParse<ThemeColor>(comboBox2.SelectedValue.ToString(), out color);
            Theme.Color = color;
            panel1.BackColor = Theme.ForeColor;
            Refresh();
        }
    }
}
