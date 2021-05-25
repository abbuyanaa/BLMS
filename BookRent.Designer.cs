namespace BLMS
{
    partial class BookRent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.lbUserDay = new MetroFramework.Controls.MetroLabel();
            this.lbUserType = new MetroFramework.Controls.MetroLabel();
            this.btnRent = new System.Windows.Forms.Button();
            this.bookCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.userProfile = new System.Windows.Forms.PictureBox();
            this.lbUserPhone = new MetroFramework.Controls.MetroLabel();
            this.lbUsername = new MetroFramework.Controls.MetroLabel();
            this.btnCheckUser = new System.Windows.Forms.Button();
            this.userCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroGridBook = new MetroFramework.Controls.MetroGrid();
            this.metroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridBook)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel
            // 
            this.metroPanel.Controls.Add(this.lbUserDay);
            this.metroPanel.Controls.Add(this.lbUserType);
            this.metroPanel.Controls.Add(this.btnRent);
            this.metroPanel.Controls.Add(this.bookCode);
            this.metroPanel.Controls.Add(this.metroLabel2);
            this.metroPanel.Controls.Add(this.userProfile);
            this.metroPanel.Controls.Add(this.lbUserPhone);
            this.metroPanel.Controls.Add(this.lbUsername);
            this.metroPanel.Controls.Add(this.btnCheckUser);
            this.metroPanel.Controls.Add(this.userCode);
            this.metroPanel.Controls.Add(this.metroLabel1);
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(30, 80);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(1400, 160);
            this.metroPanel.TabIndex = 0;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // lbUserDay
            // 
            this.lbUserDay.AutoSize = true;
            this.lbUserDay.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbUserDay.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbUserDay.Location = new System.Drawing.Point(920, 100);
            this.lbUserDay.Name = "lbUserDay";
            this.lbUserDay.Size = new System.Drawing.Size(78, 25);
            this.lbUserDay.TabIndex = 5;
            this.lbUserDay.Text = "Хоног :";
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbUserType.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbUserType.Location = new System.Drawing.Point(500, 100);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(80, 25);
            this.lbUserType.TabIndex = 4;
            this.lbUserType.Text = "Төрөл :";
            // 
            // btnRent
            // 
            this.btnRent.Enabled = false;
            this.btnRent.Location = new System.Drawing.Point(350, 100);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(90, 30);
            this.btnRent.TabIndex = 9;
            this.btnRent.Text = "Ном олгох";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // bookCode
            // 
            // 
            // 
            // 
            this.bookCode.CustomButton.Image = null;
            this.bookCode.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.bookCode.CustomButton.Name = "";
            this.bookCode.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.bookCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookCode.CustomButton.TabIndex = 1;
            this.bookCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bookCode.CustomButton.UseSelectable = true;
            this.bookCode.CustomButton.Visible = false;
            this.bookCode.Enabled = false;
            this.bookCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.bookCode.Lines = new string[0];
            this.bookCode.Location = new System.Drawing.Point(140, 100);
            this.bookCode.MaxLength = 32767;
            this.bookCode.Name = "bookCode";
            this.bookCode.PasswordChar = '\0';
            this.bookCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bookCode.SelectedText = "";
            this.bookCode.SelectionLength = 0;
            this.bookCode.SelectionStart = 0;
            this.bookCode.ShortcutsEnabled = true;
            this.bookCode.Size = new System.Drawing.Size(200, 30);
            this.bookCode.TabIndex = 8;
            this.bookCode.UseSelectable = true;
            this.bookCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bookCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.bookCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bookCode_KeyDown);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(5, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "QR :";
            // 
            // userProfile
            // 
            this.userProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userProfile.Location = new System.Drawing.Point(1250, 15);
            this.userProfile.Name = "userProfile";
            this.userProfile.Size = new System.Drawing.Size(110, 130);
            this.userProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userProfile.TabIndex = 7;
            this.userProfile.TabStop = false;
            // 
            // lbUserPhone
            // 
            this.lbUserPhone.AutoSize = true;
            this.lbUserPhone.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbUserPhone.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbUserPhone.Location = new System.Drawing.Point(920, 20);
            this.lbUserPhone.Name = "lbUserPhone";
            this.lbUserPhone.Size = new System.Drawing.Size(62, 25);
            this.lbUserPhone.TabIndex = 3;
            this.lbUserPhone.Text = "Утас :";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbUsername.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbUsername.Location = new System.Drawing.Point(500, 20);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(105, 25);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Овог нэр :";
            // 
            // btnCheckUser
            // 
            this.btnCheckUser.Location = new System.Drawing.Point(350, 17);
            this.btnCheckUser.Name = "btnCheckUser";
            this.btnCheckUser.Size = new System.Drawing.Size(90, 30);
            this.btnCheckUser.TabIndex = 7;
            this.btnCheckUser.Text = "Шалгах";
            this.btnCheckUser.UseVisualStyleBackColor = true;
            this.btnCheckUser.Click += new System.EventHandler(this.btnCheckUser_Click);
            // 
            // userCode
            // 
            // 
            // 
            // 
            this.userCode.CustomButton.Image = null;
            this.userCode.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.userCode.CustomButton.Name = "";
            this.userCode.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.userCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userCode.CustomButton.TabIndex = 1;
            this.userCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userCode.CustomButton.UseSelectable = true;
            this.userCode.CustomButton.Visible = false;
            this.userCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userCode.Lines = new string[0];
            this.userCode.Location = new System.Drawing.Point(140, 17);
            this.userCode.MaxLength = 32767;
            this.userCode.Name = "userCode";
            this.userCode.PasswordChar = '\0';
            this.userCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userCode.SelectedText = "";
            this.userCode.SelectionLength = 0;
            this.userCode.SelectionStart = 0;
            this.userCode.ShortcutsEnabled = true;
            this.userCode.Size = new System.Drawing.Size(200, 30);
            this.userCode.TabIndex = 6;
            this.userCode.UseSelectable = true;
            this.userCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(5, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Код :";
            // 
            // metroGridBook
            // 
            this.metroGridBook.AllowUserToAddRows = false;
            this.metroGridBook.AllowUserToDeleteRows = false;
            this.metroGridBook.AllowUserToOrderColumns = true;
            this.metroGridBook.AllowUserToResizeRows = false;
            this.metroGridBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGridBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGridBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Mon", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridBook.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridBook.EnableHeadersVisualStyles = false;
            this.metroGridBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGridBook.Location = new System.Drawing.Point(30, 260);
            this.metroGridBook.MultiSelect = false;
            this.metroGridBook.Name = "metroGridBook";
            this.metroGridBook.ReadOnly = true;
            this.metroGridBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridBook.RowHeadersWidth = 51;
            this.metroGridBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridBook.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.metroGridBook.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Mon", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGridBook.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridBook.RowTemplate.Height = 24;
            this.metroGridBook.RowTemplate.ReadOnly = true;
            this.metroGridBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGridBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridBook.Size = new System.Drawing.Size(1400, 520);
            this.metroGridBook.TabIndex = 1;
            this.metroGridBook.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGridBook_RowHeaderMouseClick);
            // 
            // BookRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 800);
            this.Controls.Add(this.metroGridBook);
            this.Controls.Add(this.metroPanel);
            this.Name = "BookRent";
            this.Text = "Ном түрээслэх";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.BookRent_Load);
            this.metroPanel.ResumeLayout(false);
            this.metroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroTextBox userCode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnCheckUser;
        private System.Windows.Forms.PictureBox userProfile;
        private MetroFramework.Controls.MetroLabel lbUserPhone;
        private MetroFramework.Controls.MetroLabel lbUsername;
        private MetroFramework.Controls.MetroTextBox bookCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroGrid metroGridBook;
        private System.Windows.Forms.Button btnRent;
        private MetroFramework.Controls.MetroLabel lbUserDay;
        private MetroFramework.Controls.MetroLabel lbUserType;
    }
}