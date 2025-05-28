using QuizSpiel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizDhia
{
    internal class Quiz_Logic
    {
        public static Question questionDescription { get; set; }
        public static Answer corrAnswerDescription { get; set; }
        public static Dictionary<string, string> QuestionAnswer = new Dictionary<string, string>();

        public static void getRandomQuestion(Label lQuestion)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(QuestionAnswer.Count);

            int i = 0;
            foreach (var question in Quiz_Logic.QuestionAnswer)
            {
                if (i == randomIndex)
                {
                    lQuestion.Text = question.Key; 
                    break;
                }
                i++;
            }
        }
    }
}
