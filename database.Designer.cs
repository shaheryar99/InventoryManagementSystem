namespace InventoryManagementsSystem
{
    partial class db_main
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
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.init_label = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.server_text = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.user_text = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.pass_text = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.db_text = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.connect_btn = new MetroSet_UI.Controls.MetroSetButton();
            this.fname_text = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\Shaheryar Syed\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml" +
    "";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Dark;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroDark";
            // 
            // init_label
            // 
            this.init_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.init_label.IsDerivedStyle = true;
            this.init_label.Location = new System.Drawing.Point(22, 80);
            this.init_label.Name = "init_label";
            this.init_label.Size = new System.Drawing.Size(296, 26);
            this.init_label.Style = MetroSet_UI.Enums.Style.Dark;
            this.init_label.StyleManager = this.styleManager1;
            this.init_label.TabIndex = 0;
            this.init_label.Text = "Creating new database:";
            this.init_label.ThemeAuthor = "Narwin";
            this.init_label.ThemeName = "MetroDark";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(41, 128);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel2.StyleManager = this.styleManager1;
            this.metroSetLabel2.TabIndex = 1;
            this.metroSetLabel2.Text = "Server:";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // server_text
            // 
            this.server_text.AutoCompleteCustomSource = null;
            this.server_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.server_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.server_text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.server_text.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.server_text.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.server_text.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.server_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.server_text.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.server_text.Image = null;
            this.server_text.IsDerivedStyle = true;
            this.server_text.Lines = null;
            this.server_text.Location = new System.Drawing.Point(121, 119);
            this.server_text.MaxLength = 32767;
            this.server_text.Multiline = false;
            this.server_text.Name = "server_text";
            this.server_text.ReadOnly = false;
            this.server_text.Size = new System.Drawing.Size(236, 28);
            this.server_text.Style = MetroSet_UI.Enums.Style.Dark;
            this.server_text.StyleManager = this.styleManager1;
            this.server_text.TabIndex = 2;
            this.server_text.Text = "Enter Server";
            this.server_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.server_text.ThemeAuthor = "Narwin";
            this.server_text.ThemeName = "MetroDark";
            this.server_text.UseSystemPasswordChar = false;
            this.server_text.WatermarkText = "";
            this.server_text.Enter += new System.EventHandler(this.server_text_Enter);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(271, 4);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 3;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // user_text
            // 
            this.user_text.AutoCompleteCustomSource = null;
            this.user_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.user_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.user_text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.user_text.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.user_text.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_text.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.user_text.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.user_text.Image = null;
            this.user_text.IsDerivedStyle = true;
            this.user_text.Lines = null;
            this.user_text.Location = new System.Drawing.Point(121, 167);
            this.user_text.MaxLength = 32767;
            this.user_text.Multiline = false;
            this.user_text.Name = "user_text";
            this.user_text.ReadOnly = false;
            this.user_text.Size = new System.Drawing.Size(236, 28);
            this.user_text.Style = MetroSet_UI.Enums.Style.Dark;
            this.user_text.StyleManager = this.styleManager1;
            this.user_text.TabIndex = 5;
            this.user_text.Text = "Enter Username";
            this.user_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user_text.ThemeAuthor = "Narwin";
            this.user_text.ThemeName = "MetroDark";
            this.user_text.UseSystemPasswordChar = false;
            this.user_text.WatermarkText = "";
            this.user_text.Enter += new System.EventHandler(this.user_text_Enter);
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(18, 176);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(100, 19);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel3.StyleManager = this.styleManager1;
            this.metroSetLabel3.TabIndex = 4;
            this.metroSetLabel3.Text = "Username:";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroDark";
            // 
            // pass_text
            // 
            this.pass_text.AutoCompleteCustomSource = null;
            this.pass_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pass_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pass_text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pass_text.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pass_text.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pass_text.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pass_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pass_text.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.pass_text.Image = null;
            this.pass_text.IsDerivedStyle = true;
            this.pass_text.Lines = null;
            this.pass_text.Location = new System.Drawing.Point(121, 211);
            this.pass_text.MaxLength = 32767;
            this.pass_text.Multiline = false;
            this.pass_text.Name = "pass_text";
            this.pass_text.ReadOnly = false;
            this.pass_text.Size = new System.Drawing.Size(236, 28);
            this.pass_text.Style = MetroSet_UI.Enums.Style.Dark;
            this.pass_text.StyleManager = this.styleManager1;
            this.pass_text.TabIndex = 7;
            this.pass_text.Text = "Enter Password";
            this.pass_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pass_text.ThemeAuthor = "Narwin";
            this.pass_text.ThemeName = "MetroDark";
            this.pass_text.UseSystemPasswordChar = false;
            this.pass_text.WatermarkText = "";
            this.pass_text.Enter += new System.EventHandler(this.pass_text_Enter);
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(22, 220);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel4.StyleManager = this.styleManager1;
            this.metroSetLabel4.TabIndex = 6;
            this.metroSetLabel4.Text = "Password:";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroDark";
            // 
            // db_text
            // 
            this.db_text.AutoCompleteCustomSource = null;
            this.db_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.db_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.db_text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.db_text.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.db_text.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.db_text.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.db_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.db_text.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.db_text.Image = null;
            this.db_text.IsDerivedStyle = true;
            this.db_text.Lines = null;
            this.db_text.Location = new System.Drawing.Point(121, 254);
            this.db_text.MaxLength = 32767;
            this.db_text.Multiline = false;
            this.db_text.Name = "db_text";
            this.db_text.ReadOnly = false;
            this.db_text.Size = new System.Drawing.Size(236, 28);
            this.db_text.Style = MetroSet_UI.Enums.Style.Dark;
            this.db_text.StyleManager = this.styleManager1;
            this.db_text.TabIndex = 9;
            this.db_text.Text = "Enter a DB Name";
            this.db_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.db_text.ThemeAuthor = "Narwin";
            this.db_text.ThemeName = "MetroDark";
            this.db_text.UseSystemPasswordChar = false;
            this.db_text.WatermarkText = "";
            this.db_text.Enter += new System.EventHandler(this.db_text_Enter);
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(22, 263);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(80, 19);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel5.StyleManager = this.styleManager1;
            this.metroSetLabel5.TabIndex = 8;
            this.metroSetLabel5.Text = "DB Name:";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroDark";
            // 
            // connect_btn
            // 
            this.connect_btn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.connect_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.connect_btn.DisabledForeColor = System.Drawing.Color.Gray;
            this.connect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.connect_btn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.connect_btn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.connect_btn.HoverTextColor = System.Drawing.Color.White;
            this.connect_btn.IsDerivedStyle = true;
            this.connect_btn.Location = new System.Drawing.Point(100, 350);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.connect_btn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.connect_btn.NormalTextColor = System.Drawing.Color.White;
            this.connect_btn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.connect_btn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.connect_btn.PressTextColor = System.Drawing.Color.White;
            this.connect_btn.Size = new System.Drawing.Size(180, 40);
            this.connect_btn.Style = MetroSet_UI.Enums.Style.Dark;
            this.connect_btn.StyleManager = this.styleManager1;
            this.connect_btn.TabIndex = 10;
            this.connect_btn.Text = "Connect";
            this.connect_btn.ThemeAuthor = "Narwin";
            this.connect_btn.ThemeName = "MetroDark";
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // fname_text
            // 
            this.fname_text.AutoCompleteCustomSource = null;
            this.fname_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.fname_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.fname_text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.fname_text.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fname_text.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fname_text.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fname_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fname_text.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.fname_text.Image = null;
            this.fname_text.IsDerivedStyle = true;
            this.fname_text.Lines = null;
            this.fname_text.Location = new System.Drawing.Point(121, 297);
            this.fname_text.MaxLength = 32767;
            this.fname_text.Multiline = false;
            this.fname_text.Name = "fname_text";
            this.fname_text.ReadOnly = false;
            this.fname_text.Size = new System.Drawing.Size(236, 28);
            this.fname_text.Style = MetroSet_UI.Enums.Style.Dark;
            this.fname_text.StyleManager = this.styleManager1;
            this.fname_text.TabIndex = 12;
            this.fname_text.Text = "Enter a Friendly Name";
            this.fname_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fname_text.ThemeAuthor = "Narwin";
            this.fname_text.ThemeName = "MetroDark";
            this.fname_text.UseSystemPasswordChar = false;
            this.fname_text.WatermarkText = "";
            this.fname_text.Enter += new System.EventHandler(this.metroSetTextBox1_Enter);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(6, 306);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = this.styleManager1;
            this.metroSetLabel1.TabIndex = 11;
            this.metroSetLabel1.Text = "Friendly Name:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // db_main
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(372, 408);
            this.Controls.Add(this.fname_text);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.db_text);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.server_text);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.init_label);
            this.Name = "db_main";
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager1;
            this.Text = "Database Management";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.database_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetTextBox server_text;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel init_label;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTextBox pass_text;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetTextBox user_text;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetTextBox db_text;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetButton connect_btn;
        private MetroSet_UI.Controls.MetroSetTextBox fname_text;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
    }
}