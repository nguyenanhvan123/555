using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CilientApp1
{
   public class CilientModel
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-PNT1KBR\\SQLEXPRESS;database=TestOnlineDemo;uid=sa;pwd=123456");
            return conn;
        }
        public bool CheckLogin(string u, string p)
        {
            Students st = null;
            string sql = "SELECT *FROM Student WHERE _username=@u and _password=@p";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@u", u);
            cmd.Parameters.AddWithValue("@p", p);
            SqlDataReader rd = cmd.ExecuteReader();
            bool result = rd.HasRows;
            rd.Close();
            cmd.Connection.Close();
            return result;
        }
        public bool CheckExam(string ExamCode)
        {
            bool result = false;
            string sql = "SELECT *FROM EXAM WHERE _id=@i";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string status = rd.GetString(2);
                result = status.Equals("D");
            }
            cmd.Connection.Close();
            return result;
        }
        public List<string> GetQuestionByExam(string ExamCode)
        {
            string sql = "SELECT * FROM ExamDetail WHERE _idExam=@idE";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@idE", ExamCode);
            SqlDataReader rd = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (rd.Read())
            {
                list.Add(rd.GetString(1));
            }
            rd.Close();
            cmd.Connection.Close();
            return list;
        }
        public Question GetQuestionByID(string id)
        {
            string sql = "SELECT *FROM QUESTION WHERE _id=@i";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@i", id);
            SqlDataReader rd = cmd.ExecuteReader();
            Question q = null;
            while (rd.Read())
            {
                q = new Question();
                q.ID = rd.GetString(0);
                q.content = rd.GetString(1);
                q.A = rd.GetString(2);
                q.B = rd.GetString(3);
                q.C = rd.GetString(4);
                q.D = rd.GetString(5);
                q.Correct = rd.GetString(6);
            }
            rd.Close();
            cmd.Connection.Close();
            return q;
        }
    }
}
