using QuizSpiel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuizDhia2
{
    internal class SignUp_Logic
    {
        public static void LoginUserName(TextBox Username, TextBox txtPassword, Label lHinweis, Form StartForm)
        {
            Database_Connect.openCnn();
            lHinweis.Visible = false;
            if (Database_Connect.findUserByUserName(Username.Text))
            {
                if (Database_Connect.checkPassword(Username.Text, txtPassword.Text))
                {
                    StartForm.Show();
                }
                else
                {
                    lHinweis.Visible = true;
                    lHinweis.Text = "Benutzername oder Password falsch!";
                }
            }
            else
            {
                lHinweis.Visible = true;
                lHinweis.Text = "Kein Konto mit dem Benutzername gefunden";
            }
        }
        public static void CreateUser(TextBox txtFirstname, TextBox txtLastname, TextBox txtUsername, 
                                      TextBox txtCreatepassword, TextBox txtCreatePWConfirm,
                                      Label lFehlMeldung, Form StartForm, Form SignUpForm)
        {
            lFehlMeldung.Visible = false;
            Database_Connect.openCnn();
            if (!Database_Connect.findUserByUserName(txtUsername.Text))
            {
                if (txtCreatepassword.Text == txtCreatePWConfirm.Text)
                {
                    Database_Connect.createUserDB(txtFirstname.Text, txtLastname.Text,
                                                  txtUsername.Text, txtCreatepassword.Text);
                    StartForm.Show();
                    SignUpForm.Close();
                }
                else
                {
                    lFehlMeldung.Text = "Passwort stimmt nicht überein!";
                    lFehlMeldung.Visible = true;
                }
            }
            else
            {
                lFehlMeldung.Text = txtUsername.Text + " ist bereits existiert!";
                lFehlMeldung.Visible = true;
            }
            
            
        }
    }
}
