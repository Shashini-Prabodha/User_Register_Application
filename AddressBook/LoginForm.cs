using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String uname = txtUserName.Text;
            String password = txtPswrd.Text;

            if (uname == "")
            {
                lblUserName.Text = "Please fill user name";
            }
            else
            {
                lblUserName.Text = "";
            }


            if (password == "")
            {
                lblPassword.Text = "Please fill password";
            }
            else
            {
                lblPassword.Text = "";
            }
            if (uname != "" & password != "")
            {
                MessageBox.Show("Success!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
