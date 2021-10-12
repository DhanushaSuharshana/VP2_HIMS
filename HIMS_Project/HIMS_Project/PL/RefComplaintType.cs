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
    public partial class RefComplaintType : Form
    {
        TblComplaintType_BLL TblComplaintType_BLL;
        public RefComplaintType()
        {
            InitializeComponent();
            TblComplaintType_BLL = new TblComplaintType_BLL();
        }

        private void RefComplaintType_Load(object sender, EventArgs e)
        {
            txtDescription.Focus();
            DgvAllComplaintType(); // Fetch All Complaint Type Detail to the DGV
            btnCTypeUpdate.Hide();
            btnCTypeEdit.Enabled = false;
            btnCTypeDelete.Enabled = false;
        }


        private void DgvAllComplaintType()
        {
            TblComplaintType_BLL.LoadAllComplaintTypeToGrid(dgvComplaintType);
        }

        public int AddCType()
        {
            var ComDescription = txtDescription.Text;

            return TblComplaintType_BLL.AddCType(ComDescription);
        }

        private bool validateFields()
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtDescription);
                return false;
            }

            return true;
        }

        private void btnCTypeSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var respond = AddCType();
                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AllClear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void EditComplaintType()
        {
            txtCTypeId.Text = dgvComplaintType.SelectedRows[0].Cells[0].Value.ToString();
            txtDescription.Text = dgvComplaintType.SelectedRows[0].Cells[1].Value.ToString();

            btnCTypeUpdate.Show();
            btnCTypeSave.Hide();
        }

        private void btnCTypeEdit_Click(object sender, EventArgs e)
        {
            EditComplaintType();
        }

        public int UpdateCType()
        {
            var ComplaintType = new TblComplaintType // create new object to store form data
            {
                TypeNo = int.Parse(txtCTypeId.Text),
                ComDescription = txtDescription.Text,
            };

            return TblComplaintType_BLL.UpdateCType(ComplaintType);
        }

        private void btnCTypeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var respond = UpdateCType();
                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AllClear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void AllClear()
        {
            txtCTypeId.Text = "";
            txtDescription.Text = "";
            txtDescription.Focus();
            DgvAllComplaintType();
            btnCTypeSave.Show();
            btnCTypeUpdate.Hide();
            btnCTypeEdit.Enabled = false;
            btnCTypeDelete.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        public int DeleteCType()
        {
            int CTypeId = int.Parse(dgvComplaintType.SelectedRows[0].Cells[0].Value.ToString());
            return TblComplaintType_BLL.DeleteCType(CTypeId);
        }

        private void btnCTypeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var respond = DeleteCType();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Removed", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AllClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCTypeSearch_TextChanged(object sender, EventArgs e)
        {
            TblComplaintType_BLL.LoadSpecificCTypeToGrid(txtCTypeSearch.Text, dgvComplaintType);
        }

        private void dgvComplaintType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCTypeEdit.Enabled = true;
            btnCTypeDelete.Enabled = true;
        }

        private void btnComTypeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
