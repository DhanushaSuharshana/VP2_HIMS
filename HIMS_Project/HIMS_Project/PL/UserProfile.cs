using HIMS_Project.BLL;
using HIMS_Project.Functions;
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
    public partial class UserProfile : Form
    {
        UserProfile_BLL UserProfile_BLL;
        TblSpecialtyArea_BLL TblSpecialtyArea_BLL;
        CryptoLab_BLL CryptoLab_BLL;
        public UserProfile()
        {
            InitializeComponent();
            UserProfile_BLL = new UserProfile_BLL();
            CryptoLab_BLL = new CryptoLab_BLL();
            TblSpecialtyArea_BLL = new TblSpecialtyArea_BLL();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            UserAccess(LoggedInUser.UserRole);
            btnPersonalSave.Hide();
            ViewPersonalInfo();
            ViewSpAreas();
        }

        
        public void ViewSpAreas() // View Specialty areas
        {
            TblSpecialtyArea_BLL.cmbLoadAllSpArea(cmbStaffSpArea);
            cmbStaffSpArea.SelectedText = LoggedInUser.SpecialityArea;
        }

        private void ReLogin()
        {
            Login newLogin = new Login();
            this.Close();
            newLogin.Show();
        }

        #region Show Logged In User Profile
        public void ViewPersonalInfo()
        {
            bool LoadUser = UserProfile_BLL.ViewUserDetails(LoggedInUser.UserId);
            
            if (LoadUser)
            {
                txtNIC.Text = LoggedInUser.NIC;
                txtName.Text = LoggedInUser.UName;
                txtAddress.Text = LoggedInUser.UserAddress;
                dtpDOB.Text = LoggedInUser.DOB;
                txtGender.Text = LoggedInUser.Gender;
                cmbMaritalStatus.Text = LoggedInUser.MaritalStatus;
                txtContact.Text = LoggedInUser.Contact.ToString();
                cmbBloodGroup.Text = LoggedInUser.BloodGroup;
                txtAllergies.Text = LoggedInUser.Allergies;
                lblStaffID.Text = LoggedInUser.StaffId;
                txtStaffEmail.Text = LoggedInUser.StaffEmail;
                txtStaffJoinDate.Text = LoggedInUser.JoinDate;
                //pctStaffProfile LoggedInUser.Photograph;
                
                txtUsername.Text = LoggedInUser.Username;
            }
        }
        #endregion Show Logged In User Profile

        #region Control User Access
        public void UserAccess(int UserRole)
        {
            if (UserRole == 1)
            {
                pnlUserStaff.Hide();
            }
            if (UserRole == 4)
            {
                pnlUserStaff.Hide();
                lblBloodGroup.Show();
                lblAllergies.Show();
                cmbBloodGroup.Show();
                txtAllergies.Show();
            }
        }

        #endregion Control User Access

        #region Personal Info Section
        //enable to edit personal info
        private void btnPersonalEdit_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            cmbMaritalStatus.Enabled = true;
            txtContact.Enabled = true;
            txtAllergies.Enabled = true;
            btnPersonalSave.Show();
            btnPersonalEdit.Hide();
        }

        // Personal Information Update
        public int UpdatePersonalInfo()
        {
            var user = new TblUsers // create new object to store form data
            {
                UName = txtName.Text,
                UserAddress = txtAddress.Text,
                MaritalStatus = cmbMaritalStatus.Text,
                Contact = int.Parse(txtContact.Text),
                Allergies = txtAllergies.Text,
            };
            return UserProfile_BLL.UpdatePersonalInfo(user);
        }

        // save changed personal info
        private void btnPersonalSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text)) // if the textbox empty
                {
                    ValidateFunc.ValidateEmptyTxtField(txtName);
                    return;
                }
                else if (string.IsNullOrEmpty(txtAddress.Text)) // if the textbox empty
                {
                    ValidateFunc.ValidateEmptyTxtField(txtAddress);
                    return;
                }
                else if (string.IsNullOrEmpty(cmbMaritalStatus.Text)) // if the ComboBox empty
                {
                    ValidateFunc.ValidateEmptyCmbField(cmbMaritalStatus);
                    return;
                }
                else if (string.IsNullOrEmpty(txtContact.Text)) // if the textbox empty
                {
                    ValidateFunc.ValidateEmptyTxtField(txtContact);
                    return;
                }
                else if (!Regex.Match(txtContact.Text, @"^0?7?\d{8}$").Success) // validate Srilankan mobile number
                {
                    ValidateFunc.ValidateContact(txtContact);
                    return;
                }
                else
                {
                    UpdatePersonalInfo();
                }

                var respond = UpdatePersonalInfo();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReLogin();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        #endregion Personal Info Section

        #region Login Credintials Section
        private void btnUsernameEdit_Click(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
        }

        // Username change
        public int UpdateUsername()
        {
            string username = txtUsername.Text;
            return UserProfile_BLL.UpdateUsername(username);
        }

        private void btnUsernameSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text)) // if the textbox empty
                {
                    ValidateFunc.ValidateEmptyTxtField(txtUsername);
                    return;
                }
                else
                {
                    UpdateUsername();
                }

                var respond = UpdateUsername();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReLogin();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Show change password area
        private void btnPasswordArea_Click(object sender, EventArgs e)
        {
            pnlUserPassword.Show();
        }

        // Password show hide

        private void btnOldPasswordEye_Click(object sender, EventArgs e)
        {
            PasswordFunc.PasswordShowHide(txtOldPw);
        }

        private void btnNewPasswordEye_Click(object sender, EventArgs e)
        {
            PasswordFunc.PasswordShowHide(txtNewPw);
        }

        private void btnConfirmPasswordEye_Click(object sender, EventArgs e)
        {
            PasswordFunc.PasswordShowHide(txtConfirmPw);
        }

        // Check Password Encryption by using TrippleDES method
        public string TextEncrypt()
        {
            var EncryptPw = txtOldPw.Text.Trim();
            return CryptoLab_BLL.EncryptText(EncryptPw);
        }

        // Encrypt New Password by using TrippleDES method
        public string EncryptNewPw()
        {
            var EncryptPw = txtNewPw.Text.Trim();
            return CryptoLab_BLL.EncryptText(EncryptPw);
        }

        // Password change
        public int UpdateUserPassword()
        {
            string NewPw = EncryptNewPw();
            return UserProfile_BLL.UpdateUserPassword(NewPw);
        }

        // Save Change password
        private void btnLoginPwChange_Click(object sender, EventArgs e)
        {
            try
            {
                var OldPw = TextEncrypt();
                if (string.IsNullOrEmpty(txtOldPw.Text)) // if the textbox empty
                {
                    ValidateFunc.ValidateEmptyTxtField(txtOldPw);
                    return;
                }
                else if (string.IsNullOrEmpty(txtNewPw.Text)) // if the textbox empty
                {
                    ValidateFunc.ValidateEmptyTxtField(txtNewPw);
                    return;
                }
                else if (string.IsNullOrEmpty(txtConfirmPw.Text)) // if the textbox empty
                {
                    ValidateFunc.ValidateEmptyTxtField(txtConfirmPw);
                    return;
                }
                else if (!(OldPw == LoggedInUser.UPassword)) // If OldPassword doesn't match with user password
                {
                    MessageBox.Show("Password doesn't match.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOldPw.Text = "";
                    txtOldPw.Focus();
                    return;
                }
                else if (!Regex.Match(txtNewPw.Text, @"^((?=.*[A-Z])(?=.*[a-z])(?=.*\d)|(?=.*[a-z])(?=.*\d)(?=.*[(~!@#$%^&*\-+=`|\(){}[\]:;'<>,.?/).])|(?=.*[A-Z])(?=.*\d)(?=.*[(~!@#$%^&*\-+=`|\(){}[\]:;'<>,.?/).])|(?=.*[A-Z])(?=.*[a-z])(?=.*[(~!@#$%^&*\-+=`|\(){}[\]:;'<>,.?/).])).{8,15}$").Success) // If the Password not valid
                {
                    ValidateFunc.ValidatePassword(txtNewPw);
                    return;
                }
                else if (!(txtNewPw.Text == txtConfirmPw.Text)) // If the New password & confirmation password different
                {
                    MessageBox.Show("Password Confirmation Failed.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPw.Text = "";
                    txtConfirmPw.Focus();
                    return;
                }
                else
                {
                    UpdateUserPassword();
                }

                var respond = UpdateUserPassword();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOldPw.Text = "";
                    txtNewPw.Text = "";
                    txtConfirmPw.Text = "";
                    ReLogin();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion Login Credintials Section

        #region professional info
        private void btnStaffProfileEdit_Click(object sender, EventArgs e)
        {
            txtStaffEmail.Enabled = true;
            txtStaffJoinDate.Enabled = true;
            cmbStaffSpArea.Enabled = true;
            btnStaffProfileEdit.Hide();
            btnStaffProfileSave.Show();
        }

        public int UpdateStaffInfo()
        {
            var staff = new TblStaff
            {
                StaffEmail = txtStaffEmail.Text,
                JoinDate = txtStaffJoinDate.Text,
                SpecialityArea = cmbStaffSpArea.Text,
            };
            return UserProfile_BLL.UpdateStaffInfo(staff);
        }

        // Save changed staff details
        private void btnStaffProfileSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtStaffEmail.Text)) // if the textbox empty
                {
                    ValidateFunc.ValidateEmptyTxtField(txtStaffEmail);
                    return;
                }
                else if (!Regex.Match(txtStaffEmail.Text, @"^[A-Za-z0-9!#$%&'+-/=?^`{|}~,.,]{1,}@[A-Za-z]{1,}.[A-Za-z]{1,}$").Success) // validate Email Address
                {
                    ValidateFunc.ValidateEmail(txtStaffEmail);
                    return;
                }
                else
                {
                    UpdateStaffInfo();
                }

                var respond = UpdateStaffInfo();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReLogin();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion professional info

        private void btnUserProfileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
