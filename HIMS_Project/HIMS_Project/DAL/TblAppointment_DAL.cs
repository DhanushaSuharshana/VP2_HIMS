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
                return ODBC.GetData("SELECT * FROM TblAppoinments");
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
                return ODBC.GetData("SELECT MAX(AppointmentNumber)AS AppointmentNumber FROM TblAppoinments");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Add new appointment
        public static int AddNewAppointment(TblAppoinments tblAppointment)
        {
            try
            {
                // set sql insert query
                string sql = string.Format("INSERT INTO TblAppoinments" +
                    "(Patient,Symptom,MO_Id,SpecialityArea,AppoinmentStatus,AppointmentNumber,AppTime,AppDate) " +
                    "VALUES" +
                    "(@Patient,@Symptom,@MO_Id,@SpecialityArea,@AppoinmentStatus,@AppointmentNumber,@AppTime,@ADate)");
                
                // set parameters
                SqlParameter[] _sql = new SqlParameter[8];
                _sql[0] = sqlParameterFormat.Format("@Patient", tblAppointment.Patient);
                _sql[2] = sqlParameterFormat.Format("@Symptom", tblAppointment.Symptom);
                _sql[3] = sqlParameterFormat.Format("@MO_Id", tblAppointment.MO_Id);
                _sql[4] = sqlParameterFormat.Format("@SpecialityArea", tblAppointment.SpecialityArea);
                _sql[5] = sqlParameterFormat.Format("@AppoinmentStatus", tblAppointment.AppoinmentStatus);
                _sql[6] = sqlParameterFormat.Format("@AppointmentNumber", tblAppointment.AppointmentNumber);
                _sql[7] = sqlParameterFormat.Format("@AppTime", tblAppointment.AppTime);
                _sql[1] = sqlParameterFormat.Format("@AppDate", tblAppointment.AppDate);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Update Appointment Record

        public static int UpdateAppointment(TblAppoinments tblAppointment)
        {
            try
            {
                // Set Update query
                string sql = string.Format("UPDATE TblAppoinments " +
                                           "SET Patient=@Patient," +
                                               "Symptom=@Symptom," +
                                               "MO_Id=@MO_Id," +
                                               "SpecialityArea=@SpecialityArea," +
                                               "AppoinmentStatus=@AppoinmentStatus," +
                                               "AppointmentNumber=@AppointmentNumber," +
                                               "AppTime=@AppTime" +
                                               "AppDate=@AppDate," +
                                           "WHERE AppoinmentNo=@AppoinmentNo");
                // set parameters
                SqlParameter[] _sql = new SqlParameter[9];
                _sql[0] = sqlParameterFormat.Format("@Patient", tblAppointment.Patient);
                _sql[2] = sqlParameterFormat.Format("@Symptom", tblAppointment.Symptom);
                _sql[3] = sqlParameterFormat.Format("@MO_Id", tblAppointment.MO_Id);
                _sql[4] = sqlParameterFormat.Format("@SpecialityArea", tblAppointment.SpecialityArea);
                _sql[5] = sqlParameterFormat.Format("@AppoinmentStatus", tblAppointment.AppoinmentStatus);
                _sql[6] = sqlParameterFormat.Format("@AppointmentNumber", tblAppointment.AppointmentNumber);
                _sql[7] = sqlParameterFormat.Format("@AppTime", tblAppointment.AppTime);
                _sql[1] = sqlParameterFormat.Format("@AppDate", tblAppointment.AppDate);
                _sql[8] = sqlParameterFormat.Format("@AppoinmentNo", tblAppointment.AppoinmentNo);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Delete appointment record
        public static int DeleteAppointment(int AppoinmentNo)
        {
            try
            {
                // set sql query
                string sql = string.Format("DELETE FROM TblAppoinments WHERE AppoinmentNo=@AppoinmentNo");

                // Set parameters
                SqlParameter[] _sql = new SqlParameter[1];
                _sql[0] = sqlParameterFormat.Format("@AppoinmentNo", AppoinmentNo);

                return ODBC.SetData(sql, _sql);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
