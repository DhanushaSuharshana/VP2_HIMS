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
    }
}
