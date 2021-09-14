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
            return;
        }

        // Function for Validate Empty Text Box Fiels
        public static void ValidateEmptyTxtField(TextBox txt)
        {
            MessageBox.Show("Required Field Is Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt.Focus();
            return;
        }
    }
}
