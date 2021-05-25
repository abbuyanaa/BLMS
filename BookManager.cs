using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLMS.Controllers;
using MySql.Data.MySqlClient;

namespace BLMS
{
    public partial class BookManager : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        MySqlDataReader dataReader;
        MySqlCommand command;
        Constants constants = new Constants();
        Image bookImage;
        string getImagePath;
        int book_id;
        
        public BookManager()
        {
            InitializeComponent();
        }

        private void BookManager_Load(object sender, EventArgs e)
        {
            fillBook("");
        }

        private void BookManager_Activated(object sender, EventArgs e)
        {
            fillBook("");
        }

        private void metroGridBook_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            book_id = Convert.ToInt32(metroGridBook.CurrentRow.Cells[0].Value.ToString());
            BookEdit bookEdit = new BookEdit();
            bookEdit.book_id = book_id;
            bookEdit.Show();
        }

        private void fillBook(string value)
        {
            DataTable table = new DataTable();
            table.Rows.Clear();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("№", typeof(int));
            table.Columns.Add("Зураг", typeof(Image));
            table.Columns.Add("Номны нэр", typeof(string));
            table.Columns.Add("Зохиолч", typeof(string));
            table.Columns.Add("Хэл", typeof(string));
            table.Columns.Add("Үндсэн төрөл", typeof(string));
            table.Columns.Add("Дэд төрөл", typeof(string));
            table.Columns.Add("Байгууллага", typeof(string));
            table.Columns.Add("Урсгал чиглэл", typeof(string));

            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append("SELECT b.id, b.image, b.name AS bname, a.name AS aname, l.name AS lname, ");
            sb.Append("cb.name AS cbname, cs.name AS csname, c.name AS cname, bf.name AS bfname ");
            sb.Append("FROM book AS b ");
            sb.Append("INNER JOIN book_details AS bd ON bd.book_id = b.id ");
            sb.Append("INNER JOIN authors AS a ON a.id = bd.author_id ");
            sb.Append("INNER JOIN languages AS l ON l.id = bd.lang_id ");
            sb.Append("INNER JOIN category_basic AS cb ON cb.id = bd.basic_id ");
            sb.Append("INNER JOIN category_sub AS cs ON cs.id = bd.sub_id ");
            sb.Append("INNER JOIN company AS c ON c.id = bd.company_id ");
            sb.Append("INNER JOIN book_flow AS bf ON bf.id = bd.flow_id ");
            sb.Append("WHERE b.status='0' ");
            if (!value.Equals(""))
            {
                sb.Append("AND CONCAT(b.name,a.name,l.name,cb.name,cs.name,c.name,bf.name) LIKE '%" + value + "%' ");
                sb.Append("ORDER BY b.name ASC");
            }
            else
            {
                sb.Append("ORDER BY b.id DESC LIMIT 20");
            }
            using (command = new MySqlCommand(sb.ToString(), con))
            {
                con.Close();
                if (con.State == ConnectionState.Closed) con.Open();
                dataReader = command.ExecuteReader();
                int i = 1;

                while (dataReader.Read())
                {
                    string bookName = dataReader.GetString("bname");

                    int id = dataReader.GetInt32("id");

                    getImagePath = dataReader.GetString("image");
                    bookImage = constants.checkBookImage(getImagePath, 80, 100);

                    table.Rows.Add(id, i, bookImage,
                        constants.firstCharToUpper(bookName),
                        constants.firstCharToUpper(dataReader.GetString("aname")),
                        constants.firstCharToUpper(dataReader.GetString("lname")),
                        constants.firstCharToUpper(dataReader.GetString("cbname")),
                        constants.firstCharToUpper(dataReader.GetString("csname")),
                        constants.firstCharToUpper(dataReader.GetString("cname")),
                        constants.firstCharToUpper(dataReader.GetString("bfname"))
                    );
                    i++;
                }
                metroGridBook.DataSource = table;
                metroGridBook.Columns["ID"].Visible = false;
                metroGridBook.Columns[1].Width = 80; // Numbers
                metroGridBook.Columns[2].Width = 80; // Images
                metroGridBook.Columns[3].Width = 150; // Names
                metroGridBook.Columns[4].Width = 100; // Authors
                metroGridBook.Columns[5].Width = 60; // Languages
                metroGridBook.Columns[6].Width = 150; // Category Basic
                metroGridBook.Columns[7].Width = 150; // Category Sub
                metroGridBook.Columns[8].Width = 100; // Company
                metroGridBook.Columns[9].Width = 150; // Flow
                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookAdd bookAdd = new BookAdd();
            bookAdd.Show();
        }

        private void bookName_TextChanged(object sender, EventArgs e)
        {
            fillBook(bookName.Text);
        }
    }
}
