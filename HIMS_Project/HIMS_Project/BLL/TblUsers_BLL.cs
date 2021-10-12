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
                cmbPatient.DisplayMember = "UName"; // Combo Box display value
                cmbPatient.ValueMember = "UName"; // Loading unique value to identify the Patient
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Fetch All Users Data to Grid View
        public void LoadAllUsersToGrid(DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblUsers_DAL.GetAllUsers();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Fetch All Patient Users Data to Grid View
        public void LoadAllPatientUsersToGrid(DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblUsers_DAL.GetAllPatients();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Filter Users Details when user search
        public void LoadSpecificUsersToGrid(string usertext, DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblUsers_DAL.GetUserSearchUsers(usertext);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Filter Patients Users Details when user search
        public void LoadSpecificPatientUsersToGrid(string usertext, DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblUsers_DAL.GetPatientUserSearch(usertext);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // To Confirm username already exist or not
        public bool CheckUsername(string username)
        {
            try
            {
                DataTable _dtable2 = Login_DAL.GetUsers();

                bool ReqUserFound = false;

                // check each rows till find user entered username
                foreach (DataRow _dRow2 in _dtable2.Rows)
                {
                    if (username == _dRow2["Username"].ToString()) // If find the data row
                    {
                        ReqUserFound = true;
                    }
                }

                if (!ReqUserFound)
                {
                    return false;
                }

                return ReqUserFound;

            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send Users Details to Add new record
        public int AddUser(TblUsers tblUsers)
        {
            try
            {
                return TblUsers_DAL.AddNewUser(tblUsers);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send Users Details to Update each unique record
        public int UpdateUser(TblUsers tblUsers)
        {
            try
            {
                return TblUsers_DAL.UpdateUser(tblUsers);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send UserId to delete unique record
        public int DeleteUser(int UserId)
        {
            try
            {
                return TblUsers_DAL.DeleteUser(UserId);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
