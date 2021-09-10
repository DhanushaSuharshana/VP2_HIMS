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
        public string UserId,RecoverUsername,RecoverPassword;

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
                        UserId = _dRow["UserId"].ToString();
                        UserFound = true;
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
