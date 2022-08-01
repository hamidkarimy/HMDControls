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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hmdButton1 = new HMDControls.Controls.HMDButton();
            this.rbRed = new HMDControls.Controls.HMDRadioButton();
            this.rbGreen = new HMDControls.Controls.HMDRadioButton();
            this.hmdTextbox1 = new HMDControls.Controls.HMDTextbox();
            this.hmdCheckBox1 = new HMDControls.Controls.HMDCheckBox();
            this.hmdComboBox1 = new HMDControls.Controls.HMDComboBox();
            this.rbBlue = new HMDControls.Controls.HMDRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.hmdMarquee2 = new HMDControls.Controls.HMDMarquee();
            this.hmdButton2 = new HMDControls.Controls.HMDButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hmdDataGridView1 = new HMDControls.Controls.HMDDataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hmdDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hmdButton1
            // 
            this.hmdButton1.FlatAppearance.BorderSize = 0;
            this.hmdButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hmdButton1.Icon = intelika.fontAwesome.NormalIconType.None;
            this.hmdButton1.Image = ((System.Drawing.Image)(resources.GetObject("hmdButton1.Image")));
            this.hmdButton1.Location = new System.Drawing.Point(713, 28);
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
            this.rbRed.Location = new System.Drawing.Point(667, 91);
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
            this.rbGreen.Location = new System.Drawing.Point(667, 118);
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
            this.hmdTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.hmdTextbox1.BorderSize = 0;
            this.hmdTextbox1.BoxDecoration = HMDControls.Enums.HMDBorderStyle.Flat;
            this.hmdTextbox1.ErrorMessage = null;
            this.hmdTextbox1.HasError = false;
            this.hmdTextbox1.Icon = intelika.fontAwesome.NormalIconType.None;
            this.hmdTextbox1.IsPassword = false;
            this.hmdTextbox1.Label = "";
            this.hmdTextbox1.Location = new System.Drawing.Point(9, 41);
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
            // hmdCheckBox1
            // 
            this.hmdCheckBox1.AutoSize = true;
            this.hmdCheckBox1.Location = new System.Drawing.Point(667, 57);
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
            // hmdComboBox1
            // 
            this.hmdComboBox1.ForeColor = System.Drawing.Color.Black;
            this.hmdComboBox1.FormattingEnabled = true;
            this.hmdComboBox1.Location = new System.Drawing.Point(203, 41);
            this.hmdComboBox1.Name = "hmdComboBox1";
            this.hmdComboBox1.Size = new System.Drawing.Size(121, 23);
            this.hmdComboBox1.TabIndex = 8;
            this.hmdComboBox1.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.hmdComboBox1.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(667, 145);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(21, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 31);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(21, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 31);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(21, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(77, 31);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(21, 241);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(77, 31);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(21, 278);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(77, 31);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(21, 315);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(77, 31);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(21, 352);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(77, 31);
            this.panel7.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(21, 389);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(77, 31);
            this.panel8.TabIndex = 10;
            // 
            // hmdMarquee2
            // 
            this.hmdMarquee2.Location = new System.Drawing.Point(259, 244);
            this.hmdMarquee2.Name = "hmdMarquee2";
            this.hmdMarquee2.Size = new System.Drawing.Size(427, 18);
            this.hmdMarquee2.Speed = HMDControls.Controls.MarqueeSpeed.Slow;
            this.hmdMarquee2.TabIndex = 11;
            this.hmdMarquee2.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.hmdMarquee2.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            // 
            // hmdButton2
            // 
            this.hmdButton2.FlatAppearance.BorderSize = 0;
            this.hmdButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hmdButton2.Icon = intelika.fontAwesome.NormalIconType.None;
            this.hmdButton2.Image = ((System.Drawing.Image)(resources.GetObject("hmdButton2.Image")));
            this.hmdButton2.Location = new System.Drawing.Point(481, 132);
            this.hmdButton2.Name = "hmdButton2";
            this.hmdButton2.Size = new System.Drawing.Size(75, 23);
            this.hmdButton2.TabIndex = 12;
            this.hmdButton2.Text = "hmdButton2";
            this.hmdButton2.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.hmdButton2.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            this.hmdButton2.UseVisualStyleBackColor = true;
            this.hmdButton2.Click += new System.EventHandler(this.hmdButton2_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // hmdDataGridView1
            // 
            this.hmdDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.hmdDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.hmdDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.hmdDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hmdDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.hmdDataGridView1.EnableHeadersVisualStyles = false;
            this.hmdDataGridView1.Location = new System.Drawing.Point(178, 204);
            this.hmdDataGridView1.Name = "hmdDataGridView1";
            this.hmdDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.hmdDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.hmdDataGridView1.RowHeadersWidth = 10;
            this.hmdDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.hmdDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.hmdDataGridView1.RowTemplate.Height = 25;
            this.hmdDataGridView1.Size = new System.Drawing.Size(466, 150);
            this.hmdDataGridView1.TabIndex = 13;
            this.hmdDataGridView1.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Default;
            this.hmdDataGridView1.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Default;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hmdDataGridView1);
            this.Controls.Add(this.hmdButton2);
            this.Controls.Add(this.hmdMarquee2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hmdComboBox1);
            this.Controls.Add(this.hmdCheckBox1);
            this.Controls.Add(this.hmdTextbox1);
            this.Controls.Add(this.rbBlue);
            this.Controls.Add(this.rbGreen);
            this.Controls.Add(this.rbRed);
            this.Controls.Add(this.hmdButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ThemeColor = HMDControls.ThemeDefine.ThemeColor.Green;
            this.ThemeMode = HMDControls.ThemeDefine.ThemeMode.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.hmdButton1, 0);
            this.Controls.SetChildIndex(this.rbRed, 0);
            this.Controls.SetChildIndex(this.rbGreen, 0);
            this.Controls.SetChildIndex(this.rbBlue, 0);
            this.Controls.SetChildIndex(this.hmdTextbox1, 0);
            this.Controls.SetChildIndex(this.hmdCheckBox1, 0);
            this.Controls.SetChildIndex(this.hmdComboBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.panel8, 0);
            this.Controls.SetChildIndex(this.hmdMarquee2, 0);
            this.Controls.SetChildIndex(this.hmdButton2, 0);
            this.Controls.SetChildIndex(this.hmdDataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.hmdDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HMDControls.Controls.HMDButton hmdButton1;
        private HMDControls.Controls.HMDRadioButton rbRed;
        private HMDControls.Controls.HMDRadioButton rbGreen;
        private HMDControls.Controls.HMDTextbox hmdTextbox1;
        private HMDControls.Controls.HMDCheckBox hmdCheckBox1;
        private HMDControls.Controls.HMDComboBox hmdComboBox1;
        private HMDControls.Controls.HMDRadioButton rbBlue;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private HMDControls.Controls.HMDMarquee hmdMarquee2;
        private HMDControls.Controls.HMDButton hmdButton2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private HMDControls.Controls.HMDDataGridView hmdDataGridView1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}