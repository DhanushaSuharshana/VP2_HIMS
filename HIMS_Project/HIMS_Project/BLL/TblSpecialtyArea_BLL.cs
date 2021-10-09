using HIMS_Project.DAL;
using HIMS_Project.Model;
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
        // Fetch All specialty area to appointment module combo box
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

        // Fetch All Specialty Area Data to Grid View
        public void LoadAllSpecialtyAreaToGrid(DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblSpecialtyArea_DAL.GetAllSpecialtyArea();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Filter Specialty Area Details when user search
        public void LoadSpecificSpecialtyAreaToGrid(string usertext, DataGridView dgv)
        {
            try
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = TblSpecialtyArea_DAL.GetUserSearchSpecialtyArea(usertext);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send Specialty Area Details to Add new record
        public int AddSpecialtyArea(string SDescription)
        {
            try
            {
                return TblSpecialtyArea_DAL.AddNewSpecialtyArea(SDescription);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send Specialty Area Details to Update each unique record
        public int UpdateSpecialtyArea(TblSpecialtyArea tblSpecialtyArea)
        {
            try
            {
                return TblSpecialtyArea_DAL.UpdateSpecialtyArea(tblSpecialtyArea);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Send SAreaID to delete unique record
        public int DeleteSpecialtyAreae(int SAreaID)
        {
            try
            {
                return TblSpecialtyArea_DAL.DeleteSpecialtyAreae(SAreaID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
