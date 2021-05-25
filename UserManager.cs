using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLMS.Controllers;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BLMS
{

    public partial class UserManager : MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        Constants constants = new Constants();
        MySqlDataReader dataReader;
        MySqlCommand command;
        DataTable table;
        public int user_id;
        string getImagePath, flname, fname, lname;
        Image userImage;

        public UserManager()
        {
            InitializeComponent();
        }

        private void UsersManager_Load(object sender, EventArgs e)
        {
            fillUsers("");
        }

        private void UsersManager_Activated(object sender, EventArgs e)
        {
            fillUsers("");
        }

        /**
         * START Database CURD
         */

        // Data from DB
        public void fillUsers(string value)
        {
            table = new DataTable();
            table.Rows.Clear();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Код", typeof(int));
            table.Columns.Add("Зураг", typeof(Image));
            table.Columns.Add("Овог нэр", typeof(string));
            table.Columns.Add("Цахим хаяг", typeof(string));
            table.Columns.Add("Регистр", typeof(string));
            table.Columns.Add("Утас", typeof(int));
            table.Columns.Add("Хүйс", typeof(string));
            table.Columns.Add("Төрөл", typeof(string));
            table.Columns.Add("Чуулган", typeof(string));

            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append("SELECT u.*, ut.name AS utname, ch.name AS chname FROM users AS u ");
            sb.Append("INNER JOIN users_type AS ut ON u.type_id = ut.id ");
            sb.Append("INNER JOIN chuulgan AS ch ON u.chuulgan_id = ch.id ");
            sb.Append("WHERE u.status='0' ");
            if (!value.Equals(""))
            {
                sb.Append("AND CONCAT(u.first_name, u.last_name, ut.name, ch.name) LIKE '%" + value + "%' ");
                sb.Append("ORDER BY u.first_name ASC, u.last_name ASC");
            }
            else
            {
                sb.Append("ORDER BY u.id DESC LIMIT 20");
            }

            using (command = new MySqlCommand(sb.ToString(), con))
            {
                con.Close();
                if (con.State == ConnectionState.Closed) con.Open();
                dataReader = command.ExecuteReader();

                int i = 1;
                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32("id");

                    //if (File.Exists(getImagePath))
                    //{
                    //    //bitmap = new Bitmap(getImagePath);
                    //    //bitmap = constants.resizeBitmap(bitmap, 80, 100);
                    //    userImage = Image.FromFile(getImagePath);
                    //}
                    //else
                    //{
                    //    Console.WriteLine(getImagePath + " file not found!");
                    //    //FileStream fs = new FileStream(@"..\\..\\Images\\profile.png", FileMode.Open, FileAccess.Read);
                    //    //userImage = Image.FromStream(fs);
                    //    userImage = Image.FromFile(constants.IMAGEUSER);
                    //}
                    //userImage = constants.imageResize(userImage, 80, 100);

                    getImagePath = dataReader.GetString("profile");
                    userImage = constants.checkUserImage(getImagePath, 80, 100);

                    lname = constants.firstCharToUpper(dataReader.GetString("last_name"));
                    fname = constants.firstCharToUpper(dataReader.GetString("first_name"));
                    flname = lname + "\n" + fname;

                    string gender = "Эрэгтэй";
                    if (dataReader.GetChar("gender") == 'f') gender = "Эмэгтэй";

                    table.Rows.Add(id, i, userImage, flname,
                        dataReader.GetString("email"), dataReader.GetString("regid"),
                        dataReader.GetInt32("phone"), gender,
                        constants.firstCharToUpper(dataReader.GetString("utname")),
                        constants.firstCharToUpper(dataReader.GetString("chname"))
                        );
                    i++;
                }
                metroGridUsers.DataSource = table;
                metroGridUsers.Columns["ID"].Visible = false;
                metroGridUsers.Columns[1].Width = 80;
                metroGridUsers.Columns[2].Width = 80;
                metroGridUsers.Columns[3].Width = 200;
                metroGridUsers.Columns[4].Width = 150;
                metroGridUsers.Columns[5].Width = 150;
                metroGridUsers.Columns[6].Width = 100;
                metroGridUsers.Columns[7].Width = 60;
                metroGridUsers.Columns[8].Width = 100;
                metroGridUsers.Columns[9].Width = 200;
                con.Close();
            }
        }

        private void metroGridUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                user_id = Convert.ToInt32(metroGridUsers.CurrentRow.Cells[0].Value.ToString());
                Console.WriteLine("User ID: " + user_id);
                UserEdit userEdit = new UserEdit();
                userEdit.user_id = user_id;
                userEdit.Show();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroUserAdd_Click(object sender, EventArgs e)
        {
            UserAdd userAdd = new UserAdd();
            userAdd.ShowDialog();
        }

        private void userSearch_TextChanged(object sender, EventArgs e)
        {
            fillUsers(userSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserAdd userAdd = new UserAdd();
            userAdd.ShowDialog();
        }
    }
}
