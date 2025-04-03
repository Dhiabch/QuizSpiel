using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizDhia2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            // Berechne die Position des RegisterForm, um es neben LoginForm zu öffnen

            signUpForm.StartPosition = FormStartPosition.Manual;
            signUpForm.Location = new Point(this.Location.X + this.Width, this.Location.Y); 

            signUpForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbViewPasswort_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViewPassword.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            StartForm StartForm = new StartForm();
            SignUp_Logic.LoginUserName(Username, txtPassword, lHinweis, StartForm);
        }
    }
}
