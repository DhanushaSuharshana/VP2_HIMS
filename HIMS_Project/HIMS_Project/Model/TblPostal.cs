using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.Model
{
    class TblPostal
    {
        public int PostalId { get; set; }
        public int RefNo { get; set; }
        public string MailFrom { get; set; }
        public string FromAddress { get; set; }
        public string Note { get; set; }
        public string MailTo { get; set; }
        public DateTime MDate { get; set; }
        public string Attachment { get; set; }
        public string MailStatus { get; set; }
    }
}
