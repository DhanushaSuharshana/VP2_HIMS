using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.Model
{
    class TblAppoinments
    {
        public int AppoinmentNo { get; set; }
        public int Patient { get; set; }
        public string Symptom { get; set; }
        public int MO_Id { get; set; }
        public int SpecialityArea { get; set; }
        public string AppoinmentStatus { get; set; }
        public int AppointmentNumber { get; set; }
        public string AppTime { get; set; }
        public string AppDate { get; set; }
    }
}
