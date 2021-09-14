using HIMS_Project.Others;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.DAL
{
    class TblSpecialtyArea_DAL
    {
        public static DataTable GetAllSpecialtyArea()
        {
            return ODBC.GetData("SELECT * FROM TblSpecialtyArea");
        }
    }
}
