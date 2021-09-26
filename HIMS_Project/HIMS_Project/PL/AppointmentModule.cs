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

        // Load All Medical Officers of each selected Specialty area
        private void cmbAppSpArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    //int SpecialtyArea = cmbAppSpArea.SelectedValue(); // get selected value
            //    int SpecialtyArea = cmbAppSpArea.Text;
            //    //Int32.TryParse(cmbAppSpArea.SelectedValue.ToString(), out SpecialtyArea);
            //    TblUsers_BLL.cmbLoadSpecialMO(SpecialtyArea, cmbAppMO);
            //    cmbAppMO.SelectedIndex = -1;

            if (cmbAppSpArea.SelectedValue.ToString() != null)
            {
                string SpecialtyArea = cmbAppSpArea.SelectedValue.ToString();
                TblAppointment_BLL.cmbLoadSpecialMO(SpecialtyArea, cmbAppMO);
            }
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
                btnAppointmentPrint.Hide();
                btnAppointmentDelete.Enabled = false;
            }
            if (UserRole == 2) // If user will Receptionist
            {
                // pnlFormAppointment.Show();
                btnAppointmentDelete.Hide();
                btnAppointmentComplete.Hide();
                btnAppointmentUpdate.Enabled = false;
                btnAppointmentApprove.Enabled = false;
                btnAppointmentEdit.Enabled = false;
                btnAppointmentPrint.Enabled = false;
            }
            if (UserRole == 3) // If user will Medical Officer
            {
                pnlFormAppointment.Hide();
                btnAppointmentApprove.Hide();
                btnAppointmentDelete.Hide();
                btnAppointmentEdit.Hide();
                btnAppointmentPrint.Hide();
                btnAppointmentComplete.Enabled = false;
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
                btnAppointmentPrint.Hide();
                AppointmentFunc.ShowUserName(cmbAppPatient); // view loggedin patient name
                cmbAppPatient.Enabled = false; // disable the ComboBox
            }
                
        }
        #endregion Loginned user access

        // Assign Status for new appointment
        public string NewAppointmentStatus(int UserRole)
        {
            var status = "";
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
        public void validateFields()
        {
            if (cmbAppPatient.SelectedIndex == -1)
            {
                // Call Function to Validate Empty Fiels
                ValidateFunc.ValidateEmptyCmbField(cmbAppPatient);
                return;
            }
            if (string.IsNullOrEmpty(txtAppTime.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtAppTime);
                return;
            }
            if (!Regex.Match(txtAppTime.Text, @"^[0-1]{1}\d{1}:[0-5]{1}\d{1}[AaPp][Mm]$").Success)
            {
                ValidateFunc.ValidateTime(txtAppTime);
                return;
            }
            if (cmbAppSpArea.SelectedIndex == -1)
            {
                ValidateFunc.ValidateEmptyCmbField(cmbAppSpArea);
                return;
            }
            //if(cmbAppMO.SelectedIndex == -1)
            //{
            //    ValidateFunc.ValidateEmptyCmbField(cmbAppMO);
            //}
            if (string.IsNullOrEmpty(txtAppSymptom.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtAppSymptom);
                return;
            }
        }

        public int AddAppointment()
        {
            //TblAppointments _tblAppointments = new TblAppointments();

            var appointment = new TblAppointments // create new object to store form data
            {
                Patient = cmbAppPatient.SelectedValue.ToString(),
                Symptom = txtAppSymptom.Text,
                //MO_Id = int.Parse(cmbAppMO.SelectedValue.ToString()),
                MedicalOfficer = "7",
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
                validateFields();

                var respond = AddAppointment();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAllAppointments(LoggedInUser.UserRole);
                    AllClear();
                }
            }
            catch (Exception)
            {
                throw;
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
            cmbAppPatient.Focus();
            txtAppTime.Text = "";
        }

        public void EditAppointment()
        {
            txtAppointmentNo.Text = dgvAppointment.SelectedRows[0].Cells[1].Value.ToString();
            cmbAppPatient.Text = dgvAppointment.SelectedRows[2].Cells[1].Value.ToString();
            dtpAppDate.Text = dgvAppointment.SelectedRows[3].Cells[1].Value.ToString();
            txtAppTime.Text = dgvAppointment.SelectedRows[4].Cells[1].Value.ToString();
            cmbAppSpArea.Text = dgvAppointment.SelectedRows[5].Cells[1].Value.ToString();
            cmbAppMO.Text = dgvAppointment.SelectedRows[6].Cells[1].Value.ToString();
            txtAppSymptom.Text = dgvAppointment.SelectedRows[7].Cells[1].Value.ToString();

            btnAppointmentUpdate.Enabled = true;
            btnAppointmentSave.Enabled = false;
        }

        public int UpdateAppointment()
        {
            var appointment = new TblAppointments // create new object to store form data
            {
                AppointmentNo = int.Parse(txtAppointmentNo.Text),
                Patient = cmbAppPatient.SelectedValue.ToString(),
                Symptom = txtAppSymptom.Text,
                //MedicalOfficer = cmbAppMO.SelectedValue.ToString(),
                MedicalOfficer = "7",
                SpecialityArea = cmbAppSpArea.SelectedValue.ToString(),
                AppTime = txtAppTime.Text,
                AppDate = dtpAppDate.Text,
            };
            return TblAppointment_BLL.UpdateAppointment(appointment);
        }

        public int DeleteAppointment()
        {
            int AppointmentNo  = int.Parse(dgvAppointment.SelectedRows[0].Cells[1].Value.ToString());
            return TblAppointment_BLL.DeleteAppointment(AppointmentNo);
        }

        public int UpdateAppointmentStatusApproved()
        {
            var NewStatus = new TblAppointments
            {
                AppointmentStatus = "Approved",
                AppointmentNumber = AppointmentFunc.GenerateAppointmentNo(),
            };
            return TblAppointment_BLL.UpdateAppointment(NewStatus);
        }

        public int UpdateAppointmentStatusCompleted()
        {
            var NewStatus = new TblAppointments
            {
                AppointmentStatus = "Completed",
            };
            return TblAppointment_BLL.UpdateAppointment(NewStatus);
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
                validateFields();

                var respond = UpdateAppointment();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAllAppointments(LoggedInUser.UserRole);
                    AllClear();
                }
            }
            catch (Exception)
            {

                throw;
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
                    MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAllAppointments(LoggedInUser.UserRole);
                    AllClear();
                }
            }
            catch (Exception)
            {

                throw;
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
                    dgvAllAppointments(LoggedInUser.UserRole);
                    AllClear();
                }
            }
            catch (Exception)
            {

                throw;
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
                    dgvAllAppointments(LoggedInUser.UserRole);
                    AllClear();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAppointmentPrint_click(object sender, EventArgs e)
        {

        }

        private void dgvAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAppointmentEdit.Enabled = true;
            btnAppointmentDelete.Enabled = true;
            btnAppointmentComplete.Enabled = true;
            var checkStatus = "";

            checkStatus = dgvAppointment.SelectedRows[8].Cells[1].Value.ToString();
            if (checkStatus == "Pending")
            {
                btnAppointmentApprove.Enabled = true;
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
