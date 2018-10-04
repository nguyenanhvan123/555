using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdminApp1
{
    public class Manage_Exam
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-PNT1KBR\\SQLEXPRESS;database=TestOnlineDemo;uid=sa;pwd=123456");
            return conn;
        }
        public bool AddExam(string id, string date)
        {
            string sql = "INSERT INTO EXAM(_id, _date) VALUES(@i,@d)";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@i", id);
            cmd.Parameters.AddWithValue("@d", date);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        public bool AddExamDetail(string idQuestion, string idExam)
        {
            string sql = "INSERT INTO ExamDetail(_idQuestion,_idExam) VALUES(@idQ,@idE)";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@idQ", idQuestion);
            cmd.Parameters.AddWithValue("@idE", idExam);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        public List<Question> GetQuestions(string sid)
        {
            List<Question> list = new List<Question>();
            string sql = "SELECT *FROM QUESTION WHERE _sid='" + sid + "'";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Question q = new Question();
                q.id = rd.GetString(0);
                q.Content = rd.GetString(1);
                q.A = rd.GetString(2);
                q.B = rd.GetString(3);
                q.C = rd.GetString(4);
                q.D = rd.GetString(5);
                q.Correct = rd.GetString(6);
                list.Add(q);
            }
            rd.Close();
            cmd.Connection.Close();
            return list;
        }
        public List<Question> GetRandomQuestion(string sid)
        {
            List<Question> q5 = new List<Question>();
            List<Question> listfull = GetQuestions(sid);
            int count = 0;
            while (count < 5)
            {
                Random r = new Random();
                int i = r.Next(0, listfull.Count - 1);
                Question q = listfull[i];
                if (checkExist(q.id, q5))//false
                {
                    q5.Add(q);
                    count++;
                }
            }
            return q5;
        }
        public bool checkExist(string id, List<Question> qs)
        {
            foreach (Question item in qs)
                if (item.id.Equals(id))
                    return false;
            return true;
        }
        public DataTable GetExam()

        {
            string sql = "select * from Exam";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            da.Fill(dt);
            return dt;
        }
        public DataTable SearchByIDQE(string id)

        {
            string sql = "select * from EXAM where _id = '" + id + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            da.Fill(dt);
            return dt;
        }
        public bool UpdateQE(string id, string date, string status)
        {
            string sql = "UPDATE EXAM SET _date=@d,_status=@s WHERE _id=@i";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@i", id);
            cmd.Parameters.AddWithValue("@d", date);
            cmd.Parameters.AddWithValue("@s", status);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
    }
}
