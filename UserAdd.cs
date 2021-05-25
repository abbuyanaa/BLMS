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
    public partial class UserAdd : MetroFramework.Forms.MetroForm
    {
        Constants constants = new Constants();
        UserController user;
        CategoryController cat = new CategoryController();
        char gender = 'm';
        int userType, userChuulgan;

        public UserAdd()
        {
            InitializeComponent();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            user = new UserController();
            constants.selectComboBoxes(cbUserType, "users_type");
            constants.selectComboBoxes(cbUserChuulgan, "chuulgan");
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            constants.browserImage(userProfile);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string lname = userLname.Text;
            string fname = userFname.Text;
            string regid = userRegid.Text;
            string phone = userPhone.Text;
            string email = userEmail.Text;
            string address = userAddress.Text;
            if (userFemale.Checked) gender = 'f';
            user.store(lname, fname, regid, phone, email, address, gender, userType, userChuulgan, userProfile);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void userPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            constants.pressedNumber(sender, e);
        }

        private void clearFields()
        {
            userProfile.Image = null;
            userLname.Text = null;
            userFname.Text = null;
            userRegid.Text = null;
            userEmail.Text = null;
            userAddress.Text = null;
            userPhone.Text = null;
            cbUserType.SelectedIndex = 0;
            cbUserChuulgan.SelectedIndex = 0;
            userMale.Checked = true;
        }

        private void cbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cbUserType.SelectedItem.ToString();
            userType = cat.comboBoxName("users_type", type);
            Console.WriteLine("User type: " + userType);
        }

        private void cbUserChuulgan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chuulgan = cbUserChuulgan.SelectedItem.ToString();
            userChuulgan = cat.comboBoxName("chuulgan", chuulgan);
            Console.WriteLine("User Chuulgan: " + userChuulgan);
        }
    }
}
