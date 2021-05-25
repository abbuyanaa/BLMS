using MetroFramework.Controls;
using System;
using System.Data;
using System.Drawing; // Image
using System.Linq;
using System.Windows.Forms; // OpenFileDialog
using MySql.Data.MySqlClient;
using System.IO;

namespace BLMS.Controllers
{
    class Constants
    {
        MySqlConnection con = MyConnection.getConnection();
        MySqlDataReader dataReader;
        MySqlCommand command;

        public string BOOKSDIR = @"C:/BLMS/Books/";
        public string USERSDIR = @"C:/BLMS/Books/";
        public string IMAGEUSER = @"C:/BLMS/userimage.jpg";
        public string IMAGEBOOK = @"C:/BLMS/bookimage.jpg";

        string query;
        // 1MB size
        int FileSize = 1048576;

        /**
         * First Word Uppercase
         */
        public string firstCharToUpper(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("ARGH!");
            return text.First().ToString().ToUpper() + text.Substring(1);
        }

        /**
         * MetroTextBox Pressed Only Numbers
         */
        public void pressedNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((MetroTextBox)sender).Text.Contains('.'))
            {
                // Allow only one Dot Char
            }
            else
            {
                e.Handled = true;
            }
        }

        /**
         * Browser Image
         */
        public void browserImage(PictureBox pictureBox)
        {
            Image imageOriginal;
            using (OpenFileDialog opf = new OpenFileDialog() { ValidateNames = true, Multiselect = false })
            {
                opf.Filter = "Зурагны өргөтгөл(*.JPG;*.JPEG;*.PNG;*.GIF)|*.jpg;*.jpeg;*.png;*.gif;";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = opf.FileName;
                    imageOriginal = Image.FromFile(imagePath);
                    var fileLength = new FileInfo(imagePath).Length;
                    if (fileLength < FileSize)
                    {
                        Console.WriteLine("Chosed image size 1MB: " + fileLength.ToString());
                        pictureBox.Image = imageOriginal;
                    }
                    else
                    {
                        MessageBox.Show("Зураг хэтэрхий том хэмжээтэй байна!");
                    }
                }
                else
                {
                    MessageBox.Show("Зураг цуцлагдлаа!");
                }
            }
        }
        public Bitmap resizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }
            return result;
        }

        public Image imageResize(Image image, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, w, h);
            graphic.Dispose();
            image = bmp;
            return image;
        }

        public void selectComboBoxes(ComboBox cb, string table)
        {
            query = "SELECT * FROM " + table + " ORDER BY name ASC";
            using (command = new MySqlCommand(query, con))
            {
                cb.Items.Clear();
                con.Close();
                if (con.State == ConnectionState.Closed) con.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cb.Items.Add(firstCharToUpper(dataReader.GetString("name")));
                }
                cb.SelectedIndex = 0;
                con.Close();
            }
        }

        public void getComboBoxes(ComboBox cb, string table)
        {
            query = "SELECT * FROM `" + table + "` ORDER BY `name` ASC";
            using (command = new MySqlCommand(query, con))
            {
                cb.Items.Clear();
                con.Close();
                if (con.State == ConnectionState.Closed) con.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cb.Items.Add(firstCharToUpper(dataReader.GetString("name")));
                }
                con.Close();
            }
        }

        public int getComboBoxID(string table, int basic_id, string name)
        {
            string query;
            if (basic_id == 0)
            {
                query = "SELECT * FROM `" + table + "` WHERE `name` = '" + name + "'";
            }
            else
            {
                query = ""
                    + "SELECT cs.* FROM category_basic AS cb "
                    + "INNER JOIN category AS c ON c.basic_id = cb.id "
                    + "INNER JOIN category_sub AS cs ON cs.id = c.sub_id "
                    + "WHERE cb.id = '" + basic_id + "' AND cs.name = '" + name + "'";
            }
            using (command = new MySqlCommand(query, con))
            {
                con.Close();
                if (con.State == ConnectionState.Closed) con.Open();

                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    int id = dataReader.GetInt32("id");
                    con.Close();
                    return id;
                }
                else
                {
                    con.Close();
                    return 0;
                }
            }
        }

        public Image checkUserImage(string path, int width, int height)
        {
            Image image;
            string getImagePath = USERSDIR + path;
            if (File.Exists(getImagePath))
            {
                image = Image.FromFile(getImagePath);
            }
            else
            {
                Console.WriteLine("Constants Check User Image : " + getImagePath);
                image = Image.FromFile(IMAGEUSER);
            }
            image = imageResize(image, width, height);
            return image;
        }

        public Image checkBookImage(string path, int width, int height)
        {
            Image image;
            string getImagePath = BOOKSDIR + path;
            if (File.Exists(getImagePath))
            {
                image = Image.FromFile(getImagePath);
            }
            else
            {
                Console.WriteLine("Constants Check Book Image : " + getImagePath);
                image = Image.FromFile(IMAGEBOOK);
            }
            image = imageResize(image, width, height);
            return image;
        }
    }
}
