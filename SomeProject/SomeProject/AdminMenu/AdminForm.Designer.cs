namespace SomeProject
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.timerLabel = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logoutPic = new System.Windows.Forms.PictureBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.loginLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPic)).BeginInit();
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
            this.timerLabel.TabIndex = 3;
            this.timerLabel.Text = "Loading...";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // logoutPic
            // 
            this.logoutPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutPic.Image = global::SomeProject.Properties.Resources.exit_Admin;
            this.logoutPic.Location = new System.Drawing.Point(811, 57);
            this.logoutPic.Name = "logoutPic";
            this.logoutPic.Size = new System.Drawing.Size(35, 35);
            this.logoutPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutPic.TabIndex = 15;
            this.logoutPic.TabStop = false;
            this.logoutPic.Click += new System.EventHandler(this.LogoutPic_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.Location = new System.Drawing.Point(181, 199);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(500, 73);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.TabIndex = 13;
            this.metroTile2.Text = "Волонтёры";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileCount = 2;
            this.metroTile2.TileImage = global::SomeProject.Properties.Resources.tile_Volounters;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.MetroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile3.Location = new System.Drawing.Point(181, 278);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(500, 73);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile3.TabIndex = 12;
            this.metroTile3.Text = "Благотворительные организации";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileCount = 3;
            this.metroTile3.TileImage = global::SomeProject.Properties.Resources.tile_Blago;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.MetroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile4.Enabled = false;
            this.metroTile4.Location = new System.Drawing.Point(181, 357);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(500, 73);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile4.TabIndex = 11;
            this.metroTile4.Text = "Инвентарь";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileCount = 4;
            this.metroTile4.TileImage = global::SomeProject.Properties.Resources.tile_Inventory;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(181, 120);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(500, 73);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 10;
            this.metroTile1.Text = "Пользователи";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileCount = 1;
            this.metroTile1.TileImage = global::SomeProject.Properties.Resources.tile_users;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.MetroTile1_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.loginLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.loginLabel.Location = new System.Drawing.Point(181, 73);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(500, 25);
            this.loginLabel.TabIndex = 16;
            this.loginLabel.Text = "Добро пожаловать, ";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 508);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.logoutPic);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.timerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Resizable = false;
            this.Text = "Administration Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoodbyeUser);
            ((System.ComponentModel.ISupportInitialize)(this.logoutPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel timerLabel;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.PictureBox logoutPic;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel loginLabel;
    }
}