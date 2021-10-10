using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS_Project.Functions
{
    public class ValidateFunc
    {
        // Function for Validate Empty Combo Box Fiels
        public static void ValidateEmptyCmbField(ComboBox cmb)
        {
            MessageBox.Show("Required Field Is Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmb.Focus();
        }

        // Function for Validate Empty Text Box Fields
        public static void ValidateEmptyTxtField(TextBox txt)
        {
            MessageBox.Show("Required Field Is Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt.Focus();
        }

        //Function for Validate if the field will valid or not with regex
        public static void ValidateTime(TextBox txtTime)
        {
            MessageBox.Show("This Is Not Valid Time", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTime.Text = "";
            txtTime.Focus();
        }

        // Validate Srlankan mobile number
        public static void ValidateContact(TextBox txtcontact)
        {
            MessageBox.Show("Invalid Contact Number", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtcontact.Text = "";
            txtcontact.Focus();
        }

        // Validate Email Address
        public static void ValidateEmail(TextBox txtEmail)
        {
            MessageBox.Show("Invalid Email Address", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmail.Text = "";
            txtEmail.Focus();
        }

        // Validate Strong Password
        public static void ValidatePassword(TextBox txtPassword)
        { 
            MessageBox.Show("Invalid Password.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPassword.Text = "";
            txtPassword.Focus();
        }
        //Validate NIC
        public static void ValidateNIC(TextBox txtNIC)
        {
            MessageBox.Show("Invalid NIC.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNIC.Text = "";
            txtNIC.Focus();
        }

        // Validate Number
        public static void ValidateNumber(TextBox numberField)
        {
            MessageBox.Show("Only numeric numbers are accepted.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            numberField.Text = "";
            numberField.Focus();
        }
    }
}
