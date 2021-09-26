using HIMS_Project.Model;
using HIMS_Project.Others;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.DAL
{
    class TblStaff_DAL
    {
        #region User Profile

        public static DataTable GetUserStaffDetail()
        {
            try
            {
                string sql = string.Format("SELECT * FROM TblUsers WHERE UserId=@UserId");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@UserId", LoggedInUser.UserId);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion User Profile
    }
}
