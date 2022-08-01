using System.Windows.Forms;

namespace HMDControls
{
    partial class HMDBaseForm<T> where T : class
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
            this.hmdMarquee1 = new HMDControls.Controls.HMDMarquee();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hmdMarquee1
            // 
            this.hmdMarquee1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hmdMarquee1.Location = new System.Drawing.Point(0, 0);
            this.hmdMarquee1.Name = "hmdMarquee1";
            this.hmdMarquee1.Size = new System.Drawing.Size(686, 4);
            this.hmdMarquee1.Speed = HMDControls.Controls.MarqueeSpeed.Slow;
            this.hmdMarquee1.TabIndex = 0;
            this.hmdMarquee1.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.hmdMarquee1.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(423, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // HMDBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hmdMarquee1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "HMDBaseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "HMDBaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.HMDMarquee hmdMarquee1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}