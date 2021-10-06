using HIMS_Project.Model;
using HIMS_Project.Others;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.DAL
{
    class TblComplaintType_DAL
    {
        //Select All Complaint Types
        public static DataTable GetAllComplaintType()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM TblComplaintType");
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Select User Search Complaint Types
        public static DataTable GetUserSearchComplaintType(string usertext)
        {
            try
            {
                string sql = string.Format("SELECT * FROM TblComplaintType WHERE ComDescription LIKE '%' + @usertext + '%'");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@usertext", usertext);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Add new Complaint Type
        public static int AddNewComplaintType(string ComDescription)
        {
            try
            {
                // set sql insert query
                string sql = string.Format("INSERT INTO TblComplaintType" +
                    "(ComDescription) VALUES (@ComDescription)");

                // set parameters
                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = sqlParameterFormat.Format("@ComDescription", ComDescription);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update Complaint Type Record

        public static int UpdateComplaintType(TblComplaintType tblComplaintType)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblComplaintType " +
                                           "SET ComDescription=@ComDescription" +
                                           " WHERE TypeNo=@TypeNo");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[2];
                _sql[0] = sqlParameterFormat.Format("@ComDescription", tblComplaintType.ComDescription);
                _sql[1] = sqlParameterFormat.Format("@TypeNo", tblComplaintType.TypeNo);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Delete Complaint Type record
        public static int DeleteComplaintType(int CTypeId)
        {
            try
            {
                // set sql query
                string sql = string.Format("DELETE FROM TblComplaintType WHERE TypeNo=@CTypeId");

                // Set parameters
                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = sqlParameterFormat.Format("@CTypeId", CTypeId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
