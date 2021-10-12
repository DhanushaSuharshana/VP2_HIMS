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
    public partial class AppointmentModule : Form
    {
        TblUsers_BLL TblUsers_BLL;
        TblAppointment_BLL TblAppointment_BLL;

        public AppointmentModule()
        {
            InitializeComponent();
            TblUsers_BLL = new TblUsers_BLL();
            TblAppointment_BLL = new TblAppointment_BLL();
        }

        // When form load
        private void AppointmentModule_Load(object sender, EventArgs e)
        {
            cmbLoadPatients();
            cmbLoadSpArea();
            cmbLoadMO();
            dgvAllAppointments(LoggedInUser.UserRole);
            UserAccessComponent(LoggedInUser.UserRole);
        }

        // Load All Patients to Combo box
        private void cmbLoadPatients()
        {
            TblUsers_BLL.cmbLoadAllPatients(cmbAppPatient);
            cmbAppPatient.SelectedIndex = -1;
        }

        // Load All Specialty Area to Combo box
        private void cmbLoadSpArea()
        {
            TblAppointment_BLL.cmbLoadExistSpArea(cmbAppSpArea);
            cmbAppSpArea.SelectedIndex = -1;
        }
        private void cmbLoadMO()
        {
            TblAppointment_BLL.cmbLoadExistMO(cmbAppMO);
            cmbAppMO.SelectedIndex = -1;
        }

        // Load All Medical Officers of each selected Specialty area
        private void cmbAppSpArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLoadMO();
        }

        // Load Appointment data to data grid view
        private void dgvAllAppointments(int UserRole)
        {
            if (UserRole == 3)  // If the loggined user Medical officer
            {
                var status = "Approved";
                TblAppointment_BLL.LoadStatusAppointmentsToGrid(status,dgvAppointment);
            }
            else
            {
                TblAppointment_BLL.LoadAllAppointmentsToGrid(dgvAppointment);
            }
        }

        #region Loginned user access
        // view component each loginned user
        private void UserAccessComponent(int UserRole)
        {
            if (UserRole == 1) // If user will Admin
            {
                pnlFormAppointment.Hide();
                btnAppointmentApprove.Hide();
                btnAppointmentComplete.Hide();
                btnAppointmentEdit.Hide();
                btnAppointmentDelete.Enabled = false;
                pnlAppointmentView.Width = 887;
                pnlAppointmentView.Height = 624;
            }
            if (UserRole == 2) // If user will Receptionist
            {
                // pnlFormAppointment.Show();
                btnAppointmentDelete.Hide();
                btnAppointmentComplete.Hide();
                btnAppointmentUpdate.Hide();
                btnAppointmentApprove.Enabled = false;
                btnAppointmentEdit.Enabled = false;
                pnlAppointmentView.Width = 736;
                pnlAppointmentView.Height = 624;
            }
            if (UserRole == 3) // If user will Medical Officer
            {
                pnlFormAppointment.Hide();
                btnAppointmentApprove.Hide();
                btnAppointmentDelete.Hide();
                btnAppointmentEdit.Hide();
                btnAppointmentComplete.Enabled = false;
                pnlAppointmentView.Width = 887;
                pnlAppointmentView.Height = 624;
            }
            if (UserRole == 4) // If user will Patient
            {
                //pnlFormAppointment.Show();
                lblShowAppointmentMsg.Show();
                btnAppointmentUpdate.Hide();
                btnAppointmentComplete.Hide();
                btnAppointmentApprove.Hide();
                btnAppointmentDelete.Hide();
                btnAppointmentEdit.Hide();
                AppointmentFunc.ShowUserName(cmbAppPatient); // view loggedin patient name
                cmbAppPatient.Enabled = false; // disable the ComboBox
                pnlAppointmentView.Width = 736;
                pnlAppointmentView.Height = 624;
            }
                
        }
        #endregion Loginned user access

        // Assign Status for new appointment
        public string NewAppointmentStatus(int UserRole)
        {
            var status = "Pending";
            if (UserRole == 2)
                status = "Approved";
            if(UserRole == 4)
                status = "Pending";
            return status;
        }

        // Generate New Appointment Number
        public string NewAppointmentNumber(int UserRole)
        {
            string NewNo = "N/A";
            if (UserRole == 2)
                NewNo = AppointmentFunc.GenerateAppointmentNo();
            return NewNo;
        }
        public bool validateFields()
        {
            if (cmbAppPatient.SelectedIndex == -1)
            {
                // Call Function to Validate Empty Fiels
                ValidateFunc.ValidateEmptyCmbField(cmbAppPatient);
                return false;
            }
            if (string.IsNullOrEmpty(txtAppTime.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtAppTime);
                return false;
            }
            if (!Regex.Match(txtAppTime.Text, @"^[0-1]{1}\d{1}:[0-5]{1}\d{1}[AaPp][Mm]$").Success)
            {
                ValidateFunc.ValidateTime(txtAppTime);
                return false;
            }
            if (cmbAppSpArea.SelectedIndex == -1)
            {
                ValidateFunc.ValidateEmptyCmbField(cmbAppSpArea);
                return false;
            }
            if (cmbAppMO.SelectedIndex == -1)
            {
                ValidateFunc.ValidateEmptyCmbField(cmbAppMO);
                return false;
            }
            if (string.IsNullOrEmpty(txtAppSymptom.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtAppSymptom);
                return false;
            }
            return true;
        }

        public int AddAppointment()
        {
            //TblAppointments _tblAppointments = new TblAppointments();

            var appointment = new TblAppointments // create new object to store form data
            {
                Patient = cmbAppPatient.SelectedValue.ToString(),
                Symptom = txtAppSymptom.Text,
                MedicalOfficer = cmbAppMO.SelectedValue.ToString(),
                SpecialityArea = cmbAppSpArea.SelectedValue.ToString(),
                AppointmentStatus = NewAppointmentStatus(LoggedInUser.UserRole),
                AppointmentNumber = NewAppointmentNumber(LoggedInUser.UserRole),
                AppTime = txtAppTime.Text,
                AppDate = dtpAppDate.Text,
            };
            return TblAppointment_BLL.AddAppointment(appointment);
        }

        // Save Appointment Detail
        private void btnAppointmentSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var respond = AddAppointment();
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

        // Clear Form
        public void AllClear()
        {
            txtAppointmentNo.Text = "";
            cmbAppPatient.SelectedIndex = -1;
            cmbAppSpArea.SelectedIndex = -1;
            cmbAppMO.SelectedIndex = -1;
            txtAppSymptom.Text = "";
            txtAppTime.Text = "";
            cmbAppPatient.Focus();
            UserAccessComponent(LoggedInUser.UserRole);
            dgvAllAppointments(LoggedInUser.UserRole);
            btnAppointmentUpdate.Hide();
            btnAppointmentSave.Show();
        }

        public void EditAppointment()
        {
            txtAppointmentNo.Text = dgvAppointment.SelectedRows[0].Cells[0].Value.ToString();
            cmbAppPatient.Text = dgvAppointment.SelectedRows[0].Cells[2].Value.ToString();
            dtpAppDate.Text = dgvAppointment.SelectedRows[0].Cells[3].Value.ToString();
            txtAppTime.Text = dgvAppointment.SelectedRows[0].Cells[4].Value.ToString();
            cmbAppSpArea.Text = dgvAppointment.SelectedRows[0].Cells[5].Value.ToString();
            cmbAppMO.Text = dgvAppointment.SelectedRows[0].Cells[6].Value.ToString();
            txtAppSymptom.Text = dgvAppointment.SelectedRows[0].Cells[7].Value.ToString();

            btnAppointmentUpdate.Show();
            btnAppointmentSave.Hide();
        }

        public int UpdateAppointment()
        {
            var appointment = new TblAppointments // create new object to store form data
            {
                AppointmentNo = int.Parse(txtAppointmentNo.Text),
                AppointmentNumber = NewAppointmentNumber(LoggedInUser.UserRole),
                Patient = cmbAppPatient.SelectedValue.ToString(),
                Symptom = txtAppSymptom.Text,
                MedicalOfficer = cmbAppMO.SelectedValue.ToString(),
                SpecialityArea = cmbAppSpArea.SelectedValue.ToString(),
                AppTime = txtAppTime.Text,
                AppDate = dtpAppDate.Text,
                AppointmentStatus = NewAppointmentStatus(LoggedInUser.UserRole),
            };
            return TblAppointment_BLL.UpdateAppointment(appointment);
        }

        public int DeleteAppointment()
        {
            int AppointmentNo  = int.Parse(dgvAppointment.SelectedRows[0].Cells[0].Value.ToString());
            return TblAppointment_BLL.DeleteAppointment(AppointmentNo);
        }

        public int UpdateAppointmentStatusApproved()
        {
            var appointmentID = dgvAppointment.SelectedRows[0].Cells[0].Value.ToString();
            var NewStatus = new TblAppointments
            {
                AppointmentStatus = "Approved",
                AppointmentNumber = AppointmentFunc.GenerateAppointmentNo(),
                AppointmentNo = int.Parse(appointmentID),
            };
            return TblAppointment_BLL.UpdateApprovedAppointment(NewStatus);
        }

        public int UpdateAppointmentStatusCompleted()
        {
            var appointmentID = dgvAppointment.SelectedRows[0].Cells[0].Value.ToString();
            var NewStatus = new TblAppointments
            {
                AppointmentStatus = "Completed",
                AppointmentNo = int.Parse(appointmentID),
            };
            return TblAppointment_BLL.UpdateCompleteAppointment(NewStatus);
        }

        // close appointment tab
        private void btnAppointmentClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAppointmentUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var respond = UpdateAppointment();
                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AllClear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnAppointmentClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        private void btnAppointmentApprove_Click(object sender, EventArgs e)
        {
            try
            {
                var respond = UpdateAppointmentStatusApproved();
                if (respond > 0)
                {
                    MessageBox.Show("Appointment Approved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AllClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnAppointmentComplete_Click(object sender, EventArgs e)
        {
            try
            {
                var respond = UpdateAppointmentStatusCompleted();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AllClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAppointmentEdit_Click(object sender, EventArgs e)
        {
            EditAppointment();
        }

        private void btnAppointmentDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var respond = DeleteAppointment();
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

        private void btnAppointmentPrint_click(object sender, EventArgs e)
        {

        }

        private void dgvAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAppointmentEdit.Enabled = true;
            btnAppointmentDelete.Enabled = true;
            
            //var checkStatus = "";

            var checkStatus = dgvAppointment.SelectedRows[0].Cells[8].Value.ToString();
            if (checkStatus == "Pending")
            {
                btnAppointmentApprove.Enabled = true;
            }
            if (checkStatus == "Approved")
            {
                btnAppointmentComplete.Enabled = true;
            }
        }

        private void cmbFilterAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var SelectStatus = cmbFilterAppointment.SelectedValue.ToString();
            var SelectStatus = cmbFilterAppointment.Text;
            TblAppointment_BLL.LoadStatusAppointmentsToGrid(SelectStatus, dgvAppointment);
        }

        private void txtAppointmentSearch_TextChanged(object sender, EventArgs e)
        {
            TblAppointment_BLL.LoadSpecificAppointmentsToGrid(txtAppointmentSearch.Text, dgvAppointment);
        }

        private void btnAppointmentSearch_Click(object sender, EventArgs e)
        {
            TblAppointment_BLL.LoadSpecificAppointmentsToGrid(txtAppointmentSearch.Text, dgvAppointment);
        }
    }
}
