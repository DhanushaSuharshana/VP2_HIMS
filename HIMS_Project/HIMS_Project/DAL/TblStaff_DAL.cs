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
    class TblStaff_DAL
    {
        // Add new Staff
        public static int AddNewStaff(TblStaff tblStaff)
        {
            try
            {
                // set sql insert query
                string sql = string.Format("INSERT INTO TblStaff" +
                    "(StaffId,StaffEmail,JoinDate,Photograph,Attachment,SpecialityArea) " +
                    "VALUES" +
                    "(@StaffId,@StaffEmail,@JoinDate,@Photograph,@Attachment,@SpecialityArea)");

                // set parameters
                SqlParameter[] _sql = new SqlParameter[6];
                _sql[0] = sqlParameterFormat.Format("@StaffId", tblStaff.StaffId);
                _sql[1] = sqlParameterFormat.Format("@StaffEmail", tblStaff.StaffEmail);
                _sql[2] = sqlParameterFormat.Format("@JoinDate", tblStaff.JoinDate);
                _sql[3] = sqlParameterFormat.Format("@Photograph", tblStaff.Photograph);
                _sql[4] = sqlParameterFormat.Format("@Attachment", tblStaff.Attachment);
                _sql[5] = sqlParameterFormat.Format("@SpecialityArea", tblStaff.SpecialityArea);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update staff Record

        public static int UpdateStaff(TblStaff tblStaff)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblStaff " +
                                           "SET StaffEmail=@StaffEmail," +
                                               "JoinDate=@JoinDate," +
                                               "Photograph=@Photograph," +
                                               "Attachment=@Attachment," +
                                               "SpecialityArea=@SpecialityArea" +
                                           " WHERE StaffId=@StaffId");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[6];
                _sql[0] = sqlParameterFormat.Format("@StaffEmail", tblStaff.StaffEmail);
                _sql[1] = sqlParameterFormat.Format("@JoinDate", tblStaff.JoinDate);
                _sql[2] = sqlParameterFormat.Format("@Photograph", tblStaff.Photograph);
                _sql[3] = sqlParameterFormat.Format("@Attachment", tblStaff.Attachment);
                _sql[4] = sqlParameterFormat.Format("@SpecialityArea", tblStaff.SpecialityArea);
                _sql[5] = sqlParameterFormat.Format("@StaffId", tblStaff.StaffId);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
