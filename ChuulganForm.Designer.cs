namespace BLMS
{
    partial class ChuulganForm
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chuulganSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.metroGridChuulgan = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chuulganName = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridChuulgan)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(350, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 30);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Хайх :";
            // 
            // chuulganSearch
            // 
            // 
            // 
            // 
            this.chuulganSearch.CustomButton.Image = null;
            this.chuulganSearch.CustomButton.Location = new System.Drawing.Point(276, 2);
            this.chuulganSearch.CustomButton.Name = "";
            this.chuulganSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.chuulganSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.chuulganSearch.CustomButton.TabIndex = 1;
            this.chuulganSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chuulganSearch.CustomButton.UseSelectable = true;
            this.chuulganSearch.CustomButton.Visible = false;
            this.chuulganSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.chuulganSearch.Lines = new string[0];
            this.chuulganSearch.Location = new System.Drawing.Point(446, 80);
            this.chuulganSearch.MaxLength = 32767;
            this.chuulganSearch.Name = "chuulganSearch";
            this.chuulganSearch.PasswordChar = '\0';
            this.chuulganSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.chuulganSearch.SelectedText = "";
            this.chuulganSearch.SelectionLength = 0;
            this.chuulganSearch.SelectionStart = 0;
            this.chuulganSearch.ShortcutsEnabled = true;
            this.chuulganSearch.Size = new System.Drawing.Size(304, 30);
            this.chuulganSearch.TabIndex = 2;
            this.chuulganSearch.UseSelectable = true;
            this.chuulganSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.chuulganSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.chuulganSearch.TextChanged += new System.EventHandler(this.chuulganSearch_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::BLMS.Properties.Resources.icon_clear_24;
            this.btnClear.Location = new System.Drawing.Point(185, 305);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 50);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Цэвэрлэх";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::BLMS.Properties.Resources.icon_trash_24;
            this.btnDelete.Location = new System.Drawing.Point(30, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 50);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Устгах";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::BLMS.Properties.Resources.icon_edit_24;
            this.btnEdit.Location = new System.Drawing.Point(185, 222);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 50);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Засах";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::BLMS.Properties.Resources.icon_plus_24;
            this.btnAdd.Location = new System.Drawing.Point(30, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 50);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Нэмэх";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroGridChuulgan
            // 
            this.metroGridChuulgan.AllowUserToAddRows = false;
            this.metroGridChuulgan.AllowUserToDeleteRows = false;
            this.metroGridChuulgan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridChuulgan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGridChuulgan.BackgroundColor = System.Drawing.Color.DarkGray;
            this.metroGridChuulgan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridChuulgan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridChuulgan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridChuulgan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridChuulgan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridChuulgan.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridChuulgan.EnableHeadersVisualStyles = false;
            this.metroGridChuulgan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridChuulgan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridChuulgan.Location = new System.Drawing.Point(350, 130);
            this.metroGridChuulgan.MultiSelect = false;
            this.metroGridChuulgan.Name = "metroGridChuulgan";
            this.metroGridChuulgan.ReadOnly = true;
            this.metroGridChuulgan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridChuulgan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridChuulgan.RowHeadersWidth = 51;
            this.metroGridChuulgan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridChuulgan.RowTemplate.Height = 24;
            this.metroGridChuulgan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridChuulgan.Size = new System.Drawing.Size(509, 425);
            this.metroGridChuulgan.TabIndex = 8;
            this.metroGridChuulgan.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGridChuulgan_RowHeaderMouseClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(30, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(300, 30);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Чуулганы нэр :";
            // 
            // chuulganName
            // 
            // 
            // 
            // 
            this.chuulganName.CustomButton.Image = null;
            this.chuulganName.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.chuulganName.CustomButton.Name = "";
            this.chuulganName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.chuulganName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.chuulganName.CustomButton.TabIndex = 1;
            this.chuulganName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chuulganName.CustomButton.UseSelectable = true;
            this.chuulganName.CustomButton.Visible = false;
            this.chuulganName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.chuulganName.Lines = new string[0];
            this.chuulganName.Location = new System.Drawing.Point(30, 130);
            this.chuulganName.MaxLength = 32767;
            this.chuulganName.Name = "chuulganName";
            this.chuulganName.PasswordChar = '\0';
            this.chuulganName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.chuulganName.SelectedText = "";
            this.chuulganName.SelectionLength = 0;
            this.chuulganName.SelectionStart = 0;
            this.chuulganName.ShortcutsEnabled = true;
            this.chuulganName.Size = new System.Drawing.Size(300, 30);
            this.chuulganName.TabIndex = 3;
            this.chuulganName.UseSelectable = true;
            this.chuulganName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.chuulganName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChuulganForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.chuulganSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroGridChuulgan);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.chuulganName);
            this.MaximumSize = new System.Drawing.Size(1100, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "ChuulganForm";
            this.Text = "Чуулган";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ChuulganForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridChuulgan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox chuulganSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        public MetroFramework.Controls.MetroGrid metroGridChuulgan;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox chuulganName;
    }
}