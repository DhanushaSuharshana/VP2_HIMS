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
    class TblPostal_DAL
    {
        //Select All Received Postal
        public static DataTable GetAllReceivedPostal()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM TblPostal WHERE MailStatus='Received'");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetUserSearchReceivedPostal(string usertext)
        {
            try
            {
                string sql = string.Format("SELECT * FROM TblPostal WHERE MailStatus='Received' AND (MailFrom LIKE '%' + @usertext + '%' OR MailTo LIKE '%' + @usertext + '%')");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@usertext", usertext);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Select All Dispatched Postal
        public static DataTable GetAllDispatchedPostal()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM TblPostal WHERE MailStatus='Dispatched'");
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Search Dispatched Data
        public static DataTable GetUserSearchDispatchedPostal(string usertext)
        {
            try
            {
                string sql = string.Format("SELECT * FROM TblPostal WHERE MailStatus='Dispatched' AND (MailFrom LIKE '%' + @usertext + '%' OR MailTo LIKE '%' + @usertext + '%')");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@usertext", usertext);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Add new Received Postal
        public static int AddNewReceived(TblPostal tblPostal)
        {
            try
            {
                // set sql insert query
                string sql = string.Format("INSERT INTO TblPostal" +
                    "(RefNo,MailFrom,FromAddress,Note,MailTo,MDate,Attachment,MailStatus) " +
                    "VALUES" +
                    "(@RefNo,@MailFrom,@FromAddress,@Note,@MailTo,@MDate,@Attachment,@MailStatus)");

                // set parameters
                SqlParameter[] _sql = new SqlParameter[8];
                _sql[0] = sqlParameterFormat.Format("@RefNo", tblPostal.RefNo);
                _sql[1] = sqlParameterFormat.Format("@MailFrom", tblPostal.MailFrom);
                _sql[2] = sqlParameterFormat.Format("@FromAddress", tblPostal.FromAddress);
                _sql[3] = sqlParameterFormat.Format("@Note", tblPostal.Note);
                _sql[4] = sqlParameterFormat.Format("@MailTo", tblPostal.MailTo);
                _sql[5] = sqlParameterFormat.Format("@MDate", tblPostal.MDate);
                _sql[6] = sqlParameterFormat.Format("@Attachment", tblPostal.Attachment);
                _sql[7] = sqlParameterFormat.Format("@MailStatus", tblPostal.MailStatus);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update Received Postal Record

        public static int UpdateReceivedPostal(TblPostal tblPostal)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblPostal " +
                                           "SET MailFrom=@MailFrom," +
                                               "FromAddress=@FromAddress," +
                                               "Note=@Note," +
                                               "MailTo=@MailTo," +
                                               "Attachment=@Attachment" +
                                           " WHERE PostalId=@PostalId");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[6];
                _sql[0] = sqlParameterFormat.Format("@MailFrom", tblPostal.MailFrom);
                _sql[1] = sqlParameterFormat.Format("@FromAddress", tblPostal.FromAddress);
                _sql[2] = sqlParameterFormat.Format("@Note", tblPostal.Note);
                _sql[3] = sqlParameterFormat.Format("@MailTo", tblPostal.MailTo);
                _sql[4] = sqlParameterFormat.Format("@Attachment", tblPostal.Attachment);
                _sql[5] = sqlParameterFormat.Format("@PostalId", tblPostal.PostalId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Delete Received Postal record
        public static int DeleteReceivedPostal(int PostalId)
        {
            try
            {
                // set sql query
                string sql = string.Format("DELETE FROM TblPostal WHERE PostalId=@PostalId");

                // Set parameters
                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = sqlParameterFormat.Format("@PostalId", PostalId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
