using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIMS_Project.Functions
{
    public class PasswordFunc
    {
        public static void PasswordShowHide(TextBox UserPassword)
        {
            if (UserPassword.PasswordChar == '*')
            {
                UserPassword.PasswordChar = '\0';
            }
            else if (UserPassword.PasswordChar == '\0')
            {
                UserPassword.PasswordChar = '*';
            }
        }
    }
}
