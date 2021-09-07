using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PRATHTHANA_SHEET_CENTER_NEW_PROJECT.OTHER
{
   
    class MysqlParameterFormat
    {
        public static SqlParameter Format(string parameter, SqlDbType dtype, object value)
        {
            SqlParameter parm = new SqlParameter(parameter, dtype);
            parm.Value = value;
            return parm;
        }
        public static SqlParameter Format(string parameter, object value)
        {
            return new SqlParameter(parameter, value);
        }
    }
}
