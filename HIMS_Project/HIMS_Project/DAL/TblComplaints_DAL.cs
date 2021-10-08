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
    class TblComplaints_DAL
    {
        //Select All Complaints
        public static DataTable GetAllComplaints()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM TblComplaints INNER JOIN TblComplaintType ON TblComplaintType.TypeNo=TblComplaints.ComTypeNo");
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Search Complaints By Complaint by person or Complaint Description
        public static DataTable GetUserSearchComplaints(string usertext)
        {
            try
            {
                string sql = string.Format("SELECT * FROM TblComplaints INNER JOIN TblComplaintType ON TblComplaintType.TypeNo=TblComplaints.ComTypeNo" +
                    " WHERE ComplaintBy LIKE '%' + @usertext + '%' OR CDescription LIKE '%' + @usertext + '%'");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@usertext", usertext);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Add new Complaint
        public static int AddNewComplaint(TblComplaints tblComplaints)
        {
            try
            {
                // set sql insert query
                string sql = string.Format("INSERT INTO TblComplaints" +
                    "(ComplaintBy,Contact,CDate,CDescription,ActionTaken,Note,Attachment,ComTypeNo) " +
                    "VALUES" +
                    "(@ComplaintBy,@Contact,@CDate,@CDescription,@ActionTaken,@Note,@Attachment,@ComTypeNo)");

                // set parameters
                SqlParameter[] _sql = new SqlParameter[8];
                _sql[0] = sqlParameterFormat.Format("@ComplaintBy", tblComplaints.ComplaintBy);
                _sql[1] = sqlParameterFormat.Format("@Contact", tblComplaints.Contact);
                _sql[2] = sqlParameterFormat.Format("@CDate", tblComplaints.CDate);
                _sql[3] = sqlParameterFormat.Format("@CDescription", tblComplaints.CDescription);
                _sql[4] = sqlParameterFormat.Format("@ActionTaken", tblComplaints.ActionTaken);
                _sql[5] = sqlParameterFormat.Format("@Note", tblComplaints.Note);
                _sql[6] = sqlParameterFormat.Format("@Attachment", tblComplaints.Attachment);
                _sql[7] = sqlParameterFormat.Format("@ComTypeNo", tblComplaints.ComTypeNo);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update Complaint Record
        //Raise a problem

        public static int UpdateComplaint(TblComplaints tblComplaints)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblComplaints " +
                                           "SET ActionTaken=@ActionTaken" +
                                           " WHERE ComplaintId=@ComplaintId");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[2];
                _sql[0] = sqlParameterFormat.Format("@ActionTaken", tblComplaints.ActionTaken);
                _sql[1] = sqlParameterFormat.Format("@ComplaintId", tblComplaints.ComplaintId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Delete Complaint record
        public static int DeleteComplaint(int ComplaintId)
        {
            try
            {
                // set sql query
                string sql = string.Format("DELETE FROM TblComplaints WHERE ComplaintId=@ComplaintId");

                // Set parameters
                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = sqlParameterFormat.Format("@ComplaintId", ComplaintId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
