using HIMS_Project.DAL;
using HIMS_Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS_Project.Functions
{
    public class AppointmentFunc
    {
        // Auto Generate an appointment number
        public static string GenerateAppointmentNo()
        {
            string NewNumber="1";

            try
            {
                DataTable _dtable = TblAppointment_DAL.GetMaxAppointmentno();

                foreach (DataRow _dRow in _dtable.Rows)
                {
                    NewNumber = _dRow["AppointmentNo"].ToString();
                }
                if (NewNumber == "0")
                {
                    NewNumber = "1";
                }
                else
                {
                    NewNumber += 1;
                }

                return NewNumber;

            }
            catch (Exception)
            {
                throw;
            }
        }

        // If a user will patient Show his/her name in patient text box
        public static void ShowUserName(ComboBox cmbAppPatient)
        {
            try
            {
                cmbAppPatient.DataSource = TblAppointment_DAL.ShowPatientName();
                cmbAppPatient.DisplayMember = "Name";
                cmbAppPatient.ValueMember = "Name";

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
