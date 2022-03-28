using HMDControls;
using HMDControls.ThemeDefine;

namespace HMDTest
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource= Enum.GetValues(typeof(ThemeMode));
            comboBox2.DataSource= Enum.GetValues(typeof(ThemeColor));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeMode mode;
            Enum.TryParse<ThemeMode>(comboBox1.SelectedValue.ToString(), out mode);
            Theme.Mode=mode;
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