using HIMS_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS_Project.PL
{
    public partial class UserModule : Form
    {
        int UserRoleId;
        public UserModule()
        {
            InitializeComponent();
        }

        private void UserModule_Load(object sender, EventArgs e)
        {
            UserAccessComponent(LoggedInUser.UserRole);
        }

        #region Loginned user access
        // view component each loginned user
        private void UserAccessComponent(int UserRole)
        {
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

        }

        private void DgvAllPatients()
        {

        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

            pnlformButtons.Enabled = true;
            btnUserUpdate.Hide();

            var user_role = cmbUserRole.SelectedIndex.ToString();
            if (user_role == "Receptionist")
            {
                pnlCommonDetail.Enabled = true;
                pnlPatientUser.Hide();
                pnlStaffDetail.Show();
                label16.Hide();
                cmbStaffSpArea.Hide();
                UserRoleId = 2;
            }
            if (user_role == "Medical Officer")
            {
                pnlCommonDetail.Enabled = true;
                pnlPatientUser.Hide();
                pnlStaffDetail.Show();
                UserRoleId = 3;
            }
            if (user_role == "Patient")
            {
                pnlCommonDetail.Enabled = true;
                pnlPatientUser.Show();
                pnlStaffDetail.Hide();
                UserRoleId = 4;
            }
        }

        private void btnUsersClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
