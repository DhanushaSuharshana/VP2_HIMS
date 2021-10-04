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
    class TblPostal_BLL
    {
        // Fetch All Received Data to Grid View
        public void LoadAllPostalToGrid(DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblPostal_DAL.GetAllReceivedPostal();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Filter Received Postal Details when user search
        public void LoadSpecificRePostalToGrid(string usertext, DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblPostal_DAL.GetUserSearchReceivedPostal(usertext);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Fetch All Dispatched Data to Grid View
        public void LoadAllDiPostalToGrid(DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblDispatchedPostal_DAL.GetAllDispatchedPostal();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Filter Dispatched Postal Details when user search
        public void LoadSpecificDiPostalToGrid(string usertext, DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblDispatchedPostal_DAL.GetUserSearchDispatchedPostal(usertext);
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Send Received Postal Details to Add new record
        public int AddPostal(TblPostal tblPostal)
        {
            try
            {
                return TblPostal_DAL.AddNewReceived(tblPostal);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send Received Postal Details to Update each unique record
        public int UpdatePostal(TblPostal tblPostal)
        {
            try
            {
                return TblPostal_DAL.UpdateReceivedPostal(tblPostal);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send PostalId to delete unique record
        public int DeletePostal(int PostalId)
        {
            try
            {
                return TblPostal_DAL.DeleteReceivedPostal(PostalId);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
