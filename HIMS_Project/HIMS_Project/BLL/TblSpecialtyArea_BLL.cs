using HIMS_Project.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS_Project.BLL
{
    class TblSpecialtyArea_BLL
    {
        public void cmbLoadAllSpArea(ComboBox cmdLoadAllSpArea)
        {
            try
            {
                cmdLoadAllSpArea.DataSource = TblSpecialtyArea_DAL.GetAllSpecialtyArea();
                cmdLoadAllSpArea.DisplayMember = "SDescription";
                cmdLoadAllSpArea.ValueMember = "SAreaID";


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
