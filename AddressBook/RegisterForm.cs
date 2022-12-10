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
    public partial class RegisterForm : Form
    {
        string city = "";
        public RegisterForm()
        {
            InitializeComponent();
            loadCmbData();

        }

        private void loadCmbData()
        {
            cmbCity.Items.Add("Colombo");
            cmbCity.Items.Add("Galle");
            cmbCity.Items.Add("Matara");
            cmbCity.Items.Add("Jaffna");
            cmbCity.Items.Add("Kaluthara");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = txtUserName.Text;
            String password = txtPassword.Text;
            String email = txtEmail.Text;
            String mobile = txtMobile.Text;
            Boolean gender = false;
       

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

            if (email == "")
            {
                lblEmail.Text = "Please fill email";
            }
            else
            {
                lblEmail.Text = "";
            }

            if (mobile == "")
            {
                lblMobile.Text = "Please fill mobile";
            }
            else
            {
                lblMobile.Text = "";
            }

            if (rbtnMale.Checked == true)
            {
                lblGender.Text = "";
                gender = true;
            }
            else if (rbtnFemale.Checked == true)
            {
                gender = true;
                lblGender.Text = "";
            }
            else
            {
                gender = false;
                lblGender.Text = "Please select your gender";
            }


            if (city == "")
            {
                lblCity.Text = "Please select your city";
            }
            else
            {
                lblCity.Text = "";
            }

            if (chckAccept.Checked == true) { 
                lblAccept.Text = ""; 
            }
            else
            {
                lblAccept.Text = "Please check your acceptence";
            }




            if (uname != "" & password != "" & email != "" & mobile != "" & gender == true & chckAccept.Checked == true & datePickerDOB.Value !=null & city!=null) 
            {
                MessageBox.Show("Registration Successfully");
            }

     
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            city=cmbCity.GetItemText(cmbCity.SelectedItem);
            lblCity.Text = "";
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            lblGender.Text = "";
        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            lblGender.Text = "";
        }

        private void chckAccept_CheckedChanged(object sender, EventArgs e)
        {
            lblAccept.Text = "";
        }
    }
}
