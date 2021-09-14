using HIMS_Project.DAL;
using HIMS_Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.BLL
{
    class Login_BLL
    {
        public string RecoverUsername,RecoverPassword;

        public bool AuthenticateUser(string Username, string UPassword)
        {
            try
            {
                DataTable _dtable = Login_DAL.GetUsers();

                bool UserFound = false;

                // check each rows till find user entered username & password
                foreach(DataRow _dRow in _dtable.Rows)
                {
                    if((Username == _dRow["Username"].ToString()) && (UPassword == _dRow["UPassword"].ToString())) // If find correct data row
                    {
                        //UserId = _dRow["UserId"].ToString();
                        UserFound = true;

                        //DataRow userRow = _dtable.Rows[0];
                        LoggedInUser.Username = _dRow["Username"].ToString();
                        LoggedInUser.UserId = Convert.ToInt32(_dRow["UserId"]);
                        LoggedInUser.UserRole = Convert.ToInt32(_dRow["UserRole"]);
                        LoggedInUser.RoleName = _dRow["RoleName"].ToString();
                    }
                }

                if (!UserFound)
                {
                    return false;
                }

                return UserFound;

            }
            catch (Exception)
            {
                throw;
            }
        }

        // To Confirm exact user request to the recover password
        public bool ConfirmUser(string NIC, string DOB)
        {
            try
            {
                DataTable _dtable2 = Login_DAL.GetUsers();

                bool ReqUserFound = false;

                // check each rows till find user entered NIC & DOB
                foreach (DataRow _dRow2 in _dtable2.Rows)
                {
                    if ((NIC == _dRow2["NIC"].ToString()) && (DOB == _dRow2["DOB"].ToString())) // If find correct data row
                    {
                        RecoverUsername = _dRow2["Username"].ToString();
                        RecoverPassword = _dRow2["UPassword"].ToString();
                        ReqUserFound = true;
                    }
                }

                if (!ReqUserFound)
                {
                    return false;
                }

                return ReqUserFound;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
