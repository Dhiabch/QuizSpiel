﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizDhia
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
            StartForm startForm = new StartForm();
            SignUpForm signUpForm = new SignUpForm();
            SignUp_Logic.CreateUser(txtFirstname, txtLastname, txtUsername,
                                      txtCreatepassword, txtCreatePWConfirm,
                                      lFehlMeldung, startForm, signUpForm);
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
    }
}
