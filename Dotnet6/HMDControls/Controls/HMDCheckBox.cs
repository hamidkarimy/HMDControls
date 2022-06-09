using HMDControls.ThemeDefine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDControls.Controls
{
    public class HMDCheckBox : CheckBox, IHMDControl
    {
        public ThemeColor ThemeColor { get; set; }
        public ThemeMode ThemeMode { get; set; }
        public HMDCheckBox()
        {
            this.MinimumSize = new Size(0, 21);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            var graphic = pevent.Graphics;
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int borderSize = 18;
            int checkSize = 12;
            Rectangle rectBorder = new Rectangle()
            {
                X = 1,
                Y = 1,
                Width = borderSize,
                Height = borderSize,
            };
            Rectangle rectChech = new Rectangle()
            {
                X = (int)(rectBorder.X + ((rectBorder.Width - checkSize) / 2)),
                Y = (int)((this.Height - checkSize) / 2),
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
                    graphic.DrawRectangle(penBorder,rectBorder);
                    graphic.FillRectangle(brushCheck, rectChech);

                }
                else
                {
                    //penBorder.Color = Theme.ForeColorDisable;
                    graphic.DrawRectangle(penBorder, rectBorder);
                }
                graphic.DrawString(this.Text, this.Font, brushText, borderSize + 8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = TextRenderer.MeasureText(this.Text, this.Font).Width + 30;
        }
    }
}
