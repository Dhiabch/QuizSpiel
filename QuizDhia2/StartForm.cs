﻿using QuizDhia2;
using QuizSpiel;
using System;
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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private void StartForm_Load(object sender, EventArgs e)
        {
            lTitleWelc.Text = "Welcome " + User.userFirstname + " !";
            StartForm_Logic.loadForm(lbQuestions);
        }

        private void bSubmitQuestion_Click(object sender, EventArgs e)
        {
            StartForm_Logic.submitQuestAnsw(tQuestion, tCorrectAnswer, lbQuestions);
        }

        private void bStartQuiz_Click(object sender, EventArgs e)
        {
            QuizForm quizForm = new QuizForm();
            quizForm.ShowDialog();
        }
    }
}
