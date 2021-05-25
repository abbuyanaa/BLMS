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
    public partial class BookFlow : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        Constants constants = new Constants();
        MySqlDataReader dataReader;
        MySqlCommand command;
        DialogResult dataResult;
        int flow_id;

        public BookFlow()
        {
            InitializeComponent();
        }

        private void BookFlow_Load(object sender, EventArgs e)
        {
            metroGridFlow.DataSource = flowData("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            store(flowName.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            update(flow_id, flowName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete(flow_id);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void flowSearch_TextChanged(object sender, EventArgs e)
        {
            metroGridFlow.DataSource = flowData(flowSearch.Text);
        }

        private void clearFields()
        {
            flow_id = 0;
            flowName.Text = null;
            flowSearch.Text = null;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
        }

        private void metroGridFlow_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            edit(metroGridFlow.CurrentRow.Cells[1].Value.ToString());
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
        }

        /**
         * Database CURD
         */
        // Data from DB
        public DataTable flowData(string search)
        {
            DataTable table = new DataTable();
            using (command = new MySqlCommand("SELECT * FROM `book_flow` WHERE `name` LIKE '%" + search + "%' ORDER BY `id` DESC", con))
            {
                con.Open();
                dataReader = command.ExecuteReader();

                table.Columns.Add("№", typeof(int));
                table.Columns.Add("Урсгал чиглэл", typeof(string));

                if (dataReader.HasRows)
                {
                    table.Clear();
                    int i = 1;
                    while (dataReader.Read())
                    {
                        table.Rows.Add(i, constants.firstCharToUpper(dataReader.GetString("name")));
                        i++;
                    }
                }
                con.Close();
            }
            return table;
        }

        // Check Null Data
        public bool verifyData(string text)
        {
            return !text.Equals("");
        }

        // Exist Data
        public bool existData(string text)
        {
            command = new MySqlCommand("SELECT * FROM `book_flow` WHERE `name`=@name", con);
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
        public void store(string name)
        {
            if (!verifyData(name))
            {
                MetroFramework.MetroMessageBox.Show(this, "Утга оруулна уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (existData(name))
            {
                MetroFramework.MetroMessageBox.Show(this, "Хэл бүртгэлтэй байна!", "Алдаа!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (command = new MySqlCommand("INSERT INTO `book_flow` (`name`) VALUES (@name)", con))
                {
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    executeQuery(command, "Хэл амжилттай нэмэгдлээ.");
                }
            }
        }

        // Edit from DB
        private void edit(string text)
        {
            using (command = new MySqlCommand("SELECT * FROM `book_flow` WHERE `name`='" + text + "'", con))
            {
                con.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    if (dataReader.Read())
                    {
                        flow_id = dataReader.GetInt32("id");
                        flowName.Text = dataReader.GetString("name");
                    }
                }
                con.Close();
            }
        }

        // Update to DB
        public void update(int flow_id, string name)
        {
            if (flow_id != 0)
            {
                using (command = new MySqlCommand("UPDATE `book_flow` SET `name`=@name WHERE `id`=@id", con))
                {
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Convert.ToString(flow_id);
                    executeQuery(command, "Амжилттай шинэчилэгдлээ.");
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Жагсаалтаас сонгоно уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //// Delete Data
        public void delete(int flow_id)
        {
            if (flow_id != 0)
            {
                dataResult = MetroFramework.MetroMessageBox.Show(this, "Та Зохиолчыг устгахдаа итгэлтэй байна уу!", "Анхаар!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dataResult == DialogResult.Yes)
                {
                    using (command = new MySqlCommand("DELETE FROM `book_flow` WHERE `id`=@id", con))
                    {
                        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Convert.ToString(flow_id);
                        executeQuery(command, "Мэдээлэл амжилттай устгагдлаа.");
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Жагсаалтаас сонгоно уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void executeQuery(MySqlCommand command, String myMsg)
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
                MetroFramework.MetroMessageBox.Show(this, "Мэдээллийн сантай харьцахад алдаа гарлаа", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();
            metroGridFlow.DataSource = flowData("");
        }
    }
}
