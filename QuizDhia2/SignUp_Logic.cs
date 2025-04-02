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
        

        public static void LoginUserName(TextBox Username, Label lHinweis, Form StartForm)
        {
            if (Database_Connect.findUserByID(Username.Text))
            {
                StartForm.Show();
            }
            else
            {
                lHinweis.Visible = true;
                lHinweis.Text = "Sie haben keinen Konto bei uns";
            }
        }
    }
}
