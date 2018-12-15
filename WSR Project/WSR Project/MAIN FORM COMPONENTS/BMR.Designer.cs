namespace WSRProject
{
    partial class BMR
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.timerLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.womanBox = new System.Windows.Forms.PictureBox();
            this.manBox = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.wCombo = new MetroFramework.Controls.MetroTextBox();
            this.hCombo = new MetroFramework.Controls.MetroTextBox();
            this.yCombo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.womanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(274, 297);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 19);
            this.metroLabel5.TabIndex = 81;
            this.metroLabel5.Text = "Женщина";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(109, 297);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 80;
            this.metroLabel3.Text = "Мужчина";
            // 
            // timerLabel
            // 
            this.timerLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.timerLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.timerLabel.Location = new System.Drawing.Point(20, 458);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(829, 30);
            this.timerLabel.TabIndex = 77;
            this.timerLabel.Text = "Loading...";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel2.Location = new System.Drawing.Point(8, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(457, 57);
            this.metroLabel2.TabIndex = 76;
            this.metroLabel2.Text = "BMR (Basal Metabolic Rate) — минимальное количество энергии, \r\nрасходуемое челове" +
    "ческим организмом для поддержания собственной \r\nжизни в покое. ";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(363, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(171, 25);
            this.metroLabel1.TabIndex = 75;
            this.metroLabel1.Text = "Калькулятор BMR";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // womanBox
            // 
            this.womanBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.womanBox.Image = global::WSRProject.Properties.Resources.BMIwoman;
            this.womanBox.Location = new System.Drawing.Point(257, 190);
            this.womanBox.Name = "womanBox";
            this.womanBox.Size = new System.Drawing.Size(105, 104);
            this.womanBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.womanBox.TabIndex = 79;
            this.womanBox.TabStop = false;
            this.womanBox.Click += new System.EventHandler(this.womanBox_Click);
            // 
            // manBox
            // 
            this.manBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manBox.Image = global::WSRProject.Properties.Resources.BMIman;
            this.manBox.Location = new System.Drawing.Point(84, 190);
            this.manBox.Name = "manBox";
            this.manBox.Size = new System.Drawing.Size(105, 104);
            this.manBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manBox.TabIndex = 78;
            this.manBox.TabStop = false;
            this.manBox.Click += new System.EventHandler(this.manBox_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(206, 29);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(122, 79);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Рассчитать";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(152, 59);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(20, 19);
            this.metroLabel9.TabIndex = 90;
            this.metroLabel9.Text = "кг";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(152, 33);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(24, 19);
            this.metroLabel8.TabIndex = 89;
            this.metroLabel8.Text = "см";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(59, 55);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 25);
            this.metroLabel7.TabIndex = 86;
            this.metroLabel7.Text = "Вес:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(50, 27);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 25);
            this.metroLabel6.TabIndex = 85;
            this.metroLabel6.Text = "Рост:";
            // 
            // wCombo
            // 
            // 
            // 
            // 
            this.wCombo.CustomButton.Image = null;
            this.wCombo.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.wCombo.CustomButton.Name = "";
            this.wCombo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.wCombo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.wCombo.CustomButton.TabIndex = 1;
            this.wCombo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.wCombo.CustomButton.UseSelectable = true;
            this.wCombo.CustomButton.Visible = false;
            this.wCombo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.wCombo.Lines = new string[0];
            this.wCombo.Location = new System.Drawing.Point(104, 56);
            this.wCombo.MaxLength = 3;
            this.wCombo.Name = "wCombo";
            this.wCombo.PasswordChar = '\0';
            this.wCombo.PromptText = "75";
            this.wCombo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.wCombo.SelectedText = "";
            this.wCombo.SelectionLength = 0;
            this.wCombo.SelectionStart = 0;
            this.wCombo.ShortcutsEnabled = true;
            this.wCombo.Size = new System.Drawing.Size(47, 23);
            this.wCombo.TabIndex = 2;
            this.wCombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.wCombo.UseSelectable = true;
            this.wCombo.WaterMark = "75";
            this.wCombo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.wCombo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hCombo_KeyPress);
            // 
            // hCombo
            // 
            // 
            // 
            // 
            this.hCombo.CustomButton.Image = null;
            this.hCombo.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.hCombo.CustomButton.Name = "";
            this.hCombo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.hCombo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hCombo.CustomButton.TabIndex = 1;
            this.hCombo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hCombo.CustomButton.UseSelectable = true;
            this.hCombo.CustomButton.Visible = false;
            this.hCombo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.hCombo.Lines = new string[0];
            this.hCombo.Location = new System.Drawing.Point(104, 29);
            this.hCombo.MaxLength = 3;
            this.hCombo.Name = "hCombo";
            this.hCombo.PasswordChar = '\0';
            this.hCombo.PromptText = "175";
            this.hCombo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hCombo.SelectedText = "";
            this.hCombo.SelectionLength = 0;
            this.hCombo.SelectionStart = 0;
            this.hCombo.ShortcutsEnabled = true;
            this.hCombo.Size = new System.Drawing.Size(47, 23);
            this.hCombo.TabIndex = 1;
            this.hCombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hCombo.UseSelectable = true;
            this.hCombo.WaterMark = "175";
            this.hCombo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hCombo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hCombo_KeyPress);
            // 
            // yCombo
            // 
            // 
            // 
            // 
            this.yCombo.CustomButton.Image = null;
            this.yCombo.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.yCombo.CustomButton.Name = "";
            this.yCombo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.yCombo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.yCombo.CustomButton.TabIndex = 1;
            this.yCombo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.yCombo.CustomButton.UseSelectable = true;
            this.yCombo.CustomButton.Visible = false;
            this.yCombo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.yCombo.Lines = new string[0];
            this.yCombo.Location = new System.Drawing.Point(104, 83);
            this.yCombo.MaxLength = 3;
            this.yCombo.Name = "yCombo";
            this.yCombo.PasswordChar = '\0';
            this.yCombo.PromptText = "20";
            this.yCombo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.yCombo.SelectedText = "";
            this.yCombo.SelectionLength = 0;
            this.yCombo.SelectionStart = 0;
            this.yCombo.ShortcutsEnabled = true;
            this.yCombo.Size = new System.Drawing.Size(47, 23);
            this.yCombo.TabIndex = 3;
            this.yCombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.yCombo.UseSelectable = true;
            this.yCombo.WaterMark = "20";
            this.yCombo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.yCombo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hCombo_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(18, 79);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 25);
            this.metroLabel4.TabIndex = 86;
            this.metroLabel4.Text = "Возраст:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(152, 86);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(28, 19);
            this.metroLabel10.TabIndex = 90;
            this.metroLabel10.Text = "лет";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel15);
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Controls.Add(this.metroLabel13);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Location = new System.Drawing.Point(493, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 316);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel15
            // 
            this.metroLabel15.Location = new System.Drawing.Point(25, 140);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(322, 68);
            this.metroLabel15.TabIndex = 1;
            this.metroLabel15.Text = "Ваша скорость метаболизма: 12345";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(25, 111);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(130, 19);
            this.metroLabel14.TabIndex = 1;
            this.metroLabel14.Text = "Ваш возраст: 25 лет";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(25, 82);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(100, 19);
            this.metroLabel13.TabIndex = 1;
            this.metroLabel13.Text = "Ваш вес: 123 кг";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(25, 53);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(111, 19);
            this.metroLabel12.TabIndex = 1;
            this.metroLabel12.Text = "Ваш рост: 123 см";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(95, 16);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(155, 25);
            this.metroLabel11.TabIndex = 0;
            this.metroLabel11.Text = "Ваши результаты:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(493, 108);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(356, 316);
            this.metroPanel1.TabIndex = 93;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel16);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 316);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(45, 140);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(277, 50);
            this.metroLabel16.TabIndex = 2;
            this.metroLabel16.Text = "Для получения расчета введите \r\nваши данные в поля слева";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroButton1);
            this.groupBox3.Controls.Add(this.hCombo);
            this.groupBox3.Controls.Add(this.wCombo);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.metroLabel10);
            this.groupBox3.Controls.Add(this.yCombo);
            this.groupBox3.Controls.Add(this.metroLabel9);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(84, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 130);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WSRProject.Properties.Resources.icons_back;
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 508);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.womanBox);
            this.Controls.Add(this.manBox);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "BMR";
            this.Resizable = false;
            this.Text = "BMR";
            ((System.ComponentModel.ISupportInitialize)(this.womanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox womanBox;
        private System.Windows.Forms.PictureBox manBox;
        private MetroFramework.Controls.MetroLabel timerLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox wCombo;
        private MetroFramework.Controls.MetroTextBox hCombo;
        private MetroFramework.Controls.MetroTextBox yCombo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}