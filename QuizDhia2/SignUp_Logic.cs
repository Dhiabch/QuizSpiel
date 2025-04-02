using QuizSpiel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizDhia2
{
    internal class SignUp_Logic
    {
        User benutzer = new User();
        

        private void LoginUserName(TextBox tfBenutzername)
        {
            Database_Connect.findUserByID(tfBenutzername.Text);
        }
    }
}
