namespace BLMS
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroBook = new MetroFramework.Controls.MetroTile();
            this.metroUsers = new MetroFramework.Controls.MetroTile();
            this.metroRent = new MetroFramework.Controls.MetroTile();
            this.metroReturn = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroUserRegister = new MetroFramework.Controls.MetroTile();
            this.metroChuulgan = new MetroFramework.Controls.MetroTile();
            this.metroUserType = new MetroFramework.Controls.MetroTile();
            this.metroFLow = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroCategory = new MetroFramework.Controls.MetroTile();
            this.metroLang = new MetroFramework.Controls.MetroTile();
            this.metroAuthor = new MetroFramework.Controls.MetroTile();
            this.metroCompany = new MetroFramework.Controls.MetroTile();
            this.metroCreated = new MetroFramework.Controls.MetroLink();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroGridBook = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridBook)).BeginInit();
            this.SuspendLayout();
            // 
            // metroBook
            // 
            this.metroBook.ActiveControl = null;
            this.metroBook.Location = new System.Drawing.Point(5, 5);
            this.metroBook.Name = "metroBook";
            this.metroBook.Size = new System.Drawing.Size(140, 120);
            this.metroBook.TabIndex = 1;
            this.metroBook.Text = "Ном";
            this.metroBook.TileImage = global::BLMS.Properties.Resources.icon_book_48;
            this.metroBook.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroBook.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroBook.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroBook.UseSelectable = true;
            this.metroBook.UseTileImage = true;
            this.metroBook.Click += new System.EventHandler(this.metroBook_Click);
            // 
            // metroUsers
            // 
            this.metroUsers.ActiveControl = null;
            this.metroUsers.Location = new System.Drawing.Point(150, 5);
            this.metroUsers.Name = "metroUsers";
            this.metroUsers.Size = new System.Drawing.Size(180, 120);
            this.metroUsers.TabIndex = 2;
            this.metroUsers.Text = "Гишүүд";
            this.metroUsers.TileImage = global::BLMS.Properties.Resources.icon_users_48;
            this.metroUsers.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroUsers.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroUsers.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroUsers.UseSelectable = true;
            this.metroUsers.UseTileImage = true;
            this.metroUsers.Click += new System.EventHandler(this.metroUsers_Click);
            // 
            // metroRent
            // 
            this.metroRent.ActiveControl = null;
            this.metroRent.Location = new System.Drawing.Point(335, 5);
            this.metroRent.Name = "metroRent";
            this.metroRent.Size = new System.Drawing.Size(180, 120);
            this.metroRent.TabIndex = 3;
            this.metroRent.Text = "Түрээс";
            this.metroRent.TileImage = global::BLMS.Properties.Resources.icon_rent_48;
            this.metroRent.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroRent.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroRent.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroRent.UseSelectable = true;
            this.metroRent.UseTileImage = true;
            this.metroRent.Click += new System.EventHandler(this.metroRent_Click);
            // 
            // metroReturn
            // 
            this.metroReturn.ActiveControl = null;
            this.metroReturn.Location = new System.Drawing.Point(520, 5);
            this.metroReturn.Name = "metroReturn";
            this.metroReturn.Size = new System.Drawing.Size(180, 120);
            this.metroReturn.TabIndex = 4;
            this.metroReturn.Text = "Буцаалт";
            this.metroReturn.TileImage = global::BLMS.Properties.Resources.icon_return_48;
            this.metroReturn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroReturn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroReturn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroReturn.UseSelectable = true;
            this.metroReturn.UseTileImage = true;
            this.metroReturn.Click += new System.EventHandler(this.metroReturn_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.metroUserRegister);
            this.metroPanel1.Controls.Add(this.metroChuulgan);
            this.metroPanel1.Controls.Add(this.metroUserType);
            this.metroPanel1.Controls.Add(this.metroFLow);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.metroCategory);
            this.metroPanel1.Controls.Add(this.metroLang);
            this.metroPanel1.Controls.Add(this.metroAuthor);
            this.metroPanel1.Controls.Add(this.metroCompany);
            this.metroPanel1.Controls.Add(this.metroRent);
            this.metroPanel1.Controls.Add(this.metroReturn);
            this.metroPanel1.Controls.Add(this.metroBook);
            this.metroPanel1.Controls.Add(this.metroUsers);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 78);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1500, 260);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroUserRegister
            // 
            this.metroUserRegister.ActiveControl = null;
            this.metroUserRegister.Location = new System.Drawing.Point(871, 5);
            this.metroUserRegister.Name = "metroUserRegister";
            this.metroUserRegister.Size = new System.Drawing.Size(159, 121);
            this.metroUserRegister.TabIndex = 13;
            this.metroUserRegister.Text = "Бүртгэл";
            this.metroUserRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroUserRegister.TileImage = global::BLMS.Properties.Resources.icon_register_48;
            this.metroUserRegister.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroUserRegister.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroUserRegister.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroUserRegister.UseSelectable = true;
            this.metroUserRegister.UseTileImage = true;
            this.metroUserRegister.Click += new System.EventHandler(this.metroUserRegister_Click);
            // 
            // metroChuulgan
            // 
            this.metroChuulgan.ActiveControl = null;
            this.metroChuulgan.Location = new System.Drawing.Point(870, 132);
            this.metroChuulgan.Name = "metroChuulgan";
            this.metroChuulgan.Size = new System.Drawing.Size(160, 120);
            this.metroChuulgan.TabIndex = 12;
            this.metroChuulgan.Text = "Чуулган";
            this.metroChuulgan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroChuulgan.TileImage = global::BLMS.Properties.Resources.icon_church_48;
            this.metroChuulgan.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroChuulgan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroChuulgan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroChuulgan.UseSelectable = true;
            this.metroChuulgan.UseTileImage = true;
            this.metroChuulgan.Click += new System.EventHandler(this.metroChurch_Click);
            // 
            // metroUserType
            // 
            this.metroUserType.ActiveControl = null;
            this.metroUserType.Location = new System.Drawing.Point(705, 5);
            this.metroUserType.Name = "metroUserType";
            this.metroUserType.Size = new System.Drawing.Size(160, 120);
            this.metroUserType.TabIndex = 11;
            this.metroUserType.Text = "Тохиргоо";
            this.metroUserType.TileImage = global::BLMS.Properties.Resources.icon_settings_48;
            this.metroUserType.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroUserType.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroUserType.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroUserType.UseSelectable = true;
            this.metroUserType.UseTileImage = true;
            this.metroUserType.Click += new System.EventHandler(this.metroUserType_Click);
            // 
            // metroFLow
            // 
            this.metroFLow.ActiveControl = null;
            this.metroFLow.Location = new System.Drawing.Point(705, 132);
            this.metroFLow.Name = "metroFLow";
            this.metroFLow.Size = new System.Drawing.Size(160, 120);
            this.metroFLow.TabIndex = 10;
            this.metroFLow.Text = "Урсгал";
            this.metroFLow.TileImage = global::BLMS.Properties.Resources.icon_flow_481;
            this.metroFLow.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroFLow.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroFLow.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroFLow.UseSelectable = true;
            this.metroFLow.UseTileImage = true;
            this.metroFLow.Click += new System.EventHandler(this.metroFLow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BLMS.Properties.Resources.home_image;
            this.pictureBox1.Location = new System.Drawing.Point(1050, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // metroCategory
            // 
            this.metroCategory.ActiveControl = null;
            this.metroCategory.Location = new System.Drawing.Point(335, 132);
            this.metroCategory.Name = "metroCategory";
            this.metroCategory.Size = new System.Drawing.Size(180, 120);
            this.metroCategory.TabIndex = 7;
            this.metroCategory.Text = "Ангилал";
            this.metroCategory.TileImage = global::BLMS.Properties.Resources.icon_category_48;
            this.metroCategory.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroCategory.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroCategory.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroCategory.UseSelectable = true;
            this.metroCategory.UseTileImage = true;
            this.metroCategory.Click += new System.EventHandler(this.metroCategory_Click);
            // 
            // metroLang
            // 
            this.metroLang.ActiveControl = null;
            this.metroLang.Location = new System.Drawing.Point(521, 132);
            this.metroLang.Name = "metroLang";
            this.metroLang.Size = new System.Drawing.Size(180, 120);
            this.metroLang.TabIndex = 8;
            this.metroLang.Text = "Гадаад хэл";
            this.metroLang.TileImage = global::BLMS.Properties.Resources.icon_language_48;
            this.metroLang.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLang.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroLang.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroLang.UseSelectable = true;
            this.metroLang.UseTileImage = true;
            this.metroLang.Click += new System.EventHandler(this.metroLang_Click);
            // 
            // metroAuthor
            // 
            this.metroAuthor.ActiveControl = null;
            this.metroAuthor.Location = new System.Drawing.Point(5, 132);
            this.metroAuthor.Name = "metroAuthor";
            this.metroAuthor.Size = new System.Drawing.Size(140, 120);
            this.metroAuthor.TabIndex = 5;
            this.metroAuthor.Text = "Зохиолч";
            this.metroAuthor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroAuthor.TileImage = global::BLMS.Properties.Resources.icon_author_48;
            this.metroAuthor.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroAuthor.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroAuthor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroAuthor.UseSelectable = true;
            this.metroAuthor.UseTileImage = true;
            this.metroAuthor.Click += new System.EventHandler(this.metroAuthor_Click);
            // 
            // metroCompany
            // 
            this.metroCompany.ActiveControl = null;
            this.metroCompany.Location = new System.Drawing.Point(150, 132);
            this.metroCompany.Name = "metroCompany";
            this.metroCompany.Size = new System.Drawing.Size(180, 120);
            this.metroCompany.TabIndex = 6;
            this.metroCompany.Text = "Байгууллага";
            this.metroCompany.TileImage = global::BLMS.Properties.Resources.icon_organization_48;
            this.metroCompany.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroCompany.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroCompany.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroCompany.UseSelectable = true;
            this.metroCompany.UseTileImage = true;
            this.metroCompany.Click += new System.EventHandler(this.metroCompany_Click);
            // 
            // metroCreated
            // 
            this.metroCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroCreated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroCreated.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroCreated.Location = new System.Drawing.Point(23, 959);
            this.metroCreated.Name = "metroCreated";
            this.metroCreated.Size = new System.Drawing.Size(240, 23);
            this.metroCreated.TabIndex = 7;
            this.metroCreated.Text = "Created by Huree ICT";
            this.metroCreated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroCreated.UseSelectable = true;
            this.metroCreated.Click += new System.EventHandler(this.metroCreated_Click);
            // 
            // lbDateTime
            // 
            this.lbDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.Location = new System.Drawing.Point(1254, 43);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(274, 23);
            this.lbDateTime.TabIndex = 8;
            this.lbDateTime.Text = "Өнөөдөр : 2020.03.20 12:20:20";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroGridBook
            // 
            this.metroGridBook.AllowUserToAddRows = false;
            this.metroGridBook.AllowUserToDeleteRows = false;
            this.metroGridBook.AllowUserToResizeRows = false;
            this.metroGridBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGridBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGridBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGridBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Mon", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridBook.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridBook.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridBook.EnableHeadersVisualStyles = false;
            this.metroGridBook.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridBook.Location = new System.Drawing.Point(23, 344);
            this.metroGridBook.MultiSelect = false;
            this.metroGridBook.Name = "metroGridBook";
            this.metroGridBook.ReadOnly = true;
            this.metroGridBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Mon", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridBook.RowHeadersWidth = 30;
            this.metroGridBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridBook.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.metroGridBook.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Mon", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGridBook.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.metroGridBook.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridBook.RowTemplate.Height = 24;
            this.metroGridBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGridBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridBook.Size = new System.Drawing.Size(1502, 609);
            this.metroGridBook.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = global::BLMS.Properties.Resources.logo;
            this.BackImagePadding = new System.Windows.Forms.Padding(160, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(1550, 1000);
            this.Controls.Add(this.metroGridBook);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.metroCreated);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Main";
            this.Text = "Нүүр хуудас";
            this.Load += new System.EventHandler(this.Main_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroBook;
        private MetroFramework.Controls.MetroTile metroUsers;
        private MetroFramework.Controls.MetroTile metroRent;
        private MetroFramework.Controls.MetroTile metroReturn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroCategory;
        private MetroFramework.Controls.MetroTile metroLang;
        private MetroFramework.Controls.MetroTile metroAuthor;
        private MetroFramework.Controls.MetroTile metroCompany;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile metroFLow;
        private MetroFramework.Controls.MetroLink metroCreated;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroGrid metroGridBook;
        private MetroFramework.Controls.MetroTile metroUserType;
        private MetroFramework.Controls.MetroTile metroUserRegister;
        private MetroFramework.Controls.MetroTile metroChuulgan;
    }
}

