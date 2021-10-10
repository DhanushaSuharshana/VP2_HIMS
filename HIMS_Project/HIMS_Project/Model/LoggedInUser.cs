using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.Model
{
    // Declaring variables to directly access the Logged in user details
    public class LoggedInUser
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static int UserRole { get; set; }
        public static string RoleName { get; set; }
        public static string NIC { get; set; }
        public static string UName { get; set; }
        public static string UserAddress { get; set; }
        public static string DOB { get; set; }
        public static string Gender { get; set; }
        public static string MaritalStatus { get; set; }
        public static int Contact { get; set; }
        public static string UPassword { get; set; }
        public static string BloodGroup { get; set; }
        public static string Allergies { get; set; }
        public static string StaffId { get; set; }
        public static string StaffEmail { get; set; }
        public static string JoinDate { get; set; }
        public static string Photograph { get; set; }
        public static string Attachment { get; set; }
        public static string SpecialityArea { get; set; }
    }
}
