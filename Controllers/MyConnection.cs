using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BLMS.Controllers
{
    class MyConnection
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='blms';username=root;password=");
                //MessageBox.Show("Амжилттай холбогдлоо.");
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Холболт амжилтгүй! " + ex.Message);
            }
            return con;
        }
    }
}
