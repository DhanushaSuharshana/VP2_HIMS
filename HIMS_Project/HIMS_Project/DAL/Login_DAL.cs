using HIMS_Project.Others;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.DAL
{
    class Login_DAL
    {
        // Select all users from database
        public static DataTable GetUsers()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM TblUsers");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
