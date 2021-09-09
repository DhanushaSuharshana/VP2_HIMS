using System;
using System.Data;
using System.Data.SqlClient;
using HIMS_Project.Others;
using HIMS_Project.Model;

namespace HIMS_Project.DAL
{
    class TblUsers_DAL
    {

        // Select login user details from DB to check whether the entered username & password correct or not 
        //public DataTable GetUserByUsername(TblUsers LoginUser)
        //{
        //    try
        //    {
        //        string sql = string.Format("SELECT * FROM TblUsers WHERE Username=@Username AND UPassword=@UPassword");
        //        SqlParameter[] sqlpara = new SqlParameter[2];

        //        sqlpara[0] = sqlParameterFormat.Format("@Username", LoginUser.Username);
        //        sqlpara[1] = sqlParameterFormat.Format("@UPassword", LoginUser.UPassword);

        //        return ODBC.GetData(sql, sqlpara);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

    }
}
