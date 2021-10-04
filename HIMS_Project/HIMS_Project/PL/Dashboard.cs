using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIMS_Project.BLL;
using HIMS_Project.Model;

namespace HIMS_Project.PL
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // View User Role of Logged in user
            lblMDIUsername.Text = LoggedInUser.Username;
            lblMDIUserRole.Text = LoggedInUser.RoleName;
            customizeMenuDesign();
            UserAccessControl(LoggedInUser.UserRole);
        }

        #region User Access
        // Grant user Priviledgers to login user
        private void UserAccessControl(int UserRole)
        {
            if(UserRole == 2)
            {
                btnReference.Hide();
            }
            else if (UserRole == 3)
            {

            }
            else if (UserRole == 4)
            {

            }
        }
        #endregion User Access

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Menubar Onclick Functions
        // invisible sub menus when form loadiing
        private void customizeMenuDesign()
        {
            pnlSubPostal.Visible = false;
            pnlSubReference.Visible = false;
        }

        // To hide sub menus on button click
        private void HideSubMenu()
        {
            if(pnlSubPostal.Visible == true)
                pnlSubPostal.Visible = false;
            if (pnlSubReference.Visible == true)
                pnlSubReference.Visible = false;
        }

        // Show the relevent sub menu when button click
        private void ShowSubMenu(Panel SubMenu)
        {
            if(SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }
        #endregion Menubar Onclick Functions

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            /*
             * code to be executed
             */
        }

        #region postal section
        private void btnPostal_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubPostal);
        }

        private void btnPostalReceived_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PostalReceivedModule());
            /*
             * code to be executed
             */
            HideSubMenu();
        }

        private void btnPostalDispatched_Click(object sender, EventArgs e)
        {
            /*
             * code to be executed
             */
            HideSubMenu();
        }
        #endregion postal section


        private void btnComplaint_Click(object sender, EventArgs e)
        {
            /*
             * code to be executed
             */
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AppointmentModule());
            /*
             * code to be executed
             */
        }

        #region References section
        private void btnReference_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubReference);
        }

        private void btnReferenceCType_Click(object sender, EventArgs e)
        {
            /*
             * code to be executed
             */
            HideSubMenu();
        }

        private void btnReferenceSpArea_Click(object sender, EventArgs e)
        {
            /*
             * code to be executed
             */
            HideSubMenu();
        }
        #endregion reference section

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserModule());
            /*
             * code to be executed
             */
        }

        private Form activeForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(ChildForm);
            pnlContent.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnDashboardClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login newLogin = new Login();
            this.Close();
            newLogin.Show();

            // Application.Exit();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            // open user profile form
            OpenChildForm(new UserProfile());
        }
    }
}
