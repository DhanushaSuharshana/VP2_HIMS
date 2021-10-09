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
    class UserProfile_BLL
    {
        public static bool ViewUserDetails(int UserId)
        {
            bool LoadUser = false;
            DataTable _dtable = UserProfile_DAL.GetUserDetail();

            foreach (DataRow _dRow in _dtable.Rows)
            {
                if(UserId == Convert.ToInt32(_dRow["UserId"]))
                {
                    LoadUser = true;
                    LoggedInUser.NIC = _dRow["NIC"].ToString();
                    LoggedInUser.UName = _dRow["UName"].ToString();
                    LoggedInUser.UserAddress = _dRow["UserAddress"].ToString();
                    LoggedInUser.DOB = _dRow["DOB"].ToString();
                    LoggedInUser.Gender = _dRow["Gender"].ToString();
                    LoggedInUser.MaritalStatus = _dRow["MaritalStatus"].ToString();
                    LoggedInUser.Contact = Convert.ToInt32(_dRow["Contact"]);

                    LoggedInUser.UPassword = _dRow["UPassword"].ToString();

                    LoggedInUser.BloodGroup = _dRow["BloodGroup"].ToString();
                    LoggedInUser.Allergies = _dRow["Allergies"].ToString();

                    LoggedInUser.StaffId = _dRow["StaffId"].ToString();
                    LoggedInUser.StaffEmail = _dRow["StaffEmail"].ToString();
                    LoggedInUser.JoinDate = _dRow["JoinDate"].ToString();
                    LoggedInUser.Photograph = _dRow["Photograph"].ToString();
                    LoggedInUser.Attachment = _dRow["Attachment"].ToString();
                    LoggedInUser.SpecialityArea = _dRow["SpecialityArea"].ToString();
                }
            }
            if (!LoadUser)
            {
                LoadUser = false;
            }
            return LoadUser;
        }

        // Update User Passsword
        public int UpdateUserPassword(string NewPw)
        {
            try
            {
                return UserProfile_DAL.UpdateUserPassword(NewPw);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update Username
        public int UpdateUsername(string username)
        {
            try
            {
                return UserProfile_DAL.UpdateUsername(username);
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Update User Personal Details
        public int UpdatePersonalInfo(TblUsers tblUsers)
        {
            try
            {
                return UserProfile_DAL.UpdatePersonalInfo(tblUsers);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update User Staff Details
        public int UpdateStaffInfo(TblStaff tblstaff)
        {
            try
            {
                return UserProfile_DAL.UpdateStaffInfo(tblstaff);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
