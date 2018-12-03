namespace SomeProject
{
    partial class BMIcalc
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
#pragma warning disable 612, 618
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMIcalc));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.timerLabel = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.hCombo = new MetroFramework.Controls.MetroTextBox();
            this.wCombo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.imtLabel = new MetroFramework.Controls.MetroLabel();
            this.healthStatePic = new System.Windows.Forms.PictureBox();
            this.womanBox = new System.Windows.Forms.PictureBox();
            this.manBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imtTextLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.healthStatePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.womanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(365, 51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 25);
            this.metroLabel1.TabIndex = 58;
            this.metroLabel1.Text = "Ваш ИМТ:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel2.Location = new System.Drawing.Point(5, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(444, 76);
            this.metroLabel2.TabIndex = 59;
            this.metroLabel2.Text = resources.GetString("metroLabel2.Text");
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // timerLabel
            // 
            this.timerLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.timerLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.timerLabel.Location = new System.Drawing.Point(20, 458);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(829, 30);
            this.timerLabel.TabIndex = 60;
            this.timerLabel.Text = "Loading...";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(111, 312);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 63;
            this.metroLabel3.Text = "Мужчина";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(276, 312);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 19);
            this.metroLabel5.TabIndex = 64;
            this.metroLabel5.Text = "Женщина";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(100, 352);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 25);
            this.metroLabel6.TabIndex = 65;
            this.metroLabel6.Text = "Рост:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(109, 380);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 25);
            this.metroLabel7.TabIndex = 66;
            this.metroLabel7.Text = "Вес:";
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
            this.hCombo.Enabled = false;
            this.hCombo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.hCombo.Lines = new string[0];
            this.hCombo.Location = new System.Drawing.Point(154, 354);
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
            this.hCombo.TabIndex = 67;
            this.hCombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hCombo.UseSelectable = true;
            this.hCombo.WaterMark = "175";
            this.hCombo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hCombo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MetroTextBox1_KeyPress);
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
            this.wCombo.Enabled = false;
            this.wCombo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.wCombo.Lines = new string[0];
            this.wCombo.Location = new System.Drawing.Point(154, 381);
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
            this.wCombo.TabIndex = 68;
            this.wCombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.wCombo.UseSelectable = true;
            this.wCombo.WaterMark = "75";
            this.wCombo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.wCombo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MetroTextBox1_KeyPress);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(202, 358);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(24, 19);
            this.metroLabel8.TabIndex = 69;
            this.metroLabel8.Text = "см";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(202, 384);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(20, 19);
            this.metroLabel9.TabIndex = 70;
            this.metroLabel9.Text = "кг";
            // 
            // metroButton1
            // 
            this.metroButton1.Enabled = false;
            this.metroButton1.Location = new System.Drawing.Point(100, 410);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(122, 42);
            this.metroButton1.TabIndex = 72;
            this.metroButton1.Text = "Рассчитать";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // imtLabel
            // 
            this.imtLabel.AutoSize = true;
            this.imtLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.imtLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.imtLabel.Location = new System.Drawing.Point(464, 51);
            this.imtLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.imtLabel.Name = "imtLabel";
            this.imtLabel.Size = new System.Drawing.Size(27, 25);
            this.imtLabel.TabIndex = 73;
            this.imtLabel.Text = "...";
            this.imtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imtLabel.UseCustomForeColor = true;
            this.imtLabel.UseMnemonic = false;
            this.imtLabel.Visible = false;
            // 
            // healthStatePic
            // 
            this.healthStatePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthStatePic.Image = global::SomeProject.Properties.Resources.bmiManDefault;
            this.healthStatePic.Location = new System.Drawing.Point(559, 98);
            this.healthStatePic.Name = "healthStatePic";
            this.healthStatePic.Size = new System.Drawing.Size(230, 265);
            this.healthStatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.healthStatePic.TabIndex = 71;
            this.healthStatePic.TabStop = false;
            // 
            // womanBox
            // 
            this.womanBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.womanBox.Image = global::SomeProject.Properties.Resources.BMIwoman;
            this.womanBox.Location = new System.Drawing.Point(259, 205);
            this.womanBox.Name = "womanBox";
            this.womanBox.Size = new System.Drawing.Size(105, 104);
            this.womanBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.womanBox.TabIndex = 62;
            this.womanBox.TabStop = false;
            this.womanBox.Click += new System.EventHandler(this.WomanBoxClicked);
            // 
            // manBox
            // 
            this.manBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manBox.Image = global::SomeProject.Properties.Resources.BMIman;
            this.manBox.Location = new System.Drawing.Point(86, 205);
            this.manBox.Name = "manBox";
            this.manBox.Size = new System.Drawing.Size(105, 104);
            this.manBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manBox.TabIndex = 61;
            this.manBox.TabStop = false;
            this.manBox.Click += new System.EventHandler(this.ManBoxClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SomeProject.Properties.Resources.icons_back;
            this.pictureBox1.Location = new System.Drawing.Point(38, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // imtTextLabel
            // 
            this.imtTextLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.imtTextLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.imtTextLabel.Location = new System.Drawing.Point(550, 386);
            this.imtTextLabel.MaximumSize = new System.Drawing.Size(250, 100);
            this.imtTextLabel.Name = "imtTextLabel";
            this.imtTextLabel.Size = new System.Drawing.Size(250, 25);
            this.imtTextLabel.TabIndex = 74;
            this.imtTextLabel.Text = "...";
            this.imtTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imtTextLabel.UseCustomForeColor = true;
            this.imtTextLabel.UseMnemonic = false;
            this.imtTextLabel.Visible = false;
            // 
            // BMIcalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 508);
            this.Controls.Add(this.imtTextLabel);
            this.Controls.Add(this.imtLabel);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.healthStatePic);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.wCombo);
            this.Controls.Add(this.hCombo);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.womanBox);
            this.Controls.Add(this.manBox);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BMIcalc";
            this.Resizable = false;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoodbyeUser);
            ((System.ComponentModel.ISupportInitialize)(this.healthStatePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.womanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
#pragma warning restore 612, 618
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel timerLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox manBox;
        private System.Windows.Forms.PictureBox womanBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox hCombo;
        private MetroFramework.Controls.MetroTextBox wCombo;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.PictureBox healthStatePic;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel imtLabel;
        private MetroFramework.Controls.MetroLabel imtTextLabel;
    }
}