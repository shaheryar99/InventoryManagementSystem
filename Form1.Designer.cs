
namespace InventoryManagementsSystem
{
    partial class mainForm
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.name_Text = new MetroSet_UI.Controls.MetroSetTextBox();
            this.name_Label = new MetroSet_UI.Controls.MetroSetLabel();
            this.identifier_Label = new MetroSet_UI.Controls.MetroSetLabel();
            this.identifier_Text = new MetroSet_UI.Controls.MetroSetTextBox();
            this.price_Label = new MetroSet_UI.Controls.MetroSetLabel();
            this.price_Text = new MetroSet_UI.Controls.MetroSetTextBox();
            this.quantity_Label = new MetroSet_UI.Controls.MetroSetLabel();
            this.quantity_Text = new MetroSet_UI.Controls.MetroSetTextBox();
            this.description_Label = new MetroSet_UI.Controls.MetroSetLabel();
            this.description_Text = new MetroSet_UI.Controls.MetroSetTextBox();
            this.additem_Button = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetTextBox1 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(604, 0);
            this.metroSetControlBox1.MaximizeBox = true;
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
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // name_Text
            // 
            this.name_Text.AutoCompleteCustomSource = null;
            this.name_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.name_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.name_Text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.name_Text.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.name_Text.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_Text.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.name_Text.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.name_Text.Image = null;
            this.name_Text.IsDerivedStyle = true;
            this.name_Text.Lines = null;
            this.name_Text.Location = new System.Drawing.Point(25, 108);
            this.name_Text.MaxLength = 32767;
            this.name_Text.Multiline = false;
            this.name_Text.Name = "name_Text";
            this.name_Text.ReadOnly = false;
            this.name_Text.Size = new System.Drawing.Size(152, 35);
            this.name_Text.Style = MetroSet_UI.Enums.Style.Dark;
            this.name_Text.StyleManager = this.styleManager1;
            this.name_Text.TabIndex = 1;
            this.name_Text.Text = "Enter a item name";
            this.name_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name_Text.ThemeAuthor = "Narwin";
            this.name_Text.ThemeName = "MetroDark";
            this.name_Text.UseSystemPasswordChar = false;
            this.name_Text.WatermarkText = "";
            // 
            // name_Label
            // 
            this.name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.name_Label.IsDerivedStyle = true;
            this.name_Label.Location = new System.Drawing.Point(25, 82);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(100, 23);
            this.name_Label.Style = MetroSet_UI.Enums.Style.Dark;
            this.name_Label.StyleManager = this.styleManager1;
            this.name_Label.TabIndex = 2;
            this.name_Label.Text = "Item Name:";
            this.name_Label.ThemeAuthor = "Narwin";
            this.name_Label.ThemeName = "MetroDark";
            // 
            // identifier_Label
            // 
            this.identifier_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.identifier_Label.IsDerivedStyle = true;
            this.identifier_Label.Location = new System.Drawing.Point(269, 82);
            this.identifier_Label.Name = "identifier_Label";
            this.identifier_Label.Size = new System.Drawing.Size(100, 23);
            this.identifier_Label.Style = MetroSet_UI.Enums.Style.Dark;
            this.identifier_Label.StyleManager = this.styleManager1;
            this.identifier_Label.TabIndex = 4;
            this.identifier_Label.Text = "Item Identifier:";
            this.identifier_Label.ThemeAuthor = "Narwin";
            this.identifier_Label.ThemeName = "MetroDark";
            // 
            // identifier_Text
            // 
            this.identifier_Text.AutoCompleteCustomSource = null;
            this.identifier_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.identifier_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.identifier_Text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.identifier_Text.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.identifier_Text.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.identifier_Text.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.identifier_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.identifier_Text.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.identifier_Text.Image = null;
            this.identifier_Text.IsDerivedStyle = true;
            this.identifier_Text.Lines = null;
            this.identifier_Text.Location = new System.Drawing.Point(269, 108);
            this.identifier_Text.MaxLength = 32767;
            this.identifier_Text.Multiline = false;
            this.identifier_Text.Name = "identifier_Text";
            this.identifier_Text.ReadOnly = false;
            this.identifier_Text.Size = new System.Drawing.Size(152, 35);
            this.identifier_Text.Style = MetroSet_UI.Enums.Style.Dark;
            this.identifier_Text.StyleManager = this.styleManager1;
            this.identifier_Text.TabIndex = 3;
            this.identifier_Text.Text = "Enter an identifier";
            this.identifier_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.identifier_Text.ThemeAuthor = "Narwin";
            this.identifier_Text.ThemeName = "MetroDark";
            this.identifier_Text.UseSystemPasswordChar = false;
            this.identifier_Text.WatermarkText = "";
            // 
            // price_Label
            // 
            this.price_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.price_Label.IsDerivedStyle = true;
            this.price_Label.Location = new System.Drawing.Point(269, 180);
            this.price_Label.Name = "price_Label";
            this.price_Label.Size = new System.Drawing.Size(100, 23);
            this.price_Label.Style = MetroSet_UI.Enums.Style.Dark;
            this.price_Label.StyleManager = this.styleManager1;
            this.price_Label.TabIndex = 8;
            this.price_Label.Text = "Item Price:";
            this.price_Label.ThemeAuthor = "Narwin";
            this.price_Label.ThemeName = "MetroDark";
            // 
            // price_Text
            // 
            this.price_Text.AutoCompleteCustomSource = null;
            this.price_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.price_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.price_Text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.price_Text.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.price_Text.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.price_Text.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.price_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.price_Text.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.price_Text.Image = null;
            this.price_Text.IsDerivedStyle = true;
            this.price_Text.Lines = null;
            this.price_Text.Location = new System.Drawing.Point(269, 206);
            this.price_Text.MaxLength = 32767;
            this.price_Text.Multiline = false;
            this.price_Text.Name = "price_Text";
            this.price_Text.ReadOnly = false;
            this.price_Text.Size = new System.Drawing.Size(152, 35);
            this.price_Text.Style = MetroSet_UI.Enums.Style.Dark;
            this.price_Text.StyleManager = this.styleManager1;
            this.price_Text.TabIndex = 7;
            this.price_Text.Text = "Enter per unit price";
            this.price_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.price_Text.ThemeAuthor = "Narwin";
            this.price_Text.ThemeName = "MetroDark";
            this.price_Text.UseSystemPasswordChar = false;
            this.price_Text.WatermarkText = "";
            // 
            // quantity_Label
            // 
            this.quantity_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quantity_Label.IsDerivedStyle = true;
            this.quantity_Label.Location = new System.Drawing.Point(25, 180);
            this.quantity_Label.Name = "quantity_Label";
            this.quantity_Label.Size = new System.Drawing.Size(100, 23);
            this.quantity_Label.Style = MetroSet_UI.Enums.Style.Dark;
            this.quantity_Label.StyleManager = this.styleManager1;
            this.quantity_Label.TabIndex = 6;
            this.quantity_Label.Text = "Item Quantity:";
            this.quantity_Label.ThemeAuthor = "Narwin";
            this.quantity_Label.ThemeName = "MetroDark";
            // 
            // quantity_Text
            // 
            this.quantity_Text.AutoCompleteCustomSource = null;
            this.quantity_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.quantity_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.quantity_Text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.quantity_Text.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.quantity_Text.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantity_Text.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantity_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quantity_Text.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.quantity_Text.Image = null;
            this.quantity_Text.IsDerivedStyle = true;
            this.quantity_Text.Lines = null;
            this.quantity_Text.Location = new System.Drawing.Point(25, 206);
            this.quantity_Text.MaxLength = 32767;
            this.quantity_Text.Multiline = false;
            this.quantity_Text.Name = "quantity_Text";
            this.quantity_Text.ReadOnly = false;
            this.quantity_Text.Size = new System.Drawing.Size(152, 35);
            this.quantity_Text.Style = MetroSet_UI.Enums.Style.Dark;
            this.quantity_Text.StyleManager = this.styleManager1;
            this.quantity_Text.TabIndex = 5;
            this.quantity_Text.Text = "Enter a quantity";
            this.quantity_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quantity_Text.ThemeAuthor = "Narwin";
            this.quantity_Text.ThemeName = "MetroDark";
            this.quantity_Text.UseSystemPasswordChar = false;
            this.quantity_Text.WatermarkText = "";
            // 
            // description_Label
            // 
            this.description_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.description_Label.IsDerivedStyle = true;
            this.description_Label.Location = new System.Drawing.Point(505, 82);
            this.description_Label.Name = "description_Label";
            this.description_Label.Size = new System.Drawing.Size(128, 23);
            this.description_Label.Style = MetroSet_UI.Enums.Style.Dark;
            this.description_Label.StyleManager = this.styleManager1;
            this.description_Label.TabIndex = 9;
            this.description_Label.Text = "Item Description:";
            this.description_Label.ThemeAuthor = "Narwin";
            this.description_Label.ThemeName = "MetroDark";
            // 
            // description_Text
            // 
            this.description_Text.AutoCompleteCustomSource = null;
            this.description_Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.description_Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.description_Text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.description_Text.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.description_Text.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.description_Text.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.description_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.description_Text.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.description_Text.Image = null;
            this.description_Text.IsDerivedStyle = true;
            this.description_Text.Lines = null;
            this.description_Text.Location = new System.Drawing.Point(505, 108);
            this.description_Text.MaxLength = 32767;
            this.description_Text.Multiline = false;
            this.description_Text.Name = "description_Text";
            this.description_Text.ReadOnly = false;
            this.description_Text.Size = new System.Drawing.Size(166, 95);
            this.description_Text.Style = MetroSet_UI.Enums.Style.Dark;
            this.description_Text.StyleManager = this.styleManager1;
            this.description_Text.TabIndex = 10;
            this.description_Text.Text = "Enter a description";
            this.description_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.description_Text.ThemeAuthor = "Narwin";
            this.description_Text.ThemeName = "MetroDark";
            this.description_Text.UseSystemPasswordChar = false;
            this.description_Text.WatermarkText = "";
            // 
            // additem_Button
            // 
            this.additem_Button.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.additem_Button.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.additem_Button.DisabledForeColor = System.Drawing.Color.Gray;
            this.additem_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.additem_Button.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.additem_Button.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.additem_Button.HoverTextColor = System.Drawing.Color.White;
            this.additem_Button.IsDerivedStyle = true;
            this.additem_Button.Location = new System.Drawing.Point(505, 218);
            this.additem_Button.Name = "additem_Button";
            this.additem_Button.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.additem_Button.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.additem_Button.NormalTextColor = System.Drawing.Color.White;
            this.additem_Button.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.additem_Button.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.additem_Button.PressTextColor = System.Drawing.Color.White;
            this.additem_Button.Size = new System.Drawing.Size(166, 23);
            this.additem_Button.Style = MetroSet_UI.Enums.Style.Dark;
            this.additem_Button.StyleManager = this.styleManager1;
            this.additem_Button.TabIndex = 11;
            this.additem_Button.Text = "Add Item";
            this.additem_Button.ThemeAuthor = "Narwin";
            this.additem_Button.ThemeName = "MetroDark";
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.IsDerivedStyle = true;
            this.metroSetButton1.Location = new System.Drawing.Point(326, 532);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(75, 23);
            this.metroSetButton1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetButton1.StyleManager = this.styleManager1;
            this.metroSetButton1.TabIndex = 13;
            this.metroSetButton1.Text = "metroSetButton1";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroDark";
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // metroSetTextBox1
            // 
            this.metroSetTextBox1.AutoCompleteCustomSource = null;
            this.metroSetTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetTextBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTextBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox1.Image = null;
            this.metroSetTextBox1.IsDerivedStyle = true;
            this.metroSetTextBox1.Lines = null;
            this.metroSetTextBox1.Location = new System.Drawing.Point(242, 326);
            this.metroSetTextBox1.MaxLength = 32767;
            this.metroSetTextBox1.Multiline = false;
            this.metroSetTextBox1.Name = "metroSetTextBox1";
            this.metroSetTextBox1.ReadOnly = false;
            this.metroSetTextBox1.Size = new System.Drawing.Size(319, 185);
            this.metroSetTextBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTextBox1.StyleManager = this.styleManager1;
            this.metroSetTextBox1.TabIndex = 14;
            this.metroSetTextBox1.Text = "metroSetTextBox1";
            this.metroSetTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox1.ThemeAuthor = "Narwin";
            this.metroSetTextBox1.ThemeName = "MetroDark";
            this.metroSetTextBox1.UseSystemPasswordChar = false;
            this.metroSetTextBox1.WatermarkText = "";
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(703, 624);
            this.Controls.Add(this.metroSetTextBox1);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.additem_Button);
            this.Controls.Add(this.description_Text);
            this.Controls.Add(this.description_Label);
            this.Controls.Add(this.price_Label);
            this.Controls.Add(this.price_Text);
            this.Controls.Add(this.quantity_Label);
            this.Controls.Add(this.quantity_Text);
            this.Controls.Add(this.identifier_Label);
            this.Controls.Add(this.identifier_Text);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.name_Text);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "mainForm";
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager1;
            this.Text = "Inventory Management ";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTextBox name_Text;
        private MetroSet_UI.Controls.MetroSetLabel name_Label;
        private MetroSet_UI.Controls.MetroSetLabel identifier_Label;
        private MetroSet_UI.Controls.MetroSetTextBox identifier_Text;
        private MetroSet_UI.Controls.MetroSetLabel price_Label;
        private MetroSet_UI.Controls.MetroSetTextBox price_Text;
        private MetroSet_UI.Controls.MetroSetLabel quantity_Label;
        private MetroSet_UI.Controls.MetroSetTextBox quantity_Text;
        private MetroSet_UI.Controls.MetroSetLabel description_Label;
        private MetroSet_UI.Controls.MetroSetTextBox description_Text;
        private MetroSet_UI.Controls.MetroSetButton additem_Button;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox1;
        private MetroSet_UI.Components.StyleManager styleManager1;
    }
}

