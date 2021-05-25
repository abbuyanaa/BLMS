namespace BLMS
{
    partial class Login
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.userName = new MetroFramework.Controls.MetroTextBox();
            this.userCode = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(334, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Нэр :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(334, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Код :";
            // 
            // userName
            // 
            // 
            // 
            // 
            this.userName.CustomButton.Image = null;
            this.userName.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.userName.CustomButton.Name = "";
            this.userName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.userName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userName.CustomButton.TabIndex = 1;
            this.userName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userName.CustomButton.UseSelectable = true;
            this.userName.CustomButton.Visible = false;
            this.userName.Lines = new string[0];
            this.userName.Location = new System.Drawing.Point(422, 104);
            this.userName.MaxLength = 32767;
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userName.SelectedText = "";
            this.userName.SelectionLength = 0;
            this.userName.SelectionStart = 0;
            this.userName.ShortcutsEnabled = true;
            this.userName.Size = new System.Drawing.Size(232, 30);
            this.userName.TabIndex = 2;
            this.userName.UseSelectable = true;
            this.userName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userCode
            // 
            // 
            // 
            // 
            this.userCode.CustomButton.Image = null;
            this.userCode.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.userCode.CustomButton.Name = "";
            this.userCode.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.userCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userCode.CustomButton.TabIndex = 1;
            this.userCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userCode.CustomButton.UseSelectable = true;
            this.userCode.CustomButton.Visible = false;
            this.userCode.Lines = new string[0];
            this.userCode.Location = new System.Drawing.Point(422, 170);
            this.userCode.MaxLength = 32767;
            this.userCode.Name = "userCode";
            this.userCode.PasswordChar = '*';
            this.userCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userCode.SelectedText = "";
            this.userCode.SelectionLength = 0;
            this.userCode.SelectionStart = 0;
            this.userCode.ShortcutsEnabled = true;
            this.userCode.Size = new System.Drawing.Size(232, 30);
            this.userCode.TabIndex = 3;
            this.userCode.UseSelectable = true;
            this.userCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(396, 259);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Нэвтрэх";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::BLMS.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(38, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.userCode);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Login";
            this.Text = "Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox userName;
        private MetroFramework.Controls.MetroTextBox userCode;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}