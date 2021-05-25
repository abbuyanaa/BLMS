using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;

namespace BLMS.Controllers
{
    class AuthorController
    {
        MySqlConnection con = MyConnection.getConnection();
        MySqlDataReader dr;
        MySqlCommand command;

        // Check Null Data
        public bool verifyData(string text)
        {
            return !text.Equals("");
        }

        // Exist Data
        public bool existData(string text)
        {
            command = new MySqlCommand("SELECT * FROM `authors` WHERE `name`=@name", con);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = text;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            dr = command.ExecuteReader();
            if (dr.HasRows)
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
        public void store(string name)
        {
            if (!verifyData(name))
            {
                showMessage("Утга хоосон байна!");
            }
            else if (existData(name))
            {
            }
            else
            {
                using (command = new MySqlCommand("INSERT INTO `authors`(`name`) VALUES (@name)", con))
                {
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    executeQuery(command, "Зохиолч амжилттай нэмэгдлээ.");
                }
            }
        }

        // Update to DB
        public void update(int basic_id, string name)
        {
            if (basic_id != 0)
            {
                command = new MySqlCommand("UPDATE `authors` SET `name`=@name WHERE `id`=@id", con);
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Convert.ToString(basic_id);
                executeQuery(command, "Мэдээлэл амжилттай шинэчилэгдлээ.");
            }
            else
            {
                showMessage("Жагсаалтаас сонгоно уу!");
            }
        }

        // Delete Data
        public void delete(int author_id)
        {
            try
            {
                if (author_id != 0)
                {
                    //dr = MessageBox.Show("Та жагсаалтаас хасахдаа итгэлтэй байна уу?", "Зохиолч хасах", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //if (dr == DialogResult.Yes)
                    //{
                    //    command = new MySqlCommand("DELETE FROM `authors` WHERE `id`=@id", con);
                    //    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Convert.ToString(author_id);
                    //    executeQuery(command, "Мэдээлэл амжилттай устгагдлаа.");
                    //}
                }
                else
                {
                    showMessage("Жагсаалтаас сонгоно уу!");
                }
            }
            catch (Exception ex)
            {
                showMessage(ex.Message);
            }
        }

        private void executeQuery(MySqlCommand command, string myMsg)
        {
            con.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                showMessage(myMsg);
            }
            else
            {
                showMessage("Мэдээлэлтэй харьцахад алдаа гарлаа!");
            }
            con.Close();
            AuthorForm author = new AuthorForm();
            author.metroGridAuthor.DataSource = data("");
        }

        public DataTable data(string search)
        {
            DataTable table = new DataTable();
            using (command = new MySqlCommand("SELECT * FROM `authors` WHERE `name` LIKE '%" + search + "%' ORDER BY `id` DESC", con))
            {
                con.Open();
                dr = command.ExecuteReader();

                table.Columns.Add("№", typeof(int));
                table.Columns.Add("Үндсэн төрөл", typeof(string));

                if (dr.HasRows)
                {
                    table.Clear();
                    int i = 1;
                    while (dr.Read())
                    {
                        table.Rows.Add(i, firstCharToUpper(dr.GetString("name")));
                        i++;
                    }
                }
                con.Close();
            }
            return table;
        }

        private void showMessage(String text)
        {
            MessageBox.Show(text);
        }

        /**
         * First Char Uppercase
         */
        public static string firstCharToUpper(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("ARGH!");
            return text.First().ToString().ToUpper() + text.Substring(1);
        }
    }
}
