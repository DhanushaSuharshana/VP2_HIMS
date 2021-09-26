using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.Model
{
    class TblAppointments
    {
        public int AppointmentNo { get; set; }
        public string AppointmentNumber { get; set; }
        public string Patient { get; set; }
        public string AppDate { get; set; }
        public string AppTime { get; set; }
        public string Symptom { get; set; }
        public string MedicalOfficer { get; set; }
        public string SpecialityArea { get; set; }
        public string AppointmentStatus { get; set; }
        
    }
}
