using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using BLMS.Controllers;
using MySql.Data.MySqlClient;
using System.IO;

namespace BLMS
{
    public partial class BookReturn : MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        BookController bookController = new BookController();
        Constants constants = new Constants();
        MySqlDataReader dataReader;
        MySqlCommand command;
        DataTable bookRent, bookReturn;
        Image userImage, bookImage;

        public static int user_code = 1202001;
        int bookTotalCount = 0;
        int bookTotalDay = 0;
        int bookTotalPrice = 0;

        int book_price = 0;
        DateTime current_date = DateTime.Now;
        DateTime overdue_date;
        int diffDays;
        int calc;

        public BookReturn()
        {
            InitializeComponent();
        }

        private void BookReturn_Load(object sender, EventArgs e)
        {
            // Book Rent Table
            bookRent = new DataTable();
            bookRent.Columns.Add("ID", typeof(int));
            bookRent.Columns.Add("Зураг", typeof(Image));
            bookRent.Columns.Add("Номны нэр", typeof(string));
            bookRent.Columns.Add("Зохиолч", typeof(string));
            bookRent.Columns.Add("Байгууллага", typeof(string));
            bookRent.Columns.Add("Авсан өдөр", typeof(string));
            bookRent.Columns.Add("Буцаах өдөр", typeof(string));

            metroGridBookRent.DataSource = bookRent;

            metroGridBookRent.Columns["ID"].Visible = false;
            metroGridBookRent.Columns[1].Width = 80;
            metroGridBookRent.Columns[2].Width = 100;
            metroGridBookRent.Columns[3].Width = 100;
            metroGridBookRent.Columns[4].Width = 100;
            metroGridBookRent.Columns[5].Width = 100;
            metroGridBookRent.Columns[6].Width = 100;

            // Book Return Table
            bookReturn = new DataTable();
            bookReturn.Columns.Add("RID", typeof(int));
            bookReturn.Columns.Add("BID", typeof(int));
            bookReturn.Columns.Add("Зураг", typeof(Image));
            bookReturn.Columns.Add("Номны нэр", typeof(string));
            bookReturn.Columns.Add("Хэтэрсэн хоног", typeof(int));
            bookReturn.Columns.Add("Төлбөр", typeof(int));

            metroGridBookReturn.DataSource = bookReturn;

            metroGridBookReturn.Columns["BID"].Visible = false;
            metroGridBookReturn.Columns["RID"].Visible = false;
            metroGridBookReturn.Columns[2].Width = 80;
            metroGridBookReturn.Columns[3].Width = 100;
            metroGridBookReturn.Columns[4].Width = 100;
            metroGridBookReturn.Columns[5].Width = 100;
        }

