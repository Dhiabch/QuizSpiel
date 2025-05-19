using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuizDhia2
{
    internal class Database_Connect
    {
        private static NpgsqlConnection cnn = new NpgsqlConnection("Host=dpg-d0jlofffte5s73fvjfmg-a.frankfurt-postgres.render.com;Port=5432;Database=db_quizspiel;User Id=db_quizspiel_user;Password=nYA1TL6t4zsnBZE6ZCp5ZDWu1N1yqpWB;SSL Mode=Require;Trust Server Certificate=true;");
        public static void openCnn()
        {
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void closeCnn()
        {
            cnn.Close();
        }
        public static bool findUserByUserName(string userName)
        {
            string sql = "SELECT * " +
                         "FROM tblUser " +
                         "WHERE username = '" + userName + "';";
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, cnn);
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }    
        private static string getPasswordUser(string userName)
        {
            string sql = $"SELECT userName, " +
                "password" +
                " FROM tblUser " +
                "where userName = '" + userName + "';";
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, cnn);
            da.Fill(dt);
            DataRow dr = dt.Rows[0];
            closeCnn();
            return dr["password"].ToString();
        }
        public static bool checkPassword(string userName, string userPassword)
        {
            if (getPasswordUser(userName) == userPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void createUserDB (string userFirstname, string userLastname, string userName, string password)
        {
            string sql = $"INSERT INTO tblUser (userFirstname, userLastname, userName, password) " +
                          "VALUES ('" + userFirstname + "','"
                                      + userLastname + "','"
                                      + userName + "','"
                                      + password + "');";
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, cnn);
            da.Fill(dt);
        }
    }
}
