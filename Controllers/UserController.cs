using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using BLMS.Controllers; // UsersController
using MySql.Data.MySqlClient; // MySQL
using System.IO; // MemoryStream
using System.Drawing; // Bitmap

namespace BLMS.Controllers
{
    class UserController
    {
        MySqlConnection con = MyConnection.getConnection();
        Constants constants = new Constants();
        MySqlCommand command;
        DialogResult dr;
        Image image;
        Bitmap oldBitmap, newBitmap;
        string datetime = DateTime.Now.ToString("yyyy_MM_dd_H_ss");
        string fileName, uploadFilePath;

        // Check All Fields
        private bool verifyData(
            string lname, string fname, string regid,
            string phone, string email, string address
            )
        {
            if (lname.Equals("") || fname.Equals("") || regid.Equals("") ||
                phone.Equals("") || email.Equals("") || address.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Check User Profile
        private bool verifyImage(PictureBox profile)
        {
            return profile.Image == null;
        }

        // Insert to DB
        public void store(
            string lname, string fname, string regid, string phone, string email,
            string address, char gender, int userType, int userChuulgan, PictureBox userProfile
            )
        {
            if (verifyData(lname, fname, regid, phone, email, address))
            {
                MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm, "Утга оруулна уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verifyImage(userProfile))
            {
                MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm, "Хэрэглэгчийн зураг хоосон байна!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "INSERT INTO `users` " +
                    "(`first_name`,`last_name`,`email`,`regid`,`address`,`phone`,`gender`," +
                    "`type_id`,`chuulgan_id`, `profile`, `created_at`) VALUES " +
                    "(@fname,@lname,@email,@regid,@address,@phone,@gender,@type,@chuulgan,@profile,NOW())";
                using (command = new MySqlCommand(query, con))
                {
                    oldBitmap = new Bitmap(userProfile.Image);
                    newBitmap = constants.resizeBitmap(oldBitmap, 200, 260);
                    image = new Bitmap(newBitmap);

                    // File Name
                    fileName = datetime + ".jpg";

                    // Save File Path
                    uploadFilePath = constants.USERSDIR + fileName;
                    image.Save(uploadFilePath);

                    command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
                    command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                    command.Parameters.Add("@regid", MySqlDbType.VarChar).Value = regid;
                    command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                    command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
                    command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                    command.Parameters.Add("@type", MySqlDbType.VarChar).Value = userType;
                    command.Parameters.Add("@chuulgan", MySqlDbType.VarChar).Value = userChuulgan;
                    command.Parameters.Add("@profile", MySqlDbType.VarChar).Value = fileName;

                    executeQuery(command, "Амжилттай хэрэглэгч бүртгэлээ.");
                }
            }
        }

        // Update Data
        public void update(int user_id,
            string lname, string fname, string regid, string phone, string email,
            string address, char gender, int userType, int userChuulgan, PictureBox userProfile
            )
        {
            if (verifyData(lname, fname, regid, phone, email, address))
            {
                MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm, "Утга оруулна уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "UPDATE `users` SET " +
                        "`first_name`=@fname,`last_name`=@lname,`email`=@email,`regid`=@regid," +
                        "`address`=@address,`phone`=@phone,`gender`=@gender,`type_id`=@type," +
                        "`chuulgan_id`=@chuulgan WHERE `id`= " + user_id;
                using (command = new MySqlCommand(query, con))
                {
                    command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = lname;
                    command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = fname;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                    command.Parameters.Add("@regid", MySqlDbType.VarChar).Value = regid;
                    command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                    command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
                    command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                    command.Parameters.Add("@type", MySqlDbType.VarChar).Value = userType;
                    command.Parameters.Add("@chuulgan", MySqlDbType.VarChar).Value = userChuulgan;

                    executeQuery(command, "Хэрэглэгчийн мэдээлэл амжилттай шинэчилэгдлээ.");
                }
            }
        }

        // Delete Data
        public void delete(int user_id)
        {
            if (user_id != 0)
            {
                dr = MetroMessageBox.Show(MetroForm.ActiveForm,
                    "Та жагсаалтаас хасахдаа итгэлтэй байна уу?", "Хэрэглэгч устгах!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    string query = "UPDATE `users` SET status='1' WHERE `id`='" + user_id + "'";
                    using (command = new MySqlCommand(query, con))
                    {
                        executeQuery(command, "Хэрэглэгч амжилттай устгалаа!");
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm,
                    "Мэдээллийн сантай харьцахад алдаа гарлаа", "Анхаар!",
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
                MetroFramework.MetroMessageBox.Show(MetroForm.ActiveForm, "Мэдээллийн сантай харьцахад алдаа гарлаа", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
        }
    }
}
