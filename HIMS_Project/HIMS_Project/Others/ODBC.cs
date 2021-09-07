using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HIMS_Project.Others
{
      
    internal class ODBC
    {
        //Initialize MSSQL database connection
        private static SqlConnection con;

        public static SqlConnection GetConnection()
        {
            if (con == null)
            {
                string connectionString = @"Data Source=sachini\SQLEXPRESS;Initial Catalog=HIMS;User ID=sa;Password=123;Pooling=False";

                con = new SqlConnection(connectionString);
            }
            return con;
        }


        //Open MSSQL database connection open
        private static void OpenConnection()
        {
            if (GetConnection().State == ConnectionState.Open)
            {
                GetConnection().Close();
            }
            GetConnection().Open();
        }



        //select data as a table 
        public static DataTable GetData(string sql, SqlParameter[] sqlParm=null)
        {
            OpenConnection();
            using (SqlCommand cmd = GetConnection().CreateCommand())
            {
                SqlDataAdapter adp = new SqlDataAdapter();
                DataSet ds = new DataSet();
                try
                {
                    cmd.CommandText = sql;
                    if (sqlParm != null)
                        cmd.Parameters.AddRange(sqlParm);

                    cmd.ExecuteNonQuery();
                    adp.SelectCommand = cmd;
                    adp.Fill(ds);
                    return ds.Tables[0];
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        
        public static SqlDataReader GetData_reader(string sql, SqlParameter[] sqlParm = null)
        {
            OpenConnection();
            using (SqlCommand cmd = GetConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandText = sql;
                    if (sqlParm != null)
                        cmd.Parameters.AddRange(sqlParm);
                   return cmd.ExecuteReader();
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }

        //function for execute MSsql insert/update/delete query
        public static int SetData(String sql, SqlParameter[] sqlParameter =null)
        {
            OpenConnection();
            using (SqlCommand cmd = GetConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandText = sql;
                    if (sqlParameter != null)
                        cmd.Parameters.AddRange( sqlParameter);

                    return cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }
        //this function for sql functions
        public static string ExecuteFunction(string function, SqlParameter[] sqlParameter = null)
        {
            OpenConnection();
            using (SqlCommand cmd = GetConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandText = function;
                    if (sqlParameter != null)
                        cmd.Parameters.AddRange(sqlParameter);

                    if (cmd.ExecuteScalar() != DBNull.Value)
                        return Convert.ToString(cmd.ExecuteScalar());
                }
                catch (Exception)
                {
                    throw;
                }
                return null;
            }
        }
    }
}

