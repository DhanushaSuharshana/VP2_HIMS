using System;
using System.Data;
using System.Data.SqlClient;
using HIMS_Project.Others;
using HIMS_Project.Model;

namespace HIMS_Project.DAL
{
    class TblUsers_DAL
    {

        // Select login user details from user table
        public static DataTable GetUserByUsername(TblUsers tblUsers)
        {
            try
            {
                string sql = string.Format("SELECT UserId FROM TblUsers WHERE Username=@Username AND UPassword=@UPassword");
                SqlParameter[] sqlpara = new SqlParameter[2];

                sqlpara[0] = sqlParameterFormat.Format("@Username", tblUsers.Username);
                sqlpara[1] = sqlParameterFormat.Format("@UPassword", tblUsers.UPassword);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
