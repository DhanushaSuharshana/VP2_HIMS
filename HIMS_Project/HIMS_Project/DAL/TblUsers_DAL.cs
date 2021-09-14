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

        // Select All Patients
        public static DataTable GetAllPatients()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM TblUsers INNER JOIN TblUserRole ON TblUserRole.RoleId=TblUsers.UserRole WHERE TblUserRole.RoleName='Patient'"); 
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Select All Medical Officers
        public static DataTable GetAllMO()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM TblUsers INNER JOIN TblStaff ON TblStaff.StaffId=TblUsers.StaffId WHERE TblUsers.UserRole=3");
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
