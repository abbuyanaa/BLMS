namespace BLMS
{
    partial class BookEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookEdit));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnPrintSetting = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnQrPrinter = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbAuthor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbYear = new MetroFramework.Controls.MetroComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.bookBody = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.cbFlow = new MetroFramework.Controls.MetroComboBox();
            this.cbCompany = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.cbLang = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.bookOut = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.bookEsse = new MetroFramework.Controls.MetroCheckBox();
            this.bookBible = new MetroFramework.Controls.MetroCheckBox();
            this.bookQty = new MetroFramework.Controls.MetroTextBox();
            this.cbCsub = new MetroFramework.Controls.MetroComboBox();
            this.cbCbasic = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.bookName = new MetroFramework.Controls.MetroTextBox();
            this.bookImage = new System.Windows.Forms.PictureBox();
            this.bookQrCode = new System.Windows.Forms.PictureBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroPanel1.Controls.Add(this.btnPrintSetting);
            this.metroPanel1.Controls.Add(this.btnPrintPreview);
            this.metroPanel1.Controls.Add(this.btnQrPrinter);
            this.metroPanel1.Controls.Add(this.btnDelete);
            this.metroPanel1.Controls.Add(this.cbAuthor);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.cbYear);
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.btnEdit);
            this.metroPanel1.Controls.Add(this.btnBrowser);
            this.metroPanel1.Controls.Add(this.bookBody);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.cbFlow);
            this.metroPanel1.Controls.Add(this.cbCompany);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.cbLang);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.bookOut);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.bookEsse);
            this.metroPanel1.Controls.Add(this.bookBible);
            this.metroPanel1.Controls.Add(this.bookQty);
            this.metroPanel1.Controls.Add(this.cbCsub);
            this.metroPanel1.Controls.Add(this.cbCbasic);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.bookName);
            this.metroPanel1.Controls.Add(this.bookImage);
            this.metroPanel1.Controls.Add(this.bookQrCode);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 80);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1450, 510);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnPrintSetting
            // 
            this.btnPrintSetting.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSetting.Image = global::BLMS.Properties.Resources.icon_qrcode_24;
            this.btnPrintSetting.Location = new System.Drawing.Point(757, 446);
            this.btnPrintSetting.Name = "btnPrintSetting";
            this.btnPrintSetting.Size = new System.Drawing.Size(180, 50);
            this.btnPrintSetting.TabIndex = 29;
            this.btnPrintSetting.Text = "Тохиргоо";
            this.btnPrintSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintSetting.UseVisualStyleBackColor = true;
            this.btnPrintSetting.Click += new System.EventHandler(this.btnPrintSetting_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.Image = global::BLMS.Properties.Resources.icon_qrcode_24;
            this.btnPrintPreview.Location = new System.Drawing.Point(1000, 446);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(180, 50);
            this.btnPrintPreview.TabIndex = 28;
            this.btnPrintPreview.Text = "Харах";
            this.btnPrintPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnQrPrinter
            // 
            this.btnQrPrinter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQrPrinter.Image = global::BLMS.Properties.Resources.icon_qrcode_24;
            this.btnQrPrinter.Location = new System.Drawing.Point(1220, 446);
            this.btnQrPrinter.Name = "btnQrPrinter";
            this.btnQrPrinter.Size = new System.Drawing.Size(180, 50);
            this.btnQrPrinter.TabIndex = 27;
            this.btnQrPrinter.Text = "QR Хэвлэх";
            this.btnQrPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQrPrinter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQrPrinter.UseVisualStyleBackColor = true;
            this.btnQrPrinter.Click += new System.EventHandler(this.btnQrPrinter_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::BLMS.Properties.Resources.icon_trash_24;
            this.btnDelete.Location = new System.Drawing.Point(525, 446);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 50);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Устгах";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbAuthor
            // 
            this.cbAuthor.DropDownHeight = 325;
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.IntegralHeight = false;
            this.cbAuthor.ItemHeight = 24;
            this.cbAuthor.Location = new System.Drawing.Point(370, 75);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(400, 30);
            this.cbAuthor.TabIndex = 12;
            this.cbAuthor.UseSelectable = true;
            this.cbAuthor.SelectedIndexChanged += new System.EventHandler(this.cbAuthor_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(200, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Зохиолч :";
            // 
            // cbYear
            // 
            this.cbYear.DropDownHeight = 325;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.IntegralHeight = false;
            this.cbYear.ItemHeight = 24;
            this.cbYear.Location = new System.Drawing.Point(1000, 235);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(400, 30);
            this.cbYear.TabIndex = 19;
            this.cbYear.UseSelectable = true;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::BLMS.Properties.Resources.icon_clear_24;
            this.btnClear.Location = new System.Drawing.Point(277, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 50);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Цэвэрлэх";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::BLMS.Properties.Resources.icon_edit_24;
            this.btnEdit.Location = new System.Drawing.Point(-5, 446);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 50);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Шинэчилэх";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.Image = global::BLMS.Properties.Resources.icon_file_explorer;
            this.btnBrowser.Location = new System.Drawing.Point(3, 230);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(180, 50);
            this.btnBrowser.TabIndex = 10;
            this.btnBrowser.Text = "Зураг солих";
            this.btnBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // bookBody
            // 
            // 
            // 
            // 
            this.bookBody.CustomButton.Image = null;
            this.bookBody.CustomButton.Location = new System.Drawing.Point(1299, 2);
            this.bookBody.CustomButton.Name = "";
            this.bookBody.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.bookBody.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookBody.CustomButton.TabIndex = 1;
            this.bookBody.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bookBody.CustomButton.UseSelectable = true;
            this.bookBody.CustomButton.Visible = false;
            this.bookBody.Lines = new string[0];
            this.bookBody.Location = new System.Drawing.Point(3, 340);
            this.bookBody.MaxLength = 32767;
            this.bookBody.Multiline = true;
            this.bookBody.Name = "bookBody";
            this.bookBody.PasswordChar = '\0';
            this.bookBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookBody.SelectedText = "";
            this.bookBody.SelectionLength = 0;
            this.bookBody.SelectionStart = 0;
            this.bookBody.ShortcutsEnabled = true;
            this.bookBody.Size = new System.Drawing.Size(1397, 100);
            this.bookBody.TabIndex = 23;
            this.bookBody.UseSelectable = true;
            this.bookBody.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bookBody.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(3, 300);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(77, 20);
            this.metroLabel13.TabIndex = 5;
            this.metroLabel13.Text = "Тайлбар :";
            // 
            // cbFlow
            // 
            this.cbFlow.DropDownHeight = 325;
            this.cbFlow.FormattingEnabled = true;
            this.cbFlow.IntegralHeight = false;
            this.cbFlow.ItemHeight = 24;
            this.cbFlow.Location = new System.Drawing.Point(1000, 185);
            this.cbFlow.Name = "cbFlow";
            this.cbFlow.Size = new System.Drawing.Size(400, 30);
            this.cbFlow.TabIndex = 17;
            this.cbFlow.UseSelectable = true;
            this.cbFlow.SelectedIndexChanged += new System.EventHandler(this.cbFlow_SelectedIndexChanged);
            // 
            // cbCompany
            // 
            this.cbCompany.DropDownHeight = 325;
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.IntegralHeight = false;
            this.cbCompany.ItemHeight = 24;
            this.cbCompany.Location = new System.Drawing.Point(1000, 75);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(400, 30);
            this.cbCompany.TabIndex = 13;
            this.cbCompany.UseSelectable = true;
            this.cbCompany.SelectedIndexChanged += new System.EventHandler(this.cbCompany_SelectedIndexChanged);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(820, 80);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(105, 20);
            this.metroLabel12.TabIndex = 6;
            this.metroLabel12.Text = "Байгууллага :";
            // 
            // cbLang
            // 
            this.cbLang.DropDownHeight = 325;
            this.cbLang.FormattingEnabled = true;
            this.cbLang.IntegralHeight = false;
            this.cbLang.ItemHeight = 24;
            this.cbLang.Location = new System.Drawing.Point(370, 180);
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(400, 30);
            this.cbLang.TabIndex = 16;
            this.cbLang.UseSelectable = true;
            this.cbLang.SelectedIndexChanged += new System.EventHandler(this.cbLang_SelectedIndexChanged);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(200, 185);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(43, 20);
            this.metroLabel11.TabIndex = 3;
            this.metroLabel11.Text = "Хэл :";
            // 
            // bookOut
            // 
            this.bookOut.AutoSize = true;
            this.bookOut.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.bookOut.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.bookOut.Location = new System.Drawing.Point(820, 300);
            this.bookOut.Name = "bookOut";
            this.bookOut.Size = new System.Drawing.Size(125, 20);
            this.bookOut.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookOut.TabIndex = 22;
            this.bookOut.Text = "Гаргаж болно";
            this.bookOut.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(820, 190);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(117, 20);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Усргал чиглэл :";
            // 
            // bookEsse
            // 
            this.bookEsse.AutoSize = true;
            this.bookEsse.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.bookEsse.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.bookEsse.Location = new System.Drawing.Point(1170, 300);
            this.bookEsse.Name = "bookEsse";
            this.bookEsse.Size = new System.Drawing.Size(91, 20);
            this.bookEsse.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookEsse.TabIndex = 21;
            this.bookEsse.Text = "Эссе биш";
            this.bookEsse.UseSelectable = true;
            this.bookEsse.Visible = false;
            // 
            // bookBible
            // 
            this.bookBible.AutoSize = true;
            this.bookBible.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.bookBible.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.bookBible.Location = new System.Drawing.Point(370, 300);
            this.bookBible.Name = "bookBible";
            this.bookBible.Size = new System.Drawing.Size(105, 20);
            this.bookBible.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookBible.TabIndex = 20;
            this.bookBible.Text = "Библи ном";
            this.bookBible.UseSelectable = true;
            // 
            // bookQty
            // 
            // 
            // 
            // 
            this.bookQty.CustomButton.Image = null;
            this.bookQty.CustomButton.Location = new System.Drawing.Point(372, 2);
            this.bookQty.CustomButton.Name = "";
            this.bookQty.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.bookQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookQty.CustomButton.TabIndex = 1;
            this.bookQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bookQty.CustomButton.UseSelectable = true;
            this.bookQty.CustomButton.Visible = false;
            this.bookQty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.bookQty.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.bookQty.Lines = new string[] {
        "1"};
            this.bookQty.Location = new System.Drawing.Point(370, 240);
            this.bookQty.MaxLength = 32767;
            this.bookQty.Name = "bookQty";
            this.bookQty.PasswordChar = '\0';
            this.bookQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bookQty.SelectedText = "";
            this.bookQty.SelectionLength = 0;
            this.bookQty.SelectionStart = 0;
            this.bookQty.ShortcutsEnabled = true;
            this.bookQty.Size = new System.Drawing.Size(400, 30);
            this.bookQty.TabIndex = 18;
            this.bookQty.Text = "1";
            this.bookQty.UseSelectable = true;
            this.bookQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bookQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbCsub
            // 
            this.cbCsub.DropDownHeight = 325;
            this.cbCsub.FormattingEnabled = true;
            this.cbCsub.IntegralHeight = false;
            this.cbCsub.ItemHeight = 24;
            this.cbCsub.Location = new System.Drawing.Point(1000, 130);
            this.cbCsub.Name = "cbCsub";
            this.cbCsub.Size = new System.Drawing.Size(400, 30);
            this.cbCsub.TabIndex = 15;
            this.cbCsub.UseSelectable = true;
            this.cbCsub.SelectedIndexChanged += new System.EventHandler(this.cbCsub_SelectedIndexChanged);
            // 
            // cbCbasic
            // 
            this.cbCbasic.DropDownHeight = 325;
            this.cbCbasic.FormattingEnabled = true;
            this.cbCbasic.IntegralHeight = false;
            this.cbCbasic.ItemHeight = 24;
            this.cbCbasic.Location = new System.Drawing.Point(370, 130);
            this.cbCbasic.Name = "cbCbasic";
            this.cbCbasic.Size = new System.Drawing.Size(400, 30);
            this.cbCbasic.TabIndex = 14;
            this.cbCbasic.UseSelectable = true;
            this.cbCbasic.SelectedIndexChanged += new System.EventHandler(this.cbCbasic_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(200, 245);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 20);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Тоо :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(820, 135);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 20);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Дэд төрөл :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(200, 135);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(114, 20);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Үндсэн төрөл :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(820, 240);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 20);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Он :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(200, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Нэр :";
            // 
            // bookName
            // 
            // 
            // 
            // 
            this.bookName.CustomButton.Image = null;
            this.bookName.CustomButton.Location = new System.Drawing.Point(972, 2);
            this.bookName.CustomButton.Name = "";
            this.bookName.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.bookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookName.CustomButton.TabIndex = 1;
            this.bookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bookName.CustomButton.UseSelectable = true;
            this.bookName.CustomButton.Visible = false;
            this.bookName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.bookName.Lines = new string[0];
            this.bookName.Location = new System.Drawing.Point(370, 0);
            this.bookName.MaxLength = 32767;
            this.bookName.Multiline = true;
            this.bookName.Name = "bookName";
            this.bookName.PasswordChar = '\0';
            this.bookName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bookName.SelectedText = "";
            this.bookName.SelectionLength = 0;
            this.bookName.SelectionStart = 0;
            this.bookName.ShortcutsEnabled = true;
            this.bookName.Size = new System.Drawing.Size(1030, 60);
            this.bookName.TabIndex = 11;
            this.bookName.UseCustomBackColor = true;
            this.bookName.UseSelectable = true;
            this.bookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bookName.WaterMarkFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bookImage
            // 
            this.bookImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bookImage.InitialImage = null;
            this.bookImage.Location = new System.Drawing.Point(3, 4);
            this.bookImage.Name = "bookImage";
            this.bookImage.Size = new System.Drawing.Size(180, 220);
            this.bookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookImage.TabIndex = 2;
            this.bookImage.TabStop = false;
            // 
            // bookQrCode
            // 
            this.bookQrCode.BackColor = System.Drawing.Color.White;
            this.bookQrCode.InitialImage = null;
            this.bookQrCode.Location = new System.Drawing.Point(3, 4);
            this.bookQrCode.Name = "bookQrCode";
            this.bookQrCode.Size = new System.Drawing.Size(180, 220);
            this.bookQrCode.TabIndex = 30;
            this.bookQrCode.TabStop = false;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // BookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 610);
            this.Controls.Add(this.metroPanel1);
            this.Name = "BookEdit";
            this.Text = "Ном шинэчилэх";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.BookEdit_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookQrCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox cbAuthor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbYear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBrowser;
        public MetroFramework.Controls.MetroTextBox bookBody;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroComboBox cbFlow;
        private MetroFramework.Controls.MetroComboBox cbCompany;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroComboBox cbLang;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroCheckBox bookOut;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroCheckBox bookEsse;
        private MetroFramework.Controls.MetroCheckBox bookBible;
        private MetroFramework.Controls.MetroTextBox bookQty;
        private MetroFramework.Controls.MetroComboBox cbCsub;
        private MetroFramework.Controls.MetroComboBox cbCbasic;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox bookName;
        private System.Windows.Forms.PictureBox bookImage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQrPrinter;
        private System.Windows.Forms.Button btnPrintSetting;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PictureBox bookQrCode;
    }
}