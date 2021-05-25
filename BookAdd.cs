using System;
using System.Data;
using System.Windows.Forms;
using BLMS.Controllers;
using MySql.Data.MySqlClient;

namespace BLMS
{
    public partial class BookAdd : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con = MyConnection.getConnection();
        BookController bookController = new BookController();
        Constants constants = new Constants();
        MySqlDataReader dataReader;
        MySqlCommand command;
        int current_year = DateTime.Now.Year;
        int bookAuthor, bookCompany, bookCbasic, bookCsub, bookFlow, bookLang, bookYear;
        int book_bible = 0, book_esse = 0, book_out = 0;

        public BookAdd()
        {
            InitializeComponent();
        }

        private void BookAdd_Load(object sender, EventArgs e)
        {
            // ComboBoxes select
            constants.selectComboBoxes(cbAuthor, "authors");
            constants.selectComboBoxes(cbCompany, "company");
            constants.selectComboBoxes(cbCbasic, "category_basic");
            constants.selectComboBoxes(cbLang, "languages");
            constants.selectComboBoxes(cbFlow, "book_flow");

            // Year
            for (int pyear = 1900; pyear <= current_year + 1; pyear++)
                cbYear.Items.Add(pyear);
            cbYear.SelectedIndex = 0;
        }

        private void BookAdd_Activated(object sender, EventArgs e)
        {
            // ComboBoxes select
            constants.selectComboBoxes(cbAuthor, "authors");
            constants.selectComboBoxes(cbCompany, "company");
            constants.selectComboBoxes(cbCbasic, "category_basic");
            constants.selectComboBoxes(cbLang, "languages");
            constants.selectComboBoxes(cbFlow, "book_flow");

            // Year
            for (int pyear = 1980; pyear <= current_year + 1; pyear++)
                cbYear.Items.Add(pyear);
            cbYear.SelectedIndex = 0;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            constants.browserImage(bookImage);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = bookName.Text;
            string body = bookBody.Text;
            string qty = bookQty.Text;
            if (bookBible.Checked) book_bible = 1;
            if (bookEsse.Checked) book_esse = 1;
            if (bookOut.Checked) book_out = 1;
            bookController.store(
                name, body, qty, bookAuthor, bookCompany, bookCbasic, bookCsub, bookLang,
                bookFlow, bookYear, book_bible, book_esse, book_out, bookImage
                );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void bookQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            constants.pressedNumber(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();
            authorForm.ShowDialog();
        }

        private void clearFields()
        {
            bookImage.Image = null;
            bookName.Text = null;
            bookBody.Text = null;
            bookQty.Text = "1";
            bookBible.Checked = false;
            bookEsse.Checked = false;
            bookOut.Checked = false;

            cbYear.SelectedIndex = 0;
            // ComboBoxes select
            constants.selectComboBoxes(cbAuthor, "authors");
            constants.selectComboBoxes(cbCompany, "company");
            constants.selectComboBoxes(cbCbasic, "category_basic");
            constants.selectComboBoxes(cbLang, "languages");
            constants.selectComboBoxes(cbFlow, "book_flow");
        }

        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string author = cbAuthor.SelectedItem.ToString();
            bookAuthor = constants.getComboBoxID("authors", 0, author);
            Console.WriteLine("Book Add author: " + bookAuthor);
        }

        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string company = cbCompany.SelectedItem.ToString();
            bookCompany = constants.getComboBoxID("company", 0, company);
            Console.WriteLine("Book Add company: " + bookCompany);
        }

        private void cbCbasic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbasic = cbCbasic.SelectedItem.ToString();
            bookCbasic = constants.getComboBoxID("category_basic", 0, cbasic);
            Console.WriteLine("Book Add cbasic: " + bookCbasic);

            // Category Sub
            if (con.State == ConnectionState.Open) con.Close();
            string query = ""
            + "SELECT cs.* FROM category_basic AS cb "
            + "INNER JOIN category AS c ON c.basic_id = cb.id "
            + "INNER JOIN category_sub AS cs ON cs.id = c.sub_id "
            + "WHERE cb.id = '" + bookCbasic + "' ORDER BY cs.name ASC";
            using (command = new MySqlCommand(query, con))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                dataReader = command.ExecuteReader();
                cbCsub.Items.Clear();
                while (dataReader.Read())
                {
                    cbCsub.Items.Add(constants.firstCharToUpper(dataReader.GetString("name")));
                }
                cbCsub.SelectedIndex = 0;
                con.Close();
            }
        }

        private void cbCsub_SelectedIndexChanged(object sender, EventArgs e)
        {
            string csub = cbCsub.SelectedItem.ToString();
            bookCsub = constants.getComboBoxID("category_sub", bookCbasic, csub);
            Console.WriteLine("Book Add csub: " + bookCsub);
        }

        private void cbFlow_SelectedIndexChanged(object sender, EventArgs e)
        {
            string flow = cbFlow.SelectedItem.ToString();
            bookFlow = constants.getComboBoxID("book_flow", 0, flow);
            Console.WriteLine("Book Add flow: " + bookFlow);
        }

        private void cbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lang = cbLang.SelectedItem.ToString();
            bookLang = constants.getComboBoxID("languages", 0, lang);
            Console.WriteLine("Book Add lang: " + bookLang);
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookYear = Convert.ToInt32(cbYear.SelectedItem.ToString());
            Console.WriteLine("Book Add year: " + bookYear.ToString());
        }
    }
}