        private void btnUserCheck_Click(object sender, EventArgs e)
        {
            if (!userCode.Text.Equals("")) {
                user_code = Convert.ToInt32(userCode.Text);
                if (!bookController.userCodeCheck(user_code.ToString()))
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "Хэрэглэгчийн код олдсонгүй!", "Анхаар!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string query = "" +
                        "SELECT u.profile, u.first_name, u.last_name, u.phone, angi.name AS aname, ut.book_price " +
                        "FROM users AS u " +
                        "INNER JOIN burtgel AS bl ON bl.user_id = u.id " +
                        "INNER JOIN angi ON angi.id = bl.angi_id " +
                        "INNER JOIN users_type AS ut ON ut.id = u.type_id " +
                        "WHERE bl.code = '" + user_code + "'";
                    using (command = new MySqlCommand(query, con))
                    {
                        con.Open();
                        dataReader = command.ExecuteReader();
                        if (dataReader.Read())
                        {
                            string fname = constants.firstCharToUpper(dataReader.GetString("first_name"));
                            string lname = constants.firstCharToUpper(dataReader.GetString("last_name"));

                            userFLname.Text = "Овог нэр: " + lname + " " + fname;
                            userAngi.Text = "Анги : " + constants.firstCharToUpper(dataReader.GetString("aname"));
                            userPhone.Text = "Утас : " + dataReader.GetString("phone");

                            book_price = dataReader.GetInt32("book_price");

                            string getImagePath = dataReader.GetString("profile");
                            userImage = constants.checkUserImage(getImagePath, 200, 260);
                            userProfile.Image = userImage;
                        }
                        con.Close();
                    }
                    metroGridBookRent.DataSource = userRentBook(user_code);
                    bookCode.Enabled = true;
                    bookCode.Focus();
                }
            }
        }

        public DataTable userRentBook(int usercode)
        {
            bookRent.Rows.Clear();
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
                    bookRent.Rows.Add(id, bookImage,
                        dataReader.GetString("name"),
                        dataReader.GetString("aname"),
                        dataReader.GetString("cname"),
                        dataReader.GetString("ogson_date"),
                        dataReader.GetString("awah_date")
                        );
                }
                con.Close();
            }
            return bookRent;
        }

        private bool returnBookCheck(int book_code)
        {
            for (int i = 0; i < metroGridBookReturn.Rows.Count; i++)
            {
                int index = Convert.ToInt32(metroGridBookReturn.Rows[i].Cells[0].Value);
                if (index == book_code)
                {
                    Console.WriteLine("ID: " + index);
                    return true;
                }
            }
            return false;
        }

        private void btnBookAwah_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < metroGridBookReturn.Rows.Count; i++)
            {
                int rent_id = Convert.ToInt32(metroGridBookReturn.Rows[i].Cells[1].Value);
                int book_day = Convert.ToInt32(metroGridBookReturn.Rows[i].Cells[4].Value);
                int book_price = Convert.ToInt32(metroGridBookReturn.Rows[i].Cells[5].Value);
                Console.WriteLine("Book ID: " + rent_id + ", Day: " + book_day + ", Price: " + book_price);

                string query = "UPDATE `book_rent` " +
                    "SET `overdue_date`='" + book_day + "',`price`='" + book_price + "',`status`='1' " +
                    "WHERE `id`='" + rent_id + "'";
                using (command = new MySqlCommand(query, con))
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            MetroFramework.MetroMessageBox.Show(this,
                "Мэдээллийн санд амжилттай хадгалагдлаа!", "Анхаар!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bookCode_KeyDown(object sender, KeyEventArgs e)
        {
            string code = bookCode.Text;
            if (!code.Equals(""))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!bookController.userBookCheck(user_code.ToString(), code))
                    {
                        bookCode.Text = null;
                        MetroFramework.MetroMessageBox.Show(this,
                            "Ном таарахгүй байна!", "Анхаар!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bookCode.Focus();
                    }
                    else if (returnBookCheck(Convert.ToInt32(code)))
                    {
                        bookCode.Text = null;
                        MetroFramework.MetroMessageBox.Show(this,
                            "Буцаах жагсаалтанд оруулсан байна!", "Анхаар!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bookCode.Focus();
                    }
                    else
                    {
                        bookOverdueQty.Visible = true;
                        bookOverdueDay.Visible = true;
                        bookOverduePrice.Visible = true;
                        string query = "" +
                            "SELECT b.id bid, br.id rid, b.name, b.image, br.ogson_date, br.awah_date " +
                            "FROM book_rent AS br " +
                            "INNER JOIN book AS b ON b.id = br.book_code " +
                            "WHERE br.user_code='" + user_code + "' AND br.book_code='" + code + "' AND b.status='0'";
                        using (command = new MySqlCommand(query, con))
                        {
                            con.Open();
                            dataReader = command.ExecuteReader();
                            if (dataReader.Read())
                            {
                                int bid = Convert.ToInt32(dataReader.GetInt32("bid"));
                                int rid = Convert.ToInt32(dataReader.GetInt32("rid"));
                                string awah_date = dataReader.GetString("awah_date");
                                overdue_date = Convert.ToDateTime(awah_date);
                                
                                diffDays = ((TimeSpan) (current_date - overdue_date)).Days;

                                string getImagePath = dataReader.GetString("image");
                                bookImage = constants.checkBookImage(getImagePath, 80, 100);

                                if (diffDays > 0)
                                {
                                    bookTotalCount++;
                                    bookTotalDay += diffDays;

                                    calc = diffDays * book_price;
                                    bookTotalPrice += calc;
                                    bookReturn.Rows.Add(bid, rid, bookImage,
                                        constants.firstCharToUpper(dataReader.GetString("name")),
                                        diffDays, calc
                                        );
                                }
                                else
                                {
                                    diffDays = 0;
                                    calc = 0;
                                    bookReturn.Rows.Add(bid, rid, bookImage,
                                        constants.firstCharToUpper(dataReader.GetString("name")),
                                        diffDays, calc
                                        );
                                }

                                bookOverdueQty.Text = "Хэтэрсэн номын тоо : " + bookTotalCount;
                                bookOverdueDay.Text = "Хоног : " + bookTotalDay;
                                bookOverduePrice.Text = "Төлбөр : " + bookTotalPrice + "₮";

                                Console.WriteLine("");
                                bookCode.Text = null;
                            }
                            con.Close();
                        }
                    }
                }
            }
        }
    }
}
