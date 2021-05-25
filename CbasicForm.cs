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
    public partial class CbasicForm : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        CategoryController categoryController = new CategoryController();
        Constants constants = new Constants();
        MySqlDataReader dataReader;
        MySqlCommand command;
        DialogResult dataResult;
        int cbasic_id;

        public CbasicForm()
        {
            InitializeComponent();
        }

        private void Cbasic_Load(object sender, EventArgs e)
        {
            metroGridCbasic.DataSource = data("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            store(cbasicName.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            update(cbasic_id, cbasicName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete(cbasic_id);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void cbasicSearch_TextChanged(object sender, EventArgs e)
        {
            metroGridCbasic.DataSource = data(cbasicSearch.Text);
        }

        private void metroGridCbasic_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            edit(metroGridCbasic.CurrentRow.Cells[1].Value.ToString());
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
        }

        private void metroGridCbasic_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine("Cbasic: " + cbasic_id);
            CsubForm csub = new CsubForm();
            csub.cbasic_id = cbasic_id;
            csub.Show();
        }

        public void clearFields()
        {
            cbasic_id = 0;
            cbasicName.Text = null;
            cbasicSearch.Text = null;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
        }

        /**
         * START Database CURD
         */

        // Data from DB
        public DataTable data(string search)
        {
            DataTable table = new DataTable();
            using (command = new MySqlCommand("SELECT * FROM `category_basic` WHERE `name` LIKE '%" + search + "%' ORDER BY `id` DESC", con))
            {
                con.Open();
                dataReader = command.ExecuteReader();

                table.Columns.Add("№", typeof(int));
                table.Columns.Add("Үндсэн төрөл", typeof(string));

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

        // Insert Into DB
        public void store(string name)
        {
            if (categoryController.verifyData(name))
            {
                MetroFramework.MetroMessageBox.Show(this, "Утга оруулна уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (categoryController.existCbasicData(name))
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "Үндсэн төрөл бүртгэлтэй байна!", "Алдаа!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (command = new MySqlCommand("INSERT INTO `category_basic`(`name`) VALUES (@name)", con))
                {
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    executeQuery(command, "Үндсэн төрөл амжилттай нэмэгдлээ.");
                }
            }
        }

        // Edit from DB
        private void edit(string text)
        {
            using (command = new MySqlCommand("SELECT * FROM `category_basic` WHERE `name`='" + text + "'", con))
            {
                con.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    if (dataReader.Read())
                    {
                        cbasic_id = dataReader.GetInt32("id");
                        cbasicName.Text = dataReader.GetString("name");
                    }
                }
                con.Close();
            }
        }

        // Update to DB
        public void update(int cbasic_id, String name)
        {
            if (cbasic_id != 0)
            {
                command = new MySqlCommand("UPDATE `category_basic` SET `name`=@name WHERE `id`=@id", con);
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Convert.ToString(cbasic_id);
                executeQuery(command, "Амжилттай шинэчилэгдлээ.");
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Жагсаалтаас сонгоно уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete Data
        public void delete(int cbasic_id)
        {
            if (cbasic_id != 0)
            {
                dataResult = MetroFramework.MetroMessageBox.Show(this, "Та Үндсэн төрөл устгахдаа итгэлтэй байна уу!", "Анхаар!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dataResult == DialogResult.Yes)
                {
                    command = new MySqlCommand("DELETE FROM `category_basic` WHERE `id`=@id", con);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Convert.ToString(cbasic_id);
                    executeQuery(command, "Мэдээлэл амжилттай устгагдлаа.");
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
            metroGridCbasic.DataSource = data("");
        }
    }
}
