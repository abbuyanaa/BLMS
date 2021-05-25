using BLMS.Controllers;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLMS
{
    public partial class Login : MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        MySqlDataReader dataReader;
        MySqlCommand command;

        public Login()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            InitializeComponent();
            Thread.Sleep(5000);
            t.Abort();
        }

        public void Loading()
        {
            Application.Run(new SplashScreen());
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = userName.Text;
            string code = userCode.Text;
            string query = "SELECT * FROM admin " +
                "WHERE username='" + name + "' AND password='" + code + "'";
            using (command = new MySqlCommand(query, con))
            {
                con.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    con.Close();
                    Main main = new Main();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Нэр эсвэл Код буруу байна!");
                }
            }
        }
    }
}
