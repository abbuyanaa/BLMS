namespace BLMS
{
    partial class UserManager
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
            this.metroGridUsers = new MetroFramework.Controls.MetroGrid();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.userSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblFLname = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridUsers)).BeginInit();
            this.metroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGridUsers
            // 
            this.metroGridUsers.AllowUserToAddRows = false;
            this.metroGridUsers.AllowUserToDeleteRows = false;
            this.metroGridUsers.AllowUserToResizeRows = false;
            this.metroGridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.metroGridUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGridUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Mon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridUsers.EnableHeadersVisualStyles = false;
            this.metroGridUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridUsers.Location = new System.Drawing.Point(30, 145);
            this.metroGridUsers.MultiSelect = false;
            this.metroGridUsers.Name = "metroGridUsers";
            this.metroGridUsers.ReadOnly = true;
            this.metroGridUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridUsers.RowHeadersWidth = 51;
            this.metroGridUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridUsers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.metroGridUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Mon", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroGridUsers.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridUsers.RowTemplate.Height = 24;
            this.metroGridUsers.RowTemplate.ReadOnly = true;
            this.metroGridUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridUsers.Size = new System.Drawing.Size(1540, 840);
            this.metroGridUsers.TabIndex = 25;
            this.metroGridUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGridUsers_RowHeaderMouseClick);
            // 
            // metroPanel
            // 
            this.metroPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroPanel.Controls.Add(this.btnAdd);
            this.metroPanel.Controls.Add(this.userSearch);
            this.metroPanel.Controls.Add(this.lblFLname);
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(30, 80);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(1540, 50);
            this.metroPanel.TabIndex = 26;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::BLMS.Properties.Resources.icon_plus_24;
            this.btnAdd.Location = new System.Drawing.Point(520, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(231, 47);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Шинэ хэрэглэгч бүртгэх";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // userSearch
            // 
            this.userSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.userSearch.CustomButton.Image = null;
            this.userSearch.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.userSearch.CustomButton.Name = "";
            this.userSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.userSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userSearch.CustomButton.TabIndex = 1;
            this.userSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userSearch.CustomButton.UseSelectable = true;
            this.userSearch.CustomButton.Visible = false;
            this.userSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.userSearch.Lines = new string[0];
            this.userSearch.Location = new System.Drawing.Point(190, 10);
            this.userSearch.MaxLength = 32767;
            this.userSearch.Name = "userSearch";
            this.userSearch.PasswordChar = '\0';
            this.userSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userSearch.SelectedText = "";
            this.userSearch.SelectionLength = 0;
            this.userSearch.SelectionStart = 0;
            this.userSearch.ShortcutsEnabled = true;
            this.userSearch.Size = new System.Drawing.Size(300, 30);
            this.userSearch.TabIndex = 14;
            this.userSearch.UseSelectable = true;
            this.userSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userSearch.TextChanged += new System.EventHandler(this.userSearch_TextChanged);
            // 
            // lblFLname
            // 
            this.lblFLname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFLname.AutoSize = true;
            this.lblFLname.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFLname.Location = new System.Drawing.Point(30, 15);
            this.lblFLname.Name = "lblFLname";
            this.lblFLname.Size = new System.Drawing.Size(124, 20);
            this.lblFLname.TabIndex = 12;
            this.lblFLname.Text = "Хэрэглэгч хайх :";
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(250, 20, 0, 0);
            this.BackMaxSize = 30;
            this.ClientSize = new System.Drawing.Size(1600, 1000);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.metroGridUsers);
            this.Name = "UserManager";
            this.Text = "Хэрэглэгчид";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Activated += new System.EventHandler(this.UsersManager_Activated);
            this.Load += new System.EventHandler(this.UsersManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridUsers)).EndInit();
            this.metroPanel.ResumeLayout(false);
            this.metroPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroTextBox userSearch;
        private MetroFramework.Controls.MetroLabel lblFLname;
        public MetroFramework.Controls.MetroGrid metroGridUsers;
        private System.Windows.Forms.Button btnAdd;
    }
}