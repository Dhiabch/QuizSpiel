using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace QuizDhia2
{
    internal class Datenbank_Verbindung
    {
        private static string connetionString;
        private static SqlConnection cnn;

        public static void createConnection()
        {
            connetionString = "Server=(localdb)\\Projects;Integrated Security=true; database=QuizSpiel";
            cnn = new SqlConnection(connetionString);
        }
        public static void openCnn()
        {
            if (cnn.State != ConnectionState.Open)
                cnn.Open();
        }

        public static void closeCnn()
        {
            cnn.Close();
        }
    }
}
