using System;
using HIMS_Project.Model;
using HIMS_Project.BLL;
using HIMS_Project.Functions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HIMS_Project.PL
{
    public partial class VisitorModule : Form
    {
        TblVisitor_BLL TblVisitor_BLL;
        public VisitorModule()
        {
            InitializeComponent();
            TblVisitor_BLL = new TblVisitor_BLL();
            this.BackColor = System.Drawing.Color.White;
        }


        private void VisitorModule_Load(object sender, EventArgs e)
        {
            UserAccessComponent(LoggedInUser.UserRole);
            DgvAllVisitorRecord();
        }

        #region Loginned user access
        // view component each loginned user
        private void UserAccessComponent(int UserRole)
        {
            if (UserRole == 1) // If user will Admin
            {
                
                pnlForm.Hide();
                pnlFormBtn.Hide();
                btnVEdit.Hide();
                btnVDelete.Enabled = false;
            }
            if (UserRole == 2) // If user will Receptionist
            {

                btnVEdit.Enabled = false;
                btnVUpdate.Enabled = false;
                btnVDelete.Enabled = false;
            }

        }
        #endregion Loginned user access

        private void DgvAllVisitorRecord()
        {
            TblVisitor_BLL.LoadAllVisitorToGrid(dgvVisitor);
        }

        private void AllClear()
        {
            txtVisitorNo.Text = "";
            txtVPurpose.Text = "";
            txtVName.Text = "";
            txtVContact.Text = "";
            txtVNIC.Text = "";
            dtpVDate.Text = "";
            txtVInTime.Text = "";
            txtVOutTime.Text = "";
            txtVNote.Text = "";
            txtVPurpose.Focus();
            btnVSave.Show();
            UserAccessComponent(LoggedInUser.UserRole);
            DgvAllVisitorRecord();
        }

        public int AddVisitorRecord()
        {
            var VisitorRecord = new TblVisitor // create new object to store form data
            {

                Purpose = txtVPurpose.Text,
                VName = txtVName.Text,
                Contact = int.Parse(txtVContact.Text),
                NIC = txtVNIC.Text,
                VDate = dtpVDate.Text,
                InTime = txtVInTime.Text,
                OutTime = txtVOutTime.Text,
                Note = txtVNote.Text,
                Attachment = "No Attachment",

            };
            return TblVisitor_BLL.AddVisitor(VisitorRecord);
        }

        private bool validateFields()
        {
            if (string.IsNullOrEmpty(txtVPurpose.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtVPurpose);
                return false;
            }
            if (string.IsNullOrEmpty(txtVName.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtVName);
                return false;
            }
            if (string.IsNullOrEmpty(txtVContact.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtVContact);
                return false;
            }
            if (string.IsNullOrEmpty(txtVNIC.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtVNIC);
                return false;
            }
            if (string.IsNullOrEmpty(txtVNote.Text))
            {
                ValidateFunc.ValidateEmptyTxtField(txtVNote);
                return false;
            }
            if (!Regex.Match(txtVInTime.Text, @"^[0-1]{1}\d{1}:[0-5]{1}\d{1}[AaPp][Mm]$").Success)
            {
                ValidateFunc.ValidateTime(txtVInTime);
                return false;
            }

            if (!Regex.Match(txtVOutTime.Text, @"^[0-1]{1}\d{1}:[0-5]{1}\d{1}[AaPp][Mm]$").Success)
            {
                ValidateFunc.ValidateTime(txtVOutTime);
                return false;
            }
            if (!Regex.Match(txtVNIC.Text, @"^\d{9}[Vv]|^\d{12}$").Success)
            {
                ValidateFunc.ValidateNIC(txtVNIC);
                return false;
            }
            if (!Regex.Match(txtVContact.Text, @"^0?7?\d{8}$").Success) // validate Srilankan mobile number
            {
                ValidateFunc.ValidateContact(txtVContact);
                return false;
            }

            return true;
        }



        private void btnVSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var respond = AddVisitorRecord();
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

        public int UpdateVisitor()
        {
            var VisitorRecord = new TblVisitor// create new object to store form data
            {
                Purpose = txtVPurpose.Text,
                VName = txtVName.Text,
                Contact = int.Parse(txtVContact.Text),
                NIC = txtVNIC.Text,
                VDate = dtpVDate.Text,
                InTime = txtVInTime.Text,
                OutTime = txtVOutTime.Text,
                Note = txtVNote.Text,
                Attachment = "No Attachment",
                VisitorNo = int.Parse(txtVisitorNo.Text),
                
            };
            return TblVisitor_BLL.UpdateVisitorRecord(VisitorRecord);
        }

        private void btnVUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    var respond = UpdateVisitor();
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

        private void btnVClrAll_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        public int DeleteVisitor()
        {
            int VisitorNo = int.Parse(dgvVisitor.SelectedRows[0].Cells[0].Value.ToString());
            return TblVisitor_BLL.DeleteVisitorRecord(VisitorNo);
        }


        public void EditVisitorRecord()
        {
            txtVisitorNo.Text = dgvVisitor.SelectedRows[0].Cells[0].Value.ToString();
            txtVPurpose.Text = dgvVisitor.SelectedRows[0].Cells[1].Value.ToString();
            txtVName.Text = dgvVisitor.SelectedRows[0].Cells[2].Value.ToString();
            txtVContact.Text = dgvVisitor.SelectedRows[0].Cells[3].Value.ToString();
            txtVNIC.Text = dgvVisitor.SelectedRows[0].Cells[4].Value.ToString();
            dtpVDate.Text = dgvVisitor.SelectedRows[0].Cells[5].Value.ToString();
            txtVInTime.Text = dgvVisitor.SelectedRows[0].Cells[6].Value.ToString();
            txtVOutTime.Text = dgvVisitor.SelectedRows[0].Cells[7].Value.ToString();
            txtVNote.Text = dgvVisitor.SelectedRows[0].Cells[8].Value.ToString();

            btnVUpdate.Show();
            btnVSave.Hide();
        }

        private void dgvVisitor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnVEdit.Enabled = true;
            btnVDelete.Enabled = true;
        }



        private void btnVClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                var respond = DeleteVisitor();
                if (respond > 0)
                {
                    MessageBox.Show("Successfully Deleted", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AllClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVEdit_Click(object sender, EventArgs e)
        {
            EditVisitorRecord();
        }

        private void txtVisitorSearch_TextChanged(object sender, EventArgs e)
        {
            TblVisitor_BLL.LoadSpecificVisitorsToGrid(txtVisitorSearch.Text, dgvVisitor);
        }
    
    }   
}
