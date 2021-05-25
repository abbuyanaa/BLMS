﻿namespace BLMS
{
    partial class UserEdit
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.userFemale = new MetroFramework.Controls.MetroRadioButton();
            this.userMale = new MetroFramework.Controls.MetroRadioButton();
            this.cbUserChuulgan = new MetroFramework.Controls.MetroComboBox();
            this.cbUserType = new MetroFramework.Controls.MetroComboBox();
            this.userAddress = new MetroFramework.Controls.MetroTextBox();
            this.userProfile = new System.Windows.Forms.PictureBox();
            this.userEmail = new MetroFramework.Controls.MetroTextBox();
            this.userPhone = new MetroFramework.Controls.MetroTextBox();
            this.userRegid = new MetroFramework.Controls.MetroTextBox();
            this.userFname = new MetroFramework.Controls.MetroTextBox();
            this.userLname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.Image = global::BLMS.Properties.Resources.icon_clear_241;
            this.btnClear.Location = new System.Drawing.Point(1146, 358);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 50);
            this.btnClear.TabIndex = 64;
            this.btnClear.Text = "Цэвэрлэх";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.Image = global::BLMS.Properties.Resources.icon_edit_24;
            this.btnEdit.Location = new System.Drawing.Point(427, 358);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 50);
            this.btnEdit.TabIndex = 63;
            this.btnEdit.Text = "Шинэчилэх";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowser.Image = global::BLMS.Properties.Resources.icon_file_explorer;
            this.btnBrowser.Location = new System.Drawing.Point(45, 358);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(200, 50);
            this.btnBrowser.TabIndex = 52;
            this.btnBrowser.Text = "Зураг солих";
            this.btnBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // userFemale
            // 
            this.userFemale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userFemale.AutoSize = true;
            this.userFemale.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.userFemale.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.userFemale.Location = new System.Drawing.Point(1255, 298);
            this.userFemale.Name = "userFemale";
            this.userFemale.Size = new System.Drawing.Size(82, 20);
            this.userFemale.TabIndex = 62;
            this.userFemale.Text = "Эмэгтэй";
            this.userFemale.UseSelectable = true;
            // 
            // userMale
            // 
            this.userMale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userMale.AutoSize = true;
            this.userMale.Checked = true;
            this.userMale.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.userMale.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.userMale.Location = new System.Drawing.Point(1135, 298);
            this.userMale.Name = "userMale";
            this.userMale.Size = new System.Drawing.Size(79, 20);
            this.userMale.TabIndex = 61;
            this.userMale.TabStop = true;
            this.userMale.Text = "Эрэгтэй";
            this.userMale.UseSelectable = true;
            // 
            // cbUserChuulgan
            // 
            this.cbUserChuulgan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbUserChuulgan.FormattingEnabled = true;
            this.cbUserChuulgan.ItemHeight = 24;
            this.cbUserChuulgan.Location = new System.Drawing.Point(1095, 244);
            this.cbUserChuulgan.Name = "cbUserChuulgan";
            this.cbUserChuulgan.Size = new System.Drawing.Size(300, 30);
            this.cbUserChuulgan.TabIndex = 60;
            this.cbUserChuulgan.UseSelectable = true;
            this.cbUserChuulgan.SelectedIndexChanged += new System.EventHandler(this.cbUserChuulgan_SelectedIndexChanged);
            // 
            // cbUserType
            // 
            this.cbUserType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.ItemHeight = 24;
            this.cbUserType.Location = new System.Drawing.Point(1095, 193);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(300, 30);
            this.cbUserType.TabIndex = 59;
            this.cbUserType.UseSelectable = true;
            this.cbUserType.SelectedIndexChanged += new System.EventHandler(this.cbUserType_SelectedIndexChanged);
            // 
            // userAddress
            // 
            this.userAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.userAddress.CustomButton.Image = null;
            this.userAddress.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.userAddress.CustomButton.Name = "";
            this.userAddress.CustomButton.Size = new System.Drawing.Size(87, 87);
            this.userAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userAddress.CustomButton.TabIndex = 1;
            this.userAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userAddress.CustomButton.UseSelectable = true;
            this.userAddress.CustomButton.Visible = false;
            this.userAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userAddress.Lines = new string[0];
            this.userAddress.Location = new System.Drawing.Point(530, 244);
            this.userAddress.MaxLength = 32767;
            this.userAddress.Multiline = true;
            this.userAddress.Name = "userAddress";
            this.userAddress.PasswordChar = '\0';
            this.userAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userAddress.SelectedText = "";
            this.userAddress.SelectionLength = 0;
            this.userAddress.SelectionStart = 0;
            this.userAddress.ShortcutsEnabled = true;
            this.userAddress.Size = new System.Drawing.Size(300, 89);
            this.userAddress.TabIndex = 56;
            this.userAddress.UseSelectable = true;
            this.userAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userProfile
            // 
            this.userProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userProfile.Location = new System.Drawing.Point(45, 93);
            this.userProfile.Name = "userProfile";
            this.userProfile.Size = new System.Drawing.Size(200, 240);
            this.userProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userProfile.TabIndex = 65;
            this.userProfile.TabStop = false;
            // 
            // userEmail
            // 
            this.userEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.userEmail.CustomButton.Image = null;
            this.userEmail.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.userEmail.CustomButton.Name = "";
            this.userEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.userEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userEmail.CustomButton.TabIndex = 1;
            this.userEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userEmail.CustomButton.UseSelectable = true;
            this.userEmail.CustomButton.Visible = false;
            this.userEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userEmail.Lines = new string[0];
            this.userEmail.Location = new System.Drawing.Point(530, 193);
            this.userEmail.MaxLength = 32767;
            this.userEmail.Name = "userEmail";
            this.userEmail.PasswordChar = '\0';
            this.userEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userEmail.SelectedText = "";
            this.userEmail.SelectionLength = 0;
            this.userEmail.SelectionStart = 0;
            this.userEmail.ShortcutsEnabled = true;
            this.userEmail.Size = new System.Drawing.Size(300, 30);
            this.userEmail.TabIndex = 55;
            this.userEmail.UseSelectable = true;
            this.userEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userPhone
            // 
            this.userPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.userPhone.CustomButton.Image = null;
            this.userPhone.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.userPhone.CustomButton.Name = "";
            this.userPhone.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.userPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userPhone.CustomButton.TabIndex = 1;
            this.userPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userPhone.CustomButton.UseSelectable = true;
            this.userPhone.CustomButton.Visible = false;
            this.userPhone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userPhone.Lines = new string[0];
            this.userPhone.Location = new System.Drawing.Point(1095, 143);
            this.userPhone.MaxLength = 32767;
            this.userPhone.Name = "userPhone";
            this.userPhone.PasswordChar = '\0';
            this.userPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userPhone.SelectedText = "";
            this.userPhone.SelectionLength = 0;
            this.userPhone.SelectionStart = 0;
            this.userPhone.ShortcutsEnabled = true;
            this.userPhone.Size = new System.Drawing.Size(300, 30);
            this.userPhone.TabIndex = 58;
            this.userPhone.UseSelectable = true;
            this.userPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userRegid
            // 
            this.userRegid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.userRegid.CustomButton.Image = null;
            this.userRegid.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.userRegid.CustomButton.Name = "";
            this.userRegid.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.userRegid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userRegid.CustomButton.TabIndex = 1;
            this.userRegid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userRegid.CustomButton.UseSelectable = true;
            this.userRegid.CustomButton.Visible = false;
            this.userRegid.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userRegid.Lines = new string[0];
            this.userRegid.Location = new System.Drawing.Point(530, 143);
            this.userRegid.MaxLength = 32767;
            this.userRegid.Name = "userRegid";
            this.userRegid.PasswordChar = '\0';
            this.userRegid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userRegid.SelectedText = "";
            this.userRegid.SelectionLength = 0;
            this.userRegid.SelectionStart = 0;
            this.userRegid.ShortcutsEnabled = true;
            this.userRegid.Size = new System.Drawing.Size(300, 30);
            this.userRegid.TabIndex = 54;
            this.userRegid.UseSelectable = true;
            this.userRegid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userRegid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userFname
            // 
            this.userFname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.userFname.CustomButton.Image = null;
            this.userFname.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.userFname.CustomButton.Name = "";
            this.userFname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.userFname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userFname.CustomButton.TabIndex = 1;
            this.userFname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userFname.CustomButton.UseSelectable = true;
            this.userFname.CustomButton.Visible = false;
            this.userFname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userFname.Lines = new string[0];
            this.userFname.Location = new System.Drawing.Point(1095, 93);
            this.userFname.MaxLength = 32767;
            this.userFname.Name = "userFname";
            this.userFname.PasswordChar = '\0';
            this.userFname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userFname.SelectedText = "";
            this.userFname.SelectionLength = 0;
            this.userFname.SelectionStart = 0;
            this.userFname.ShortcutsEnabled = true;
            this.userFname.Size = new System.Drawing.Size(300, 30);
            this.userFname.TabIndex = 57;
            this.userFname.UseSelectable = true;
            this.userFname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userFname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userLname
            // 
            this.userLname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.userLname.CustomButton.Image = null;
            this.userLname.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.userLname.CustomButton.Name = "";
            this.userLname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.userLname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userLname.CustomButton.TabIndex = 1;
            this.userLname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userLname.CustomButton.UseSelectable = true;
            this.userLname.CustomButton.Visible = false;
            this.userLname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userLname.Lines = new string[0];
            this.userLname.Location = new System.Drawing.Point(530, 93);
            this.userLname.MaxLength = 32767;
            this.userLname.Name = "userLname";
            this.userLname.PasswordChar = '\0';
            this.userLname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userLname.SelectedText = "";
            this.userLname.SelectionLength = 0;
            this.userLname.SelectionStart = 0;
            this.userLname.ShortcutsEnabled = true;
            this.userLname.Size = new System.Drawing.Size(300, 30);
            this.userLname.TabIndex = 53;
            this.userLname.UseSelectable = true;
            this.userLname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userLname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(860, 293);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 25);
            this.metroLabel6.TabIndex = 51;
            this.metroLabel6.Text = "Хүйс :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(860, 243);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(96, 25);
            this.metroLabel7.TabIndex = 50;
            this.metroLabel7.Text = "Чуулган :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(860, 193);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(80, 25);
            this.metroLabel8.TabIndex = 49;
            this.metroLabel8.Text = "Төрөл :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(860, 143);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(156, 25);
            this.metroLabel9.TabIndex = 48;
            this.metroLabel9.Text = "Утасны дугаар :";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(860, 93);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(184, 25);
            this.metroLabel10.TabIndex = 47;
            this.metroLabel10.Text = "Хэрэглэгчийн нэр :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(268, 243);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(133, 25);
            this.metroLabel4.TabIndex = 46;
            this.metroLabel4.Text = "Гэрийн хаяг :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(268, 193);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(131, 25);
            this.metroLabel3.TabIndex = 45;
            this.metroLabel3.Text = "Цахим хаяг :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(268, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(196, 25);
            this.metroLabel2.TabIndex = 44;
            this.metroLabel2.Text = "Регистрийн дугаар :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(268, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 25);
            this.metroLabel1.TabIndex = 43;
            this.metroLabel1.Text = "Эцэг, эхийн нэр :";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Image = global::BLMS.Properties.Resources.icon_trash_24;
            this.btnDelete.Location = new System.Drawing.Point(785, 358);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 50);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "Устгах";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 500);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.userFemale);
            this.Controls.Add(this.userMale);
            this.Controls.Add(this.cbUserChuulgan);
            this.Controls.Add(this.cbUserType);
            this.Controls.Add(this.userAddress);
            this.Controls.Add(this.userProfile);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.userPhone);
            this.Controls.Add(this.userRegid);
            this.Controls.Add(this.userFname);
            this.Controls.Add(this.userLname);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UserEdit";
            this.Text = "Хэрэглэгчийн мэдээлэл засах";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.UserEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBrowser;
        private MetroFramework.Controls.MetroRadioButton userFemale;
        private MetroFramework.Controls.MetroRadioButton userMale;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnDelete;
        public MetroFramework.Controls.MetroComboBox cbUserChuulgan;
        public MetroFramework.Controls.MetroComboBox cbUserType;
        public MetroFramework.Controls.MetroTextBox userAddress;
        public System.Windows.Forms.PictureBox userProfile;
        public MetroFramework.Controls.MetroTextBox userEmail;
        public MetroFramework.Controls.MetroTextBox userPhone;
        public MetroFramework.Controls.MetroTextBox userRegid;
        public MetroFramework.Controls.MetroTextBox userFname;
        public MetroFramework.Controls.MetroTextBox userLname;
    }
}