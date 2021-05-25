using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLMS.Controllers;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;

namespace BLMS
{
    public partial class UserType : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        Constants constants = new Constants();
        MySqlDataReader dataReader;
        MySqlCommand command;
        DialogResult dataResult;
        int usertype_id;

        public UserType()
        {
            InitializeComponent();
        }

        private void UserType_Load(object sender, EventArgs e)
        {
            metroGridUserType.DataSource = data("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            store(userTypeName.Text, userTypeQty.Text, userTypeDay.Text, userTypePrice.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            update(usertype_id, userTypeName.Text, userTypeQty.Text, userTypeDay.Text, userTypePrice.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete(usertype_id);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void metroGridUserType_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            edit(metroGridUserType.CurrentRow.Cells[1].Value.ToString());
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
        }

        private void clearFields()
        {
            usertype_id = 0;
            userTypeName.Text = null;
            userTypeQty.Text = null;
            userTypeDay.Text = null;
            userTypePrice.Text = null;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
        }

        /**
         * START Database CURD
         */

        // Data from DB
        public DataTable data(string search)
        {
            DataTable table = new DataTable();
            string query = "SELECT * FROM `users_type` WHERE `name` LIKE '%" + search + "%' ORDER BY `id` DESC";
            using (command = new MySqlCommand(query, con))
            {
                con.Open();
                dataReader = command.ExecuteReader();

                table.Columns.Add("№", typeof(int));
                table.Columns.Add("Төрөл", typeof(string));
                table.Columns.Add("Номын тоо", typeof(int));
                table.Columns.Add("Хугацаа (хоног)", typeof(int));
                table.Columns.Add("Үнэ (1ш)", typeof(int));

                if (dataReader.HasRows)
                {
                    table.Clear();
                    int i = 1;
                    while (dataReader.Read())
                    {
                        table.Rows.Add(i, constants.firstCharToUpper(dataReader.GetString("name")),
                            dataReader.GetInt32("book_count"),
                            dataReader.GetInt32("book_day"),
                            dataReader.GetInt32("book_price")
                        );
                        i++;
                    }
                }
                con.Close();
            }
            return table;
        }

        // Check Null Data
        public bool verifyData(string text, string count, string day, string price)
        {
            return !text.Equals("") || !count.Equals("") || !day.Equals("") || !price.Equals("");
        }

        // Exist Data
        public bool existData(string text)
        {
            command = new MySqlCommand("SELECT * FROM `users_type` WHERE `name`=@name", con);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = text;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        // Insert Into DB
        public void store(string name, string count, string day, string price)
        {
            if (!verifyData(name, count, day, price))
            {
                MetroFramework.MetroMessageBox.Show(this, "Утга оруулна уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //else if (existData(name))
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Хэрэглэгчийн төрөл бүртгэлтэй байна!", "Алдаа!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO `users_type` (`name`, `book_count`, `book_day`, `book_price`) VALUES ");
                sb.Append("(@name, @count, @day, @price)");
                using (command = new MySqlCommand(sb.ToString(), con))
                {
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    command.Parameters.Add("@count", MySqlDbType.VarChar).Value = count;
                    command.Parameters.Add("@day", MySqlDbType.VarChar).Value = day;
                    command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                    executeQuery(command, "Хэрэглэгчийн төрөл амжилттай нэмэгдлээ.");
                }
            }
        }

        // Edit from DB
        private void edit(string text)
        {
            string query = "SELECT * FROM `users_type` WHERE `name` = '" + text + "'";
            using (command = new MySqlCommand(query, con))
            {
                con.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    if (dataReader.Read())
                    {
                        usertype_id = dataReader.GetInt32("id");
                        userTypeName.Text = dataReader.GetString("name");
                        userTypeQty.Text = dataReader.GetString("book_count");
                        userTypeDay.Text = dataReader.GetString("book_day");
                        userTypePrice.Text = dataReader.GetString("book_price");
                    }
                }
                con.Close();
            }
        }

        // Update to DB
        public void update(int usertype_id, string name, string count, string day, string price)
        {
            if (usertype_id != 0)
            {
                string query = "UPDATE `users_type` SET `name`=@name,`book_count`=@count,`book_day`=@day,`book_price`=@price WHERE `id`=@id";
                command = new MySqlCommand(query, con);
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@count", MySqlDbType.VarChar).Value = count;
                command.Parameters.Add("@day", MySqlDbType.VarChar).Value = day;
                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = usertype_id;
                executeQuery(command, "Амжилттай шинэчилэгдлээ.");
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Жагсаалтаас сонгоно уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete Data
        public void delete(int usertype_id)
        {
            if (usertype_id != 0)
            {
                dataResult = MetroFramework.MetroMessageBox.Show(this, "Та Хэрэглэгчийн төрөл устгахдаа итгэлтэй байна уу!", "Анхаар!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dataResult == DialogResult.Yes)
                {
                    command = new MySqlCommand("DELETE FROM `users_type` WHERE `id`=@id", con);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = usertype_id;
                    executeQuery(command, "Мэдээлэл амжилттай устгагдлаа.");
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Жагсаалтаас сонгоно уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void executeQuery(MySqlCommand command, String myMsg)
        {
            con.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MetroFramework.MetroMessageBox.Show(this, myMsg, "Баяр хүргье.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Мэдээллийн сантай харьцахад алдаа гарлаа", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
            metroGridUserType.DataSource = data("");
            clearFields();
        }

        private void userTypeQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            constants.pressedNumber(sender, e);
        }

        private void userTypeDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            constants.pressedNumber(sender, e);
        }

        private void userTypePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            constants.pressedNumber(sender, e);
        }
    }
}
