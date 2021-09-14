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
                DataTable _dtable = TblAppointment_DAL.GetAllAppointment();

                foreach (DataRow _dRow in _dtable.Rows)
                {
                    if (status == _dRow["AppoinmentStatus"].ToString()) // If find correct data row
                    {
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = TblAppointment_DAL.GetAllAppointment();
                    }
                }
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
                DataTable _dtable = TblAppointment_DAL.GetAllAppointment();

                foreach (DataRow _dRow in _dtable.Rows)
                {
                    if (usertext == _dRow["Patient"].ToString()) // If find correct data row
                    {
                        dgv.AutoGenerateColumns = false;
                        dgv.DataSource = TblAppointment_DAL.GetAllAppointment();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Send Appointment Details to Add new record
        public int AddAppointment(TblAppoinments tblAppointments)
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
        public int UpdateAppointment(TblAppoinments tblAppointments)
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
