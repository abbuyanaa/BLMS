using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLMS.Controllers;
using MySql.Data.MySqlClient;

namespace BLMS
{
    public partial class CsubForm : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        CategoryController category = new CategoryController();
        Constants constants = new Constants();
        MySqlDataReader dataReader;
        MySqlCommand command;
        DialogResult dataResult;
        DataTable table;
        public int cbasic_id, csub_id, csub_lastid;

        public CsubForm()
        {
            InitializeComponent();
        }

        private void Csub_Load(object sender, EventArgs e)
        {
            metroGridCsub.DataSource = data(cbasic_id, "");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            store(cbasic_id, csubName.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            update(csub_id, csubName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete(csub_id);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void csubSearch_TextChanged(object sender, EventArgs e)
        {
            metroGridCsub.DataSource = data(cbasic_id, csubSearch.Text);
        }

        private void metroGridCsub_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            edit(metroGridCsub.CurrentRow.Cells[0].Value.ToString());
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
        }

        private void clearFields()
        {
            csub_id = 0;
            csubName.Text = null;
            csubSearch.Text = null;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
        }

        /**
         * START Database CURD
         */

        // Data from DB
        public DataTable data(int cbasic_id, string search)
        {
            table = new DataTable();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT cs.* FROM category_sub AS cs ");
            sb.Append("INNER JOIN category AS c ON c.sub_id = cs.id ");
            sb.Append("WHERE c.basic_id = '" + cbasic_id + "' AND cs.name LIKE '%" + search + "%'");
            using (command = new MySqlCommand(sb.ToString(), con))
            {
                con.Open();
                dataReader = command.ExecuteReader();

                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("№", typeof(int));
                table.Columns.Add("Дэд төрөл", typeof(string));

                if (dataReader.HasRows)
                {
                    table.Clear();
                    int i = 1;
                    while (dataReader.Read())
                    {
                        int id = dataReader.GetInt32("id");
                        table.Rows.Add(id, i,
                            constants.firstCharToUpper(dataReader.GetString("name")));
                        i++;
                    }

                    metroGridCsub.DataSource = table;
                    metroGridCsub.Columns["ID"].Visible = false;
                }
                con.Close();
            }
            return table;
        }

        // Check Null Data
        public bool verifyData(string text)
        {
            return text.Equals("");
        }

        // Cbasic Exist Data
        public bool existCbasicData(string text)
        {
            command = new MySqlCommand("SELECT * FROM `category_sub` WHERE `name`=@name", con);
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

        // Insert Into DB
        public void store(int cbasic_id, string name)
        {
            if (category.verifyData(name))
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "Утга оруулна уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (category.existCsubData(cbasic_id, name))
            {
                MetroFramework.MetroMessageBox.Show(this, "Таны оруулсан Дэд төрөл бүртгэлтэй байна!", "Алдаа!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query;
                query = "INSERT INTO `category_sub`(`name`) VALUES (@name)";
                using (command = new MySqlCommand(query, con))
                {
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

                    con.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        con.Close();
                        csub_lastid = category.csubLastID();
                        query = "INSERT INTO `category`(`basic_id`, `sub_id`) VALUES (@cbasic, @csub)";
                        using (command = new MySqlCommand(query, con))
                        {
                            command.Parameters.Add("@cbasic", MySqlDbType.VarChar).Value = cbasic_id;
                            command.Parameters.Add("@csub", MySqlDbType.VarChar).Value = csub_lastid;

                            executeQuery(command, "Дэд төрөл амжилттай нэмэгдлээ.");
                        }
                    }
                    else
                    {
                        con.Close();
                        MetroFramework.MetroMessageBox.Show(this, "Дэд төрөл хадгалж чадсангүй!", "Анхаар!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        // Edit from DB
        private void edit(string id)
        {
            using (command = new MySqlCommand("SELECT * FROM `category_sub` WHERE `id`='" + id + "'", con))
            {
                con.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    csub_id = dataReader.GetInt32("id");
                    csubName.Text = dataReader.GetString("name");
                }
                Console.WriteLine(csub_id);
                con.Close();
            }
        }

        // Update to DB
        public void update(int csub_id, string name)
        {
            if (csub_id != 0)
            {
                command = new MySqlCommand("UPDATE `category_sub` SET `name`=@name WHERE `id`=@id", con);
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = csub_id;
                executeQuery(command, "Амжилттай шинэчилэгдлээ.");
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "Жагсаалтаас сонгоно уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete Data
        public void delete(int csub_id)
        {
            string query;
            if (csub_id != 0)
            {
                dataResult = MetroFramework.MetroMessageBox.Show(this, "Та Дэд төрөл устгахдаа итгэлтэй байна уу!", "Анхаар!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dataResult == DialogResult.Yes)
                {
                    query = "DELETE FROM `category` WHERE `sub_id`='" + csub_id + "'";
                    using (command = new MySqlCommand(query, con))
                    {
                        con.Open();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            con.Close();
                            command = new MySqlCommand("DELETE FROM `category_sub` WHERE `id`=@id", con);
                            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = csub_id;
                            executeQuery(command, "Мэдээлэл амжилттай устгагдлаа.");
                        }
                        else
                        {
                            con.Close();
                            MetroFramework.MetroMessageBox.Show(this, "Дэд төрөл устгаж чадсангүй!", "Алдаа!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Жагсаалтаас сонгоно уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void executeQuery(MySqlCommand command, string myMsg)
        {
            con.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MetroFramework.MetroMessageBox.Show(this, myMsg, "Баяр хүргье.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "Мэдээллийн сантай харьцахад алдаа гарлаа", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
            metroGridCsub.DataSource = data(cbasic_id, "");
        }
    }
}
