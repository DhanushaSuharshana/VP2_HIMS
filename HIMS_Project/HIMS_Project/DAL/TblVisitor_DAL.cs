using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HIMS_Project.Model;
using HIMS_Project.Others;

namespace HIMS_Project.DAL
{
   
    class TblVisitor_DAL
    {
        //Select All Visitors
        public static DataTable GetAllVisitor()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM TblVisitor ");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetUserSearchVisitor(string usertext)
        {
            try
            {
                string sql = string.Format("SELECT * FROM TblVisitor WHERE VName LIKE '%' + @usertext + '%'");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@usertext", usertext);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Add New Visitor

        public static int AddNewVisitor(TblVisitor tblVisitor)
        {
            try
            {
                // set sql insert query
                string sql = string.Format("INSERT INTO TblVisitor" +
                    "(Purpose,VName,Contact,NIC,VDate,InTime,OutTime,Note,Attachment) " +
                    "VALUES" +
                    "(@Purpose,@Name,@Contact,@NIC,@VDate,@InTime,@OutTime,@Note,@Attachment)");

                // set parameters
                SqlParameter[] _sql = new SqlParameter[9];
                _sql[0] = sqlParameterFormat.Format("@Purpose", tblVisitor.Purpose);
                _sql[1] = sqlParameterFormat.Format("@Name", tblVisitor.VName);
                _sql[2] = sqlParameterFormat.Format("@Contact", tblVisitor.Contact);
                _sql[3] = sqlParameterFormat.Format("@NIC", tblVisitor.NIC);
                _sql[4] = sqlParameterFormat.Format("@VDate", tblVisitor.VDate);
                _sql[5] = sqlParameterFormat.Format("@InTime", tblVisitor.InTime);
                _sql[6] = sqlParameterFormat.Format("@OutTime", tblVisitor.OutTime);
                _sql[7] = sqlParameterFormat.Format("@Note", tblVisitor.Note);
                _sql[8] = sqlParameterFormat.Format("@Attachment", tblVisitor.Attachment);


                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update Visitor Record

        public static int UpdateVisitorRecord(TblVisitor tblVisitor)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblVisitor " +
                                           "SET Purpose=@Purpose," +
                                               "VName=@Name," +
                                               "Contact=@Contact," +
                                               "NIC=@NIC," +
                                               "VDate=@VDate," +
                                               "InTime=@InTime," +
                                               "OutTime=@OutTime," +
                                               "Note=@Note," +
                                               "Attachment=@Attachment" +
                                           " WHERE VisitorNo=@VisitorNo");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[10];
                _sql[0] = sqlParameterFormat.Format("@Purpose",tblVisitor.Purpose );
                _sql[1] = sqlParameterFormat.Format("@Name",tblVisitor.VName );
                _sql[2] = sqlParameterFormat.Format("@Contact", tblVisitor.Contact );
                _sql[3] = sqlParameterFormat.Format("@NIC", tblVisitor.NIC );
                _sql[4] = sqlParameterFormat.Format("@VDate", tblVisitor.VDate );
                _sql[5] = sqlParameterFormat.Format("@InTime", tblVisitor.InTime );
                _sql[6] = sqlParameterFormat.Format("@OutTime", tblVisitor.OutTime);
                _sql[7] = sqlParameterFormat.Format("@Note", tblVisitor.Note );
                _sql[8] = sqlParameterFormat.Format("@Attachment", tblVisitor.Attachment );
                _sql[9] = sqlParameterFormat.Format("@VisitorNo", tblVisitor.VisitorNo);
                
                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Delete Visitor Record
        public static int DeleteVisitorRecord(int VisitorNO)
        {
            try
            {
                // set sql query
                string sql = string.Format("DELETE FROM TblVisitor WHERE VisitorNo=@VisitorNo");

                // Set parameters
                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = sqlParameterFormat.Format("@VisitorNo", VisitorNO);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

        
}
