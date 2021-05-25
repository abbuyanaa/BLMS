using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace BLMS.Controllers
{
    class CategoryController
    {
        MySqlConnection con = MyConnection.getConnection();
        Constants constants = new Constants();
        MySqlDataReader dataReader;
        MySqlCommand command;

        // Check Null Data
        public bool verifyData(string text)
        {
            return text.Equals("");
        }

        public bool existCbasicData(string text)
        {
            command = new MySqlCommand("SELECT * FROM `category_basic` WHERE `name`=@name", con);
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

        public bool existCsubData(int cbasic_id, string text)
        {
            string query = "" +
                "SELECT * FROM category AS c " +
                "INNER JOIN category_sub AS cs ON cs.id = c.sub_id " +
                "WHERE c.basic_id = '" + cbasic_id + "' AND cs.name = '" + text + "'";
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

        public int comboBoxName(string table, string name)
        {
            string query = "SELECT * FROM `" + table + "` WHERE `name`='" + name + "'";
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

        public int csubLastID()
        {
            string query = "SELECT id FROM category_sub ORDER BY id DESC LIMIT 1";
            using (command = new MySqlCommand(query, con))
            {
                con.Close();
                if (con.State == ConnectionState.Closed) con.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    int id = dataReader.GetInt32("id");
                    con.Clone();
                    return id;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
