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
    class TblAppointment_DAL
    {
        //Select All appointments from database
        public static DataTable GetAllAppointment()
        {
            try
            {
                return ODBC.GetData("SELECT * FROM TblAppointments");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetUserSearchAppointment(string usertext)
        {
            try
            {
                string sql = string.Format("SELECT * FROM TblAppointments WHERE Patient LIKE '%' + @usertext + '%'");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@usertext", usertext);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Get specific data filtering by appointment status
        public static DataTable GetStatusAppointment(string status)
        {
            try
            {
                string sql = string.Format("SELECT * FROM TblAppointments WHERE AppointmentStatus=@AppointmentStatus");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@AppointmentStatus", status);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable GetAllExistSpArea()
        {
            try
            {
                return ODBC.GetData("SELECT DISTINCT(SpecialityArea) as SpecialityArea FROM TblStaff"); 
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        // SELECT Maximum AppointmentNumber from TblAppointments
        public static DataTable GetMaxAppointmentno()
        {
            try
            {
                return ODBC.GetData("SELECT COUNT(AppointmentNo)AS AppointmentNo FROM TblAppointments");
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Select All Medical Officers
        public static DataTable GetAllMO(string SpecialityArea)
        {
            try
            {
                string sql = string.Format("SELECT TblUsers.Name FROM TblUsers INNER JOIN TblStaff ON TblStaff.StaffId=TblUsers.StaffId WHERE TblUsers.UserRole=3 AND TblStaff.SpecialityArea=@SpecialityArea");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@SpecialityArea", SpecialityArea);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Get LoggedIn patient name
        public static DataTable ShowPatientName()
        {
            try
            {
                string sql = string.Format("SELECT * FROM TblUsers WHERE UserId=@UserId");
                SqlParameter[] sqlpara = new SqlParameter[1];

                sqlpara[0] = sqlParameterFormat.Format("@UserId", LoggedInUser.UserId);

                return ODBC.GetData(sql, sqlpara);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Add new appointment
        public static int AddNewAppointment(TblAppointments tblAppointment)
        {
            try
            {
                // set sql insert query
                string sql = string.Format("INSERT INTO TblAppointments" +
                    "(AppointmentNumber,Patient,AppDate,AppTime,Symptom,MedicalOfficer,SpecialityArea,AppointmentStatus) " +
                    "VALUES" +
                    "(@AppointmentNumber,@Patient,@AppDate,@AppTime,@Symptom,@MedicalOfficer,@SpecialityArea,@AppointmentStatus)");
                
                // set parameters
                SqlParameter[] _sql = new SqlParameter[8];
                _sql[0] = sqlParameterFormat.Format("@AppointmentNumber", tblAppointment.AppointmentNumber);
                _sql[1] = sqlParameterFormat.Format("@Patient", tblAppointment.Patient);
                _sql[2] = sqlParameterFormat.Format("@AppDate", tblAppointment.AppDate);
                _sql[3] = sqlParameterFormat.Format("@AppTime", tblAppointment.AppTime);
                _sql[4] = sqlParameterFormat.Format("@Symptom", tblAppointment.Symptom);
                _sql[5] = sqlParameterFormat.Format("@MedicalOfficer", tblAppointment.MedicalOfficer);
                _sql[6] = sqlParameterFormat.Format("@SpecialityArea", tblAppointment.SpecialityArea);
                _sql[7] = sqlParameterFormat.Format("@AppointmentStatus", tblAppointment.AppointmentStatus);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update Appointment Record

        public static int UpdateAppointment(TblAppointments tblAppointment)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblAppointments " +
                                           "SET AppointmentNumber=@AppointmentNumber," +
                                               "Patient=@Patient," +
                                               "AppDate=@AppDate," +
                                               "AppTime=@AppTime" +
                                               "Symptom=@Symptom," +
                                               "MedicalOfficer=@MedicalOfficer," +
                                               "SpecialityArea=@SpecialityArea," +
                                               "AppointmentStatus=@AppointmentStatus," +
                                           "WHERE AppointmentNo=@AppointmentNo");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[9];
                _sql[0] = sqlParameterFormat.Format("@AppointmentNumber", tblAppointment.AppointmentNumber);
                _sql[1] = sqlParameterFormat.Format("@Patient", tblAppointment.Patient);
                _sql[2] = sqlParameterFormat.Format("@AppDate", tblAppointment.AppDate);
                _sql[3] = sqlParameterFormat.Format("@AppTime", tblAppointment.AppTime);
                _sql[4] = sqlParameterFormat.Format("@Symptom", tblAppointment.Symptom);
                _sql[5] = sqlParameterFormat.Format("@MedicalOfficer", tblAppointment.MedicalOfficer);
                _sql[6] = sqlParameterFormat.Format("@SpecialityArea", tblAppointment.SpecialityArea);
                _sql[7] = sqlParameterFormat.Format("@AppointmentStatus", tblAppointment.AppointmentStatus);
                _sql[8] = sqlParameterFormat.Format("@AppointmentNo", tblAppointment.AppointmentNo);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Delete appointment record
        public static int DeleteAppointment(int AppointmentNo)
        {
            try
            {
                // set sql query
                string sql = string.Format("DELETE FROM TblAppointments WHERE AppointmentNo=@AppointmentNo");

                // Set parameters
                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = sqlParameterFormat.Format("@AppointmentNo", AppointmentNo);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
