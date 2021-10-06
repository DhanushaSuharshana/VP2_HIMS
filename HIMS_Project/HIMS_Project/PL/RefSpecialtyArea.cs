using HIMS_Project.BLL;
using HIMS_Project.Functions;
using HIMS_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS_Project.PL
{
    public partial class RefSpecialtyArea : Form
    {
        TblSpecialtyArea_BLL TblSpecialtyArea_BLL;
        public RefSpecialtyArea()
        {
            InitializeComponent();
            TblSpecialtyArea_BLL = new TblSpecialtyArea_BLL();
        }

        private void RefSpecialtyArea_Load(object sender, EventArgs e)
        {
            txtSpDescription.Focus();
            DgvAllSpecialtyArea();
        }

        private void DgvAllSpecialtyArea()
        {
            TblSpecialtyArea_BLL.LoadAllSpecialtyAreaToGrid(dgvSpArea);
        }

        public int AddSpecialtyArea()
        {
            var SDescription = txtSpDescription.Text;

            return TblSpecialtyArea_BLL.AddSpecialtyArea(SDescription);
        }

        private bool validateFields()
        {
            if (string.IsNullOrEmpty(txtSpDescription.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtSpDescription);
                return false;
            }

            return true;
        }

        private void btnSpAreaSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var respond = AddSpecialtyArea();
                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DgvAllSpecialtyArea();
                        AllClear();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EditSpecialtyArea()
        {
            txtSpAreaId.Text = dgvSpArea.SelectedRows[0].Cells[0].Value.ToString();
            txtSpDescription.Text = dgvSpArea.SelectedRows[0].Cells[1].Value.ToString();

            btnSpAreaUpdate.Show();
            btnSpAreaSave.Hide();
        }

        private void btnSpAreaEdit_Click(object sender, EventArgs e)
        {
            EditSpecialtyArea();
        }

        public int UpdatSpecialtyArea()
        {
            var SpecialtyArea = new TblSpecialtyArea // create new object to store form data
            {
                SAreaID = int.Parse(txtSpAreaId.Text),
                SDescription = txtSpDescription.Text,
            };

            return TblSpecialtyArea_BLL.UpdateSpecialtyArea(SpecialtyArea);
        }

        private void btnSpAreaUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var respond = UpdatSpecialtyArea();
                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DgvAllSpecialtyArea();
                        AllClear();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AllClear()
        {
            txtSpAreaId.Text = "";
            txtSpDescription.Text = "";
            txtSpDescription.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        public int DeleteSpArea()
        {
            int SpAreaId = int.Parse(dgvSpArea.SelectedRows[0].Cells[0].Value.ToString());
            return TblSpecialtyArea_BLL.DeleteSpecialtyAreae(SpAreaId);
        }

        private void btnSpAreaDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var respond = DeleteSpArea();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Removed", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgvAllSpecialtyArea();
                    AllClear();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtSpAreaSearch_TextChanged(object sender, EventArgs e)
        {
            TblSpecialtyArea_BLL.LoadSpecificSpecialtyAreaToGrid(txtSpAreaSearch.Text, dgvSpArea);
        }

        private void dgvSpArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSpAreaEdit.Enabled = true;
            btnSpAreaDelete.Enabled = true;
        }

        private void btnSpAreaClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
