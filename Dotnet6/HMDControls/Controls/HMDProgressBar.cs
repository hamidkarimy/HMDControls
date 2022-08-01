using HMDControls.ThemeDefine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDControls.Controls
{
    public enum ProgressBarTextPosition
    {
        Left,
        Center,
        Right,
        None
    }
    public class HMDProgressBar:ProgressBar,IHMDControl
    {
        int chanelHeight = 6;
        int sliderHeight = 6;
        int marqueeState=0;
        private bool paintedBack=false;
        private bool stopPainting=false;
        private ProgressBarTextPosition showValue = ProgressBarTextPosition.Right;

        [Category("Appearance")]
        public ThemeColor ThemeColor { get; set; }
        [Category("Appearance")]
        public ThemeMode ThemeMode { get; set; }
        [Category("Appearance")]
        public int ChanelHeight 
        {
            get
            {
                return chanelHeight;
            }
            set 
            { 
                chanelHeight = value; 
                Invalidate(); 
            }
        }
        [Category("Appearance")]
        public int SliderHeight
        {
            get
            {
                return sliderHeight;
            }
            set
            {
                sliderHeight = value;
                Invalidate();
            }
        }
        [Category("Appearance")]
        public ProgressBarTextPosition ShowValue
        {
            get
            {
                return showValue;
            }
            set
            {
                showValue = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; }
        }
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }
        public HMDProgressBar()
        {
            //this.SetStyle(ControlStyles.UserPaint, true);
        }
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (stopPainting)
            {
                if (paintedBack)
                {
                    Graphics g = pevent.Graphics;
                    Rectangle rectChanel=new Rectangle(0,0,this.Width,chanelHeight);
                    using(var brushChanel=new SolidBrush(Theme.BackColorMain))
                    {
                        if (chanelHeight>=sliderHeight)
                        {
                            rectChanel.Y = this.Height - chanelHeight;
                        }
                        else
                        {
                            rectChanel.Y = this.Height - ((chanelHeight - sliderHeight) / 2);
                        }
                        g.Clear(BackColor);
                        g.FillRectangle(brushChanel, rectChanel);

                        if (!this.DesignMode)
                        {
                            paintedBack = true;
                        }
                    }
                }
                if (this.Value==this.Maximum || this.Value==this.Minimum)
                {
                    paintedBack = false;
                }
            }

        }



        protected override void OnPaint(PaintEventArgs e)
        {
            if (!stopPainting)
            {
                Graphics g = e.Graphics;
                if (this.Style==ProgressBarStyle.Blocks)
                {
                    double scaleFactor = (((double)this.Value - this.Minimum) / ((double)this.Maximum - this.Minimum));
                    int sliderWidth = (int)(this.Width * scaleFactor);
                    Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, sliderHeight);
                    using (var brushSlider = new SolidBrush(Theme.ForeColor))
                    {
                        if (sliderHeight >= chanelHeight)
                        {
                            rectSlider.Y = this.Height - sliderHeight;
                        }
                        else
                        {
                            rectSlider.Y = this.Height - ((sliderHeight - chanelHeight) / 2);
                        }
                        if (sliderWidth > 1)
                        {
                            g.FillRectangle(brushSlider, rectSlider);
                        }
                        if (showValue != ProgressBarTextPosition.None)
                        {
                            DrawValueText(g, sliderWidth, rectSlider);
                        }
                    }
                }
                if (this.Style == ProgressBarStyle.Marquee)
                {
                    ++marqueeState;
                    int scaleWidth = marqueeState >= 20 ? 20 : marqueeState;
                    double scaleFactor = (((double)scaleWidth - this.Minimum) / ((double)this.Maximum - this.Minimum));
                    int sliderWidth = (int)(this.Width * scaleFactor);
                    int marqueeX= marqueeState<=20 ? 0 : marqueeState-20;
                    int marqueeY= marqueeState>=this.Maximum-20 ? this.Maximum : marqueeState;
                    if (marqueeState>=this.Maximum+20)
                    {
                        marqueeState = 0;
                    }
                    Rectangle rectSlider = new Rectangle(marqueeX, marqueeY, sliderWidth, sliderHeight);
                    using (var brushSlider = new SolidBrush(Theme.ForeColor))
                    {
                        if (sliderHeight >= chanelHeight)
                        {
                            rectSlider.Y = this.Height - sliderHeight;
                        }
                        else
                        {
                            rectSlider.Y = this.Height - ((sliderHeight - chanelHeight) / 2);
                        }
                        if (sliderWidth > 1)
                        {
                            g.FillRectangle(brushSlider, rectSlider);
                        }
                        if (showValue != ProgressBarTextPosition.None)
                        {
                            DrawValueText(g, sliderWidth, rectSlider);
                        }
                    }
                    OnPaint(e);
                }
               
            } 

                stopPainting = this.Value == this.Maximum;           
        }

        private void DrawValueText(Graphics g, int sliderWidth, Rectangle rectSlider)
        {
            string text=this.Value.ToString()+"%";

        }
    }
}
