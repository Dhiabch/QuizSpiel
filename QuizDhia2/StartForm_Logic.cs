using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizSpiel;

namespace QuizDhia
{
    internal class StartForm_Logic
    {
        public static void submitQuestAnsw(TextBox tQuestion, TextBox tCorrectAnswer, ListBox lbQuestions)
        {
            Question.questionDescription = tQuestion.Text;
            Answer.corrAnswerDescription = tCorrectAnswer.Text;
            Database_Connect.openCnn();
            Database_Connect.saveQuestion();
            Database_Connect.saveAnswer();

            lbQuestions.Items.Add($"Frage: {Question.questionDescription} | Antwort: {Answer.corrAnswerDescription}");

            tQuestion.Clear();
            tCorrectAnswer.Clear();
        }
    }
}
