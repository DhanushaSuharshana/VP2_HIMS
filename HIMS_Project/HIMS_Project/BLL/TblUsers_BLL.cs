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
    class TblUsers_BLL
    {
        #region Appointment Module ComboBox
        // Fetch All Patients
        public void cmbLoadAllPatients(ComboBox cmbPatient)
        {
            try
            {
                cmbPatient.DataSource = TblUsers_DAL.GetAllPatients();
                cmbPatient.DisplayMember = "UName"; // Combo Box display value
                cmbPatient.ValueMember = "UName"; // Loading unique value to identify the Patient
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        #endregion Appointment Module ComboBox

        #region User Profile
        // Fetch All Logginned User details to user profile form


        #endregion User Profile
    }
}
