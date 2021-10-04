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
    public partial class PostalDispatchedModule : Form
    {
        TblPostal_BLL TblPostal_BLL;
        public PostalDispatchedModule()
        {
            InitializeComponent();
            TblPostal_BLL = new TblPostal_BLL();
        }

        private void PostalDispatchedModule_Load(object sender, EventArgs e)
        {
            UserAccessComponent(LoggedInUser.UserRole);
            DgvAllDispatchedPostal(); // Fetch All Received Postal Detail to the DGV
        }

        #region Loginned user access
        // view component each loginned user
        private void UserAccessComponent(int UserRole)
        {
            if (UserRole == 1) // If user will Admin
            {
                pnlPostalForm.Hide();
                pnlformButtons.Hide();
                btnDiPostalEdit.Hide();
                btnDiPostalDelete.Enabled = false;
            }
            if (UserRole == 2) // If user will Receptionist
            {
                btnDiPostalUpdate.Hide();
                btnDiPostalEdit.Enabled = false;
                btnDiPostalDelete.Enabled = false;
            }

        }
        #endregion Loginned user access

        private void DgvAllDispatchedPostal()
        {
            TblPostal_BLL.LoadAllDiPostalToGrid(dgvDiPostal);
        }

        private void txtDiPostalSearch_TextChanged(object sender, EventArgs e)
        {
            TblPostal_BLL.LoadSpecificDiPostalToGrid(txtDiPostalSearch.Text, dgvDiPostal);
        }

        private void AllClear()
        {
            txtDiPostalId.Text = "";
            txtDiRefNo.Text = "";
            txtDiFrom.Text = "";
            txtDiAddress.Text = "";
            txtDiTo.Text = "";
            txtDiNote.Text = "";
            txtDiRefNo.Focus();
        }

        private void btnDiPostalClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        private int GenerateRandomRefNo()
        {
            int refNo = 1;

            return refNo;
        }
        public int AddDispatchedPostal()
        {
            var DispatchedPostal = new TblPostal // create new object to store form data
            {
                RefNo = int.Parse(txtDiRefNo.Text), // replace to random number generate
                MailFrom = txtDiFrom.Text,
                FromAddress = txtDiAddress.Text,
                Note = txtDiNote.Text,
                MailTo = txtDiTo.Text,
                MDate = DateTime.Now,
                Attachment = "No Attachment",
                MailStatus = "Dispatched",

            };
            return TblPostal_BLL.AddPostal(DispatchedPostal);
        }

        private bool validateFields()
        {
            if (string.IsNullOrEmpty(txtDiRefNo.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtDiRefNo);
                return false;
            }
            if (string.IsNullOrEmpty(txtDiFrom.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtDiFrom);
                return false;
            }
            if (string.IsNullOrEmpty(txtDiAddress.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtDiAddress);
                return false;
            }
            if (string.IsNullOrEmpty(txtDiTo.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtDiTo);
                return false;
            }
            //if (!Regex.Match(txtReRefNo.Text, @"^[\d]$").Success)
            //{
            //    ValidateFunc.ValidateNumber(txtReRefNo);
            //    return false;
            //}
            return true;
        }
        private void btnDiPostalSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var respond = AddDispatchedPostal();
                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DgvAllDispatchedPostal();
                        AllClear();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void EditDispatchedPostal()
        {
            txtDiPostalId.Text = dgvDiPostal.SelectedRows[0].Cells[0].Value.ToString();
            txtDiRefNo.Text = dgvDiPostal.SelectedRows[0].Cells[1].Value.ToString();
            txtDiFrom.Text = dgvDiPostal.SelectedRows[0].Cells[2].Value.ToString();
            txtDiAddress.Text = dgvDiPostal.SelectedRows[0].Cells[3].Value.ToString();
            txtDiTo.Text = dgvDiPostal.SelectedRows[0].Cells[4].Value.ToString();
            txtDiNote.Text = dgvDiPostal.SelectedRows[0].Cells[6].Value.ToString();
            /*
             * Edit Attach document
             */

            btnDiPostalUpdate.Show();
            btnDiPostalSave.Hide();
        }

        private void btnDiPostalEdit_Click(object sender, EventArgs e)
        {
            EditDispatchedPostal();
        }

        public int UpdateDiPostal()
        {
            var DispatchedPostal = new TblPostal // create new object to store form data
            {
                MailFrom = txtDiFrom.Text,
                FromAddress = txtDiAddress.Text,
                Note = txtDiNote.Text,
                MailTo = txtDiTo.Text,
                Attachment = "No Attachment",
                PostalId = int.Parse(txtDiPostalId.Text),
                //MDate = DateTime.Now,
                //MailStatus = "Received",
            };
            return TblPostal_BLL.UpdatePostal(DispatchedPostal);
        }

        private void btnDiPostalUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var respond = UpdateDiPostal();
                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DgvAllDispatchedPostal();
                        AllClear();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeleteDiPostal()
        {
            int DiPostalId = int.Parse(dgvDiPostal.SelectedRows[0].Cells[0].Value.ToString());
            return TblPostal_BLL.DeletePostal(DiPostalId);
        }

        private void btnDiPostalDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var respond = DeleteDiPostal();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Removed", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgvAllDispatchedPostal();
                    AllClear();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvDiPostal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDiPostalEdit.Enabled = true;
            btnDiPostalDelete.Enabled = true;
        }
    }
}
