using HMDControls.Controls;
using HMDControls.ThemeDefine;
using intelika.fontAwesome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMDControls
{
    public enum MessageType
    {
        info,
        warning,
        error,
        ok
    }
    public partial class HMDBaseForm : Form,IHMDControl

    { 
        public HMDBaseForm()
        {
            InitializeComponent();           
        }     

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
        public void DialogResultClose(DialogResult dr)
        {
            StaticHelper.InvokeIfRequired(() => {
                this.DialogResult = dr;
                this.Close();
            }, this);
        }
        bool wait;
        List<Control> controlList;

        
        public override Color BackColor
        {
            get
            {
                var m = Theme.Mode;
                return Theme.BackColorMain;
            }
        }
        [Browsable(false)]
        public bool Wait
        {
            get
            {
                return wait;
            }

            set
            {
                wait = value;
                if (wait)
                {
                    formOnWait();
                }
                else
                {
                    formDisposeWait();
                   
                }
            }

        }

        private void formDisposeWait()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(HMDControls.Controls.HMDMarquee))
                {
                    var oldControl = controlList.FirstOrDefault(x => x.Name == control.Name);
                    if (oldControl != null)
                    {
                        var oldState = oldControl.Visible;
                        control.Visible = oldState;
                    }
                    else
                    {
                        control.Visible = true;
                    }
                }
                else
                {
                    if (control.Name == "hmdMarquee1")
                    {
                        hmdMarquee1.EndProgress();
                    }
                    //((HMDMarquee)control).EndProgress();
                }
            }
            //hmdMarquee1.EndProgress();
        }
        string waitingText;

        [Category("Appearance")]
        [Description("Choose Theme Color.")]
        NormalIconType waitingIcon;
        private MessageType MessageType { get; set; }
        public string WaitingText { 
             get
            {
                return waitingText;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() => {
                    waitingText = value;
                    if (Wait)
                    {
                        StaticHelper.InvokeIfRequired(() =>
                        { label1.Visible = true;
                            label1.Text = waitingText;
                        }
                        , label1);
                    }
                    else
                    {
                        StaticHelper.InvokeIfRequired(() => label1.Visible = false, label1); 
                    }
                    Refresh();
                }, this);
            }
        }
        public NormalIconType WaitingIcon
        {
            get
            {
                return waitingIcon;
            }
            set
            {
                StaticHelper.InvokeIfRequired(() => {
                    waitingIcon = value;
                    if (Wait)
                    {
                        if (waitingIcon == NormalIconType.None)
                        {
                            StaticHelper.InvokeIfRequired(() => pictureBox1.Visible = false, pictureBox1);
                        }
                        else
                        {
                            StaticHelper.InvokeIfRequired(() => pictureBox1.Visible = true, pictureBox1);
                            switch (MessageType)
                            {
                                case MessageType.info:
                                    pictureBox1.Image = Icons.ThinIcon.GetImage(waitingIcon, color: Theme.TextColor, size: 32);
                                    break;
                                case MessageType.warning:
                                    pictureBox1.Image = Icons.ThinIcon.GetImage(waitingIcon, color: Color.Orange, size: 32);
                                    break;
                                case MessageType.error:
                                    pictureBox1.Image = Icons.ThinIcon.GetImage(waitingIcon, color: Color.Red, size: 32);
                                    break;
                                case MessageType.ok:
                                    pictureBox1.Image = Icons.ThinIcon.GetImage(waitingIcon, color: Color.Green, size: 32);
                                    break;
                                default:
                                    break;
                            }
                            
                            
                        }
                    }
                    else
                    {
                        StaticHelper.InvokeIfRequired(() => pictureBox1.Visible = false, pictureBox1);
                    }
                    
                    Refresh();
                }, this);
            }
        }
        private void formOnWait()
        {
            if (controlList == null)
            {
                controlList = new List<Control>();
            }
            controlList.Clear();
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(HMDControls.Controls.HMDMarquee))
                {
                    controlList.Add(new Control { Name = control.Name, Visible = control.Visible });
                    control.Visible = false;
                }
                else
                {
                    if (control.Name == "hmdMarquee1")
                    {
                        hmdMarquee1.StartProgress();
                    }
                }
            }
            pictureBox1.Visible = true;
            if (WaitingIcon==NormalIconType.None)
            {
                pictureBox1.Image = Icons.ThinIcon.GetImage(NormalIconType.exclamation_circle, Theme.TextColor, 32);
            }
            else
            {
                pictureBox1.Image = Icons.ThinIcon.GetImage(WaitingIcon, Theme.TextColor, 32);
            }
            label1.Visible = true;
            if (string.IsNullOrEmpty(WaitingText))
            {
                label1.Text = "در حال بارگزاری اطلاعات ...";
            }
            else
            {
                label1.Text = WaitingText;
            }
            pictureBox1.Location = new Point(this.Width/4, (this.Height / 2)- (this.Height/5));
            label1.Location = new Point(pictureBox1.Location.X+40, pictureBox1.Location.Y + 16);
            Refresh();
            //hmdMarquee1.StartProgress();
        }
        protected void LoadData<T>(Action<T> func, T input) where T : class
        {
            Wait = true;
            doAction(func, input);
        }
        protected void LoadData(Action func) 
        {
            Wait = true;
            doAction(func);
        }
        //protected void LoadData1<T1,T2>(Func<T1,T2> func,Action<T2> completedOn=null) 
        //{
        //    Wait = true;
        //    doWork(func,completedOn);
        //}
        private async void doAction(Action func) 
        {
            await Task.Run(() => func.Invoke());
            Wait = false;
        }
        private async void doAction<T>(Action<T> func, T input) where T : class
        {
            await Task.Run(() => func.Invoke(input));
            Wait = false;
        }
        protected void ChangeWaitingStatus(MessageType messageType, NormalIconType waitIcon,string text)
        {
            if (Wait)
            {
                MessageType = messageType;
                WaitingIcon = waitIcon;
                WaitingText = text;
            }
        }
    }
}
