using System;
using System.Data;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using HIMS_Project.BLL;
using HIMS_Project.Functions;
using HIMS_Project.Model;

namespace HIMS_Project.PL
{
    public partial class Login : Form
    {
        CryptoLab_BLL _cryptoLab_Bll;
        public Login()
        {
            //Splash Screen Thread ** Suha **
            Thread SplashThread = new Thread(new ThreadStart(StartSplash));
            SplashThread.Start();
            Thread.Sleep(4000);

            //colour changes ** lahiru **
            this.BackColor = Color.DarkGray;
            this.TransparencyKey = Color.DarkGray;
            //to here
            InitializeComponent();


            SplashThread.Abort();
            txtUsername.Focus();

            //Bring Login Infront of all windows ** Suha **
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;

            _cryptoLab_Bll = new CryptoLab_BLL();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        public void StartSplash()
        {
            Application.Run(new SplashScreen());
        }

        public void Clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        #region Encrypt Password
        public string TextEncrypt() // Encrypt Password by using 3Des
        {
            var EncryptPw = txtPassword.Text.Trim();
            return _cryptoLab_Bll.EncryptText(EncryptPw);

        }
        #endregion Encrypt Passwrod

        public void VerifyLoginDetail()
        {
            var password = TextEncrypt();
            Login_BLL userCredentials = new Login_BLL();
            bool UserFound = userCredentials.AuthenticateUser(txtUsername.Text, password);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnPasswordEye_Click(object sender, EventArgs e)
        {
            PasswordFunc.PasswordShowHide(txtPassword);
        }
    }
}
