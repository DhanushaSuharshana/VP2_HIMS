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
        string NewNumber = "1";
        int LastNumber;
        string countNo = "";
            try
            {
                DataTable _dtable = TblAppointment_DAL.GetMaxAppointmentno();

                foreach (DataRow _dRow in _dtable.Rows)
                {
                    countNo = _dRow["CountNo"].ToString();

                    if (countNo == "0")
                    {
                        NewNumber = "1";
                    }
                    else
                    {
                        LastNumber = Convert.ToInt32(_dRow["LastAppointmentNo"]);
                        NewNumber = LastNumber.ToString();
                    }
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
                cmbAppPatient.DisplayMember = "UName";
                cmbAppPatient.ValueMember = "UName";

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
