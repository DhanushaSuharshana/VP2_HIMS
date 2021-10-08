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
using HIMS_Project.BLL;
using HIMS_Project.Functions;
using HIMS_Project.Model;

namespace HIMS_Project.PL
{
    public partial class ComplaintsModule : Form
    {
        TblUsers_BLL TblUsers_BLL;
        TblComplaintType_BLL TblComplaintType_BLL;
        TblComplaints_BLL TblComplaints_BLL;
        public ComplaintsModule()
        {
            InitializeComponent();
            TblUsers_BLL = new TblUsers_BLL();
            TblComplaintType_BLL = new TblComplaintType_BLL();
            TblComplaints_BLL = new TblComplaints_BLL();
        }

        private void ComplaintsModule_Load(object sender, EventArgs e)
        {
            cmbLoadPatients();
            cmbLoadComplaintType();
            cmbComplaintType.Focus();
            UserAccessComponent(LoggedInUser.UserRole);
            DgvAllComplaint(); // Fetch All Complaints Detail to the DGV
        }

        #region Loginned user access
        // view component each loginned user
        private void UserAccessComponent(int UserRole)
        {
            if (UserRole == 1) // If user will Admin
            {
                pnlComplaintForm.Enabled = false;
                btnComplaintSave.Hide();
                btnComplaintEdit.Enabled = false;
                btnComplaintDelete.Enabled = false;
            }
            if (UserRole == 2) // If user will Receptionist
            {
                btnComplaintUpdate.Hide();
                pnlDgvBtn.Hide();
            }
            if (UserRole == 4) // If user will Patient
            {
                btnComplaintUpdate.Hide();
                pnlDgvBtn.Hide();
                txtActionTaken.Enabled = false;
                AppointmentFunc.ShowUserName(cmbComplaintBy); // view loggedin patient name
                cmbComplaintBy.Enabled = false;
            }

        }
        #endregion Loginned user access

        // Load All Patients to Combo box
        private void cmbLoadPatients()
        {
            TblUsers_BLL.cmbLoadAllPatients(cmbComplaintBy);
            cmbComplaintBy.SelectedIndex = -1;
        }

        // Load All Specialty Area to Combo box
        private void cmbLoadComplaintType()
        {
            TblComplaintType_BLL.cmbLoadExistComType(cmbComplaintType);
            cmbComplaintType.SelectedIndex = -1;
        }

        private void DgvAllComplaint()
        {
            TblComplaints_BLL.LoadAllComplaintsToGrid(dgvComplaint);
        }

        private void AllClear()
        {
            cmbComplaintType.SelectedIndex = -1;
            cmbComplaintBy.SelectedIndex = -1;
            txtComplaintId.Text = "";
            txtPhoneNo.Text = "";
            txtCDescription.Text = "";
            txtActionTaken.Text = "";
            txtComplaintNote.Text = "";
            cmbComplaintType.Focus();
            UserAccessComponent(LoggedInUser.UserRole);
        }

        public int AddComplaint()
        {
            var Complaint = new TblComplaints // create new object to store form data
            {
                ComplaintBy = cmbComplaintBy.SelectedIndex.ToString(), // replace to random number generate
                Contact = int.Parse(txtPhoneNo.Text),
                CDate = DateTime.Now,
                CDescription = txtCDescription.Text,
                ActionTaken = txtActionTaken.Text,
                Note = txtComplaintNote.Text,
                Attachment = "No Attachment",
                ComTypeNo = int.Parse(cmbComplaintType.SelectedIndex.ToString()),

            };
            return TblComplaints_BLL.AddComplaint(Complaint);
        }

        private bool validateFields()
        {
            if (cmbComplaintBy.SelectedIndex == -1)
            {
                ValidateFunc.ValidateEmptyCmbField(cmbComplaintBy);
                return false;
            }
            if (string.IsNullOrEmpty(txtPhoneNo.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtPhoneNo);
                return false;
            }
            if (string.IsNullOrEmpty(txtCDescription.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtCDescription);
                return false;
            }
            if (cmbComplaintType.SelectedIndex == -1)
            {
                ValidateFunc.ValidateEmptyCmbField(cmbComplaintType);
                return false;
            }
            if (!Regex.Match(txtPhoneNo.Text, @"^0?7?\d{8}$").Success) // validate Srilankan mobile number
            {
                ValidateFunc.ValidateContact(txtPhoneNo);
                return false;
            }
            return true;
        }

        private void btnComplaintSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var respond = AddComplaint();
                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DgvAllComplaint();
                        AllClear();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EditComplaints()
        {
            txtComplaintId.Text = dgvComplaint.SelectedRows[0].Cells[0].Value.ToString();
            cmbComplaintBy.Text = dgvComplaint.SelectedRows[0].Cells[1].Value.ToString();
            txtPhoneNo.Text = dgvComplaint.SelectedRows[0].Cells[2].Value.ToString();
            cmbComplaintType.Text = dgvComplaint.SelectedRows[0].Cells[3].Value.ToString();
            txtCDescription.Text = dgvComplaint.SelectedRows[0].Cells[4].Value.ToString();
            txtActionTaken.Text = dgvComplaint.SelectedRows[0].Cells[5].Value.ToString();
            txtComplaintNote.Text = dgvComplaint.SelectedRows[0].Cells[6].Value.ToString();

            btnComplaintUpdate.Show();
            pnlComplaintForm.Enabled = false;
            txtActionTaken.Enabled = true;
        }

        private void btnComplaintEdit_Click(object sender, EventArgs e)
        {
            EditComplaints();
        }

        public int UpdateComplaint()
        {
            var Complaint = new TblComplaints // create new object to store form data
            {
                ActionTaken = txtActionTaken.Text,
                ComplaintId = int.Parse(txtComplaintId.Text),
            };
            return TblComplaints_BLL.UpdateComplaint(Complaint);
        }


        private void btnComplaintUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtActionTaken.Text))
                {
                    ValidateFunc.ValidateEmptyTxtField(txtActionTaken);
                    return;
                }
                else
                {
                    var respond = UpdateComplaint();
                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DgvAllComplaint();
                        AllClear();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeleteComplaint()
        {
            int ComplaintId = int.Parse(dgvComplaint.SelectedRows[0].Cells[0].Value.ToString());
            return TblComplaints_BLL.DeleteComplaint(ComplaintId);
        }

        private void btnComplaintDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var respond = DeleteComplaint();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Removed", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgvAllComplaint();
                    AllClear();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        private void txtComplaintSearch_TextChanged(object sender, EventArgs e)
        {
            TblComplaints_BLL.LoadSpecificComplaintsToGrid(txtComplaintSearch.Text, dgvComplaint);
        }

        private void dgvComplaint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnComplaintEdit.Enabled = true;
            btnComplaintDelete.Enabled = true;
        }

        private void btnComplaintClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
