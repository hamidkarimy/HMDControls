using HMDControls.ThemeDefine;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HMDControls.Controls
{
    public class HMDDataGridView : DataGridView, IHMDControl
    {


        #region props
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
                StaticHelper.InvokeIfRequired(()=>
               {
                   mode = value;
                   Theme.Mode = value;
                   DataGridViewCellStyle style=new DataGridViewCellStyle();
                   style.BackColor= Theme.ForeColorAccent;
                   this.RowHeadersDefaultCellStyle = style;
                   this.ColumnHeadersDefaultCellStyle = style;
                   Refresh();
               },this);
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
                StaticHelper.InvokeIfRequired(() =>
                {
                    color = value;
                    Theme.Color = value;
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = Theme.ForeColorAccent;
                    this.RowHeadersDefaultCellStyle = style;
                    this.ColumnHeadersDefaultCellStyle = style;
                    Refresh();
                }, this);
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
        public object DataSource
        {
            get
            {
                return base.DataSource;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() => base.DataSource = value, this);
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
        #endregion
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor =Theme.ForeColor == null?System.Drawing.Color.White: Theme.ForeColor   ;
            style.ForeColor = Theme.TextColor == null ? System.Drawing.Color.Black : Theme.TextColor;
            this.RowHeadersDefaultCellStyle = style;
            this.ColumnHeadersDefaultCellStyle = style;
            this.BackgroundColor = Theme.BackColorMain;
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = Theme.BackColorAccent;
            rowStyle.ForeColor = Theme.TextColor;
            rowStyle.SelectionForeColor = Theme.TextColor;
            rowStyle.SelectionBackColor=Theme.BackColorAccent2 ;
            RowsDefaultCellStyle = rowStyle;
        }
        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);
        }
        protected override void InitLayout()
        {
            base.InitLayout();
            //this.BackgroundColor = Theme.BackColorMain;
           // this.ForeColor = Theme.TextColor;
            this.RowHeadersWidth = 10;
            this.RowTemplate.Height = 30;
            
            this.EnableHeadersVisualStyles = false;

        }
    }
}
