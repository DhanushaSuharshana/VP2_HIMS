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
    class TblComplaints_BLL
    {
        // Fetch All Complaints Data to Grid View
        public void LoadAllComplaintsToGrid(DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblComplaints_DAL.GetAllComplaints();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Filter Complaints Details when user search
        public void LoadSpecificComplaintsToGrid(string usertext, DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblComplaints_DAL.GetUserSearchComplaints(usertext);
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Send Complaint Details to Add new record
        public int AddComplaint(TblComplaints tblComplaints)
        {
            try
            {
                return TblComplaints_DAL.AddNewComplaint(tblComplaints);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send Complaint Details to Update each unique record
        public int UpdateComplaint(TblComplaints tblComplaints)
        {
            try
            {
                return TblComplaints_DAL.UpdateComplaint(tblComplaints);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send ComplaintId to delete unique record
        public int DeleteComplaint(int ComplaintId)
        {
            try
            {
                return TblComplaints_DAL.DeleteComplaint(ComplaintId);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
