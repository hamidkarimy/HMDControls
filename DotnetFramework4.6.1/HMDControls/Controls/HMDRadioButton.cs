using HMDControls.ThemeDefine;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HMDControls.Controls
{
    public class HMDRadioButton : RadioButton, IHMDControl
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
                mode = value;
                Theme.Mode = value;
                Refresh();
            }

        }
        
        public bool Checked { 
            get
            {
                return base.Checked;
            }
            set
            {
                StaticHelper.InvokeIfRequired(()=>base.Checked=value,this);
            }
        }
        public bool Enabled
        {
            get
            {
                return base.Enabled;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() => base.Enabled = value, this);
            }
        }
        public bool Visible
        {
            get
            {
                return base.Visible;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() => base.Visible = value, this);
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
                color = value;
                Theme.Color = value;
                Refresh();
            }

        }

        public HMDRadioButton()
        {
            this.MinimumSize = new Size(0, 21);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            var graphic = pevent.Graphics;
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            float borderSize = 15F;
            float checkSize = 10F;
            RectangleF rectBorder = new RectangleF()
            {
                X = 0.5F,
                Y = (this.Height - borderSize) / 2,
                Width = borderSize,
                Height = borderSize,
            };
            RectangleF rectChech = new RectangleF()
            {
                X = rectBorder.X + ((rectBorder.Width - checkSize) / 2),
                Y = (this.Height - checkSize) / 2,
                Width = checkSize,
                Height = checkSize,
            };
            using (Pen penBorder = new Pen(Theme.ForeColor, 1.6F))
            using (SolidBrush brushCheck = new SolidBrush(Theme.ForeColor))
            using (SolidBrush brushText = new SolidBrush(Theme.TextColor))
            {
                graphic.Clear(this.BackColor);
                if (Checked)
                {
                    graphic.DrawEllipse(penBorder, rectBorder);
                    graphic.FillEllipse(brushCheck, rectChech);

                }
                else
                {
                    //penBorder.Color = Theme.ForeColorDisable;
                    graphic.DrawEllipse(penBorder, rectBorder);
                }
                graphic.DrawString(this.Text, this.Font, brushText,borderSize+8,(this.Height-TextRenderer.MeasureText(this.Text,this.Font).Height)/2);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = TextRenderer.MeasureText(this.Text, this.Font).Width + 30;
        }
    }
}
