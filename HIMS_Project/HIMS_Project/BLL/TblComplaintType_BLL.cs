using HIMS_Project.DAL;
using HIMS_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS_Project.BLL
{
    class TblComplaintType_BLL
    {
        // Fetch All Complaint Types to Combo Box
        public void cmbLoadExistComType(ComboBox ComplaintType)
        {
            try
            {
                ComplaintType.DataSource = TblComplaintType_DAL.GetAllComplaintType();
                ComplaintType.DisplayMember = "ComDescription"; // Combo Box display value
                ComplaintType.ValueMember = "TypeNo"; // Loading unique value to identify the Patient
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Fetch All Complaint Types Data to Grid View
        public void LoadAllComplaintTypeToGrid(DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblComplaintType_DAL.GetAllComplaintType();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Filter Complaint Types Details when user search
        public void LoadSpecificCTypeToGrid(string usertext, DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblComplaintType_DAL.GetUserSearchComplaintType(usertext);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send Complaint Types Details to Add new record
        public int AddCType(string ComDescription)
        {
            try
            {
                return TblComplaintType_DAL.AddNewComplaintType(ComDescription);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // SendComplaint Types Details to Update each unique record
        public int UpdateCType(TblComplaintType tblComplaintType)
        {
            try
            {
                return TblComplaintType_DAL.UpdateComplaintType(tblComplaintType);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send CTypeId to delete unique record
        public int DeleteCType(int CTypeId)
        {
            try
            {
                return TblComplaintType_DAL.DeleteComplaintType(CTypeId);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
