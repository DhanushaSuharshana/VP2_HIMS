using System;
using System.Data;
using System.Data.SqlClient;
using HIMS_Project.Others;
using HIMS_Project.Model;

namespace HIMS_Project.DAL
{
    class TblUsers_DAL
    {
        // Select All Users
        public static DataTable GetAllUsers()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM TblUsers LEFT JOIN TblStaff ON TblUsers.StaffId=TblStaff.StaffId");
            }
            catch (Exception)
            {
                throw;
            }
        }
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
        public static DataTable GetPatientUserSearch(string usertext)
        {
            try
            {
                string sql = string.Format("SELECT * FROM TblUsers INNER JOIN TblUserRole ON TblUserRole.RoleId=TblUsers.UserRole WHERE TblUserRole.RoleName='Patient' AND TblUsers.UName LIKE '%' + @usertext + '%'");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@usertext", usertext);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetUserSearchUsers(string usertext)
        {
            try
            {
                string sql = string.Format("SELECT * FROM TblUsers LEFT JOIN TblStaff ON TblUsers.StaffId=TblStaff.StaffId WHERE TblUsers.UName LIKE '%' + @usertext + '%'");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@usertext", usertext);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region User Profile
        // Select Loginned User Detail for user profile
        public static DataTable GetUserDetail()
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


        // Add new User
        public static int AddNewUser(TblUsers tblUsers)
        {
            try
            {
                // set sql insert query
                string sql = string.Format("INSERT INTO TblUsers" +
                    "(NIC,UName,UserAddress,DOB,Gender,MaritalStatus,Contact,Username,UPassword,BloodGroup,Allergies,UserRole,StaffId) " +
                    "VALUES" +
                    "(@NIC,@UName,@UserAddress,@DOB,@Gender,@MaritalStatus,@Contact,@Username,@UPassword,@BloodGroup,@Allergies,@UserRole,@StaffId)");

                // set parameters
                SqlParameter[] _sql = new SqlParameter[13];
                _sql[0] = sqlParameterFormat.Format("@NIC", tblUsers.NIC);
                _sql[1] = sqlParameterFormat.Format("@UName", tblUsers.UName);
                _sql[2] = sqlParameterFormat.Format("@UserAddress", tblUsers.UserAddress);
                _sql[3] = sqlParameterFormat.Format("@DOB", tblUsers.DOB);
                _sql[4] = sqlParameterFormat.Format("@Gender", tblUsers.Gender);
                _sql[5] = sqlParameterFormat.Format("@MaritalStatus", tblUsers.MaritalStatus);
                _sql[6] = sqlParameterFormat.Format("@Contact", tblUsers.Contact);
                _sql[7] = sqlParameterFormat.Format("@Username", tblUsers.Username);
                _sql[8] = sqlParameterFormat.Format("@UPassword", tblUsers.UPassword);
                _sql[9] = sqlParameterFormat.Format("@BloodGroup", tblUsers.BloodGroup);
                _sql[10] = sqlParameterFormat.Format("@Allergies", tblUsers.Allergies);
                _sql[11] = sqlParameterFormat.Format("@UserRole", tblUsers.UserRole);
                _sql[12] = sqlParameterFormat.Format("@StaffId", tblUsers.StaffId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update User Record

        public static int UpdateUser(TblUsers tblUsers)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblUsers " +
                                           "SET NIC=@NIC," +
                                               "UName=@UName," +
                                               "UserAddress=@UserAddress," +
                                               "DOB=@DOB," +
                                               "Gender=@Gender," +
                                               "MaritalStatus=@MaritalStatus," +
                                               "Contact=@Contact," +
                                               "Username=@Username," +
                                               "BloodGroup=@BloodGroup," +
                                               "Allergies=@Allergies," +
                                               "StaffId=@StaffId" +
                                           " WHERE UserId=@UserId");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[12];
                _sql[0] = sqlParameterFormat.Format("@NIC", tblUsers.NIC);
                _sql[1] = sqlParameterFormat.Format("@UName", tblUsers.UName);
                _sql[2] = sqlParameterFormat.Format("@UserAddress", tblUsers.UserAddress);
                _sql[3] = sqlParameterFormat.Format("@DOB", tblUsers.DOB);
                _sql[4] = sqlParameterFormat.Format("@Gender", tblUsers.Gender);
                _sql[5] = sqlParameterFormat.Format("@MaritalStatus", tblUsers.MaritalStatus);
                _sql[6] = sqlParameterFormat.Format("@Contact", tblUsers.Contact);
                _sql[7] = sqlParameterFormat.Format("@Username", tblUsers.Username);
                _sql[8] = sqlParameterFormat.Format("@BloodGroup", tblUsers.BloodGroup);
                _sql[9] = sqlParameterFormat.Format("@Allergies", tblUsers.Allergies);
                _sql[10] = sqlParameterFormat.Format("@StaffId", tblUsers.StaffId);
                _sql[11] = sqlParameterFormat.Format("@UserId", tblUsers.UserId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Delete User record
        public static int DeleteUser(int UserId)
        {
            try
            {
                // set sql query
                string sql = string.Format("DELETE FROM TblUsers INNER JOIN TblStaff ON TblUsers.StaffId=TblStaff.StaffId WHERE UserId=@UserId");

                // Set parameters
                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = sqlParameterFormat.Format("@UserId", UserId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
