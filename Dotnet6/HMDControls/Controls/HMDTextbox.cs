using HMDControls.Enums;
using HMDControls.ThemeDefine;
using intelika.fontAwesome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMDControls.Controls
{

    public partial class HMDTextbox : UserControl, IHMDControl
    {
        public HMDTextbox()
        {
            InitializeComponent();
        }


        #region test
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

        
        #endregion





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
                        pictureBox1.Image = Icons.RegularIcon.GetImage(icon, color: Theme.ForeColorDisable, size: 16);
                    }
                    Refresh();
                },this);
            }
        }
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
                if (Enabled)
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
        public string Label
        {
            get
            {
                label = textBox1.PlaceholderText;
                return label;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() =>
                {
                    StaticHelper.InvokeIfRequired(() => textBox1.PlaceholderText = value, textBox1);
                    label = value;
                }, this);
            }
        }
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
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() =>
                {
                    StaticHelper.InvokeIfRequired(() => textBox1.Text = value, textBox1);
                    text = value;
                }, this);
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
                            graph.DrawLine(penBorder, 0, this.Height - 20, this.Width, this.Height -20);
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
                int textBoxHeight = 25;
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 16);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(26, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 16);
            this.textBox1.TabIndex = 5;
            // 
            // HMDTextbox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HMDTextbox";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(167, 28);
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

    }
}
