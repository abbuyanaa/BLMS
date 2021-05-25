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
    public partial class CompanyForm : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        Constants constants = new Constants();
        MySqlDataReader dataReader;
        MySqlCommand command;
        DialogResult dataResult;
        int company_id;

        public CompanyForm()
        {
            InitializeComponent();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            metroGridCompany.DataSource = companyData("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            store(companyName.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            update(company_id, companyName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete(company_id);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            company_id = 0;
            companyName.Text = null;
            companySearch.Text = null;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
        }

        private void companySearch_TextChanged(object sender, EventArgs e)
        {
            metroGridCompany.DataSource = companyData(companySearch.Text);
        }

        private void metroGridCompany_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            edit(metroGridCompany.CurrentRow.Cells[1].Value.ToString());
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
        }

        /**
         * START Database CURD
         */

        // Data from DB
        public DataTable companyData(string search)
        {
            DataTable table = new DataTable();
            using (command = new MySqlCommand("SELECT * FROM `company` WHERE `name` LIKE '%" + search + "%' ORDER BY `id` DESC", con)) 
            {
                con.Open();
                dataReader = command.ExecuteReader();

                table.Columns.Add("№", typeof(int));
                table.Columns.Add("Байгууллага", typeof(string));

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
            command = new MySqlCommand("SELECT * FROM `company` WHERE `name`=@name", con);
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
                MetroFramework.MetroMessageBox.Show(this, "Зохиолч бүртгэлтэй байна!", "Алдаа!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (command = new MySqlCommand("INSERT INTO `company` (`name`) VALUES (@name)", con))
                {
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                    executeQuery(command, "Зохиолч амжилттай нэмэгдлээ.");
                }
            }
        }

        // Edit from DB
        private void edit(string text)
        {
            using (command = new MySqlCommand("SELECT * FROM `company` WHERE `name`='" + text + "'", con))
            {
                con.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    if (dataReader.Read())
                    {
                        company_id = dataReader.GetInt32("id");
                        companyName.Text = dataReader.GetString("name");
                    }
                }
                con.Close();
            }
        }

        // Update to DB
        public void update(int company_id, String name)
        {
            if (company_id != 0)
            {
                command = new MySqlCommand("UPDATE `company` SET `name`=@name WHERE `id`=@id", con);
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Convert.ToString(company_id);
                executeQuery(command, "Амжилттай шинэчилэгдлээ.");
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Жагсаалтаас сонгоно уу!", "Анхаар!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete Data
        public void delete(int company_id)
        {
            if (company_id != 0)
            {
                dataResult = MetroFramework.MetroMessageBox.Show(this, "Та Зохиолчыг устгахдаа итгэлтэй байна уу!", "Анхаар!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dataResult == DialogResult.Yes)
                {
                    command = new MySqlCommand("DELETE FROM `company` WHERE `id`=@id", con);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = Convert.ToString(company_id);
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
            metroGridCompany.DataSource = companyData("");
        }
    }
}
