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
    public partial class UserModule : Form
    {
        TblUsers_BLL TblUsers_BLL;
        TblStaff_BLL TblStaff_BLL;
        CryptoLab_BLL CryptoLab_BLL;
        TblSpecialtyArea_BLL TblSpecialtyArea_BLL;
        public UserModule()
        {
            InitializeComponent();
            TblUsers_BLL = new TblUsers_BLL();
            TblStaff_BLL = new TblStaff_BLL();
            CryptoLab_BLL = new CryptoLab_BLL();
            TblSpecialtyArea_BLL = new TblSpecialtyArea_BLL();
        }

        private void UserModule_Load(object sender, EventArgs e)
        {
            UserAccessComponent(LoggedInUser.UserRole);
            cmbLoadSpArea();
            txtName.Focus();
        }

        // Load All Specialty Area to Combo box
        private void cmbLoadSpArea()
        {
            TblSpecialtyArea_BLL.cmbLoadAllSpArea(cmbStaffSpArea);
            cmbStaffSpArea.SelectedIndex = -1;
        }

        #region Loginned user access
        // view component each loginned user
        private void UserAccessComponent(int UserRole)
        {
            btnUserEdit.Enabled = false;
            btnUserDelete.Enabled = false;
            btnClear.Enabled = true;

            if (UserRole == 1) // If user will Admin
            {
                pnlCommonDetail.Enabled = false;
                pnlPatientUser.Hide();
                pnlStaffDetail.Hide();
                pnlformButtons.Enabled = false;
                /*
                 * Fetch All Users Detail to the DGV
                 */
                DgvAllUsers();
            }
            if (UserRole == 2) // If user will Receptionist
            {
                label2.Hide();
                cmbUserRole.Hide();
                pnlCommonDetail.Enabled = true;
                pnlPatientUser.Enabled = true;
                pnlStaffDetail.Hide();
                btnUserUpdate.Hide();
                /*
                 * Fetch Only Patient Users Detail to the DGV
                 */
                DgvAllPatients();
            }

        }
        #endregion Loginned user access

        private void DgvAllUsers()
        {
            TblUsers_BLL.LoadAllUsersToGrid(dgvUsers);
        }

        private void DgvAllPatients()
        {
            TblUsers_BLL.LoadAllPatientUsersToGrid(dgvUsers);
        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCommonDetail.Enabled = true;
            pnlformButtons.Enabled = true;
            btnUserUpdate.Hide();
            //txtUserRoleId.Text = "OK";
            var user_role = cmbUserRole.Text;
            if (user_role == "Receptionist")
            {
                pnlPatientUser.Hide();
                pnlStaffDetail.Show();
                label16.Hide();
                cmbStaffSpArea.Hide();
                txtUserRoleId.Text = "2";
            }
            if (user_role == "Medical Officer")
            {
                //label16.Hide();
                cmbStaffSpArea.Show();
                pnlPatientUser.Hide();
                pnlStaffDetail.Show();
                txtUserRoleId.Text = "3";
            }
            if (user_role == "Patient")
            {
                pnlPatientUser.Show();
                pnlStaffDetail.Hide();
                txtUserRoleId.Text = "4";
            }
        }
        private void AllClear()
        {
            cmbUserRole.SelectedIndex = -1;
            txtUserId.Text = "";
            txtName.Text = "";
            txtUsername.Text = "";
            txtAddress.Text = "";
            txtNIC.Text = "";
            txtContact.Text = "";
            cmbGender.SelectedIndex = -1;
            cmbMaritalStatus.SelectedIndex = -1;
            cmbBloodGroup.SelectedIndex = -1;
            txtAllergies.Text = "";
            txtStaffId.Text = "";
            txtStaffEmail.Text = "";
            cmbStaffSpArea.SelectedIndex = -1;
            txtUserSearch.Text = "";
            dtpDOB.Text = "";
            dtpStaffJoinDate.Text = "";
            txtUserRoleId.Text = "";
            txtName.Focus();
            UserAccessComponent(LoggedInUser.UserRole);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }
        public int AddStaffDetails()
        {
            var StaffDetails = new TblStaff // create new object to store form data
            {
                StaffId = txtStaffId.Text,
                StaffEmail = txtStaffEmail.Text,
                JoinDate = dtpStaffJoinDate.Text,
                Photograph = "None",
                Attachment = "No Attachment",
                SpecialityArea = cmbStaffSpArea.Text,

            };
            return TblStaff_BLL.AddStaff(StaffDetails);
        }
        // Encrypt Password by using TrippleDES method
        public string EncryptPw()
        {
            var EncryptPw = txtNIC.Text.Trim();
            return CryptoLab_BLL.EncryptText(EncryptPw);
        }

        public int AddUserDetails()
        {
            var UserDetails = new TblUsers // create new object to store form data
            {
                NIC = txtNIC.Text,
                UName = txtName.Text,
                UserAddress = txtAddress.Text,
                DOB = dtpDOB.Text,
                Gender = cmbGender.Text,
                MaritalStatus = cmbMaritalStatus.Text,
                Contact = int.Parse(txtContact.Text),
                Username = txtUsername.Text,
                UPassword = EncryptPw(),
                BloodGroup = cmbBloodGroup.Text,
                Allergies = txtAllergies.Text,
                UserRole = int.Parse(txtUserRoleId.Text),
                StaffId = txtStaffId.Text,
            };
            return TblUsers_BLL.AddUser(UserDetails);
        }
        private bool ValidateUsername()
        {
            bool UsernameFound = TblUsers_BLL.CheckUsername(txtUsername.Text);

            if (UsernameFound) // if username found
            {
                MessageBox.Show("This Username Already Exist", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Text = "";
                txtUsername.Focus();
                return false;
            }
            return true;

        }
        private bool validateFields()
        {
            if (string.IsNullOrEmpty(txtNIC.Text.Trim()))
            {
                ValidateFunc.ValidateEmptyTxtField(txtNIC);
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                ValidateFunc.ValidateEmptyTxtField(txtName);
                return false;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtAddress);
                return false;
            }
            if (cmbGender.SelectedIndex == -1)
            {
                ValidateFunc.ValidateEmptyCmbField(cmbGender);
                return false;
            }
            if (cmbMaritalStatus.SelectedIndex == -1)
            {
                ValidateFunc.ValidateEmptyCmbField(cmbMaritalStatus);
                return false;
            }
            if (string.IsNullOrEmpty(txtContact.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtContact);
                return false;
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtUsername);
                return false;
            }
            if (txtUserRoleId.Text == "4" && cmbBloodGroup.SelectedIndex == -1)
            {
                ValidateFunc.ValidateEmptyCmbField(cmbBloodGroup);
                return false;
            }
            if (string.IsNullOrEmpty(txtContact.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtContact);
                return false;
            }
            if (string.IsNullOrEmpty(txtUserRoleId.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtUserRoleId);
                return false;
            }
            if ((txtUserRoleId.Text == "2" || txtUserRoleId.Text == "3") && string.IsNullOrEmpty(txtStaffId.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtStaffId);
                return false;
            }
            if ((txtUserRoleId.Text == "2" || txtUserRoleId.Text == "3") && string.IsNullOrEmpty(txtStaffEmail.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtStaffEmail);
                return false;
            }
            if ((txtUserRoleId.Text == "3") && cmbStaffSpArea.SelectedIndex == -1)
            {
                ValidateFunc.ValidateEmptyCmbField(cmbStaffSpArea);
                return false;
            }
            if (!Regex.Match(txtNIC.Text, @"^\d{9}[Vv]|^\d{12}$").Success) // validate NIC
            {
                ValidateFunc.ValidateNIC(txtNIC);
                return false;
            }
            if (!Regex.Match(txtContact.Text, @"^0?7?\d{8}$").Success) // validate Srilankan mobile number
            {
                ValidateFunc.ValidateContact(txtContact);
                return false;
            }
            if (!Regex.Match(txtStaffEmail.Text, @"^[A-Za-z0-9!#$%&'+-/=?^`{|}~,.,]{1,}@[A-Za-z]{1,}.[A-Za-z]{1,}$").Success) // validate Email Address
            {
                ValidateFunc.ValidateEmail(txtStaffEmail);
                return false;
            }
            if (!ValidateUsername()) //check whether the username is already exist or not
            {
                return false;
            }
            return true;
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var UserRoleID = txtUserRoleId.Text;
                    var respond = 0;

                    if (UserRoleID == "2" || UserRoleID == "3")
                    {
                        var staffResponse = AddStaffDetails();
                        if (staffResponse > 0)
                        {
                            respond = AddUserDetails();
                        }
                    }
                    else if (UserRoleID == "4")
                    {
                        respond = AddUserDetails();
                    }

                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AllClear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void EditUsers()
        {
            txtUserId.Text = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
            txtNIC.Text = dgvUsers.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = dgvUsers.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = dgvUsers.SelectedRows[0].Cells[3].Value.ToString();
            dtpDOB.Text = dgvUsers.SelectedRows[0].Cells[4].Value.ToString();
            cmbGender.Text = dgvUsers.SelectedRows[0].Cells[5].Value.ToString();
            cmbMaritalStatus.Text = dgvUsers.SelectedRows[0].Cells[6].Value.ToString();
            txtContact.Text = dgvUsers.SelectedRows[0].Cells[7].Value.ToString();
            txtUsername.Text = dgvUsers.SelectedRows[0].Cells[8].Value.ToString();
            cmbBloodGroup.Text = dgvUsers.SelectedRows[0].Cells[10].Value.ToString();
            txtAllergies.Text = dgvUsers.SelectedRows[0].Cells[11].Value.ToString();
            txtStaffId.Text = dgvUsers.SelectedRows[0].Cells[12].Value.ToString();
            txtStaffEmail.Text = dgvUsers.SelectedRows[0].Cells[13].Value.ToString();
            dtpStaffJoinDate.Text = dgvUsers.SelectedRows[0].Cells[14].Value.ToString();
            cmbStaffSpArea.Text = dgvUsers.SelectedRows[0].Cells[15].Value.ToString();
            txtUserRoleId.Text = dgvUsers.SelectedRows[0].Cells[16].Value.ToString();

            txtStaffId.Enabled = false;
            pnlCommonDetail.Enabled = true;
            cmbUserRole.Enabled = false;
            btnUserUpdate.Show();
            btnUserSave.Hide();
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            EditUsers();
        }

        public int UpdateStaffDetails()
        {
            var StaffDetails = new TblStaff // create new object to store form data
            {
                StaffId = txtStaffId.Text,
                StaffEmail = txtStaffEmail.Text,
                JoinDate = dtpStaffJoinDate.Text,
                Photograph = "None",
                Attachment = "No Attachment",
                SpecialityArea = cmbStaffSpArea.Text,

            };
            return TblStaff_BLL.UpdateStaff(StaffDetails);
        }

        public int UpdatUserDetails()
        {
            var UserDetails = new TblUsers // create new object to store form data
            {
                NIC = txtNIC.Text,
                UName = txtName.Text,
                UserAddress = txtAddress.Text,
                DOB = dtpDOB.Text,
                Gender = cmbGender.Text,
                MaritalStatus = cmbMaritalStatus.Text,
                Contact = int.Parse(txtContact.Text),
                Username = txtUsername.Text,
                BloodGroup = cmbBloodGroup.Text,
                Allergies = txtAllergies.Text,
                StaffId = txtStaffId.Text,
            };
            return TblUsers_BLL.UpdateUser(UserDetails);
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var UserRoleID = txtUserRoleId.Text;
                    var respond = 0;

                    if (UserRoleID == "2" || UserRoleID == "3")
                    {
                        var staffResponse = UpdateStaffDetails();
                        if (staffResponse > 0)
                        {
                            respond = UpdatUserDetails();
                        }
                    }
                    else if (UserRoleID == "4")
                    {
                        respond = UpdatUserDetails();
                    }

                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AllClear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public int DeleteUser()
        {
            int UserId = int.Parse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString());
            return TblUsers_BLL.DeleteUser(UserId);
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var respond = DeleteUser();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Removed", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AllClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            if (LoggedInUser.UserRole == 1)
            {
                TblUsers_BLL.LoadSpecificUsersToGrid(txtUserSearch.Text, dgvUsers);
            }
            else if (LoggedInUser.UserRole == 2)
            {
                TblUsers_BLL.LoadSpecificPatientUsersToGrid(txtUserSearch.Text, dgvUsers);
            }
        }
        
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUserEdit.Enabled = true;
            btnUserDelete.Enabled = true;
        }

        private void btnUsersClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
