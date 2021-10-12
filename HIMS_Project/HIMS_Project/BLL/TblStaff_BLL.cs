using HIMS_Project.DAL;
using HIMS_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.BLL
{
    class TblStaff_BLL
    {
        // Send staff Details to Add new record
        public int AddStaff(TblStaff tblStaff)
        {
            try
            {
                return TblStaff_DAL.AddNewStaff(tblStaff);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send staff Details to Update each unique record
        public int UpdateStaff(TblStaff tblStaff)
        {
            try
            {
                return TblStaff_DAL.UpdateStaff(tblStaff);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
