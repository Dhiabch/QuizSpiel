using Npgsql;
using QuizSpiel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuizDhia
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

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                User.userID = Convert.ToInt32(dr["userID"]);
                return true;
            }
            return false;
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

        public static void getUserFirstname() 
        {
            string sql = $"SELECT userfirstname " +
                " FROM tblUser " +
                "where userName = '" + User.userName + "';";
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, cnn);
            da.Fill(dt);
            DataRow dr = dt.Rows[0];
            closeCnn();
            User.userFirstname = dr["userfirstname"].ToString();
        }

        public static void saveAnswer()
        {

            string sql = $"INSERT INTO tblAnswer (answerDescription, questionID)" +
                           " VALUES ('" + Answer.corrAnswerDescription + "',(SELECT questionID FROM tblQuestion " +
                                                                            "WHERE questionDescription = '" + Question.questionDescription + "'));"; 
            using (var cmd = new NpgsqlCommand(sql, cnn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public static void saveQuestion()
        {
            string sql = $"INSERT INTO tblQuestion (questionDescription, userID)" +
                         " VALUES ('" + Question.questionDescription + "'," +
                                        User.userID + ")" +
                         " RETURNING questionID;";

            using (var cmd = new NpgsqlCommand(sql, cnn))
            {
                Question.questionID = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }


   

    }
}
