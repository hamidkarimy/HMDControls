using HMDControls.Enums;
using HMDControls.ThemeDefine;
using intelika.fontAwesome;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HMDControls.Controls
{
    public enum TextBoxType
    {
        String,
        Number
    }

    public partial class HMDTextbox : UserControl, IHMDControl
    {
        //public HMDTextbox(Type @class,string property)
        //{
        //   var t= @class.GetProperty(property);

        //   var att= t.CustomAttributes.Where(c => c.AttributeType == typeof(DisplayNameAttribute)).Cast<DisplayNameAttribute>().FirstOrDefault();
        //}
        public HMDTextbox()
        {
            InitializeComponent();
        }

        #region properties
        [Browsable(true)]
        [Category("Validation")]
        public bool IsRequired { get; set; }
        [Browsable(true)]
        [Category("Validation")]
        [DefaultValue(2147483648)]
        public int MaxLenght { get; set; }
        public bool Enabled {
            get
            {
                return base.Enabled;
            }
            set
            {
               StaticHelper.InvokeIfRequired(()=>base.Enabled=value,this);
            }
        }
        
        ThemeMode mode;
        ThemeColor color;
        NormalIconType icon;

        bool multiline;
        bool isPassword;
        string label;
        bool readOnly;
        ScrollBars scrollbars;
        string text;
        bool hasError;
        string errorMessage;
        HMDBorderStyle boxDecoration;
        int borderSize;
        string placeHolder = "";

        public TextBoxType ValueType { get; set; }
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks on textBox")]
        public event EventHandler TextChanged
        {
            add { textBox1.TextChanged += value; }
            remove { textBox1.TextChanged -= value; }
        }

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
                StaticHelper.InvokeIfRequired(() => { 
                    mode = value; 
                    Refresh();  
                },this);                
            }

        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            textBox1.Focus();            
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
                StaticHelper.InvokeIfRequired(() => {
                    color = value;
                    Refresh();
                },this);
            }

        }

        [Category("Appearance")]
        [Description("Choose Icon.")]
        public NormalIconType Icon
        {
            get
            {
                return icon;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() => {
                    icon = value;
                    if (icon == NormalIconType.None)
                    {
                        StaticHelper.InvokeIfRequired(() => pictureBox1.Visible = false, pictureBox1);   
                    }
                    else
                    {
                        StaticHelper.InvokeIfRequired(() => pictureBox1.Visible = true, pictureBox1);
                        pictureBox1.Image = Icons.LightIcon.GetImage(icon, color: Theme.ForeColor, size: 16);
                    }
                    Refresh();
                },this);
            }
        }
        //public override RightToLeft RightToLeft { 
        //    get =>this.Parent.RightToLeft; 
        //    set => base.RightToLeft = value; }
        public override Color BackColor
        {
            get
            {
                
                textBox1.BackColor = Theme.BackColorAccent;
                return Theme.BackColorAccent;
            }
        }
        public override Color ForeColor
        {
            get
            {
                if (Enabled && !IsPlaceHolder)
                {
                    textBox1.ForeColor = Theme.TextColor;
                    return Theme.TextColor;
                }
                textBox1.ForeColor = Theme.ForeColorDisable;
                return Theme.ForeColorDisable;
            }
        }
        public bool Multiline
        {
            get
            {
                multiline = textBox1.Multiline;
                return multiline;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() =>
                {
                    StaticHelper.InvokeIfRequired(() => textBox1.Multiline = value, textBox1);
                    multiline = value;
                }, this);
                
            }
        }
        public bool IsPassword
        {
            get
            {
                isPassword = textBox1.UseSystemPasswordChar;
                return isPassword;
            }
            set
            { 
                textBox1.UseSystemPasswordChar = value;
                isPassword = value;
            }
        }
        //public string Label
        //{
        //    get
        //    {
        //        label = textBox1.Text;
        //        return label;
        //    }
        //    set
        //    {
        //        StaticHelper.InvokeIfRequired(() =>
        //        {
        //            StaticHelper.InvokeIfRequired(() => textBox1.Text = value, textBox1);
        //            label = value;
        //        }, this);
        //    }
        //}
        public bool ReadOnly
        {
            get
            {
                readOnly = textBox1.ReadOnly;
                return readOnly;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() =>
                {
                    StaticHelper.InvokeIfRequired(() => textBox1.ReadOnly = value, textBox1);
                    readOnly = value;
                }, this);
            }
        }
        public ScrollBars Scrollbars
        {
            get
            {
                scrollbars = textBox1.ScrollBars;
                return scrollbars;
            }
            set
            {
                textBox1.ScrollBars = value;
                scrollbars = value;
            }
        }
        [Browsable(false)]
        public BorderStyle BorderStyle { get; set; }
        [Browsable(true)]
        [Category("Appearance")]
        public string PlaceHolder 
        
        {
            get
            {
                return placeHolder;
            }
            set 
            {
                placeHolder = value;
                textBox1.Text = "";
                setPlaceHolder();
            }
        }
        [Browsable(false)]
        public bool IsPlaceHolder { get; set; }
        public string Text
        {
            get
            {
                if (IsPlaceHolder)
                {
                    return "";
                }
                return textBox1.Text;
                setPlaceHolder();
            }
            set
            {
                StaticHelper.InvokeIfRequired(() =>
                {
                    StaticHelper.InvokeIfRequired(() =>
                    {
                        textBox1.Text = value;
                    }
                    , textBox1);
                    text = value;
                }, this);
            }
        }

        private void setPlaceHolder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeHolder!="")
            {
                IsPlaceHolder = true;   
                textBox1.Text = placeHolder;
                textBox1.ForeColor = Theme.ForeColorDisable;
                if (IsPassword)
                {
                    textBox1.UseSystemPasswordChar = false;
                }
            }
        }
        private void removePlaceHolder()
        {
            if (IsPlaceHolder && placeHolder != "")
            {
                IsPlaceHolder = false;
                textBox1.Text = "";
                textBox1.ForeColor = Theme.TextColor;
                if (IsPassword)
                {
                    textBox1.UseSystemPasswordChar = true;
                }

            }
        }

        [Browsable(false)]
        public bool HasError
        {
            get
            {
                return hasError;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() =>
                { hasError = value;
                if (hasError)
                {
                        StaticHelper.InvokeIfRequired(() => { 
                            pictureBox1.Image = Icons.RegularIcon.GetImage(NormalIconType.exclamation_square, color: Theme.ErrorColor, size: 16);
                            pictureBox1.Visible = true;
                        }, pictureBox1);
                    setSize();
                }
                else
                {
                    if (icon != NormalIconType.None)
                    {
                            StaticHelper.InvokeIfRequired(() => {
                                pictureBox1.Image = Icons.RegularIcon.GetImage(icon, color: Theme.ForeColorDisable, size: 16);
                                pictureBox1.Visible = true;
                            }, pictureBox1);
                    }
                    else
                    {
                            StaticHelper.InvokeIfRequired(() => pictureBox1.Visible = false,pictureBox1);
                    }
                }

                Refresh();
            },this);
            }
        }
        public string ErrorMessage { get => errorMessage; set => errorMessage = value; }
        public HMDBorderStyle BoxDecoration
        {
            get
            {
                return boxDecoration;
            }
            set
            {
                boxDecoration = value;
                Refresh();
            }
        }
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                Refresh();
            }
        }

        ThemeColor IHMDControl.ThemeColor { get; set; }
        ThemeMode IHMDControl.ThemeMode { get; set; }
        #endregion

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (IsRequired && string.IsNullOrEmpty(Text.Trim()))
            {
                SetError("این فیلد باید مقدار داشته باشد");
            }
            else
            {
                SetError("");
            }
            if (!string.IsNullOrEmpty(Text.Trim()) && Text.Trim().Length>MaxLenght)
            {
                SetError("تعداد کاراکتر بیشتر از حد مجاز است");
            }
            else
            {
                SetError("");
            }
            double result=0;
            if (ValueType==TextBoxType.Number && !double.TryParse(Text.Trim(),out result))
            {
                SetError("نوع ورودی باید عدد باشد");
            }
            else
            {
                SetError("");
            }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {           
            if ((e.KeyChar == '.') && (Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
           
        }
        public void SetError(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                HasError = true;
                ErrorMessage = message;
            }
            else
            {
                HasError = false;
                ErrorMessage = message;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            Color borderColor;
            if (hasError)
            {
                borderColor = Theme.ErrorColor;
            }
            else
            {
                borderColor = Theme.ForeColor;
            }
            using (Pen penBorder = new Pen(borderColor, BorderSize == 0 ? 2 : BorderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                switch (BoxDecoration)
                {
                    case HMDBorderStyle.None:
                        break;
                    case HMDBorderStyle.Flat:
                        {
                                graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height  - 0.5F);                           
                        }
                        break;
                    case HMDBorderStyle.UnderOnly:
                        {
                            graph.DrawLine(penBorder, 0, this.Height - 2, this.Width, this.Height -2);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode)
            {
                setSize();
            }
        }

        private void setSize()
        {
            if (!multiline)
            {
                textBox1.Multiline = true;
                int textBoxHeight = TextRenderer.MeasureText("Text",this.Font).Height;
                textBox1.MinimumSize = new Size(0, textBoxHeight);
                textBox1.Multiline = false;
                this.Height = textBoxHeight + 12;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            Refresh();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            setSize();
        }
        PictureBox pictureBox1;
        TextBox textBox1;
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(26, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 28);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // HMDTextbox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HMDTextbox";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(167, 40);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.BackColor = Theme.ErrorColor;
            tt.ForeColor = Color.White;
            tt.Show(errorMessage, pictureBox1);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            removePlaceHolder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            setPlaceHolder();  
        }
    }
}
