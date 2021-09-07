using System;
using System.Data;
using System.Windows.Forms;
using HIMS_Project.BLL;
using HIMS_Project.Model;

namespace HIMS_Project.PL
{
    public partial class Login : Form
    {
        TblUsers_BLL TblUsers_BLL; 

        public Login()
        {
            InitializeComponent();
            TblUsers_BLL = new TblUsers_BLL(); // create a object
        }

        public void Clear()
        {
            txtUserId.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // check tect bos is empty or not
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
                    //var ID = txtUserId.Text;
                    if (string.IsNullOrEmpty(txtUserId.Text))
                    {
                        lblLoginError.Text = "Incorrect Username Or Password.";
                        Clear();
                        txtUsername.Focus();
                        return;
                    }
                    else
                    {
                        // Link MDI Dashboard here - Login to the system
                        lblLoginError.Text = "Successfully Login.";
                    }
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
            Close();
        }
    }
}
