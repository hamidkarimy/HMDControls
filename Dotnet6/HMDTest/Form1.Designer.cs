namespace HMDTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hmdButton1 = new HMDControls.Controls.HMDButton();
            this.rbRed = new HMDControls.Controls.HMDRadioButton();
            this.rbGreen = new HMDControls.Controls.HMDRadioButton();
            this.hmdTextbox1 = new HMDControls.Controls.HMDTextbox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.hmdCheckBox1 = new HMDControls.Controls.HMDCheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hmdComboBox1 = new HMDControls.Controls.HMDComboBox();
            this.rbBlue = new HMDControls.Controls.HMDRadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.hmdProgressBar1 = new HMDControls.Controls.HMDProgressBar();
            this.SuspendLayout();
            // 
            // hmdButton1
            // 
            this.hmdButton1.FlatAppearance.BorderSize = 0;
            this.hmdButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hmdButton1.Icon = intelika.fontAwesome.NormalIconType.None;
            this.hmdButton1.Image = ((System.Drawing.Image)(resources.GetObject("hmdButton1.Image")));
            this.hmdButton1.Location = new System.Drawing.Point(580, 167);
            this.hmdButton1.Name = "hmdButton1";
            this.hmdButton1.Size = new System.Drawing.Size(75, 23);
            this.hmdButton1.TabIndex = 0;
            this.hmdButton1.Text = "hmdButton1";
            this.hmdButton1.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.hmdButton1.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            this.hmdButton1.UseVisualStyleBackColor = true;
            this.hmdButton1.Click += new System.EventHandler(this.hmdButton1_Click);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(530, 230);
            this.rbRed.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(54, 21);
            this.rbRed.TabIndex = 2;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "red";
            this.rbRed.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.rbRed.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(530, 257);
            this.rbGreen.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(67, 21);
            this.rbGreen.TabIndex = 2;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "green";
            this.rbGreen.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.rbGreen.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // hmdTextbox1
            // 
            this.hmdTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.hmdTextbox1.BorderSize = 0;
            this.hmdTextbox1.BoxDecoration = HMDControls.Enums.HMDBorderStyle.Flat;
            this.hmdTextbox1.ErrorMessage = null;
            this.hmdTextbox1.HasError = false;
            this.hmdTextbox1.Icon = intelika.fontAwesome.NormalIconType.None;
            this.hmdTextbox1.IsPassword = false;
            this.hmdTextbox1.Label = "";
            this.hmdTextbox1.Location = new System.Drawing.Point(149, 66);
            this.hmdTextbox1.Margin = new System.Windows.Forms.Padding(0);
            this.hmdTextbox1.Multiline = false;
            this.hmdTextbox1.Name = "hmdTextbox1";
            this.hmdTextbox1.Padding = new System.Windows.Forms.Padding(6);
            this.hmdTextbox1.ReadOnly = false;
            this.hmdTextbox1.Scrollbars = System.Windows.Forms.ScrollBars.None;
            this.hmdTextbox1.Size = new System.Drawing.Size(191, 37);
            this.hmdTextbox1.TabIndex = 4;
            this.hmdTextbox1.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.hmdTextbox1.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // hmdCheckBox1
            // 
            this.hmdCheckBox1.AutoSize = true;
            this.hmdCheckBox1.Location = new System.Drawing.Point(530, 196);
            this.hmdCheckBox1.MinimumSize = new System.Drawing.Size(0, 21);
            this.hmdCheckBox1.Name = "hmdCheckBox1";
            this.hmdCheckBox1.Size = new System.Drawing.Size(121, 21);
            this.hmdCheckBox1.TabIndex = 6;
            this.hmdCheckBox1.Text = "hmdCheckBox1";
            this.hmdCheckBox1.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.hmdCheckBox1.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            this.hmdCheckBox1.UseVisualStyleBackColor = true;
            this.hmdCheckBox1.CheckedChanged += new System.EventHandler(this.hmdCheckBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Red;
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5"});
            this.comboBox1.Location = new System.Drawing.Point(274, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // hmdComboBox1
            // 
            this.hmdComboBox1.ForeColor = System.Drawing.Color.White;
            this.hmdComboBox1.FormattingEnabled = true;
            this.hmdComboBox1.Location = new System.Drawing.Point(63, 160);
            this.hmdComboBox1.Name = "hmdComboBox1";
            this.hmdComboBox1.Size = new System.Drawing.Size(121, 23);
            this.hmdComboBox1.TabIndex = 8;
            this.hmdComboBox1.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.hmdComboBox1.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(530, 284);
            this.rbBlue.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(60, 21);
            this.rbBlue.TabIndex = 2;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "blue";
            this.rbBlue.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.rbBlue.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 5);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 10;
            // 
            // hmdProgressBar1
            // 
            this.hmdProgressBar1.ChanelHeight = 6;
            this.hmdProgressBar1.Location = new System.Drawing.Point(0, 40);
            this.hmdProgressBar1.Name = "hmdProgressBar1";
            this.hmdProgressBar1.ShowValue = HMDControls.Controls.ProgressBarTextPosition.Right;
            this.hmdProgressBar1.Size = new System.Drawing.Size(800, 10);
            this.hmdProgressBar1.SliderHeight = 6;
            this.hmdProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.hmdProgressBar1.TabIndex = 11;
            this.hmdProgressBar1.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.hmdProgressBar1.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hmdProgressBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.hmdComboBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.hmdCheckBox1);
            this.Controls.Add(this.hmdTextbox1);
            this.Controls.Add(this.rbBlue);
            this.Controls.Add(this.rbGreen);
            this.Controls.Add(this.rbRed);
            this.Controls.Add(this.hmdButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Green;
            this.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HMDControls.Controls.HMDButton hmdButton1;
        private HMDControls.Controls.HMDRadioButton rbRed;
        private HMDControls.Controls.HMDRadioButton rbGreen;
        private HMDControls.Controls.HMDTextbox hmdTextbox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private HMDControls.Controls.HMDCheckBox hmdCheckBox1;
        private ComboBox comboBox1;
        private HMDControls.Controls.HMDComboBox hmdComboBox1;
        private HMDControls.Controls.HMDRadioButton rbBlue;
        private ProgressBar progressBar1;
        private HMDControls.Controls.HMDProgressBar hmdProgressBar1;
    }
}