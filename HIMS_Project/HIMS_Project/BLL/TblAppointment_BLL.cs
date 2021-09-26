using HIMS_Project.DAL;
using HIMS_Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS_Project.BLL
{
    class TblAppointment_BLL
    {
        // Fetch Data to Grid View
        public void LoadAllAppointmentsToGrid(DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblAppointment_DAL.GetAllAppointment();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Filter Appointment Details when status changed
        public void LoadStatusAppointmentsToGrid(string status, DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblAppointment_DAL.GetStatusAppointment(status);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Filter Appointment Details when user search
        public void LoadSpecificAppointmentsToGrid(string usertext, DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblAppointment_DAL.GetUserSearchAppointment(usertext);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Fetch All existing specialist area
        public void cmbLoadExistSpArea(ComboBox cmbAppSpArea)
        {
            try
            {
                cmbAppSpArea.DataSource = TblAppointment_DAL.GetAllExistSpArea();
                cmbAppSpArea.DisplayMember = "SpecialityArea"; // Combo Box display value
                cmbAppSpArea.ValueMember = "SpecialityArea"; // Loading unique value to identify the Patient
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Fetch All Medical officers for specialty area
        public void cmbLoadSpecialMO(string SpecialityArea, ComboBox cmbAppMO)
        {
            try
            {
                cmbAppMO.DataSource = TblAppointment_DAL.GetAllMO(SpecialityArea);
                cmbAppMO.DisplayMember = "Name";
                cmbAppMO.ValueMember = "Name";
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send Appointment Details to Add new record
        public int AddAppointment(TblAppointments tblAppointments)
        {
            try
            {
                return TblAppointment_DAL.AddNewAppointment(tblAppointments);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send Appointment Details to Update each unique record
        public int UpdateAppointment(TblAppointments tblAppointments)
        {
            try
            {
                return TblAppointment_DAL.UpdateAppointment(tblAppointments);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send AppointmentNo to delete unique record
        public int DeleteAppointment(int AppoinmentNo)
        {
            try
            {
                return TblAppointment_DAL.DeleteAppointment(AppoinmentNo);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
