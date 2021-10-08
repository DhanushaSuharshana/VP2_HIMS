using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.Model
{
    class TblComplaints
    {
        public int ComplaintId { get; set; }
        public string ComplaintBy { get; set; }
        public int Contact { get; set; }
        public DateTime CDate { get; set; }
        public string CDescription { get; set; }
        public string ActionTaken { get; set; }
        public string Note { get; set; }
        public string Attachment { get; set; }
        public int ComTypeNo { get; set; }
    }
}
