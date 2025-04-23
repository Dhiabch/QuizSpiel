using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizDhia2
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bKontoErstellen_Click(object sender, EventArgs e)
        {
            this.Close(); // Schließt das aktuelle Formular
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void cbViewNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViewNewPassword.CheckState == CheckState.Checked)
            {
                txtCreatepassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtCreatepassword.UseSystemPasswordChar = false;
            }
        }

        private void cbViewConfirmedPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViewConfirmedPassword.CheckState == CheckState.Checked)
            {
                txtConfirm.UseSystemPasswordChar = true;
            }
            else
            {
                txtConfirm.UseSystemPasswordChar = false;
            }
        }
    }
}
