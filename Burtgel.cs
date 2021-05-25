using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLMS.Controllers;
using MySql.Data.MySqlClient;

namespace BLMS
{
    public partial class Burtgel : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        MySqlDataReader dataReader;
        MySqlCommand command;
        Constants constants = new Constants();
        DialogResult dr;
        string getImagePath;
        Image userImage;

        int current_year = DateTime.Now.Year;
        int burtgel_id, angi_id, user_id, user_count;
        string user_code, user_year;
        DataTable table;

        public Burtgel()
        {
            InitializeComponent();
        }

        private void Bvrtgel_Load(object sender, EventArgs e)
        {
            // Year
            for (int pyear = 2000; pyear <= current_year + 1; pyear++)
                userYear.Items.Add(pyear);
            userYear.SelectedIndex = 0;

            string type_query = "SELECT * FROM `angi` ORDER BY `id` ASC";
            using (command = new MySqlCommand(type_query, con))
            {
                userType.Items.Clear();
                con.Close();
                if (con.State == ConnectionState.Closed) con.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    userType.Items.Add(constants.firstCharToUpper(dataReader.GetString("name")));
                }
                con.Close();
            }

            fillBurtgel("");
        }

        private void btnCheckRegid_Click(object sender, EventArgs e)
        {
            string regid = userRegid.Text;
            if (!regid.Equals(""))
            {
                string query = "SELECT u.*, u.first_name, u.last_name, u.profile, ut.name FROM users AS u " +
                    "INNER JOIN users_type AS ut ON ut.id = u.type_id " +
                    "WHERE u.regid = '" + regid + "'";
                using (command = new MySqlCommand(query, con))
                {
                    con.Open();
                    dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        if (dataReader.Read())
                        {
                            user_id = dataReader.GetInt32("id");
                            string lname = constants.firstCharToUpper(dataReader.GetString("last_name"));
                            string fname = constants.firstCharToUpper(dataReader.GetString("first_name"));
                            lbUserLname.Text = "Овог нэр : " + lname + " " + fname;
                            lbUserEmail.Text = "Цахим хаяг : " + dataReader.GetString("email");

                            lbUserType.Text = "Төрөл : " + constants.firstCharToUpper(dataReader.GetString("name"));

                            getImagePath = dataReader.GetString("profile");
                            userImage = constants.checkUserImage(getImagePath, 80, 100); // Image Resize
                            userProfile.Image = userImage;
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this,
                            "Хэрэглэгч олдсонгүй!", "Анхаар!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                }
            }
        }

        private bool verifyData(int user_id, int angi_id, int year)
        {
            string query = "SELECT * FROM `burtgel` " +
                "WHERE `user_id`=@user_id AND `angi_id`=@angi_id AND `year`=@year";
            using (command = new MySqlCommand(query, con))
            {
                command.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = user_id;
                command.Parameters.Add("@angi_id", MySqlDbType.VarChar).Value = angi_id;
                command.Parameters.Add("@year", MySqlDbType.VarChar).Value = year;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (angi_id != 0) {
                user_count = userCount();
                if (user_count < 10)
                {
                    user_code = "" + angi_id + user_year + "0" + user_count;
                }
                else
                {
                    user_code = "" + angi_id + user_year + user_count;
                }

                if (verifyData(user_id, angi_id, Convert.ToInt32(user_year)))
                {
                    MetroFramework.MetroMessageBox.Show(this,
                        "Бүртгэлтэй байна!", "Анхаар!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string query = "INSERT INTO `burtgel`" +
                        "(`user_id`, `angi_id`, `year`, `code`) VALUES " +
                        "(@user_id, @angi_id, @year, @code)";
                    using (command = new MySqlCommand(query, con))
                    {
                        command.Parameters.Add("@user_id", MySqlDbType.VarChar).Value = user_id;
                        command.Parameters.Add("@angi_id", MySqlDbType.VarChar).Value = angi_id;
                        command.Parameters.Add("@year", MySqlDbType.VarChar).Value = user_year;
                        command.Parameters.Add("@code", MySqlDbType.VarChar).Value = user_code;
                        con.Open();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this,
                                "Амжилттай бүртгэгдлээ.", "Баяр хүргье.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this,
                                "Мэдээлэл оруулахад алдаа гарлаа!", "Анхаар!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        con.Close();
                        fillBurtgel("");
                    }
                }
            }
        }

        private void btnCheckUserCode_Click(object sender, EventArgs e)
        {
            string code = searchUserCode.Text;
            fillBurtgel(code);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (burtgel_id != 0)
            {
                dr = MetroFramework.MetroMessageBox.Show(this,
                    "Та жагсаалтаас хасахдаа итгэлтэй байна уу?", "Хэрэглэгч устгах!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    string query = "DELETE FROM burtgel WHERE id = '" + burtgel_id + "'";
                    using (command = new MySqlCommand(query, con))
                    {
                        con.Open();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this,
                                "Амжилттай устгагдлаа.", "Баяр хүргье.",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this,
                                "Хэрэглэгчтэй холбоотой мэдээлэл байгаа учир устгах боломжгүй!", "Анхаар!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        con.Close();
                        btnDelete.Enabled = false;
                        fillBurtgel("");
                    }
                }
            }
        }

        private int userCount()
        {
            int user;
            user_year = userYear.SelectedItem.ToString();
            string query = "SELECT COUNT(*) AS count FROM `burtgel` " +
                    "WHERE `angi_id`='" + angi_id + "' AND `year`='" + user_year + "'";
            using (command = new MySqlCommand(query, con))
            {
                con.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    user = dataReader.GetInt32("count");
                    user++;
                    con.Close();
                    return user;
                }
            }
            return 0;
        }

        private void metroGridUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            burtgel_id = Convert.ToInt32(metroGridUsers.CurrentRow.Cells[0].Value);
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
        }

        private void userType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = userType.SelectedItem.ToString();
            if (!type.Equals(""))
            {
                string query = "SELECT * FROM angi WHERE name = '" + type + "'";
                using (command = new MySqlCommand(query, con))
                {
                    con.Close();
                    if (con.State == ConnectionState.Closed) con.Open();

                    dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        angi_id = dataReader.GetInt32("number");
                    }
                    con.Close();
                }
            }
        }

        private void fillBurtgel(string value)
        {
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("№", typeof(int));
            table.Columns.Add("Зураг", typeof(Image));
            table.Columns.Add("Овог нэр", typeof(string));
            table.Columns.Add("Регистр", typeof(string));
            table.Columns.Add("Анги", typeof(string));
            table.Columns.Add("Он", typeof(int));

            metroGridUsers.DataSource = table;

            table.Rows.Clear();
            string query = "SELECT b.id, b.code, u.first_name, u.last_name, u.profile, u.regid, b.year, a.name AS aname " +
                "FROM users AS u " +
                "INNER JOIN burtgel AS b ON b.user_id = u.id " +
                "INNER JOIN angi AS a ON a.id = b.angi_id " +
                "WHERE CONCAT(u.regid, b.code) LIKE '%" + value + "%' " +
                "ORDER BY b.id DESC";
            using (command = new MySqlCommand(query, con))
            {
                con.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32("id");
                    int code = dataReader.GetInt32("code");

                    userImage = constants.checkUserImage(dataReader.GetString("profile"), 80, 100);

                    //outBitmap = new Bitmap(getImagePath); // Get current image path
                    //newBitmap = constants.resizeBitmap(outBitmap, 80, 100); // Image Resize

                    string lname = constants.firstCharToUpper(dataReader.GetString("last_name"));
                    string fname = constants.firstCharToUpper(dataReader.GetString("first_name"));

                    table.Rows.Add(id, code, userImage, lname + "\n" + fname,
                        dataReader.GetString("regid").ToUpper(),
                        constants.firstCharToUpper(dataReader.GetString("aname")),
                        dataReader.GetInt32("year")
                        );
                }
                con.Close();

                metroGridUsers.Columns["ID"].Visible = false;
                metroGridUsers.Columns[1].Width = 40;
                metroGridUsers.Columns[2].Width = 80;
                metroGridUsers.Columns[3].Width = 100;
                metroGridUsers.Columns[4].Width = 100;
                metroGridUsers.Columns[5].Width = 100;
                metroGridUsers.Columns[6].Width = 100;
            }
        }
    }
}
