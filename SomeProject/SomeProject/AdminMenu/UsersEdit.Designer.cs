namespace SomeProject
{
    partial class aUsersEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aUsersEdit));
            this.timerLabel = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.updateButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.userInfo3 = new MetroFramework.Controls.MetroComboBox();
            this.userInfo1 = new MetroFramework.Controls.MetroTextBox();
            this.userInfo2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.runnerLabel = new MetroFramework.Controls.MetroLabel();
            this.runnerDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.runnerCombo1 = new MetroFramework.Controls.MetroComboBox();
            this.runnerCombo2 = new MetroFramework.Controls.MetroComboBox();
            this.getCountryCodeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wSRDataSetCountry = new SomeProject.DataSets.WSRDataSetCountry();
            this.runnerLabel1 = new MetroFramework.Controls.MetroLabel();
            this.runnerLabel2 = new MetroFramework.Controls.MetroLabel();
            this.runnerLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.usersTableAdapter = new SomeProject.DataSets.WSRDataSetUsersTableAdapters.UsersTableAdapter();
            this.getCountryCodeTableAdapter = new SomeProject.DataSets.WSRDataSetCountryTableAdapters.getCountryCodeTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deleteButton1 = new MetroFramework.Controls.MetroButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.wsrDataSetUsers1 = new SomeProject.DataSets.WSRDataSetUsers();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getCountryCodeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSRDataSetCountry)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSetUsers1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.timerLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.timerLabel.Location = new System.Drawing.Point(20, 458);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(829, 30);
            this.timerLabel.TabIndex = 31;
            this.timerLabel.Text = "Loading...";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.Location = new System.Drawing.Point(234, 346);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(83, 23);
            this.metroButton2.TabIndex = 73;
            this.metroButton2.Text = "Отмена";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.BackToUsers_Click);
            // 
            // updateButton1
            // 
            this.updateButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.updateButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.updateButton1.Location = new System.Drawing.Point(129, 346);
            this.updateButton1.Name = "updateButton1";
            this.updateButton1.Size = new System.Drawing.Size(83, 23);
            this.updateButton1.TabIndex = 74;
            this.updateButton1.Text = "Сохранить";
            this.updateButton1.UseSelectable = true;
            this.updateButton1.Click += new System.EventHandler(this.UpdateUser_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(671, 163);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(54, 19);
            this.metroLabel9.TabIndex = 71;
            this.metroLabel9.Text = "Пароль";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(671, 191);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(103, 19);
            this.metroLabel10.TabIndex = 69;
            this.metroLabel10.Text = "Повтор пароля";
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(553, 161);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '•';
            this.metroTextBox4.PromptText = "Password";
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(114, 23);
            this.metroTextBox4.TabIndex = 70;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMark = "Password";
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(553, 190);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '•';
            this.metroTextBox5.PromptText = "Re-enter password";
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(114, 23);
            this.metroTextBox5.TabIndex = 72;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMark = "Re-enter password";
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(572, 117);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(109, 19);
            this.metroLabel8.TabIndex = 68;
            this.metroLabel8.Text = "Смена пароля";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(47, 2);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(174, 19);
            this.metroLabel7.TabIndex = 67;
            this.metroLabel7.Text = "Основная информация";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(45, 148);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 66;
            this.metroLabel6.Text = "Роль";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(48, 48);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 19);
            this.metroLabel5.TabIndex = 63;
            this.metroLabel5.Text = "Имя";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 61;
            this.metroLabel3.Text = "Фамилия";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(42, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 59;
            this.metroLabel2.Text = "Email";
            // 
            // userInfo3
            // 
            this.userInfo3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userInfo3.FormattingEnabled = true;
            this.userInfo3.ItemHeight = 23;
            this.userInfo3.Items.AddRange(new object[] {
            "A",
            "R",
            "C"});
            this.userInfo3.Location = new System.Drawing.Point(88, 144);
            this.userInfo3.Name = "userInfo3";
            this.userInfo3.PromptText = "Выбрать..";
            this.userInfo3.Size = new System.Drawing.Size(94, 29);
            this.userInfo3.TabIndex = 65;
            this.userInfo3.UseSelectable = true;
            this.userInfo3.TextChanged += new System.EventHandler(this.UserInfo3_TextChanged);
            // 
            // userInfo1
            // 
            // 
            // 
            // 
            this.userInfo1.CustomButton.Image = null;
            this.userInfo1.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.userInfo1.CustomButton.Name = "";
            this.userInfo1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userInfo1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userInfo1.CustomButton.TabIndex = 1;
            this.userInfo1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userInfo1.CustomButton.UseSelectable = true;
            this.userInfo1.CustomButton.Visible = false;
            this.userInfo1.Lines = new string[0];
            this.userInfo1.Location = new System.Drawing.Point(88, 46);
            this.userInfo1.MaxLength = 32767;
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.PasswordChar = '\0';
            this.userInfo1.PromptText = "Иван";
            this.userInfo1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userInfo1.SelectedText = "";
            this.userInfo1.SelectionLength = 0;
            this.userInfo1.SelectionStart = 0;
            this.userInfo1.ShortcutsEnabled = true;
            this.userInfo1.Size = new System.Drawing.Size(114, 23);
            this.userInfo1.TabIndex = 60;
            this.userInfo1.UseSelectable = true;
            this.userInfo1.WaterMark = "Иван";
            this.userInfo1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userInfo1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userInfo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserInfo1_KeyPress);
            // 
            // userInfo2
            // 
            // 
            // 
            // 
            this.userInfo2.CustomButton.Image = null;
            this.userInfo2.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.userInfo2.CustomButton.Name = "";
            this.userInfo2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userInfo2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userInfo2.CustomButton.TabIndex = 1;
            this.userInfo2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userInfo2.CustomButton.UseSelectable = true;
            this.userInfo2.CustomButton.Visible = false;
            this.userInfo2.Lines = new string[0];
            this.userInfo2.Location = new System.Drawing.Point(88, 75);
            this.userInfo2.MaxLength = 32767;
            this.userInfo2.Name = "userInfo2";
            this.userInfo2.PasswordChar = '\0';
            this.userInfo2.PromptText = "Иванов";
            this.userInfo2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userInfo2.SelectedText = "";
            this.userInfo2.SelectionLength = 0;
            this.userInfo2.SelectionStart = 0;
            this.userInfo2.ShortcutsEnabled = true;
            this.userInfo2.Size = new System.Drawing.Size(114, 23);
            this.userInfo2.TabIndex = 62;
            this.userInfo2.UseSelectable = true;
            this.userInfo2.WaterMark = "Иванов";
            this.userInfo2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userInfo2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userInfo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserInfo2_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(312, 51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(283, 25);
            this.metroLabel1.TabIndex = 58;
            this.metroLabel1.Text = "Редактирование пользователя";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::SomeProject.Properties.Resources.aExit;
            this.pictureBox2.Location = new System.Drawing.Point(811, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.LogoutPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SomeProject.Properties.Resources.icons_back;
            this.pictureBox1.Location = new System.Drawing.Point(38, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BackToUsers_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.metroLabel11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel11.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.metroLabel11.Location = new System.Drawing.Point(84, 104);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(156, 19);
            this.metroLabel11.TabIndex = 75;
            this.metroLabel11.Text = "blablablabla@gmail.com";
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel12.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.metroLabel12.Location = new System.Drawing.Point(637, 218);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(186, 46);
            this.metroLabel12.TabIndex = 76;
            this.metroLabel12.Text = "Оставьте поля пустыми, если\r\nне хотите изменять пароль.\r\n";
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.runnerLabel);
            this.metroPanel1.Controls.Add(this.runnerDateTime1);
            this.metroPanel1.Controls.Add(this.runnerCombo1);
            this.metroPanel1.Controls.Add(this.runnerCombo2);
            this.metroPanel1.Controls.Add(this.runnerLabel1);
            this.metroPanel1.Controls.Add(this.runnerLabel2);
            this.metroPanel1.Controls.Add(this.runnerLabel3);
            this.metroPanel1.Enabled = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(468, 271);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(332, 164);
            this.metroPanel1.TabIndex = 77;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // runnerLabel
            // 
            this.runnerLabel.AutoSize = true;
            this.runnerLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.runnerLabel.Location = new System.Drawing.Point(85, 7);
            this.runnerLabel.Name = "runnerLabel";
            this.runnerLabel.Size = new System.Drawing.Size(155, 19);
            this.runnerLabel.TabIndex = 62;
            this.runnerLabel.Text = "Информация бегуна";
            // 
            // runnerDateTime1
            // 
            this.runnerDateTime1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runnerDateTime1.CustomFormat = "";
            this.runnerDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.runnerDateTime1.Location = new System.Drawing.Point(65, 50);
            this.runnerDateTime1.MaxDate = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            this.runnerDateTime1.MinDate = new System.DateTime(1930, 3, 1, 0, 0, 0, 0);
            this.runnerDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.runnerDateTime1.Name = "runnerDateTime1";
            this.runnerDateTime1.Size = new System.Drawing.Size(134, 29);
            this.runnerDateTime1.TabIndex = 56;
            this.runnerDateTime1.Value = new System.DateTime(1969, 1, 1, 0, 0, 0, 0);
            // 
            // runnerCombo1
            // 
            this.runnerCombo1.Cursor = System.Windows.Forms.Cursors.Default;
            this.runnerCombo1.FormattingEnabled = true;
            this.runnerCombo1.ItemHeight = 23;
            this.runnerCombo1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.runnerCombo1.Location = new System.Drawing.Point(65, 85);
            this.runnerCombo1.Name = "runnerCombo1";
            this.runnerCombo1.PromptText = "Выбрать..";
            this.runnerCombo1.Size = new System.Drawing.Size(134, 29);
            this.runnerCombo1.TabIndex = 57;
            this.runnerCombo1.UseSelectable = true;
            // 
            // runnerCombo2
            // 
            this.runnerCombo2.Cursor = System.Windows.Forms.Cursors.Default;
            this.runnerCombo2.DataSource = this.getCountryCodeBindingSource1;
            this.runnerCombo2.DisplayMember = "CountryCode";
            this.runnerCombo2.FormattingEnabled = true;
            this.runnerCombo2.ItemHeight = 23;
            this.runnerCombo2.Location = new System.Drawing.Point(65, 120);
            this.runnerCombo2.Name = "runnerCombo2";
            this.runnerCombo2.PromptText = "Выбрать..";
            this.runnerCombo2.Size = new System.Drawing.Size(134, 29);
            this.runnerCombo2.TabIndex = 58;
            this.runnerCombo2.UseSelectable = true;
            // 
            // getCountryCodeBindingSource1
            // 
            this.getCountryCodeBindingSource1.DataMember = "getCountryCode";
            this.getCountryCodeBindingSource1.DataSource = this.wSRDataSetCountry;
            // 
            // wSRDataSetCountry
            // 
            this.wSRDataSetCountry.DataSetName = "WSRDataSetCountry";
            this.wSRDataSetCountry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // runnerLabel1
            // 
            this.runnerLabel1.AutoSize = true;
            this.runnerLabel1.Location = new System.Drawing.Point(204, 51);
            this.runnerLabel1.Name = "runnerLabel1";
            this.runnerLabel1.Size = new System.Drawing.Size(103, 19);
            this.runnerLabel1.TabIndex = 59;
            this.runnerLabel1.Text = "Дата рождения";
            // 
            // runnerLabel2
            // 
            this.runnerLabel2.AutoSize = true;
            this.runnerLabel2.Location = new System.Drawing.Point(204, 89);
            this.runnerLabel2.Name = "runnerLabel2";
            this.runnerLabel2.Size = new System.Drawing.Size(33, 19);
            this.runnerLabel2.TabIndex = 60;
            this.runnerLabel2.Text = "Пол";
            // 
            // runnerLabel3
            // 
            this.runnerLabel3.AutoSize = true;
            this.runnerLabel3.Location = new System.Drawing.Point(204, 123);
            this.runnerLabel3.Name = "runnerLabel3";
            this.runnerLabel3.Size = new System.Drawing.Size(53, 19);
            this.runnerLabel3.TabIndex = 61;
            this.runnerLabel3.Text = "Страна";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel11);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.userInfo2);
            this.metroPanel2.Controls.Add(this.userInfo1);
            this.metroPanel2.Controls.Add(this.userInfo3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(83, 115);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(282, 188);
            this.metroPanel2.TabIndex = 78;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // getCountryCodeTableAdapter
            // 
            this.getCountryCodeTableAdapter.ClearBeforeFill = true;
            // 
            // deleteButton1
            // 
            this.deleteButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.deleteButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.deleteButton1.Location = new System.Drawing.Point(138, 375);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(172, 45);
            this.deleteButton1.TabIndex = 79;
            this.deleteButton1.Text = "Удалить пользователя";
            this.deleteButton1.UseSelectable = true;
            this.deleteButton1.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // wsrDataSetUsers1
            // 
            this.wsrDataSetUsers1.DataSetName = "WSRDataSetUsers";
            this.wsrDataSetUsers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aUsersEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 508);
            this.Controls.Add(this.deleteButton1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.updateButton1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.metroTextBox5);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroLabel12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "aUsersEdit";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administration Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoodbyeUser);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getCountryCodeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wSRDataSetCountry)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSetUsers1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
