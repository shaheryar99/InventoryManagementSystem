
namespace InventoryManagementsSystem
{
    partial class RemoveDB
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
            this.removedb_btn = new MetroSet_UI.Controls.MetroSetButton();
            this.dblist_box = new MetroSet_UI.Controls.MetroSetComboBox();
            this.init_label = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
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
            // removedb_btn
            // 
            this.removedb_btn.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.removedb_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.removedb_btn.DisabledForeColor = System.Drawing.Color.Gray;
            this.removedb_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removedb_btn.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.removedb_btn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.removedb_btn.HoverTextColor = System.Drawing.Color.White;
            this.removedb_btn.IsDerivedStyle = true;
            this.removedb_btn.Location = new System.Drawing.Point(230, 122);
            this.removedb_btn.Name = "removedb_btn";
            this.removedb_btn.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.removedb_btn.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.removedb_btn.NormalTextColor = System.Drawing.Color.White;
            this.removedb_btn.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.removedb_btn.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.removedb_btn.PressTextColor = System.Drawing.Color.White;
            this.removedb_btn.Size = new System.Drawing.Size(180, 26);
            this.removedb_btn.Style = MetroSet_UI.Enums.Style.Dark;
            this.removedb_btn.StyleManager = this.styleManager1;
            this.removedb_btn.TabIndex = 8;
            this.removedb_btn.Text = "Remove Database";
            this.removedb_btn.ThemeAuthor = "Narwin";
            this.removedb_btn.ThemeName = "MetroDark";
            this.removedb_btn.Click += new System.EventHandler(this.removedb_btn_Click);
            // 
            // dblist_box
            // 
            this.dblist_box.AllowDrop = true;
            this.dblist_box.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.dblist_box.BackColor = System.Drawing.Color.Transparent;
            this.dblist_box.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dblist_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.dblist_box.CausesValidation = false;
            this.dblist_box.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dblist_box.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dblist_box.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dblist_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dblist_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dblist_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dblist_box.FormattingEnabled = true;
            this.dblist_box.IsDerivedStyle = true;
            this.dblist_box.ItemHeight = 20;
            this.dblist_box.Location = new System.Drawing.Point(25, 122);
            this.dblist_box.Name = "dblist_box";
            this.dblist_box.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.dblist_box.SelectedItemForeColor = System.Drawing.Color.White;
            this.dblist_box.Size = new System.Drawing.Size(180, 26);
            this.dblist_box.Style = MetroSet_UI.Enums.Style.Dark;
            this.dblist_box.StyleManager = this.styleManager1;
            this.dblist_box.TabIndex = 7;
            this.dblist_box.ThemeAuthor = "Narwin";
            this.dblist_box.ThemeName = "MetroDark";
            // 
            // init_label
            // 
            this.init_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.init_label.IsDerivedStyle = true;
            this.init_label.Location = new System.Drawing.Point(21, 82);
            this.init_label.Name = "init_label";
            this.init_label.Size = new System.Drawing.Size(357, 26);
            this.init_label.Style = MetroSet_UI.Enums.Style.Dark;
            this.init_label.StyleManager = this.styleManager1;
            this.init_label.TabIndex = 6;
            this.init_label.Text = "Select Database to Remove:";
            this.init_label.ThemeAuthor = "Narwin";
            this.init_label.ThemeName = "MetroDark";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(321, -2);
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
            this.metroSetControlBox1.TabIndex = 9;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // RemoveDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(422, 178);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.removedb_btn);
            this.Controls.Add(this.dblist_box);
            this.Controls.Add(this.init_label);
            this.Name = "RemoveDB";
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager1;
            this.Text = "Database Management";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.RemoveDB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetButton removedb_btn;
        private MetroSet_UI.Controls.MetroSetComboBox dblist_box;
        private MetroSet_UI.Controls.MetroSetLabel init_label;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}