namespace SomeProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(20, 458);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(829, 30);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Loading...";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(732, 397);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(85, 41);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile4.TabIndex = 12;
            this.metroTile4.Text = "LOGIN";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(228, 126);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(450, 67);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 9;
            this.metroTile1.Text = "Я хочу стать бегуном";
            this.metroTile1.TileCount = 1;
            this.metroTile1.TileImage = global::SomeProject.Properties.Resources.icons8_упражнение_26;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(228, 272);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(450, 67);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile3.TabIndex = 11;
            this.metroTile3.Text = "Я хочу узнать больше о событии";
            this.metroTile3.TileCount = 3;
            this.metroTile3.TileImage = global::SomeProject.Properties.Resources.icons8_о_нас_26;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(228, 199);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(450, 67);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile2.TabIndex = 10;
            this.metroTile2.Text = "Я хочу стать спонсором бегуна";
            this.metroTile2.TileCount = 2;
            this.metroTile2.TileImage = global::SomeProject.Properties.Resources.icons8_краудфандинг_24;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(20, 356);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(119, 82);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile5.TabIndex = 13;
            this.metroTile5.Text = "Я Денис";
            this.metroTile5.TileCount = 69;
            this.metroTile5.TileImage = global::SomeProject.Properties.Resources.icons8_упражнение_26;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseStyleColors = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(20, 257);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(119, 82);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile6.TabIndex = 13;
            this.metroTile6.Text = "Maxik";
            this.metroTile6.TileCount = 96;
            this.metroTile6.TileImage = global::SomeProject.Properties.Resources.icons8_упражнение_26;
            this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseStyleColors = true;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(869, 508);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "MARATHON INFORMATION SYSTEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
    }
}

