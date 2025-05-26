using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDhia
{
    internal class User
    {
        public static String userName { get; set; }
        public static String userFirstname { get; set; }
        public static String passwordUser { get; set; }
        public static int userID  { get; set; }
        public List<Question> Fragen { get; set; } = new List<Question>();

        public User()
        { }

    }
}
