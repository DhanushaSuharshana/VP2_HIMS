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
    class TblSpecialtyArea_DAL
    {
        //Select All Specialty Area
        public static DataTable GetAllSpecialtyArea()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM TblSpecialtyArea");
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Select User Search Specialty Area
        public static DataTable GetUserSearchSpecialtyArea(string usertext)
        {
            try
            {
                string sql = string.Format("SELECT * FROM TblSpecialtyArea WHERE SDescription LIKE '%' + @usertext + '%'");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@usertext", usertext);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Add new Specialty Area
        public static int AddNewSpecialtyArea(string SDescription)
        {
            try
            {
                // set sql insert query
                string sql = string.Format("INSERT INTO TblSpecialtyArea" +
                    "(SDescription) VALUES (@SDescription)");

                // set parameters
                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = sqlParameterFormat.Format("@SDescription", SDescription);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update Specialty Area Record

        public static int UpdateSpecialtyArea(TblSpecialtyArea tblSpecialtyArea)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblSpecialtyArea " +
                                           "SET SDescription=@SDescription" +
                                           " WHERE SAreaID=@SAreaID");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[2];
                _sql[0] = sqlParameterFormat.Format("@SDescription", tblSpecialtyArea.SDescription);
                _sql[1] = sqlParameterFormat.Format("@SAreaID", tblSpecialtyArea.SAreaID);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Delete Specialty Area record
        public static int DeleteSpecialtyAreae(int SAreaID)
        {
            try
            {
                // set sql query
                string sql = string.Format("DELETE FROM TblSpecialtyArea WHERE SAreaID=@SAreaID");

                // Set parameters
                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = sqlParameterFormat.Format("@SAreaID", SAreaID);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
