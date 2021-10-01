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
    public partial class PostalReceivedModule : Form
    {
        public PostalReceivedModule()
        {
            InitializeComponent();
        }

        private void PostalReceivedModule_Load(object sender, EventArgs e)
        {
            UserAccessComponent(LoggedInUser.UserRole);
            DgvAllReceivedPostal(); // Fetch All Received Postal Detail to the DGV
                 
        }

        #region Loginned user access
        // view component each loginned user
        private void UserAccessComponent(int UserRole)
        {
            if (UserRole == 1) // If user will Admin
            {
                pnlPostalForm.Hide();
                pnlformButtons.Hide();
                btnRePostalEdit.Hide();
                btnRePostalDelete.Enabled = false;
            }
            if (UserRole == 2) // If user will Receptionist
            {
                btnRePostalUpdate.Hide();
                btnRePostalEdit.Enabled = false;
                btnRePostalDelete.Enabled = false;
            }

        }
        #endregion Loginned user access

        private void DgvAllReceivedPostal()
        {

        }
        private void btnRePostalClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
