using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BLMS.Controllers
{
    class BookController
    {
        MySqlConnection con = MyConnection.getConnection();
        MySqlDataReader dataReader;
        Constants constants = new Constants();
        MySqlCommand command;
        DialogResult dr;
        Image image;
        Bitmap oldBitmap, newBitmap;
        string imageName, filePath;
        string datetime = DateTime.Now.ToString("yyyy_MM_dd_H_mm");

        private bool verifyData(string name, string body, string qty)
        {
            if (name.Equals("") || body.Equals("") || qty.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool verifyImage(PictureBox bookImage)
        {
            return bookImage.Image == null;
        }

        private bool bookNameCheck(string name)
        {
            string query = "SELECT * FROM `book` WHERE `name`='" + name + "'";
            using (command = new MySqlCommand(query, con))
            {
                con.Open();
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
        }

        public void store(
            string name, string body, string qty, int author, int company,
            int cbasic, int csub, int lang, int flow, int year, int book_bible,
            int book_esse, int book_out, PictureBox bookImage
            )
        {
            if (verifyData(name, body, qty))
            {
                MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm, "Утга оруулна уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verifyImage(bookImage))
            {
                MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm, "Номны зураг хоосон байна!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bookNameCheck(name))
            {
                MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm, "Номны нэр давхардаж байна!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string book_query = "INSERT INTO `book` "
                    + "(`name`, `tailbar`, `year`, `qty`, `book_out`, `image`, `created_at`) VALUES "
                    + "(@name, @tailbar, @year, @qty, @bookout, @image, NOW())";
                using (command = new MySqlCommand(book_query, con))
                {
                    oldBitmap = new Bitmap(bookImage.Image);
                    newBitmap = constants.resizeBitmap(oldBitmap, 200, 260);
                    image = new Bitmap(newBitmap);

                    // File Name
                    imageName = datetime + ".jpg";
                    
                    // Save File Path
                    filePath = constants.BOOKSDIR + imageName;
                    filePath = filePath.Replace("\\", "\\\\");
                    image.Save(filePath);

                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    command.Parameters.Add("@tailbar", MySqlDbType.VarChar).Value = body;
                    command.Parameters.Add("@year", MySqlDbType.VarChar).Value = year;
                    command.Parameters.Add("@qty", MySqlDbType.VarChar).Value = qty;
                    command.Parameters.Add("@bookout", MySqlDbType.VarChar).Value = book_out;
                    command.Parameters.Add("@image", MySqlDbType.VarChar).Value = imageName;

                    con.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        con.Close();
                        string book_details_query = "INSERT INTO `book_details` "
                            + "(`book_id`, `author_id`, `lang_id`, `basic_id`, `sub_id`, `company_id`, `flow_id`, `esse`, `bible`) VALUES "
                            + "((SELECT `id` FROM `book` ORDER BY `id` DESC LIMIT 1), @author, @lang, @basic, @sub, @company, @flow, @esse, @bible)";
                        using (command = new MySqlCommand(book_details_query, con))
                        {
                            command.Parameters.Add("@author", MySqlDbType.VarChar).Value = author;
                            command.Parameters.Add("@lang", MySqlDbType.VarChar).Value = lang;
                            command.Parameters.Add("@basic", MySqlDbType.VarChar).Value = cbasic;
                            command.Parameters.Add("@sub", MySqlDbType.VarChar).Value = csub;
                            command.Parameters.Add("@company", MySqlDbType.VarChar).Value = company;
                            command.Parameters.Add("@flow", MySqlDbType.VarChar).Value = flow;
                            command.Parameters.Add("@esse", MySqlDbType.VarChar).Value = book_esse;
                            command.Parameters.Add("@bible", MySqlDbType.VarChar).Value = book_bible;
                            executeQuery(command, "Ном амжилттай бүртгэгдлээ.");
                        }
                    }
                    else
                    {
                        con.Close();
                        MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm,
                            "Мэдээллийн сантай харьцахад алдаа гарлаа", "Анхаар!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void update(int book_id,
            string name, string body, string qty, int author, int company,
            int cbasic, int csub, int lang, int flow, int year, int book_bible,
            int book_esse, int book_out, PictureBox bookImage
            )
        {
            if (verifyData(name, body, qty))
            {
                MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm, "Утга оруулна уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string book_query = "UPDATE `book` SET " +
                        "`name`=@name,`tailbar`=@tailbar,`year`=@year,`qty`=@qty," +
                        "`book_out`=@bookout WHERE `id`=@id";
                
                using (command = new MySqlCommand(book_query, con))
                {
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    command.Parameters.Add("@tailbar", MySqlDbType.VarChar).Value = body;
                    command.Parameters.Add("@year", MySqlDbType.VarChar).Value = year;
                    command.Parameters.Add("@qty", MySqlDbType.VarChar).Value = qty;
                    command.Parameters.Add("@bookout", MySqlDbType.VarChar).Value = book_out;
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = book_id;

                    con.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        con.Close();
                        string book_details_query = "UPDATE `book_details` SET " +
                            "`author_id`=@author,`lang_id`=@lang,`basic_id`=@basic,`sub_id`=@sub,`company_id`=@company," +
                            "`flow_id`=@flow,`esse`=@esse,`bible`=@bible WHERE `book_id`=@bookid";
                        using (command = new MySqlCommand(book_details_query, con))
                        {
                            command.Parameters.Add("@author", MySqlDbType.VarChar).Value = author;
                            command.Parameters.Add("@lang", MySqlDbType.VarChar).Value = lang;
                            command.Parameters.Add("@basic", MySqlDbType.VarChar).Value = cbasic;
                            command.Parameters.Add("@sub", MySqlDbType.VarChar).Value = csub;
                            command.Parameters.Add("@company", MySqlDbType.VarChar).Value = company;
                            command.Parameters.Add("@flow", MySqlDbType.VarChar).Value = flow;
                            command.Parameters.Add("@esse", MySqlDbType.VarChar).Value = book_esse;
                            command.Parameters.Add("@bible", MySqlDbType.VarChar).Value = book_bible;
                            command.Parameters.Add("@bookid", MySqlDbType.VarChar).Value = book_id;
                            executeQuery(command, "Ном амжилттай шинэчилэгдлээ.");
                        }
                    }
                    else
                    {
                        con.Close();
                        MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm, "Мэдээллийн сантай харьцахад алдаа гарлаа", "Анхаар!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void delete(int book_id)
        {
            if (book_id != 0)
            {
                dr = MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm,
                    "Номтой холбоотой бүх мэдээлэл устах болно.\nТа жагсаалтаас хасахдаа итгэлтэй байна уу?", "Ном устгах!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    string query = "UPDATE book SET status='1' WHERE id='" + book_id + "'";
                    using (command = new MySqlCommand(query, con))
                    {
                        executeQuery(command, "Ном амжилттай устгалаа");
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm, "Та хасах номоо сонгоно уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void executeQuery(MySqlCommand command, string myMsg)
        {
            con.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm, myMsg, "Баяр хүргье.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm,
                    "Мэдээллийн сантай харьцахад алдаа гарлаа", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }


        /**
         * User Book Rent
         * BookRent
         * BookReturn
         */
        public bool userCodeCheck(string usercode)
        {
            string query = "SELECT * FROM `burtgel` WHERE `code`='" + usercode + "'";
            using (command = new MySqlCommand(query, con))
            {
                con.Open();
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
        }

        /**
         * User Book Check
         * BookRent
         */
        public bool userBookCheck(string user_code, string book_code)
        {
            string query = "SELECT * FROM `book_rent` " +
                "WHERE `user_code`='" + user_code + "' AND `book_code`='" + book_code + "' AND `status`='0'";
            //Console.WriteLine("User Book Rent Check: " + user_code + ", " + book_code);
            using (command = new MySqlCommand(query, con))
            {
                con.Close();
                if (con.State == ConnectionState.Closed) con.Open();
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
        }

        public int userBookCount(int user_code)
        {
            string query = "SELECT COUNT(*) count FROM `book_rent` " +
                "WHERE `user_code`='" + user_code + "' AND `status`='0'";
            using (command = new MySqlCommand(query, con))
            {
                con.Close();
                if (con.State == ConnectionState.Closed) con.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    int count = dataReader.GetInt32("count");
                    con.Close();
                    return count;
                }
                else
                {
                    con.Close();
                    return 0;
                }
            }
        }
    }
}
