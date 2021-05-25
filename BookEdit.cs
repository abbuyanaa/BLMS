using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BLMS.Controllers;
using System.IO;

namespace BLMS
{
    public partial class BookEdit : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        BookController bookController = new BookController();
        MySqlDataReader dataReader;
        MySqlCommand command;

        Constants constants = new Constants();
        public int book_id;
        Image image;

        // Image var
        int current_year = DateTime.Now.Year;
        string datetime = DateTime.Now.ToString("yyyy_MM_dd_H_ss");
        string getImagePath, uploadImagePath, fileName, delImagePath;
        string getAuthor, getLang, getCbasic, getCsub, getCompany, getFlow;
        int bookAuthor, bookCompany, bookCbasic, bookCsub, bookFlow, bookLang, bookYear;
        int book_bible = 0, book_esse = 0, book_out = 0;

        public BookEdit()
        {
            InitializeComponent();
        }

        private void BookEdit_Load(object sender, EventArgs e)
        {
            // ComboBoxes select
            constants.selectComboBoxes(cbAuthor, "authors");
            constants.selectComboBoxes(cbCompany, "company");
            constants.selectComboBoxes(cbCbasic, "category_basic");
            constants.selectComboBoxes(cbLang, "languages");
            constants.selectComboBoxes(cbFlow, "book_flow");

            // Year
            for (int pyear = 1900; pyear <= current_year + 1; pyear++)
                cbYear.Items.Add(pyear);
            cbYear.SelectedIndex = 0;

            string query = "" +
                "SELECT b.id, b.name, b.tailbar, b.year, b.qty, b.book_out, b.image, " +
                "bd.bible, bd.esse, a.name AS aname, l.name AS lname, cb.name AS cbname, cs.name AS csname, " +
                "c.name AS cname, bf.name AS bfname FROM book AS b " +
                "INNER JOIN book_details AS bd ON bd.book_id = b.id " +
                "INNER JOIN authors AS a ON a.id = bd.author_id " +
                "INNER JOIN languages AS l ON l.id = bd.lang_id " +
                "INNER JOIN category_basic AS cb ON cb.id = bd.basic_id " +
                "INNER JOIN category_sub AS cs ON cs.id = bd.sub_id " +
                "INNER JOIN company AS c ON c.id = bd.company_id " +
                "INNER JOIN book_flow AS bf ON bf.id = bd.flow_id " +
                "WHERE b.id = '" + book_id + "'";

            using (command = new MySqlCommand(query, con))
            {
                con.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    bookName.Text = dataReader.GetString("name");
                    bookBody.Text = dataReader.GetString("tailbar");
                    bookQty.Text = dataReader.GetString("qty");
                    cbYear.SelectedItem = dataReader.GetInt32("year");

                    if (dataReader.GetInt32("book_out") == 0) bookOut.Checked = false;
                    else bookOut.Checked = true;

                    if (dataReader.GetInt32("bible") == 0) bookBible.Checked = false;
                    else bookBible.Checked = true;

                    if (dataReader.GetInt32("esse") == 0) bookEsse.Checked = false;
                    else bookEsse.Checked = true;

                    getImagePath = dataReader.GetString("image");
                    bookImage.Image = constants.checkBookImage(getImagePath, 200, 260);

                    getAuthor = dataReader.GetString("aname");
                    getCompany = dataReader.GetString("cname");
                    getLang = dataReader.GetString("lname");
                    getCbasic = dataReader.GetString("cbname");
                    getCsub = dataReader.GetString("csname");
                    getFlow = dataReader.GetString("bfname");
                }
                con.Close();
                cbAuthor.SelectedItem = constants.firstCharToUpper(getAuthor);
                cbCompany.SelectedItem = constants.firstCharToUpper(getCompany);
                cbCbasic.SelectedItem = constants.firstCharToUpper(getCbasic);
                cbCsub.SelectedItem = constants.firstCharToUpper(getCsub);
                cbLang.SelectedItem = constants.firstCharToUpper(getLang);
                cbFlow.SelectedItem = constants.firstCharToUpper(getFlow);
            }

            QRCoder.QRCodeGenerator qrCodeGenerator = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData qrCodeData = qrCodeGenerator.CreateQrCode(book_id.ToString(), QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData);
            Image img = qrCode.GetGraphic(2);
            bookQrCode.Image = img;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                uploadImagePath = open.FileName;
                
                bookImage.Image = null;
                delImagePath = constants.BOOKSDIR + getImagePath;

                image = Image.FromFile(uploadImagePath);
                image = constants.imageResize(image, 200, 260);

