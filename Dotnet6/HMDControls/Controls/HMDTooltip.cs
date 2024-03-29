﻿using intelika.fontAwesome;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMDControls.Controls
{
    public class HMDTooltip:ToolTip
    {
        public HMDTooltip()
        {
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }
        private void OnPopup(object sender, PopupEventArgs e) // use this event to set the size of the tool tip
        {
            //var a = this.Active;
            //e.ToolTipSize = new Size(200,100);
        }
        private void OnDraw(object sender, DrawToolTipEventArgs e) // use this event to customise the tool tip
        {             
            Graphics g = e.Graphics;
           var textSize= TextRenderer.MeasureText(e.ToolTipText, new Font(e.Font, FontStyle.Bold));
            textSize.Width = textSize.Width + 50;
            textSize.Height = 50;
            Brush b = new SolidBrush(Theme.ErrorColor);
            g.FillRectangle(b,new Rectangle (e.Bounds.X, e.Bounds.Y,
                textSize.Width, textSize.Height));

            g.DrawRectangle(new Pen(Brushes.Red, 1), new Rectangle(e.Bounds.X, e.Bounds.Y,
                textSize.Width - 1, textSize.Height - 1));

            g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Bold), Brushes.White,
                new PointF(e.Bounds.X + 32, e.Bounds.Y + 15)); // shadow layer
            //g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Bold), Brushes.Black,
            //    new PointF(e.Bounds.X + 5, e.Bounds.Y + 5)); // top layer
            g.DrawImage(Icons.LightIcon.GetImage(NormalIconType.exclamation_square, Color.White, 24),
                new PointF(e.Bounds.X + 6, e.Bounds.Y + 13));

            b.Dispose();
        }
    }
}
