using HIMS_Project.BLL;
using HIMS_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS_Project.PL
{
    public partial class PasswordRecover : Form
    {
        public PasswordRecover()
        {
            InitializeComponent();
            txtReqNIC.Focus();
        }

        public void ClearForm()
        {
            txtReqNIC.Text = "";
            dtpReqDOB.Text = "";
            pnlRecoverData.Hide();
        }

        public void RequestLoginDetail()
        {
            Login_BLL userRequest = new Login_BLL();
            bool ReqUserFound = userRequest.ConfirmUser(txtReqNIC.Text, dtpReqDOB.Text);

            if (ReqUserFound) // if user found
            {
                lblReUsername.Text = userRequest.RecoverUsername;
                lblRePassword.Text = userRequest.RecoverPassword;
                lblErrorRequest.Hide();
                pnlRecoverData.Show();
                btnLoginReq.Enabled = false;
            }
            else if (!ReqUserFound) // if user does not found
            {
                lblErrorRequest.Text = "No User Found.";
                lblErrorRequest.Show();
                ClearForm();
                txtReqNIC.Focus();
                return;
            }

        }

        private void btnLoginReq_Click(object sender, EventArgs e)
        {
            try
            {
                //Regex RgNIC = new Regex(@"^\d{9}[Vv]|^\d{12}$");

                // check text boxes are empty or not
                if (txtReqNIC.Text=="" || dtpReqDOB.Text=="")
                {
                    lblErrorRequest.Text = "Required Field Is Empty. Please Fill again.";
                    lblErrorRequest.Show();
                    txtReqNIC.Focus();
                    return;
                }
                // validate if it is a valid NIC or not by using regex
                else if (!Regex.Match(txtReqNIC.Text, @"^\d{9}[Vv]|^\d{12}$").Success)
                {
                    lblErrorRequest.Text = "Invalid NIC. Please Try again.";
                    lblErrorRequest.Show();
                    txtReqNIC.Focus();
                    return;
                }
                else
                {
                    RequestLoginDetail();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnLoginBack_Click(object sender, EventArgs e)
        {
            Login BackToLogin = new Login();
            BackToLogin.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
