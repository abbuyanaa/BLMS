using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLMS.Controllers;
using MySql.Data.MySqlClient;

namespace BLMS
{
    public partial class BookRent : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        BookController bookController = new BookController();
        Constants constants = new Constants();
        MySqlDataReader dataReader;
        MySqlCommand command;
        DialogResult dr;
        DataTable table;
        Image userImage, bookImage;

        string user_type = "";
        int user_day = 0, user_qty = 0;
        int user_code = 0;

        public BookRent()
        {
            InitializeComponent();
        }

        private void BookRent_Load(object sender, EventArgs e)
        {
            userCode.Focus();
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Зураг", typeof(Image));
            table.Columns.Add("Номны нэр", typeof(string));
            table.Columns.Add("Зохиолч", typeof(string));
            table.Columns.Add("Байгууллага", typeof(string));
            table.Columns.Add("Он", typeof(int));
            table.Columns.Add("Авсан өдөр", typeof(string));
            table.Columns.Add("Буцаах өдөр", typeof(string));

            metroGridBook.DataSource = table;

            metroGridBook.Columns["ID"].Visible = false;
            metroGridBook.Columns[1].Width = 80;
            metroGridBook.Columns[2].Width = 100;
            metroGridBook.Columns[3].Width = 100;
            metroGridBook.Columns[4].Width = 200;
            metroGridBook.Columns[5].Width = 100;
            metroGridBook.Columns[6].Width = 100;
            metroGridBook.Columns[7].Width = 100;
        }

        private void btnCheckUser_Click(object sender, EventArgs e)
        {
            string usercode = userCode.Text;
            Console.WriteLine("Book Rent usercode: " + usercode);
            if (!usercode.Equals(""))
            {
                if (!bookController.userCodeCheck(usercode))
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "Хэрэглэгчийн код олдсонгүй!", "Анхаар!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string query = "SELECT bg.id, u.first_name, u.last_name, u.phone, u.profile, ut.* FROM users AS u " +
                        "INNER JOIN burtgel AS bg ON bg.user_id = u.id " +
                        "INNER JOIN angi ON angi.id = bg.angi_id " +
                        "INNER JOIN users_type AS ut ON ut.id = u.type_id " +
                        "WHERE bg.code = '" + usercode + "'";
                    using (command = new MySqlCommand(query, con))
                    {
                        con.Open();
                        dataReader = command.ExecuteReader();

                        if (dataReader.Read())
                        {
                            user_code = Convert.ToInt32(usercode);
                            string lname = constants.firstCharToUpper(dataReader.GetString("last_name"));
                            string fname = constants.firstCharToUpper(dataReader.GetString("first_name"));
                            lbUsername.Text = "Овог нэр: " + lname + " " + fname;
                            lbUserPhone.Text = "Утас : " + dataReader.GetString("phone");

                            user_type = constants.firstCharToUpper(dataReader.GetString("name"));
                            user_day = dataReader.GetInt32("book_day");
                            user_qty = dataReader.GetInt32("book_count");

                            lbUserType.Text = "Төрөл : " + user_type;
                            lbUserDay.Text = "Хоног : " + user_day;
                            
                            string getImagePath = dataReader.GetString("profile");
                            userImage = constants.checkUserImage(getImagePath, 80, 100);
                            userProfile.Image = userImage;

                            bookCode.Enabled = true;
                            btnRent.Enabled = true;
                            bookCode.Focus();
                        }
                        con.Close();
                    }
                    metroGridBook.DataSource = userRentBook(Convert.ToInt32(usercode));
                }
            }
        }

        public DataTable userRentBook(int usercode)
        {
            table.Rows.Clear();
            string query = "" +
                "SELECT br.id, b.image, b.name, a.name AS aname, c.name AS cname, b.year, " +
                "br.ogson_date, br.awah_date FROM book AS b " +
                "INNER JOIN book_details AS bd ON bd.book_id = b.id " +
                "INNER JOIN authors AS a ON a.id = bd.author_id " +
                "INNER JOIN company AS c ON c.id = bd.company_id " +
                "INNER JOIN book_rent AS br ON br.book_code = b.id " +
                "WHERE br.user_code = '" + usercode + "' AND br.status = '0'";
            using (command = new MySqlCommand(query, con))
            {
                con.Close();
                if (con.State == ConnectionState.Closed) con.Open();
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string getImagePath = dataReader.GetString("image");

                    bookImage = constants.checkBookImage(getImagePath, 80, 100);

                    int id = Convert.ToInt32(dataReader.GetInt32("id"));
                    table.Rows.Add(id, bookImage,
                        dataReader.GetString("name"),
                        dataReader.GetString("aname"),
                        dataReader.GetString("cname"),
                        dataReader.GetInt32("year"),
                        dataReader.GetString("ogson_date"),
                        dataReader.GetString("awah_date")
                        );
                }
                con.Close();
            }
            return table;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroGridBook_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = Convert.ToInt32(metroGridBook.CurrentRow.Cells[0].Value.ToString());
            if (index != 0)
            {
                dr = MetroFramework.MetroMessageBox.Show(this,
                        "Та жагсаалтаас хасахдаа итгэлтэй байна уу?", "Анхаар!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string query = "DELETE FROM `book_rent` WHERE `id`='" + index + "'";
                    using (command = new MySqlCommand(query, con))
                    {
                        con.Open();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this,
                                "Жагсаалтаас хасагдлаа!", "Анхаар!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            metroGridBook.DataSource = userRentBook(Convert.ToInt32(user_code));
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this,
                                "Алдаа гарлаа!", "Анхаар!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        con.Close();
                    }
                }
            }
        }

        private void bookCode_KeyDown(object sender, KeyEventArgs e)
        {
            string code = bookCode.Text;
            if (!code.Equals(""))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    insertBook(user_code, Convert.ToInt32(code));
                }
            }
        }

        public static DateTime AddBusinessDays(DateTime date, int daysToAdd)
        {
            while (daysToAdd > 0)
            {
                date = date.AddDays(1);

                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    daysToAdd -= 1;
                }
            }
            return date;
        }

        private void insertBook(int user_code, int book_code)
        {
            int count = bookController.userBookCount(user_code);

            string ogson_date = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime date = AddBusinessDays(DateTime.Now, user_day);
            string awah_date = date.ToString("yyyy-MM-dd");

            if (count == user_qty)
            {
                MetroFramework.MetroMessageBox.Show(this,
                    user_type + " ном авч болох хязгаарт хүрсэн байна!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bookController.userBookCheck(user_code.ToString(), book_code.ToString()))
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "Бүртгэгдсэн байна!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "" +
                        "INSERT INTO `book_rent` " +
                        "(`user_code`, `book_code`, `ogson_date`, `awah_date`, `created_at`) values " +
                        "(@user, @book, @ogson_date, @awsan_date, NOW())";
                using (command = new MySqlCommand(query, con))
                {
                    command.Parameters.Add("@user", MySqlDbType.VarChar).Value = user_code;
                    command.Parameters.Add("@book", MySqlDbType.VarChar).Value = book_code;
                    command.Parameters.Add("@ogson_date", MySqlDbType.VarChar).Value = ogson_date;
                    command.Parameters.Add("@awsan_date", MySqlDbType.VarChar).Value = awah_date;

                    con.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this,
                            "Ном амжилттай хадгалагдлаа.", "Баяр хүргье!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroGridBook.DataSource = userRentBook(Convert.ToInt32(user_code));
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this,
                            "Мэдээлэл оруулахад алдаа гарлаа!", "Анхаар!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                }
            }
            bookCode.Text = null;
            bookCode.Focus();
        }
    }
}
