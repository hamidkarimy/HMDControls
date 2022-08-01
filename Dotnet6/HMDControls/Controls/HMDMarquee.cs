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

namespace HMDControls.Controls
{
    public enum MarqueeSpeed
    {
        Slow,
        Normal,
        Fast,
    }
    public partial class HMDMarquee : UserControl,IHMDControl
    {
        public HMDMarquee()
        {
            InitializeComponent();            
        }
        int timer1Tick = 0;
        public MarqueeSpeed Speed { get; set; }
        public void StartProgress()
        {
            base.Show();
            timer1.Start();
        }
        public void EndProgress()
        {
            base.Hide();
            timer1.Stop();
        }
        public ThemeColor ThemeColor { get; set; }
        public ThemeMode ThemeMode { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int rectWidth = (int)(this.Width / 5);
            if (timer1Tick>=(this.Width+ rectWidth))
            {
                timer1Tick = 0;
            }
            int rectX = timer1Tick-rectWidth;
            
           var  slider = new Rectangle(rectX, 0,rectWidth,  this.Height);
            using (Brush sliderBrush = (new SolidBrush(Theme.ForeColor)))
            {
                g.FillRectangle(sliderBrush, slider);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (Speed)
            {
                case MarqueeSpeed.Slow:
                    timer1Tick = timer1Tick + 2;
                    break;
                case MarqueeSpeed.Normal:
                    timer1Tick = timer1Tick + 5;
                    break;
                case MarqueeSpeed.Fast:
            timer1Tick= timer1Tick+7;
                    break;
                default:
            timer1Tick= timer1Tick+5;
                    break;
            }
            timer1Tick= timer1Tick+5;
            Invalidate();
        }
    }
}
