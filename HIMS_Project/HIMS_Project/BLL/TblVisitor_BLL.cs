using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIMS_Project.DAL;
using System.Windows.Forms;
using HIMS_Project.Model;
using System.Data;

namespace HIMS_Project.BLL
{
    class TblVisitor_BLL
    {
        // Fetch All Visitor records to Grid View
        public void LoadAllVisitorToGrid(DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblVisitor_DAL.GetAllVisitor();
            }
            catch (Exception)
            {
                throw;
            }   

        }

        //Filter Visitorl Details when user search
        public void LoadSpecificVisitorsToGrid(string usertext, DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblVisitor_DAL.GetUserSearchVisitor(usertext);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send Visitor Details to Add new record
        public int AddVisitor(TblVisitor tblVisitor)
        {
            try
            {
                return TblVisitor_DAL.AddNewVisitor(tblVisitor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send VisitorNo to update unique record
        public static int UpdateVisitorRecord(TblVisitor tblVisitor)
        {
            try
            {
                return TblVisitor_DAL.UpdateVisitorRecord(tblVisitor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send VisitorNo to delete unique record
        public int DeleteVisitorRecord(int VisitorNo)
        {
            try
            {
                return TblVisitor_DAL.DeleteVisitorRecord(VisitorNo);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
