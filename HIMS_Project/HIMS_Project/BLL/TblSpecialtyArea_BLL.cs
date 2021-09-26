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
        public void cmbLoadAllSpArea(ComboBox cmbAppSpArea)
        {
            try
            {
                cmbAppSpArea.DataSource = TblSpecialtyArea_DAL.GetAllSpecialtyArea();
                cmbAppSpArea.DisplayMember = "SDescription";
                cmbAppSpArea.ValueMember = "SDescription";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
