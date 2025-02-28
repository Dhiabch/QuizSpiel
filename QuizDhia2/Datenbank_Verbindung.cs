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
        private static SqlConnection cnn;

        public static void createConnection()
        {
            cnn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Integrated Security=true; database=QuizSpiel");
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

        public static string getPasswortBenutzer(string benutzerID)
        {
            openCnn();
            string sql = $"SELECT benutzerID, " +
                "passwort" +
                " FROM tbBenutzer " +
                "where benutzerID = " + benutzerID + ";";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            da.Fill(dt);
            DataRow dr = dt.Rows[0];
            closeCnn();
            return dr["password"].ToString();
        }
    }
}
