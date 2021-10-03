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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS_Project.PL
{
    public partial class PostalReceivedModule : Form
    {
        TblPostal_BLL TblPostal_BLL;
        public PostalReceivedModule()
        {
            InitializeComponent();
            TblPostal_BLL = new TblPostal_BLL();
        }

        private void PostalReceivedModule_Load(object sender, EventArgs e)
        {
            UserAccessComponent(LoggedInUser.UserRole);
            DgvAllReceivedPostal(); // Fetch All Received Postal Detail to the DGV
        }

        #region Loginned user access
        // view component each loginned user
        private void UserAccessComponent(int UserRole)
        {
            if (UserRole == 1) // If user will Admin
            {
                pnlPostalForm.Hide();
                pnlformButtons.Hide();
                btnRePostalEdit.Hide();
                btnRePostalDelete.Enabled = false;
            }
            if (UserRole == 2) // If user will Receptionist
            {
                btnRePostalUpdate.Hide();
                btnRePostalEdit.Enabled = false;
                btnRePostalDelete.Enabled = false;
            }

        }
        #endregion Loginned user access

        private void DgvAllReceivedPostal()
        {
            TblPostal_BLL.LoadAllPostalToGrid(dgvRePostal);
        }
        private void btnRePostalClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRePostalSearch_TextChanged(object sender, EventArgs e)
        {
            TblPostal_BLL.LoadSpecificRePostalToGrid(txtRePostalSearch.Text, dgvRePostal);
        }

        private void AllClear()
        {
            txtRePostalId .Text= "";
            txtReRefNo.Text = "";
            txtReFrom.Text = "";
            txtReAddress.Text = "";
            txtReTo.Text = "";
            txtReNote.Text = "";
            txtReRefNo.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        private int GenerateRandomRefNo()
        {
            int refNo=1;

            return refNo;
        }
        public int AddReceivedPostal()
        {
            var ReceivedPostal = new TblPostal // create new object to store form data
            {
                RefNo = int.Parse(txtReRefNo.Text), // replace to random number generate
                MailFrom = txtReFrom.Text,
                FromAddress = txtReAddress.Text,
                Note = txtReNote.Text,
                MailTo = txtReTo.Text,
                MDate = DateTime.Now,
                Attachment = "No Attachment",
                MailStatus = "Received",
               
            };
            return TblPostal_BLL.AddPostal(ReceivedPostal);
        }

        private bool validateFields()
        {
            if (string.IsNullOrEmpty(txtReRefNo.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtReRefNo);
                return false;
            }
            if (string.IsNullOrEmpty(txtReFrom.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtReFrom);
                return false;
            }
            if (string.IsNullOrEmpty(txtReAddress.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtReAddress);
                return false;
            }
            if (string.IsNullOrEmpty(txtReTo.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtReTo);
                return false;
            }
            //if (!Regex.Match(txtReRefNo.Text, @"^[\d]$").Success)
            //{
            //    ValidateFunc.ValidateNumber(txtReRefNo);
            //    return false;
            //}
            return true;
        }

        private void btnRePostalSave_Click(object sender, EventArgs e)
        {
            try
            {
               if (validateFields())
               {
                    var respond = AddReceivedPostal();
                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Saved", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DgvAllReceivedPostal();
                        AllClear();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void EditReceivedPostal()
        {
            txtRePostalId.Text = dgvRePostal.SelectedRows[0].Cells[0].Value.ToString();
            txtReRefNo.Text = dgvRePostal.SelectedRows[0].Cells[1].Value.ToString();
            txtReFrom.Text = dgvRePostal.SelectedRows[0].Cells[2].Value.ToString();
            txtReAddress.Text = dgvRePostal.SelectedRows[0].Cells[3].Value.ToString();
            txtReTo.Text = dgvRePostal.SelectedRows[0].Cells[4].Value.ToString();
            txtReNote.Text = dgvRePostal.SelectedRows[0].Cells[6].Value.ToString();
            /*
             * Edit Attach document
             */

            btnRePostalUpdate.Show();
            btnRePostalSave.Hide();
        }
        private void btnRePostalEdit_Click(object sender, EventArgs e)
        {
            EditReceivedPostal();
        }

        public int UpdateRePostal()
        {
            var ReceivedPostal = new TblPostal // create new object to store form data
            {
                MailFrom = txtReFrom.Text,
                FromAddress = txtReAddress.Text,
                Note = txtReNote.Text,
                MailTo = txtReTo.Text,
                Attachment = "No Attachment",
                PostalId = int.Parse(txtRePostalId.Text),
                //MDate = DateTime.Now,
                //MailStatus = "Received",
            };
            return TblPostal_BLL.UpdatePostal(ReceivedPostal);
        }

        private void btnRePostalUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var respond = UpdateRePostal();
                    if (respond > 0)
                    {
                        MessageBox.Show("Successfully Updated", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DgvAllReceivedPostal();
                        AllClear();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeleteRePostal()
        {
            int RePostalId = int.Parse(dgvRePostal.SelectedRows[0].Cells[0].Value.ToString());
            return TblPostal_BLL.DeletePostal(RePostalId);
        }

        private void btnRePostalDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var respond = DeleteRePostal();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Removed", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgvAllReceivedPostal();
                    AllClear();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvRePostal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRePostalEdit.Enabled = true;
            btnRePostalDelete.Enabled = true;
        }
    }
}