#pragma warning restore 612, 618
        private MetroFramework.Controls.MetroLabel timerLabel;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton updateButton1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox userInfo3;
        private MetroFramework.Controls.MetroTextBox userInfo1;
        private MetroFramework.Controls.MetroTextBox userInfo2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        protected MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel runnerLabel;
        private MetroFramework.Controls.MetroDateTime runnerDateTime1;
        private MetroFramework.Controls.MetroComboBox runnerCombo1;
        private MetroFramework.Controls.MetroComboBox runnerCombo2;
        private MetroFramework.Controls.MetroLabel runnerLabel1;
        private MetroFramework.Controls.MetroLabel runnerLabel2;
        private MetroFramework.Controls.MetroLabel runnerLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private DataSets.WSRDataSetUsersTableAdapters.UsersTableAdapter usersTableAdapter;
        private DataSets.WSRDataSetCountry wSRDataSetCountry;
        private DataSets.WSRDataSetCountryTableAdapters.getCountryCodeTableAdapter getCountryCodeTableAdapter;
        private System.Windows.Forms.BindingSource getCountryCodeBindingSource1;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private MetroFramework.Controls.MetroButton deleteButton1;
        private System.Windows.Forms.ErrorProvider error;
        private DataSets.WSRDataSetUsers wsrDataSetUsers1;
    }
}