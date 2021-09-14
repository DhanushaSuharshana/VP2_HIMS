using HIMS_Project.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIMS_Project.Functions
{
    public class AppointmentFunc
    {
        
        public static int GenerateAppointmentNo()
        {
            int NewNumber=0;

            try
            {
                DataTable _dtable = TblAppointment_DAL.GetMaxAppointmentno();

                foreach (DataRow _dRow in _dtable.Rows)
                {
                    NewNumber = Convert.ToInt32(_dRow["AppointmentNumber"]);
                }
                if (NewNumber == 0)
                {
                    NewNumber = 1;
                }
                else
                {
                    NewNumber += 1;
                }

                return NewNumber;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
