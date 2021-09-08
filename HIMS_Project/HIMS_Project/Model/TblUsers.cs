using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.Model
{
    //Encapsulate GET | SET Method
    class TblUsers
    {
        public int UserId { get; set; }
        public string NIC { get; set; }
        public string Name { get; set; }
        public string UserAddress { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public int Contact { get; set; }
        public string Username { get; set; }
        public string UPassword { get; set; }
        public string BloodGroup { get; set; }
        public string Allergies { get; set; }
        public int UserRole { get; set; }
        public string StaffId { get; set; }

    }
}
