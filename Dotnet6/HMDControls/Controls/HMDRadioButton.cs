using HMDControls.ThemeDefine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDControls.Controls
{
    public class HMDRadioButton : RadioButton, IHMDControl
    {
        public ThemeColor ThemeColor { get; set; }
        public ThemeMode ThemeMode { get; set; }

        public HMDRadioButton()
        {
            this.MinimumSize = new Size(0, 21);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            var graphic = pevent.Graphics;
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            float borderSize = 18F;
            float checkSize = 12F;
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
