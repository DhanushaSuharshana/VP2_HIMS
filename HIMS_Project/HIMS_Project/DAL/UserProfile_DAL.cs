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
    class UserProfile_DAL
    {
        //Fetch All Details from user and staff table
        public static DataTable GetUserDetail()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM TblUsers LEFT JOIN TblStaff ON TblStaff.StaffId=TblUsers.StaffId");
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update user password
        public static int UpdateUserPassword(String NewPw)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblUsers " +
                                           "SET UPassword=@NewPw," +
                                           "WHERE UserId=@UserId");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[2];
                _sql[0] = sqlParameterFormat.Format("@NewPw", NewPw);
                _sql[1] = sqlParameterFormat.Format("@UserId", LoggedInUser.UserId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Update username
        public static int UpdateUsername(String username)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblUsers " +
                                           "SET Username=@username," +
                                           "WHERE UserId=@UserId");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[2];
                _sql[0] = sqlParameterFormat.Format("@username", username);
                _sql[1] = sqlParameterFormat.Format("@UserId", LoggedInUser.UserId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Update Personal Info
        public static int UpdatePersonalInfo(TblUsers tblUsers)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblUsers " +
                                           "SET Username=@Name," +
                                                "UserAddress=@UserAddress," +
                                                "MaritalStatus=@MaritalStatus," +
                                                "Contact=@Contact," +
                                                "Allergies=@Allergies," +
                                           "WHERE UserId=@UserId");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[6];
                _sql[0] = sqlParameterFormat.Format("@Name", tblUsers.Name);
                _sql[1] = sqlParameterFormat.Format("@UserAddress", tblUsers.UserAddress);
                _sql[2] = sqlParameterFormat.Format("@MaritalStatus", tblUsers.MaritalStatus);
                _sql[3] = sqlParameterFormat.Format("@Contact", tblUsers.Contact);
                _sql[4] = sqlParameterFormat.Format("@Allergies", tblUsers.Allergies);
                _sql[5] = sqlParameterFormat.Format("@UserId", LoggedInUser.UserId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        // Update User Proffessional Info
        public static int UpdateStaffInfo(TblStaff tblstaff)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblStaff " +
                                           "SET StaffEmail=@StaffEmail," +
                                                "JoinDate=@JoinDate," +
                                                "SpecialityArea=@SpecialityArea," +
                                                "Photograph=@Photograph," +
                                           "WHERE StaffId=@StaffId");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[6];
                _sql[0] = sqlParameterFormat.Format("@StaffEmail", tblstaff.StaffEmail);
                _sql[1] = sqlParameterFormat.Format("@JoinDate", tblstaff.JoinDate);
                _sql[2] = sqlParameterFormat.Format("@SpecialityArea", tblstaff.SpecialityArea);
                //_sql[3] = sqlParameterFormat.Format("@Photograph", tblstaff.Photograph);
                _sql[4] = sqlParameterFormat.Format("@StaffId", LoggedInUser.StaffId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
