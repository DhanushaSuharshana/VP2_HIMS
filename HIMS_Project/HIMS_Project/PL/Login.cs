using System;
using System.Data;
using System.Windows.Forms;
using HIMS_Project.BLL;
using HIMS_Project.Model;

namespace HIMS_Project.PL
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        public void Clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        public void VerifyLoginDetail()
        {

            //var LoginUser = new TblUsers
            //{
            //    Username = txtUsername.Text,
            //    UPassword = txtPassword.Text,
            //};

            Login_BLL userCredentials = new Login_BLL();
            bool UserFound = userCredentials.AuthenticateUser(txtUsername.Text, txtPassword.Text);

            if (UserFound) // if user found
            {
                Dashboard dBoard = new Dashboard();
                dBoard.Show();
                this.Hide();
            }
            else if(!UserFound) // if user does not found
            {
                lblLoginError.Text = "Incorrect Username Or Password.";
                Clear();
                txtUsername.Focus();
                return;
            }

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // check text boxes are empty or not
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    lblLoginError.Text = "Invalid username. Please Try again.";
                    txtUsername.Focus();
                    return;
                }
                else if(string.IsNullOrEmpty(txtPassword.Text))
                {
                    lblLoginError.Text = "Invalid password. Please Try again.";
                    txtPassword.Focus();
                    return;
                }
                else
                {
                    VerifyLoginDetail();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Close the login form
        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRecoverPW_Click(object sender, EventArgs e)
        {
            PasswordRecover PwRecover = new PasswordRecover();
            PwRecover.Show();
            this.Hide();
        }
    }
}
