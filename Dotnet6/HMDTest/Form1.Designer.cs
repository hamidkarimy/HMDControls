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
            this.hmdButton1 = new HMDControls.HMDButton();
            this.SuspendLayout();
            // 
            // hmdButton1
            // 
            this.hmdButton1.FlatAppearance.BorderSize = 0;
            this.hmdButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hmdButton1.Icon = intelika.fontAwesome.NormalIconType.None;
            this.hmdButton1.Image = ((System.Drawing.Image)(resources.GetObject("hmdButton1.Image")));
            this.hmdButton1.Location = new System.Drawing.Point(565, 146);
            this.hmdButton1.Name = "hmdButton1";
            this.hmdButton1.Size = new System.Drawing.Size(75, 23);
            this.hmdButton1.TabIndex = 3;
            this.hmdButton1.Text = "hmdButton1";
            this.hmdButton1.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.hmdButton1.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            this.hmdButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hmdButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Red;
            this.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Light;
            this.ResumeLayout(false);

        }

        #endregion
        private HMDControls.HMDButton hmdButton1;
    }
}