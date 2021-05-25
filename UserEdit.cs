using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BLMS.Controllers;
using MySql.Data.MySqlClient;

namespace BLMS
{
    public partial class UserEdit : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        UserController userController = new UserController();
        CategoryController cat = new CategoryController();
        Constants constants = new Constants();
        MySqlDataReader dataReader;
        MySqlCommand command;
        Image image;
        string fileName, getImagePath, uploadFilePath, delImagePath;
        string datetime = DateTime.Now.ToString("yyyy_MM_dd_H_ss");

        public int user_id;
        char gender = 'm';
        int userType, userChuulgan;

        public UserEdit()
        {
            InitializeComponent();
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            // Select ComboBox Data
            constants.selectComboBoxes(cbUserType, "users_type");
            constants.selectComboBoxes(cbUserChuulgan, "chuulgan");

            // Get User Data
            string query = "SELECT u.*, ut.name AS utname, ch.name AS chname FROM users AS u " +
                "INNER JOIN users_type AS ut ON ut.id = u.type_id " +
                "INNER JOIN chuulgan AS ch ON ch.id = u.chuulgan_id " +
                "WHERE u.id = '" + user_id + "'";
            using (command = new MySqlCommand(query, con))
            {
                con.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    userLname.Text = dataReader.GetString("last_name");
                    userFname.Text = dataReader.GetString("first_name");
                    userRegid.Text = dataReader.GetString("regid");
                    userEmail.Text = dataReader.GetString("email");
                    userAddress.Text = dataReader.GetString("address");
                    userPhone.Text = dataReader.GetString("phone");
                    string getType = dataReader.GetString("utname");
                    string getChuulgan = dataReader.GetString("chname");

                    cbUserType.SelectedItem = constants.firstCharToUpper(getType);
                    cbUserChuulgan.SelectedItem = constants.firstCharToUpper(getChuulgan);

                    getImagePath = dataReader.GetString("profile");
                    userProfile.Image = constants.checkUserImage(getImagePath, 200, 260);
                }
                con.Close();
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                uploadFilePath = open.FileName;

                userProfile.Image = null;
                delImagePath = constants.USERSDIR + getImagePath;

                image = Image.FromFile(uploadFilePath);
                image = constants.imageResize(image, 200, 260);

                fileName = datetime + ".jpg";
                string query = "UPDATE users SET profile='" + fileName + "' WHERE id='" + user_id + "'";
                using (command = new MySqlCommand(query, con))
                {
                    con.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        uploadFilePath = constants.USERSDIR + fileName;
                        Console.WriteLine("User Edit Upload Image Path: " + uploadFilePath);
                        image.Save(uploadFilePath);
                        userProfile.Image = Image.FromFile(uploadFilePath);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string lname = userLname.Text;
            string fname = userFname.Text;
            string regid = userRegid.Text;
            string phone = userPhone.Text;
            string email = userEmail.Text;
            string address = userAddress.Text;
            if (userFemale.Checked) gender = 'f';
            userController.update(user_id,
                lname, fname, regid, phone, email, address,
                gender, userType, userChuulgan, userProfile
                );
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            userController.delete(user_id);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void clearFields()
        {
            userProfile.Image = null;
            userLname.Text = null;
            userFname.Text = null;
            userRegid.Text = null;
            userEmail.Text = null;
            userAddress.Text = null;
            userPhone.Text = null;
            cbUserType.SelectedIndex = 0;
            cbUserChuulgan.SelectedIndex = 0;
            userMale.Checked = true;
        }

        private void cbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cbUserType.SelectedItem.ToString();
            userType = cat.comboBoxName("users_type", type);
            Console.WriteLine("User type: " + userType);
        }

        private void cbUserChuulgan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chuulgan = cbUserChuulgan.SelectedItem.ToString();
            userChuulgan = cat.comboBoxName("chuulgan", chuulgan);
            Console.WriteLine("User Chuulgan: " + userChuulgan);
        }
    }
}
