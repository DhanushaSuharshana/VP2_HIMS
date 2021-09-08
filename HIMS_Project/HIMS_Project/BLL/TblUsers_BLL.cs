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
    class TblUsers_BLL
    {
        public void LoadUserId(TblUsers tblUser)
        {
            try
            {
                return TblUsers_DAL.GetUserByUsername(tblUser);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
