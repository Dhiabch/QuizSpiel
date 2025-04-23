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
    internal class Database_Connect
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
        public static bool findUserByID(string userName)
        {
            openCnn();
            string sql = "SELECT * " +
                         "FROM tbEmployee " +
                         "WHERE employeeID = " + userName + ";";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            da.Fill(dt);

            if (dt.Rows.Count < 1)
            {
                closeCnn();
                return false;
            }
            closeCnn();
            return true;
        }    
        public static string getPasswordUser(string userName)
        {
            openCnn();
            string sql = $"SELECT userID, " +
                "password" +
                " FROM tbBenutzer " +
                "where userID = " + userName + ";";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            da.Fill(dt);
            DataRow dr = dt.Rows[0];
            closeCnn();
            return dr["password"].ToString();
        }

        
    }
}
