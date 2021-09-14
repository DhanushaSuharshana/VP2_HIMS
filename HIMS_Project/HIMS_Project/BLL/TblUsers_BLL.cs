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
        // Fetch All Patients
        public void cmbLoadAllPatients(ComboBox cmbPatient)
        {
            try
            {
                cmbPatient.DataSource = TblUsers_DAL.GetAllPatients();
                cmbPatient.DisplayMember = "Name"; // Combo Box display value
                cmbPatient.ValueMember = "UserId"; // Loading unique value to identify the Patient
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Fetch All Medical officers for specialty area
        public void cmbLoadSpecialMO(int spArea, ComboBox cmbMO)
        {
            try
            {
                DataTable _dtable = TblUsers_DAL.GetAllMO();

                // check each rows till find user entered username & password
                foreach (DataRow _dRow in _dtable.Rows)
                {
                    if (spArea == Convert.ToInt32(_dRow["SpecialityArea"])) // If find correct data row
                    {
                        cmbMO.DataSource = TblUsers_DAL.GetAllMO();
                        cmbMO.DisplayMember = "Name";
                        cmbMO.ValueMember = "UserId";
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