                fileName = datetime + ".jpg";
                string query = "UPDATE book SET image='" + fileName + "' WHERE id='" + book_id + "'";
                using (command = new MySqlCommand(query, con))
                {
                    con.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        uploadImagePath = constants.BOOKSDIR + fileName;
                        image.Save(uploadImagePath);
                        bookImage.Image = Image.FromFile(uploadImagePath);
                        MetroFramework.MetroMessageBox.Show(this,
                            "Зураг амжилттай шинэчиллээ!", "Анхаар!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (File.Exists(delImagePath))
                        {
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            File.SetAttributes(delImagePath, FileAttributes.Normal);
                            File.Delete(delImagePath);
                        }
                    }
                    con.Close();
                }
            }
        }

        private void btnPrintSetting_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void btnQrPrinter_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(bookQrCode.Width - 10, bookQrCode.Height - 10);
            Font fb = new Font("Times New Roman", 8f, FontStyle.Bold, GraphicsUnit.Pixel);
            Font fn = new Font("Times New Roman", 8f, FontStyle.Regular, GraphicsUnit.Pixel);

            string pBasic = cbCbasic.SelectedItem.ToString();
            string pSub = cbCsub.SelectedItem.ToString();

            int marginTop = 2;
            int marginLeft = -3;

            SolidBrush sb = new SolidBrush(Color.Black);
            bookQrCode.DrawToBitmap(bmp, new Rectangle(0, 0, bookQrCode.Width - 10, bookQrCode.Height - 10));
            e.Graphics.DrawImage(bmp, marginLeft, marginTop); // (X, Y)

            marginLeft += 55;
            marginTop += 6;
            e.Graphics.DrawString("Үндсэн төрөл:", fb, sb, marginLeft, marginTop);

            marginTop += 8;
            e.Graphics.DrawString(pBasic, fn, sb, marginLeft, marginTop);

            marginTop += 10;
            e.Graphics.DrawString("Дэд төрөл:", fb, sb, marginLeft, marginTop);

            marginTop += 8;
            e.Graphics.DrawString(pSub, fn, sb, marginLeft, marginTop);

            marginTop += 10;
            e.Graphics.DrawString("Код:", fb, sb, marginLeft, marginTop);

            marginLeft += 18; marginTop++;
            e.Graphics.DrawString(book_id.ToString(), fn, sb, marginLeft, marginTop);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = bookName.Text;
            string body = bookBody.Text;
            string qty = bookQty.Text;
            if (bookBible.Checked) book_bible = 1;
            if (bookEsse.Checked) book_esse = 1;
            if (bookOut.Checked) book_out = 1;
            bookController.update(book_id,
                name, body, qty, bookAuthor, bookCompany, bookCbasic, bookCsub, bookLang,
                bookFlow, bookYear, book_bible, book_esse, book_out, bookImage
                );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bookController.delete(book_id);
        }

        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string author = cbAuthor.SelectedItem.ToString();
            bookAuthor = constants.getComboBoxID("authors", 0, author);
            Console.WriteLine("Book Edit author: " + bookAuthor);
        }

        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string company = cbCompany.SelectedItem.ToString();
            bookCompany = constants.getComboBoxID("company", 0, company);
            Console.WriteLine("Book Edit company: " + bookCompany);
        }

        private void cbCbasic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbasic = cbCbasic.SelectedItem.ToString();
            bookCbasic = constants.getComboBoxID("category_basic", 0, cbasic);
            Console.WriteLine("Book Edit cbasic: " + bookCbasic);

            // Category Sub
            if (con.State == ConnectionState.Open) con.Close();
            string query = ""
            + "SELECT cs.* FROM category_basic AS cb "
            + "INNER JOIN category AS c ON c.basic_id = cb.id "
            + "INNER JOIN category_sub AS cs ON cs.id = c.sub_id "
            + "WHERE cb.id = '" + bookCbasic + "' ORDER BY cs.name ASC";
            using (command = new MySqlCommand(query, con))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                dataReader = command.ExecuteReader();
                cbCsub.Items.Clear();
                while (dataReader.Read())
                {
                    cbCsub.Items.Add(constants.firstCharToUpper(dataReader.GetString("name")));
                }
                cbCsub.SelectedIndex = 0;
                con.Close();
            }
        }

        private void cbCsub_SelectedIndexChanged(object sender, EventArgs e)
        {
            string csub = cbCsub.SelectedItem.ToString();
            bookCsub = constants.getComboBoxID("category_sub", bookCbasic, csub);
            Console.WriteLine("Book Edit csub: " + bookCsub);
        }

        private void cbFlow_SelectedIndexChanged(object sender, EventArgs e)
        {
            string flow = cbFlow.SelectedItem.ToString();
            bookFlow = constants.getComboBoxID("book_flow", 0, flow);
            Console.WriteLine("Book Edit flow: " + bookFlow);
        }

        private void cbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lang = cbLang.SelectedItem.ToString();
            bookLang = constants.getComboBoxID("languages", 0, lang);
            Console.WriteLine("Book Edit lang: " + bookLang);
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookYear = Convert.ToInt32(cbYear.SelectedItem.ToString());
            Console.WriteLine("Book Edit year: " + bookYear.ToString());
        }
    }
}
