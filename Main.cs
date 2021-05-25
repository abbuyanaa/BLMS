using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using BLMS.Controllers;
using System.IO;

namespace BLMS
{
    public partial class Main : MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        Constants constants = new Constants();
        MySqlDataReader dataReader;
        MySqlCommand command;
        DataTable table;
        Bitmap oldBitmap, newBitmap;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("Нэр", typeof(string));
            table.Columns.Add("Код", typeof(int));
            table.Columns.Add("Зураг", typeof(Image));
            table.Columns.Add("Номны нэр", typeof(string));
            table.Columns.Add("Ү/төрөл", typeof(string));
            table.Columns.Add("Д/төрөл", typeof(string));
            table.Columns.Add("Статус", typeof(string));
            table.Columns.Add("Ном өгсөн өдөр", typeof(string));
            table.Columns.Add("Буцааж авах өдөр", typeof(string));

            string query = "" +
                "SELECT CONCAT(u.first_name, ' ', u.last_name) AS flname, bl.code, " +
                "b.image, b.name AS bname, cb.name AS cbname, cs.name AS csname, " +
                "ut.name AS tname, br.ogson_date, br.awah_date " +
                "FROM book_rent AS br " +
                "INNER JOIN burtgel AS bl ON bl.code = br.user_code " +
                "INNER JOIN users AS u ON u.id = bl.user_id " +
                "INNER JOIN book AS b ON b.id = br.book_code " +
                "INNER JOIN book_details AS bd ON bd.id = b.id " +
                "INNER JOIN category_basic AS cb ON cb.id = bd.basic_id " +
                "INNER JOIN category_sub AS cs ON cs.id = bd.sub_id " +
                "INNER JOIN users_type AS ut ON ut.id = u.type_id " +
                "WHERE br.status = '0' ORDER BY br.awah_date ASC";
            using (command = new MySqlCommand(query, con))
            {
                con.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string flname = dataReader.GetString("flname");

                    string getImagePath = constants.BOOKSDIR + dataReader.GetString("image");
                    oldBitmap = new Bitmap(getImagePath);
                    newBitmap = constants.resizeBitmap(oldBitmap, 80, 100);

                    int code = dataReader.GetInt32("code");

                    table.Rows.Add(flname, code, newBitmap,
                        constants.firstCharToUpper(dataReader.GetString("bname")),
                        constants.firstCharToUpper(dataReader.GetString("cbname")),
                        constants.firstCharToUpper(dataReader.GetString("csname")),
                        constants.firstCharToUpper(dataReader.GetString("tname")),
                        dataReader.GetString("ogson_date"),
                        dataReader.GetString("awah_date")
                        );
                }
                metroGridBook.DataSource = table;
                con.Close();
            }

            metroGridBook.Columns[0].Width = 100;
            metroGridBook.Columns[1].Width = 50;
            metroGridBook.Columns[2].Width = 60;
            metroGridBook.Columns[3].Width = 80;
            metroGridBook.Columns[4].Width = 80;
            metroGridBook.Columns[5].Width = 80;
            metroGridBook.Columns[6].Width = 50;
            metroGridBook.Columns[7].Width = 100;
            metroGridBook.Columns[8].Width = 100;
        }

        private void metroCreated_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.huree.edu.mn/");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string dateString = DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss");
            lbDateTime.Text = "Өнөөдөр: " + dateString;
        }

        private void metroBook_Click(object sender, EventArgs e)
        {
            BookManager book = new BookManager();
            book.ShowDialog();
        }

        private void metroUsers_Click(object sender, EventArgs e)
        {
            UserManager user = new UserManager();
            user.ShowDialog();
        }

        private void metroRent_Click(object sender, EventArgs e)
        {
            BookRent rent = new BookRent();
            rent.ShowDialog();
        }

        private void metroReturn_Click(object sender, EventArgs e)
        {
            BookReturn bookReturn = new BookReturn();
            bookReturn.ShowDialog();
        }

        private void metroUserType_Click(object sender, EventArgs e)
        {
            UserType userType = new UserType();
            userType.ShowDialog();
        }

        private void metroAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm author = new AuthorForm();
            author.ShowDialog();
        }

        private void metroCompany_Click(object sender, EventArgs e)
        {
            CompanyForm company = new CompanyForm();
            company.ShowDialog();
        }

        private void metroCategory_Click(object sender, EventArgs e)
        {
            CbasicForm cbasic = new CbasicForm();
            cbasic.ShowDialog();
        }

        private void metroLang_Click(object sender, EventArgs e)
        {
            LangForm lang = new LangForm();
            lang.ShowDialog();
        }

        private void metroFLow_Click(object sender, EventArgs e)
        {
            BookFlow flow = new BookFlow();
            flow.ShowDialog();
        }

        private void metroUserRegister_Click(object sender, EventArgs e)
        {
            Burtgel burtgel = new Burtgel();
            burtgel.ShowDialog();
        }

        private void metroChurch_Click(object sender, EventArgs e)
        {
            ChuulganForm chuulganForm = new ChuulganForm();
            chuulganForm.ShowDialog();
        }
    }
}
